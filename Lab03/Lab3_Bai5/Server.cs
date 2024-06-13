using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai5
{

    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        private TcpListener _listener;
        private List<TcpClient> _clients = new List<TcpClient>();
        public void Start(int port)
        {
            _listener = new TcpListener(IPAddress.Any, port);
            _listener.Start();

            while (true)
            {
                TcpClient client = _listener.AcceptTcpClient();
                _clients.Add(client);

                // Start a new thread to handle the connection
                Task.Run(() =>
                {
                    AddMessage("A client connected.");

                    NetworkStream stream = client.GetStream();

                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    // Keep reading data from the client
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        // If the message is a database change event
                        if (message.Contains("DatabaseChanged"))
                        {
                            AddMessage("Database has been changed.");

                            // Notify all clients to reload data
                            foreach (var c in _clients)
                            {
                                NetworkStream clientStream = c.GetStream();
                                byte[] notification = Encoding.UTF8.GetBytes("ReloadData");
                                clientStream.Write(notification, 0, notification.Length);
                            }
                        }
                    }

                    AddMessage("A client disconnected.");
                    client.Close();
                });
            }
        }

        private void AddMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddMessage), new object[] { message });
                return;
            }

            listView1.Items.Add(message);
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            _listener?.Stop();
            foreach (var client in _clients)
            {
                client.Close();
            }
        }
    }
}
