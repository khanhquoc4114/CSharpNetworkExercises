using System;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Text;

namespace TCP_server
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private ClientConnection client;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    client  = new ClientConnection();
                    client.Connect();
                } catch
                {
                    MessageBox.Show("Không thành công");
                    return;
                }

                if (!client.isConnected)
                {
                    return;
                }
                BeginInvoke((Action)(() =>
                {
                    txtStatus.Text = "Đã kết nối đến server thành công";
                    btnSend.Enabled = true;
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                }));
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"Không thể kết nối server: {ex.Message}", "Notice");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtSend.Text == "")
            {
                return;
            }
            string message = txtSend.Text.Trim();
            client.Send(message);
            txtSend.Clear();
            txtSend.Focus();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                client.Disconnect();
                btnSend.Enabled = false;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
            }));
            txtStatus.Text = "Đang không kết nối server";
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
                txtSend.Focus();
            }
        }
    }

    class ClientConnection
    {
        public bool isConnected = false;
        IPAddress ipAdd= IPAddress.Parse("127.0.0.1");
        IPEndPoint ipEP;
        TcpClient client;
        NetworkStream stream;
        int port = 8888;

        public void Connect()
        {
            try
            {
                client = new TcpClient();
                ipEP = new IPEndPoint(ipAdd, port);
                client.Connect(ipEP);
                stream = client.GetStream();
                isConnected = true;
            }
            catch (SocketException ex) when (ex.SocketErrorCode == SocketError.ConnectionRefused)
            {
                MessageBox.Show("Không thể kết nối server: Server không khả dụng hoặc không đang chạy", "Thông báo");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối server: {ex.Message}", "Thông báo");
                return;
            }
        }

        public void Send(string message)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                if (isConnected)
                {
                    client.Close();
                    stream.Close();
                    isConnected = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing client socket: " + ex.Message);
            }
            finally
            {
                stream?.Dispose();
                client?.Dispose();
            }
        }
    }
}
