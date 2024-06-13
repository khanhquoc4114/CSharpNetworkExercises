using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3_Bai1
{
    public partial class Server : Form
    {

        private UdpClient udpClient;
        private Thread receiveThread;
    
        public Server()
        {
            InitializeComponent();
        }

        private void button_Listen_Click(object sender, EventArgs e)
        {
            button_Listen.Enabled = false;

            receiveThread = new Thread(new ThreadStart(Receive));
            receiveThread.Start();
        }

        private void Receive()
        {
            int port = int.Parse(textBox_port.Text);
            udpClient = new UdpClient(port);
            while (true)
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = udpClient.Receive(ref remoteEP);
                string text = Encoding.UTF8.GetString(data);

                listView1.Invoke((MethodInvoker)delegate
                {
                    listView1.Items.Add($"Received from {remoteEP}: {text}");
                });
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (receiveThread != null && receiveThread.IsAlive)
            {
                receiveThread.Abort();
            }
            Environment.Exit(0);
        }

    }
}