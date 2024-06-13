using System;
using System.Drawing;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace Lab5_Bai5
{
    public partial class Compose : Form
    {
        SmtpClient smtpClient = new SmtpClient();

        public Compose(SmtpClient smtpClient = null, string email=null, string emailTo = null)
        {
            InitializeComponent();
            InitializeTextBoxEvents();

            txtFrom.ReadOnly = true;

            this.smtpClient = smtpClient;

            if (!string.IsNullOrWhiteSpace(email))
            {
                txtFrom.Text = email;
                txtFrom.ForeColor = Color.Black;

                var fromAddress = MailboxAddress.Parse(email);
                txtName.Text = string.IsNullOrEmpty(fromAddress.Name) ? "Unknown" : fromAddress.Name;
                txtName.ForeColor = Color.Black;
            }

            if (!string.IsNullOrWhiteSpace(emailTo))
            {
                txtTo.Text = emailTo;
                txtTo.ForeColor = Color.Black;
            }
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

            txtName.Enter += TextBox_Enter;
            txtName.Leave += TextBox_Leave;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Tag.ToString())
            {
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
            string style = "plain";

            if (cbHTML.Checked)
            {
                style = "html";
            }

            try
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("", from));
                message.To.Add(new MailboxAddress("", to));
                message.Subject = subject;
                message.Body = new TextPart(style)
                {
                    Text = body
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