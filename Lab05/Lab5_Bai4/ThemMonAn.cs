using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Bai7
{
    public partial class ThemMonAn : Form
    {
        private string url = "https://nt106.uitiot.vn/api/v1/monan/add";
        private string accessToken;
        private string tokenType;

        public event EventHandler MonAnAdded;
        private void OnMonAnAdded()
        {
            MonAnAdded?.Invoke(this, EventArgs.Empty);
        }
        public ThemMonAn(string accessToken, string tokenType)
        {
            InitializeComponent();
            this.accessToken = accessToken;
            this.tokenType = tokenType;
        }

        private async void button_them_Click(object sender, EventArgs e)
        {
            string ten = textBox_Ten.Text;
            int gia = int.Parse(textBox_Gia.Text);
            string mota = richTextBox_Mota.Text;
            string hinhanh = textBox_HinhAnh.Text;
            string diachi = textBox_Diachi.Text;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokenType, accessToken);

                var monAn = new
                {
                    ten_mon_an = ten,
                    gia = gia,
                    mo_ta = mota,
                    hinh_anh = hinhanh,
                    dia_chi = diachi
                };

                var jsonContent = new StringContent(
                    Newtonsoft.Json.JsonConvert.SerializeObject(monAn),
                    Encoding.UTF8,
                    "application/json"
                );

                try
                {
                    HttpResponseMessage response = await client.PostAsync(url, jsonContent);
                    string responseContent = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Món ăn đã được thêm thành công!");
                        OnMonAnAdded();
                    }
                    else
                    {
                        MessageBox.Show("Thêm món ăn không thành công. Vui lòng thử lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error when sending POST request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ThemMonAn_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Ten.Text = "";
            textBox_Gia.Text = "";
            textBox_Diachi.Text = "";
            textBox_HinhAnh.Text = "";
            richTextBox_Mota.Text = "";
        }
    }
}
