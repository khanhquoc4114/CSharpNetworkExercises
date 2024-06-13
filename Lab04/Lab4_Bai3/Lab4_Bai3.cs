using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab4_Bai3
{
    public partial class Lab4_Bai3 : Form
    {
        string url = "";
        public Lab4_Bai3()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            url = addressBar.Text.Trim();
            if (url == "") return;
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
            }

            try
            {
                webView.Source = new Uri(url);
            } catch
            {
                MessageBox.Show("Can't get to website");
            }
        }

        private void btnDownFile_Click(object sender, EventArgs e)
        {
            if (webView.Source == null || string.IsNullOrEmpty(webView.Source.ToString()))
            {
                MessageBox.Show("Please load a website first.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "HTML Files (*.html)|*.html";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string downloadUrl = webView.Source.ToString();
                    string downloadPath = saveFileDialog.FileName;

                    try
                    {
                        using (WebClient myClient = new WebClient())
                        {
                            myClient.DownloadFile(downloadUrl, downloadPath);
                            MessageBox.Show("File downloaded successfully!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error downloading file: {ex.Message}");
                    }
                }
            }
        }

        private string getHTML(string szURL)
        {
            try
            {
                // Create a request for the URL.
                WebRequest request = WebRequest.Create(szURL);
                // Get the response.
                using (WebResponse response = request.GetResponse())
                {
                    // Get the stream containing content returned by the server.
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        // Open the stream using a StreamReader for easy access.
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            // Read the content.
                            string responseFromServer = reader.ReadToEnd();
                            return responseFromServer;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching HTML: {ex.Message}");
                return null;
            }
        }

        private void btnDownRes_Click(object sender, EventArgs e)
        {
            // Kiểm tra webview đã tải chưa 
            if (webView.Source == null || string.IsNullOrEmpty(webView.Source.ToString()))
            {
                MessageBox.Show("Please load a website first.");
                return;
            }

            // Lấy source html 
            string html = getHTML(webView.Source.ToString());
            if (html == null) return;

            // Phân tích cú pháp html
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            // Tìm các thẻ img
            var imgNodes = doc.DocumentNode.SelectNodes("//img");

            // Kiểm tra có ảnh không
            if (imgNodes == null || imgNodes.Count == 0)
            {
                MessageBox.Show("No images found on the webpage.");
                return;
            }

            // Hiển thị hộp thoại chọn thư mục 
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;

                    // Thiết lập process bar
                    progressBar.Visible = true;
                    progressBar.Maximum = imgNodes.Count;
                    progressBar.Value = 0;

                    // Tải từng ảnh xuống
                    foreach (var imgNode in imgNodes)
                    {
                        // Lấy Url của ảnh 
                        string imgUrl = imgNode.GetAttributeValue("src", null);
                        if (string.IsNullOrEmpty(imgUrl)) continue;

                        if (!imgUrl.StartsWith("http://") && !imgUrl.StartsWith("https://"))
                        {
                            Uri baseUri = new Uri(webView.Source.ToString());
                            imgUrl = new Uri(baseUri, imgUrl).ToString();
                        }

                        // Tạo đường dẫn file để lưu ảnh
                        string fileName = Path.GetFileName(new Uri(imgUrl).AbsolutePath);
                        string filePath = Path.Combine(folderPath, fileName);

                        try
                        {
                            // Sử dụng webclient để tải ảnh từ url
                            using (WebClient client = new WebClient())
                            {
                                client.DownloadFile(imgUrl, filePath);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error downloading image {imgUrl}: {ex.Message}");
                        }
                        progressBar.PerformStep();
                    }
                    progressBar.Visible = false;
                    MessageBox.Show("Images downloaded successfully!");
                }
            }
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLoad.PerformClick();
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            btnLoad.PerformClick();
        }
    }
}
