using System;
using System.Drawing;
using System.Net.Http;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab5_Bai4;
using Newtonsoft.Json;

namespace Lab4_Bai7
{
    public partial class ShowMonAn : Form
    {

        private readonly SmtpClient smtpClient;
        private readonly bool? isconnected;
        string emaillab5;

        private string tokenType;
        private string accessToken;
        private string url;

        public ShowMonAn(string tokenType, string accessToken, string url, SmtpClient smtpClient, bool? isconnected, string emaillab5)
        {
            InitializeComponent();
            this.tokenType = tokenType;
            this.accessToken = accessToken;
            this.url = url;
            GetMonAnById(url);

            this.smtpClient = smtpClient; 
            this.emaillab5 = emaillab5;
            this.isconnected = isconnected;

            if (isconnected != true)
            {
                isconnectedlabel.Text = "Email Server Disconnected";
                isconnectedlabel.ForeColor = Color.Red;
            }
            else
            {
                isconnectedlabel.Text = "Email Server Connected";
                isconnectedlabel.ForeColor = Color.Green;
            }
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

        private void button_moibanbe_Click(object sender, EventArgs e)
        {
            if (isconnected != true)
            {
                MessageBox.Show("Bạn cần cài đặt Email Server để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Invite invite = new Invite(smtpClient, pictureBoxHinhAnh.ImageLocation, labelTenMonAn.Text, labelGia.Text, labelDiaChi.Text, emaillab5);
                invite.Show();
            } 
                
        }
    }
}
