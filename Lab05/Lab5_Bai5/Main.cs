using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;

namespace Lab5_Bai5
{
    public partial class Main : Form
    {
        SmtpClient smtpClient;
        ImapClient imapClient;
        string email;
        bool isLoggedIn = false;

        public Main()
        {
            InitializeComponent();

            listViewEmails.View = View.Details;
            listViewEmails.FullRowSelect = true;

            listViewEmails.Columns.Add("#", 50);
            listViewEmails.Columns.Add("From", 200);
            listViewEmails.Columns.Add("Subject", 300);
            listViewEmails.Columns.Add("Date", 100);
            listViewEmails.ItemActivate += ListViewEmails_ItemActivate;
        }

        private void ListViewEmails_ItemActivate(object sender, EventArgs e)
        {
            if (listViewEmails.SelectedItems.Count > 0)
            {
                var selectedItem = listViewEmails.SelectedItems[0];
                var emailUid = (UniqueId)selectedItem.Tag;
                var emailDetailsForm = new Detail(smtpClient, imapClient, emailUid);
                emailDetailsForm.Show();
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                Compose compose = new Compose(this.smtpClient, email);
                compose.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đăng nhập trước khi gửi email.");
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                await Logout();
            }

            progressBar.Visible = true;
            progressBar.Value = 0;

            email = txtEmail.Text;

            smtpClient = new SmtpClient();
            await smtpClient.ConnectAsync("smtp.gmail.com", 465, true);

            imapClient = new ImapClient();
            await imapClient.ConnectAsync("imap.gmail.com", 993, true);

            try
            {
                await smtpClient.AuthenticateAsync(email, txtPass.Text);
                await imapClient.AuthenticateAsync(email, txtPass.Text);

                await LoadEmails();

                btnLogin.Text = "Logout";
                groupBox2.Enabled = false;
                txtPass.Enabled = txtEmail.Enabled = false;
                isLoggedIn = true;
            }
            catch
            {
                MessageBox.Show("Sai tài khoản!!");
            }
        }

        private async Task LoadEmails()
        {
            try
            {
                var inbox = imapClient.Inbox;
                await inbox.OpenAsync(FolderAccess.ReadOnly);

                listViewEmails.Items.Clear();

                int messageCount = inbox.Count;
                int startIndex = Math.Max(0, messageCount - 20);

                progressBar.Maximum = 20;

                var summaries = await inbox.FetchAsync(startIndex, messageCount - 1, MessageSummaryItems.Envelope | MessageSummaryItems.UniqueId);

                for (int i = messageCount - 1, j = 1; i >= startIndex; i--, j++)
                {
                    var summary = summaries[i - startIndex];
                    var listViewItem = new ListViewItem(new[]
                    {
                        j.ToString(),
                        summary.Envelope.From.ToString(),
                        summary.Envelope.Subject,
                        summary.Envelope.Date.Value.DateTime.ToString("dd MMM")
                    })
                    {
                        Tag = summary.UniqueId
                    };
                    listViewEmails.Items.Add(listViewItem);
                    progressBar.PerformStep();
                }

                await Task.Delay(100);
                progressBar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải email: " + ex.Message);
            }
        }
        private async Task Logout()
        {
            try
            {
                if (smtpClient.IsConnected)
                {
                    await smtpClient.DisconnectAsync(true);
                }

                if (imapClient.IsConnected)
                {
                    await imapClient.DisconnectAsync(true);
                }

                listViewEmails.Items.Clear();
                MessageBox.Show("Đã đăng xuất thành công.");

                btnLogin.Text = "Login";
                groupBox2.Enabled = true;
                txtPass.Enabled = txtEmail.Enabled = true;
                isLoggedIn = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng xuất: " + ex.Message);
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                await LoadEmails();
            }
            else
            {
                MessageBox.Show("Bạn cần đăng nhập trước khi gửi email.");
            }
        }

    }
}
