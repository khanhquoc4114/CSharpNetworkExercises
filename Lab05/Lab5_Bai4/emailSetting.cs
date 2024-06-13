using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab4_Bai7;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace Lab5_Bai4
{
    public partial class emailSetting : Form
    {
        public event EventHandler SaveClicked;
        SmtpClient smtpClient;
        ImapClient imapClient; 
        public SmtpClient SmtpClientInstance { get; private set; }

        public bool ? isconnected { get; set; }
        public string email;

        public emailSetting(string username)
        {
            InitializeComponent();
            textBox_nickname.Text = username;
        }

        private async void button_test_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            smtpClient = new SmtpClient();
            imapClient = new ImapClient();

            try
            {
                // Kết nối đến máy chủ SMTP
                await smtpClient.ConnectAsync(smtpserver.Text, int.Parse(smtp_port.Text), smtp_requiressl.Checked);
                await smtpClient.AuthenticateAsync(username, password);
                MessageBox.Show("Kết nối SMTP thành công!");
                SmtpClientInstance = smtpClient;
                email = username;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối SMTP thất bại: " + ex.Message);
                isconnected = false;
            }

            try
            {
                // Kết nối đến máy chủ IMAP
                await imapClient.ConnectAsync(imapserver.Text, int.Parse(imap_port.Text), SecureSocketOptions.SslOnConnect);
                await imapClient.AuthenticateAsync(username, password);
                MessageBox.Show("Kết nối IMAP thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối IMAP thất bại: " + ex.Message);
                isconnected = false;
            }
            isconnected = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
