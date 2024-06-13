using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;

namespace Lab5_Bai5
{
    public partial class Detail : Form
    {
        private ImapClient imapClient;
        private UniqueId emailUid;
        SmtpClient smtpClient;

        string emailTo = null;
        string emailFrom = null;

        public Detail(SmtpClient smtpClient,ImapClient imapClient, UniqueId emailUid)
        {
            InitializeComponent();
            this.imapClient = imapClient;
            this.emailUid = emailUid;
            this.smtpClient = smtpClient;
        }

        private async void Detail_Load(object sender, EventArgs e)
        {
            var message = await imapClient.Inbox.GetMessageAsync(emailUid);
            webBrowser.DocumentText = message.HtmlBody ?? message.TextBody;

            lbFrom.Text = message.From.ToString();
            emailFrom = string.Join(", ", message.From.Mailboxes.Select(m => m.Address));
            lbTo.Text = string.Join(", ", message.To.Mailboxes.Select(m => m.Address));
            emailTo = lbTo.Text;
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            // Reply so it reverse 
            var compose = new Compose(this.smtpClient,emailTo, emailFrom);
            this.Hide();
            compose.Show();
            this.Show();
        }
    }
}
