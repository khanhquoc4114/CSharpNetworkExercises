using System;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Lab4_Bai7
{
    public partial class Login : Form
    {
        public string? tokentype { get; set; }
        public string? accesstoken { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        #region Nút đăng nhập giống bài 6, lấy ra tên để chào trong mainForm 
        private async void button_login_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các ô nhập liệu
            string url = "https://nt106.uitiot.vn/auth/token";
            string username = textBox_Name.Text;
            string password = textBox_Pass.Text;

            using (HttpClient client = new HttpClient())
            {
                // Tạo nội dung form-data cho body của yêu cầu POST
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(username), "username");
                content.Add(new StringContent(password), "password");

                try
                {
                    // Gửi yêu cầu POST
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    // Đọc phản hồi từ máy chủ
                    string responseString = await response.Content.ReadAsStringAsync();
                    // Chuyển đổi chuỗi JSON phản hồi thành đối tượng JObject
                    var jsonResponse = JObject.Parse(responseString);

                    // Kiểm tra trạng thái của phản hồi
                    if (response.IsSuccessStatusCode)
                    {
                        // Lấy các trường access_token và token_type từ JSON phản hồi
                        string? accessToken = jsonResponse["access_token"]?.ToString();
                        this.accesstoken = accessToken;
                        string? tokenType = jsonResponse["token_type"]?.ToString();
                        this.tokentype = tokenType;
                        MessageBox.Show("Đăng nhập thành công");
                        if (accessToken != null && tokenType != null)
                        {
                            // Gọi hàm để thực hiện yêu cầu GET
                            await GetUserInfo(accessToken, tokenType);
                        }
                        else
                        {
                            MessageBox.Show("Lấy thông tin thất bại, không thấy token");
                        }
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công");
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi xảy ra trong quá trình kết nối
                    MessageBox.Show($"Lỗi khi thực hiện kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public async Task GetUserInfo(string accessToken, string tokenType)
        {
            string userInfoUrl = "https://nt106.uitiot.vn/api/v1/user/me";
            using (HttpClient client = new HttpClient())
            {
                // Thêm token vào header của yêu cầu GET
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokenType, accessToken);

                try
                {
                    // Gửi yêu cầu GET
                    HttpResponseMessage response = await client.GetAsync(userInfoUrl);
                    string responseContent = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        //lấy thông tin người đăng nhập
                        var jsonResponse = JObject.Parse(responseContent);
                        string lastName = jsonResponse["last_name"]?.ToString();
                        this.LastName = lastName;
                        string? firstName = jsonResponse["first_name"]?.ToString();
                        this.FirstName = firstName;
                        string username = jsonResponse["username"]?.ToString();
                        this.Username = username;
                        string email = jsonResponse["email"]?.ToString();
                        this.Email = email;
                    }
                    else
                    {
                        MessageBox.Show("Yêu cầu GET thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thực hiện yêu cầu GET: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        //bấm vào hiện form đăng kí
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();
            Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Thực hiện hành động của nút Login
                button_login.PerformClick();
            }
        }
    }
}
