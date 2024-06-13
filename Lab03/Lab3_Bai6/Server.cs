﻿using J3QQ4;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3_Bai6
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            LoadEmojiButtons();
        }

        #region Global
        const int maxWidth = 200;
        const int maxHeight = 150;

        private bool serverRunning = false;
        private TcpListener tcpServer;
        private Thread listenThread;
        private Dictionary<string, TcpClient> dic_clients = new Dictionary<string, TcpClient>();
        private bool listening = true;
        private IPAddress ipServer = IPAddress.Any;
        #endregion

        #region Message
        // Thêm tin nhắn vào rtbChatBox
        private delegate void SafeCallDelegate(string username, string message);
        private void AddMessage(string username, string data)
        {
            if (rtbChatBox.InvokeRequired)
            {
                var method = new SafeCallDelegate(AddMessage);
                rtbChatBox.Invoke(method, new object[] { username, data });
            }
            else
            {
                if (username == null)
                {
                    rtbChatBox.AppendText(data + Environment.NewLine);
                }
                else
                {
                    rtbChatBox.AppendText($"{username}: {data}" + Environment.NewLine);
                }
                ScrollToBottom();
            }
        }
        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }
        // Button gửi tin nhắn
        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text.Trim();
            if (message == "") return;
            if (message == "//connections")
            {
                int count = dic_clients.Count;
                AddMessage("Connection", $"{count}");
                txtMessage.Clear();
                return;
            }

            AddMessage("Admin", message);
            Broadcast("Admin", message);
            txtMessage.Clear();
        }
        // Chỉnh tự động hiện cuối rtbChatBox
        private void ScrollToBottom()
        {
            rtbChatBox.SelectionStart = rtbChatBox.Text.Length;
            rtbChatBox.ScrollToCaret();
        }
        #endregion

        #region Server
        // Hàm lắng nghe từ client
        private void Listen()
        {
            try
            {
                while (listening)
                {
                    TcpClient client = tcpServer.AcceptTcpClient();
                    IPEndPoint remoteIpEndPoint = (IPEndPoint)client.Client.RemoteEndPoint;
                    string clientIp = remoteIpEndPoint.Address.ToString();
                    int clientPort = remoteIpEndPoint.Port;

                    NetworkStream net_stream = client.GetStream();
                    byte[] data = new byte[1024*5000];
                    int byte_count = net_stream.Read(data, 0, data.Length);
                    string username = Encoding.UTF8.GetString(data, 0, byte_count);

                    if (username == "Admin" || username == "Administrator")
                    {
                        byte[] response = Encoding.UTF8.GetBytes("This username is reserved!");
                        net_stream.Write(response, 0, response.Length);
                        net_stream.Flush();
                        client.Close();
                    }
                    else if (dic_clients.ContainsKey(username))
                    {
                        byte[] response = Encoding.UTF8.GetBytes("This username has already existed!");
                        net_stream.Write(response, 0, response.Length);
                        net_stream.Flush();
                        client.Close();
                    }
                    else
                    {
                        AddMessage("Message", $"User {username} from ({clientIp}:{clientPort}) has connected succesfully");
                        dic_clients.Add(username, client);
                        Thread receiveThread = new Thread(Receive)
                        {
                            IsBackground = true
                        };
                        receiveThread.Start(username);
                    }
                }
            }
            catch
            {
                tcpServer = new TcpListener(ipServer, int.Parse(txtServerPort.Text));
            }
        }
        // Broadcast đến toàn bộ connection trừ người gửi
        private void Broadcast(string username, string message, TcpClient except_this_client = null)
        {
            byte[] final = Encoding.UTF8.GetBytes($"<Message>💀{username}: {message}");
            foreach (TcpClient client in dic_clients.Values)
            {
                if (client != except_this_client)
                {
                    NetworkStream net_stream = client.GetStream();
                    net_stream.Write(final, 0, final.Length);
                    net_stream.Flush();
                }
            }
        }

        // Nhận message
        private void Receive(object obj)
        {
            string username = obj.ToString();
            TcpClient client = dic_clients[username];
            NetworkStream net_stream = client.GetStream();
            byte[] data = new byte[1024 * 10000];
            try
            {
                while (listening)
                {
                    int byte_count = net_stream.Read(data, 0, data.Length);


                    if (byte_count == 0)
                    {
                        dic_clients.Remove(username);
                        client.Close();
                        AddMessage(null, $"Client {username} disconnected.");
                        break;
                    }

                    if (IsImageData(data))
                    {
                        using (MemoryStream ms = new MemoryStream(data, 0, byte_count))
                        {
                            Image image = Image.FromStream(ms);

                            this.Invoke((MethodInvoker)delegate
                            {
                                AddImageToChat(username, image);
                            });
                            SendImageBroadCast(image, client);
                        }
                    } else
                    {
                        string message = Encoding.UTF8.GetString(data, 0, byte_count);
                        string[] msg = Split_Message(message);
                        if (msg[0] == "<Message>")
                        {
                            AddMessage(username, msg[1]);
                            Broadcast(username, msg[1], client);
                        } 
                        else if (msg[0] == "<FileText>")
                        {
                            AddMessage(null, "Đã nhận được 1 file");
                            ReceiveFile(msg[1]);
                            byte[] final = Encoding.UTF8.GetBytes(message);
                            foreach (TcpClient clients in dic_clients.Values)
                            {
                                if (clients != client)
                                {
                                    NetworkStream newnet_stream = clients.GetStream();
                                    newnet_stream.Write(final, 0, final.Length);
                                    newnet_stream.Flush();
                                }
                            }
                        }
                    }
                    Array.Clear(data, 0, data.Length);
                }
            }
            catch (IOException ex)
            {
                dic_clients.Remove(username);
                client.Close();
                AddMessage("Server", $"Error: Client {username} connection lost. {ex.Message}");
            }
        }
        // Tách chuỗi
        private string[] Split_Message(string message)
        {
            string separator = "💀";
            string[] msg = message.Contains(separator) ? message.Split(new string[]
            { separator }, 2, StringSplitOptions.None) : new string[] { message };
            return msg;
        }

        // Button mở và đóng server
        private void btnListen_Click(object sender, EventArgs e)
        {
            if (btnListen.Text == "Listen")
            {
                StartServer();
            } 
            else if (btnListen.Text == "Shut")
            {
                StopServer();
            }
        }
        private void StartServer()
        {
            // Khởi động nhanh bằng số lượng client cho sẵn
            int users_num = int.Parse(txtUserNumber.Text);
            while (users_num > 0)
            {
                Client client = new Client();
                client.Show();
                users_num--;
            }

            if (!serverRunning)
            {
                try
                {
                    if (!int.TryParse(txtServerPort.Text, out int port))
                    {
                        MessageBox.Show("Invalid port number.");
                        return;
                    }

                    tcpServer = new TcpListener(ipServer, port);
                    tcpServer.Start();
                    serverRunning = true;

                    AddMessage("Admin", $"{ipServer} - Waiting for connections...");
                    listenThread = new Thread(new ThreadStart(Listen));
                    listenThread.IsBackground = true;
                    listenThread.Start();

                    txtServerPort.ReadOnly = txtUserNumber.ReadOnly = true;
                    btnListen.Text = "Shut";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error starting server: {ex.Message}");
                }
            }
        }
        private void StopServer()
        {
            if (serverRunning)
            {
                try
                {
                    listening = false;

                    foreach (TcpClient client in dic_clients.Values)
                    {
                        client.Close();
                    }

                    dic_clients.Clear();
                    tcpServer.Stop();

                    serverRunning = false;
                    rtbChatBox.Clear();

                    AddMessage("Admin", "Server stopped.");
                    txtServerPort.ReadOnly = txtUserNumber.ReadOnly = false;
                    btnListen.Text = "Listen";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error stopping server: {ex.Message}");
                }
            }
        }
        #endregion

        #region Image
        bool IsImageData(byte[] data)
        {
            try
            {
                using (var ms = new MemoryStream(data))
                {
                    Image.FromStream(ms);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        private bool IsImageFile(string filePath)
        {
            try
            {
                using (var image = Image.FromFile(filePath))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        private Image ResizeImage(Image image, int maxWidth, int maxHeight)
        {
            int newWidth, newHeight;
            double aspectRatio = (double)image.Width / image.Height;

            if (image.Width > maxWidth)
            {
                newWidth = maxWidth;
                newHeight = (int)(newWidth / aspectRatio);
            }
            else if (image.Height > maxHeight)
            {
                newHeight = maxHeight;
                newWidth = (int)(newHeight * aspectRatio);
            }
            else
            {
                newWidth = image.Width;
                newHeight = image.Height;
            }

            return new Bitmap(image, newWidth, newHeight);
        }
        // Hàm gửi ảnh 
        private void SendImageBroadCast(Image image, TcpClient except_this_client = null)
        {
            image = ResizeImage(image, maxWidth, maxHeight);
            //byte[] imageData = File.ReadAllBytes(imagePath);
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageData = ms.ToArray();

                foreach (TcpClient client in dic_clients.Values)
                {
                    if (client != except_this_client)
                    {
                        NetworkStream netStream = client.GetStream();
                        netStream.Write(imageData, 0, imageData.Length);
                        netStream.Flush();
                    }
                }
            }
        }
        // Hàm hiện ảnh lên trên rtbChatBox
        private void AddImageToChat(string username, Image image)
        {
                rtbChatBox.AppendText(Environment.NewLine);
                rtbChatBox.Select(rtbChatBox.Text.Length, 0);
                rtbChatBox.SelectionColor = rtbChatBox.ForeColor;
                rtbChatBox.AppendText($"{username}: ");
                rtbChatBox.Select(rtbChatBox.Text.Length, 0);
                rtbChatBox.ReadOnly = false;
                image = ResizeImage(image, maxWidth, maxHeight);

                if (rtbChatBox.InvokeRequired)
                {
                    rtbChatBox.BeginInvoke((MethodInvoker)delegate {
                        Clipboard.SetImage(image);
                        rtbChatBox.Paste();
                    });
                }
                else
                {
                    Clipboard.SetImage(image);
                    rtbChatBox.Paste();
                }
                rtbChatBox.ScrollToCaret();
                rtbChatBox.ReadOnly = true;
                rtbChatBox.AppendText(Environment.NewLine);
            }
        #endregion

        #region File

        // Button gửi file và ảnh
        private void btnSendFlie_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (IsImageFile(filePath))
                {
                    Image image = Image.FromFile(filePath);
                    SendImageBroadCast(image);
                    AddImageToChat("Admin", image);
                }
                else
                {
                    SendFile(filePath);
                }
            }
        }


        // Hàm gửi file
        private void SendFile(string filePath)
        {
            try
            {
                string fileName = Path.GetFileName(filePath);
                string fileContent = File.ReadAllText(filePath);

                string file = $"<FileText>💀{fileName}💀{fileContent}";

                byte[] final= Encoding.UTF8.GetBytes(file);

                foreach (TcpClient client in dic_clients.Values)
                {
                    NetworkStream netStream = client.GetStream();
                    netStream.Write(final, 0, final.Length);
                    netStream.Flush();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending file: {ex.Message}");
            }
        }
        // Nhận file
        private void ReceiveFile(string message)
        {
            string[] file = Split_Message(message);
            string fileName = file[0];
            string fileContent = file[1];

            this.Invoke((MethodInvoker)delegate
            {
                Button downloadButton = new Button();
                downloadButton.Text = fileName;
                downloadButton.Tag = fileContent;
                downloadButton.AutoSize = true;

                flpFile.Controls.Add(downloadButton);

                downloadButton.Click += (sender, e) =>
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.FileName = fileName;
                        saveFileDialog.Filter = "Text file|*.txt|All files|*.*";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;

                            try
                            {
                                File.WriteAllText(filePath, downloadButton.Tag.ToString());
                                MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                };
            });
        }
        #endregion

        #region Emoji

        private List<string> emojiList = new List<string>();

        private void LoadEmojiButtons()
        {
            Type emojiType = typeof(Emoji);
            FieldInfo[] emojiFields = emojiType.GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (FieldInfo field in emojiFields)
            {
                string emoji = (string)field.GetValue(null);
                emojiList.Add(emoji);

                Button emojiButton = new Button();
                emojiButton.Text = emoji;
                emojiButton.Width = 60;
                emojiButton.Height = 60;
                emojiButton.Margin = new Padding(5);
                emojiButton.Font = new Font("Segoe UI Emoji", 15);

                emojiButton.Click += (sender, e) =>
                {
                    txtMessage.AppendText(emojiButton.Text);
                    flpEmoji.Visible = !flpEmoji.Visible;
                };

                flpEmoji.Controls.Add(emojiButton);
            }
        }

        private void txtEmoji_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string keyword = txtEmoji.Text.Trim().ToLower();
                List<string> searchResults = SearchEmoji(keyword);
                UpdateEmojiButtons(searchResults);
            }
        }

        private void UpdateEmojiButtons(List<string> emojis)
        {
            for (int i = flpEmoji.Controls.Count - 1; i > 0; i--)
            {
                flpEmoji.Controls.RemoveAt(i);
            }

            foreach (string emoji in emojis)
            {
                Button emojiButton = new Button();
                emojiButton.Text = emoji;
                emojiButton.Width = 60;
                emojiButton.Height = 60;
                emojiButton.Margin = new Padding(5);
                emojiButton.Font = new Font("Segoe UI Emoji", 15);

                emojiButton.Click += (sender, e) =>
                {
                    txtMessage.AppendText(emojiButton.Text);
                    flpEmoji.Visible = !flpEmoji.Visible;
                };
                flpEmoji.Controls.Add(emojiButton);
            }
        }

        private List<string> SearchEmoji(string keyword)
        {
            List<string> results = new List<string>();

            Type emojiType = typeof(Emoji);
            FieldInfo[] emojiFields = emojiType.GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (FieldInfo field in emojiFields)
            {
                string emoji = (string)field.GetValue(null);
                if (field.Name.ToLower().Contains(keyword.ToLower()))
                {
                    results.Add(emoji);
                }
            }
            return results;
        }

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            flpEmoji.Visible = !flpEmoji.Visible;
        }
        #endregion
    }
}
