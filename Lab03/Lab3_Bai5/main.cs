using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using GetStartedWinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab03_Bai5
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm log = new loginForm();
            log.Show();
        }

        private void button_server_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            Thread serverThread = new Thread(() => server.Start(8080));
            serverThread.Start();
            server.Show();
            button_server.Enabled = false;

        }

        private void button_changeData_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient();

            try
            {
                client.Connect("127.0.0.1", 8080); // Connect to IP and port

                var dbContext = new MonAnsContext();
                try
                {
                    changeData changedataform = new changeData(dbContext, client);
                    changedataform.FormClosed += (s, args) => this.Show();
                    changedataform.Show();
                }
                catch (Exception ex)
                {
                    // Handle connection errors
                    MessageBox.Show("E " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                // Handle connection errors
                MessageBox.Show("Error connecting to server: " + ex.Message);
            }
        }

    }

}
