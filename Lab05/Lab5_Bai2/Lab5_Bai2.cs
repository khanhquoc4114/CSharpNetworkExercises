using System;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit;

namespace Lab5_Bai2
{
    public partial class Lab5_Bai2 : Form
    {
        public Lab5_Bai2()
        {
            InitializeComponent();

            listViewEmails.View = View.Details;
            listViewEmails.Columns.Add("Email", 400);
            listViewEmails.Columns.Add("Người gửi", 200);
            listViewEmails.Columns.Add("Ngày nhận", 200);
            listViewEmails.FullRowSelect = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (ImapClient imapClient = new ImapClient())
            {
                try
                {
                    imapClient.Connect("imap.gmail.com", 993, true);
                    imapClient.Authenticate(txtEmail.Text, txtPass.Text);

                    var inbox = imapClient.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    listViewEmails.Items.Clear();

                    int messageCount = inbox.Count;
                    int startIndex = Math.Max(0, messageCount - 10);

                    // Load 10 email gần nhất
                    for (int i = messageCount - 1; i >= startIndex; i--)
                    {
                        var message = inbox.GetMessage(i);
                        var listViewItem = new ListViewItem(new[]
                        {
                            message.Subject,
                            message.From.ToString(),
                            message.Date.ToString()
                        });
                        listViewEmails.Items.Add(listViewItem);
                    }

                    MessageBox.Show("Đăng nhập thành công!!!");
                }
                catch
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!!!");
                }
            }
        }
    }
}
