using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab03_Bai2
{
    public partial class TCPserver : Form
    {
        public TCPserver()
        {
            InitializeComponent();
        }

        private void StartListen()
        {
            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            listenerSocket.Bind(iPEndPoint);
            listenerSocket.Listen(5);

            while (true)
            {
                var clientSocket = listenerSocket.Accept();
                Thread thread = new Thread(() => ReceiveData(clientSocket));
                thread.Start();
            }
        }

        private void button_listen_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(StartListen);
            thread.Start();
            button_listen.Enabled = false;
        }

        private void ReceiveData(Socket clientSocket)
        {
            byte[] receive = new byte[100];
              UTF8Encoding utf8 = new UTF8Encoding(false, true);
            // Change: Always add "New Client Connected" message to listView_message, regardless of the thread
            listView_message.Invoke((MethodInvoker)delegate
            {
                listView_message.Items.Add("New Client Connected");
            });

            // Change: Always try to receive data from the client
            while (true)
            {
                string text = "";
                int bytesReceive;
                do
                {
                    bytesReceive = clientSocket.Receive(receive);
                    // Check if the received data is valid UTF-8
                    try
                    {
                        char[] chars = utf8.GetChars(receive, 0, bytesReceive);
                        text += new string(chars);
                    }
                    catch (DecoderFallbackException)
                    {
                        // The received data is not valid UTF-8
                        // Handle the error here
                        text += "[Invalid UTF-8 data received]";
                    }
                } while (!text.EndsWith("\n"));

                // Change: Always add received text to listView_message, regardless of the thread
                listView_message.Invoke((MethodInvoker)delegate
                {
                    listView_message.Items.Add(text);
                    listView_message.EnsureVisible(listView_message.Items.Count - 1);
                });
            }
        }

        private void TCPserver_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}