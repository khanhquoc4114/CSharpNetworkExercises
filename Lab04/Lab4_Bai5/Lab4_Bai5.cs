using System.Net;
using Newtonsoft.Json.Linq;
namespace Lab4_Bai5
{
    public partial class Lab4_Bai5 : Form
    {
        public Lab4_Bai5()
        {
            InitializeComponent();
        }

        private async void button_login_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các ô nhập liệu
            string url = textBox_URL.Text;
            string username = textBox_Name.Text;
            string password = textBox_Pass.Text;

            using (HttpClient client = new HttpClient())
            {
                // Tạo nội dung form-data cho body của yêu cầu POST
                var content = new MultipartFormDataContent
                {
                    { new StringContent(username), "username" },
                    { new StringContent(password), "password" }
                };

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
                            // Hiển thị token_type và access_token
                            richTextBox_response.Text = $"{tokenType} {accessToken}\nĐăng nhập thành công";
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
    }
}