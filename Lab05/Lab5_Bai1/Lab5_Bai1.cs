using System;
using System.Drawing;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace Lab5_Bai1
{
    public partial class Lab5_Bai1 : Form
    {
        public Lab5_Bai1()
        {
            InitializeComponent();
            InitializeTextBoxEvents();
        }

        #region UI

        private void InitializeTextBoxEvents()
        {
            txtFrom.Enter += TextBox_Enter;
            txtFrom.Leave += TextBox_Leave;

            txtTo.Enter += TextBox_Enter;
            txtTo.Leave += TextBox_Leave;

            txtSubject.Enter += TextBox_Enter;
            txtSubject.Leave += TextBox_Leave;

            txtBody.Enter += TextBox_Enter;
            txtBody.Leave += TextBox_Leave;

            txtPass.Enter += TextBox_Enter;
            txtPass.Leave += TextBox_Leave;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Tag.ToString())
            {
                if (textBox.Text == " Pass:")
                {
                    textBox.PasswordChar = '*';
                }
                textBox.ForeColor = Color.Black;
                textBox.Clear();
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.ForeColor = Color.FromArgb(129, 128, 121);
                textBox.Text = textBox.Tag.ToString();
                textBox.PasswordChar = '\0';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBody.Clear();
            txtBody.Focus();
        }
        #endregion

        private void btnSend_Click(object sender, EventArgs e)
        {
            string from = txtFrom.Text.Trim();
            string to = txtTo.Text.Trim();
            string subject = txtSubject.Text.Trim();
            string body = txtBody.Text.Trim();

            if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to) || string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(body))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 465, true);

            try
            {
                // Thay đổi mật khẩu ở đây
                smtpClient.Authenticate(txtFrom.Text, txtPass.Text);

                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("", txtFrom.Text));
                message.To.Add(new MailboxAddress("", txtTo.Text));
                message.Subject = txtSubject.Text;
                message.Body = new TextPart("plain")
                {
                    Text = txtBody.Text
                };

                smtpClient.Send(message);
                MessageBox.Show("Gửi email thành công!");
            }
            catch 
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!!!");
            }
        }
    }
}
