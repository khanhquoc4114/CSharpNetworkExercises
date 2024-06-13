using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab4_Bai2
{
    public partial class Lab4_Bai2 : Form
    {
        
        public Lab4_Bai2()
        {
            InitializeComponent();
        }

        string url = "";

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

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (url == "") return;
            string location = txtDownload.Text;

            try
            {
                using (WebClient myClient = new WebClient())
                {
                    myClient.DownloadFile(url, location);
                    MessageBox.Show("File downloaded successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error downloading file: {ex.Message}");
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            url = txtURL.Text;
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
            }

            try
            {
                string content = getHTML(url);
                if (content != null)
                {
                    rtbContent.Text = content;
                }
                btnDownload.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can't read the URL: {ex}");
            }
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGet.PerformClick();
            }
        }
        private void txtDownload_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDownload.PerformClick();
            }
        }
    }
}
