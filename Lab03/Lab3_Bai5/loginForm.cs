using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetStartedWinForms;
using Lab02;
using Microsoft.Data.Sqlite;

namespace Lab03_Bai5
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_id.Text;
            string ip = textBox_ip.Text;
            int port = int.Parse(textBox_port.Text);
            TcpClient client = new TcpClient(); // Create TcpClient without IP and port

            try
            {
                client.Connect(ip, port); // Connect to IP and port

                using (var dbContext = new MonAnsContext())
                {
                    var user = dbContext.nguoidung.FirstOrDefault(u => u.IDNCC == int.Parse(username));

                    if (user != null)
                    {
                        // Đăng nhập thành công
                        mainForm mainForm = new mainForm(int.Parse(username), client);
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Đăng nhập thất bại
                        MessageBox.Show("Tên tài không đúng. Vui lòng thử lại.");
                    }
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
