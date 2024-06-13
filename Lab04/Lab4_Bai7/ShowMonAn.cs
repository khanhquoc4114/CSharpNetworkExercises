using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab4_Bai7
{
    public partial class ShowMonAn : Form
    {
        private string tokenType;
        private string accessToken;
        private string url;

        public ShowMonAn(string tokenType, string accessToken, string url)
        {
            InitializeComponent();
            this.tokenType = tokenType;
            this.accessToken = accessToken;
            this.url = url;
            GetMonAnById(url);
        }

        private async void GetMonAnById(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokenType, accessToken);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    string responseContent = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        var monAn = JsonConvert.DeserializeObject<MonAn>(responseContent);

                        // Hiển thị thông tin món ăn trong các label và PictureBox
                        labelId.Text = "ID: " + monAn.Id;
                        labelTenMonAn.Text = "Tên: " + monAn.TenMonAn;
                        labelGia.Text = "Giá: " + monAn.Gia;
                        labelDiaChi.Text = "Địa chỉ: " + monAn.DiaChi;
                        labelNguoiDongGop.Text = "Người đóng góp: " + monAn.NguoiDongGop;

                        if (!string.IsNullOrEmpty(monAn.HinhAnh))
                        {
                            pictureBoxHinhAnh.Load(monAn.HinhAnh);
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
    }
}
