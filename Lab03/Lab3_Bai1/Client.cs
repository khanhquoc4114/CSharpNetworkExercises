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

namespace Lab3_Bai1
{
    public partial class Client : Form
    {
        UdpClient udpClient = new UdpClient();
        public Client()
        {
            InitializeComponent();

        }

        private void button_send_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.UTF8.GetBytes(richTextBox_message.Text);
            udpClient.Send(data, data.Length, textBox_ip.Text, int.Parse(textBox_port.Text));
            richTextBox_message.Clear();
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpClient.Close();
        }
    }
}
