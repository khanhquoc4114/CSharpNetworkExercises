using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab4_Bai7
{
    public partial class MainForm : Form
    {
        private string? accessToken;
        private string? tokenType;
        private string? username;
        private string? email;
        private string? selectedRowId;
        string urlall = "https://nt106.uitiot.vn/api/v1/monan/all";
        string urlme = "https://nt106.uitiot.vn/api/v1/monan/my-dishes";

        private List<int> monAnIds = new List<int>();
        public MainForm()
        {
            Login login = new Login();
            login.ShowDialog();

            InitializeComponent();
            string? lastName = login.LastName;
            string? firstName = login.FirstName;
            username = login.Username;
            email = login.Email;
            accessToken = login.accesstoken;
            tokenType = login.tokentype;
            label_name.Text = "Welcome, " + username + "!";

            dataGridView_All.CellClick += DataGridView_CellClick;
            dataGridView_Me.CellClick += DataGridView_CellClick;

            SetupDataGridView(dataGridView_All);
            SetupDataGridView(dataGridView_Me);
            LoadMonAnBasedOnTab();
        }
        // Button Ăn gì giờ
        private void button_angigio_Click(object sender, EventArgs e)
        {
            if (monAnIds.Count == 0)
            {
                MessageBox.Show("Không có món ăn nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Random random = new Random();
            int randomIndex = random.Next(monAnIds.Count);
            int randomId = monAnIds[randomIndex];
            string? url = $"https://nt106.uitiot.vn/api/v1/monan/{randomId}";
            ShowMonAn showMonAn = new(tokenType, accessToken, url);
            showMonAn.Show();
        }
        // Vẽ grid hiển thị cho database
        private void SetupDataGridView(DataGridView dataGridView)
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.RowTemplate.Height = 100;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "Id";
            idColumn.HeaderText = "ID";
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns.Insert(0, idColumn);

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "Image";
            imageColumn.HeaderText = "Image";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView.Columns.Add(imageColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "TenMonAn";
            nameColumn.HeaderText = "Tên Món Ăn";
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.Name = "Gia";
            priceColumn.HeaderText = "Giá";
            priceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns.Add(priceColumn);

            DataGridViewTextBoxColumn addressColumn = new DataGridViewTextBoxColumn();
            addressColumn.Name = "DiaChi";
            addressColumn.HeaderText = "Địa Chỉ";
            dataGridView.Columns.Add(addressColumn);

            DataGridViewTextBoxColumn contributorColumn = new DataGridViewTextBoxColumn();
            contributorColumn.Name = "NguoiDongGop";
            contributorColumn.HeaderText = "Đóng Góp";
            dataGridView.Columns.Add(contributorColumn);
        }

        // Hàm chính để load database cho all và me
        private async Task LoadMonAnAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokenType, accessToken);

                var jsonContent = new StringContent(
                    JsonConvert.SerializeObject(new { current = comboBox_page.Text, pageSize = comboBox_pagesize.Text }),
                    Encoding.UTF8,
                    "application/json"
                );

                try
                {
                    HttpResponseMessage response = await client.PostAsync(url, jsonContent);
                    string responseContent = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseContent);

                        // Clear the existing IDs
                        monAnIds.Clear();

                        // Extract and store the IDs
                        foreach (var monAn in apiResponse.Data)
                        {
                            monAnIds.Add(monAn.Id); // Assuming the Id property exists in the MonAn class
                        }

                        if (url == urlall)
                        {
                            DisplayMonAn(apiResponse.Data, dataGridView_All);
                        }
                        else if (url == urlme)
                        {
                            DisplayMonAn(apiResponse.Data, dataGridView_Me);
                        }
                    }
                    else
                    {
                        MessageBox.Show("GET request failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error when sending GET request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Hiển thị món ăn
        private void DisplayMonAn(List<MonAn> monAnList, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            for (int i = 0; i < monAnList.Count; i++)
            {
                var monAn = monAnList[i];
                var image = string.IsNullOrEmpty(monAn.HinhAnh) ? null : DownloadImage(monAn.HinhAnh);
                dataGridView.Rows.Add(monAn.Id, image, monAn.TenMonAn, monAn.Gia, monAn.DiaChi, monAn.NguoiDongGop);
                progressBar1.Value = (i + 1) * 100 / monAnList.Count;
            }
        }
        private Image? DownloadImage(string url)
        {
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    byte[] data = webClient.DownloadData(url);
                    using var mem = new MemoryStream(data);
                    return Image.FromStream(mem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error downloading image: {ex.Message}");
                return null;
            }
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonAnBasedOnTab();
            UpdateProgressBar();
        }
        private void UpdateProgressBar()
        {
            TabPage currentTab = tabControl.SelectedTab;
            if (currentTab == tabPage_All)
            {
                UpdateProgressBar(dataGridView_All);
            }
            else if (currentTab == tabPage_Me)
            {
                UpdateProgressBar(dataGridView_Me);
            }
        }
        private void UpdateProgressBar(DataGridView dataGridView)
        {
            int rowCount = dataGridView.Rows.Count;
            if (rowCount > 0)
            {
                progressBar1.Value = (dataGridView.Rows.Count) * 100 / rowCount;
            }
            else
            {
                progressBar1.Value = 0;
            }
        }
        private void LoadMonAnBasedOnTab()
        {
            TabPage? currentTab = tabControl.SelectedTab;
            if (currentTab == tabPage_All)
            {
                _ = LoadMonAnAsync(urlall);
            }
            else if (currentTab == tabPage_Me)
            {
                _ = LoadMonAnAsync(urlme);
            }
        }
        private void comboBox_page_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonAnBasedOnTab();
        }
        private void comboBox_pagesize_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonAnBasedOnTab();
        }
        private void button_themmonan_Click(object sender, EventArgs e)
        {
            ThemMonAn themmonan = new ThemMonAn(accessToken, tokenType);
            themmonan.MonAnAdded += Themmonan_MonAnAdded; 
            themmonan.Show();
        }
        private void Themmonan_MonAnAdded(object sender, EventArgs e)
        {
            LoadMonAnBasedOnTab(); // Tải lại danh sách món ăn
        }
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView? dataGridView = sender as DataGridView;

            if (e.RowIndex >= 0 && dataGridView != null) // Đảm bảo chỉ thực hiện khi người dùng chọn một hàng có thực trong DataGridView
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                selectedRowId = selectedRow.Cells["Id"].Value.ToString(); // Lưu ID của hàng được chọn
            }
        }

        private async void button_delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedRowId))
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    string url = $"https://nt106.uitiot.vn/api/v1/monan/{selectedRowId}";

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokenType, accessToken);

                        try
                        {
                            HttpResponseMessage response = await client.DeleteAsync(url);
                            if (response.IsSuccessStatusCode) // Thành công
                            {
                                MessageBox.Show("Món ăn đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadMonAnBasedOnTab(); // Tải lại danh sách món ăn sau khi xóa
                            }
                            else // Thất bại
                            {
                                MessageBox.Show("Xóa món ăn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi gửi yêu cầu DELETE: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trước khi bấm nút xóa.", "Không có hàng nào được chọn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}