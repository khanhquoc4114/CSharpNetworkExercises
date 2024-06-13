using System;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Lab4_Bai6
{
    public partial class Lab4_Bai6 : Form
    {
        public Lab4_Bai6()
        {
            InitializeComponent();
        }

        public async void button_Post_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các ô nhập liệu
            string url = "https://nt106.uitiot.vn/auth/token";
            string username = textBox_Name.Text;
            string password = textBox_Pass.Text;

            using (HttpClient client = new HttpClient())
            {
                // Tạo nội dung form-data cho body của yêu cầu POST
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("username", username),
                    new KeyValuePair<string, string>("password", password)
                });

                try
                {
                    // Gửi yêu cầu POST
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    //Đọc phản hồi từ máy chủ
                    string responseString = await response.Content.ReadAsStringAsync();
                    // Chuyển đổi chuỗi JSON phản hồi thành đối tượng JObject
                    var jsonResponse = JObject.Parse(responseString);

                    // Kiểm tra trạng thái của phản hồi
                    if (response.IsSuccessStatusCode)
                    {
                        // Lấy các trường access_token và token_type từ JSON phản hồi
                        string? accessToken = jsonResponse["access_token"]?.ToString();
                        string? tokenType = jsonResponse["token_type"]?.ToString();

                        if (accessToken != null && tokenType != null)
                        {
                            // Gọi hàm để thực hiện yêu cầu GET
                            await GetUserInfo(accessToken, tokenType);
                        }
                        else
                        {
                            richTextBox_response.Text = "Đăng nhập thất bại. Không tìm thấy token.";
                        }
                    }
                    else
                    {
                        // Lấy thông tin chi tiết lỗi từ JSON phản hồi
                        string? detail = jsonResponse["detail"]?.ToString();
                        richTextBox_response.Text = $"Đăng nhập thất bại: {detail}";
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi xảy ra trong quá trình kết nối
                    richTextBox_response.Text = $"Lỗi khi thực hiện kết nối: {ex.Message}";
                }
            }
        }

        public async Task GetUserInfo(string accessToken, string tokenType)
        {
            string userInfoUrl = textBox_URL.Text;
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
                        var jsonResponse = JObject.Parse(responseContent);
                        richTextBox_response.Text = jsonResponse.ToString();
                    }
                    else
                    {
                        richTextBox_response.Text = "Yêu cầu GET thất bại";
                    }
                }
                catch (Exception ex)
                {
                    richTextBox_response.Text = $"Lỗi khi thực hiện yêu cầu GET: {ex.Message}";
                }
            }
        }
    }
}
