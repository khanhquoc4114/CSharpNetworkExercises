using System;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace Lab5_Bai4
{
    public partial class Invite : Form
    {
        SmtpClient smtpClient;
        string hinhanh, ten, gia, diachi, emaillab5;

        public Invite(SmtpClient smtpClient, string hinhanh, string ten, string gia, string diachi, string emaillab5)
        {
            InitializeComponent();
            this.smtpClient = smtpClient;
            this.hinhanh = hinhanh;
            this.ten = ten;
            this.gia = gia;
            this.diachi = diachi;
            this.emaillab5 = emaillab5;
        }

        private async void button_send_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("ND Toan", emaillab5)); // Địa chỉ email của bạn
                message.Subject = "Bạn có lời mời đi ăn ";

                var builder = new BodyBuilder();
                builder.HtmlBody = $@"
                    <html>
                    <body>
                        <h2>Đi ăn thôi</h2>
                        <img src=""{hinhanh}"" alt=""Hình ảnh món ăn""><br>
                        <p><strong>Tên món ăn:</strong> {ten}</p>
                        <p><strong>Giá:</strong> {gia}</p>
                        <p><strong>Địa chỉ:</strong> {diachi}</p>
                    </body>
                    </html>
                ";

                message.Body = builder.ToMessageBody();

                // Thêm các địa chỉ email nhận vào message
                foreach (ListViewItem item in listView1.Items)
                {
                    message.To.Add(new MailboxAddress("",item.Text));
                }

                // Gửi email
                await smtpClient.SendAsync(message);

                MessageBox.Show("Email đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_review_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox_email.Text);
        }
    }
}
