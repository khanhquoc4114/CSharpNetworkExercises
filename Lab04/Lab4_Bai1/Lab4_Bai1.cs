using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Lab4_Bai1 : Form
    {
        public Lab4_Bai1()
        {
            InitializeComponent();
        }


        private string getHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response. 
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server. 
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access. 
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. 
            string responseFromServer = reader.ReadToEnd();
            // Close the response. 
            response.Close();
            return responseFromServer;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string url;
            try
            {
                url = "https://" + txtURL.Text;
                string content = getHTML(url);
                rtbContent.Text = content;
            } catch (Exception ex)
            {
                MessageBox.Show("Can't read the URL" + ex.ToString());
            }
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGet.PerformClick();
            }
        }
    }
}
