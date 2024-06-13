using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Lab4_Bai7
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private async void button_submit_Click(object sender, EventArgs e)
        {
            // Đường dẫn gửi yêu cầu POST
            string signupUrl = "https://nt106.uitiot.vn/api/v1/user/signup";

            // Lấy thông tin từ các control trên giao diện người dùng
            string username = textBox_name.Text;
            string password = textBox_pass.Text;
            string email = textBox_email.Text;
            string fname = textBox_fName.Text;
            string lname = textBox_lName.Text;
            string phone = textBox_phone.Text;
            string birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string? language = comboBox1.SelectedItem?.ToString();
            int sex = btn_Female.Checked ? 0 : (btn_Male.Checked ? 1 : -1);

            try
            {
                // Tạo đối tượng chứa thông tin người dùng
                var user = new
                {
                    username = username,
                    password = password,
                    email = email,
                    first_name = fname,
                    last_name = lname,
                    sex = sex,
                    birthday = birthday,
                    language = language,
                    phone = phone
                };

                // Chuyển đối tượng thành chuỗi JSON
                string json = JsonConvert.SerializeObject(user);

                // Gửi yêu cầu POST
                using (HttpClient client = new HttpClient())
                {
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(signupUrl, content);

                    // Đọc phản hồi từ máy chủ
                    string responseString = await response.Content.ReadAsStringAsync();

                    // Chuyển đổi chuỗi JSON phản hồi thành đối tượng JObject
                    var jsonResponse = JObject.Parse(responseString);

                    // Kiểm tra trạng thái của phản hồi
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Đăng ký thành công!");
                    }
                    else
                    {
                        // Lấy thông tin chi tiết lỗi từ JSON phản hồi
                        string? detail = jsonResponse["detail"]?.ToString();
                        MessageBox.Show($"Đăng ký thất bại: {detail}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Login login = new Login(); // truyền 'this' vào constructor của SignUp
            //login.Show();
        }
    }
}
