using Lab3_Bai4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab3_Bai3
{
    public partial class SuperUser : Form
    {
        public SuperUser()
        {
            InitializeComponent();
        }



        IPEndPoint IP;
        Socket client;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Thiết lập kết nối
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8000);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                // Kết nối đến server
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Fail to connect to server!", "Warning", MessageBoxButtons.OK);
                return;
            }
            // Tạo luồng để lắng nghe server liên tục
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        private void Receive()
        {
            try
            {
                while (true)
                {
                    //Tạo mảng byte để nhận dữ liệu
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    //Gom mảnh dữ liệu thành dạng string
                    string message = (string)Deserialize(data);

                    if (message != null)
                    {
                        //Phân tách nội dung của gói tin
                        string[] msg = message.Split('-');

                        if (msg[0] == "<FilmsJson>")
                        { }
                        else if (msg[0] == "<GetList>")
                        {
                            List<string> list = new List<string>(msg[1].Split('@'));
                            Invoke((MethodInvoker)delegate
                            {
                                cb.Items.Clear();
                                cb.DataSource = list;
                            });
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show(e.Message);
            }
        }

        //Gom mảnh cho việc nhận
        private object Deserialize(byte[] data)
        {
            //Tạo stream để lưu trữ mảng byte đầu vào
            MemoryStream stream = new MemoryStream(data);
            //Dùng BinaryFormatter để gom mảnh
            BinaryFormatter bf = new BinaryFormatter();
            //Gom mảnh và trả về dữ liệu
            return bf.Deserialize(stream);
        }
        //Phân mảnh cho việc gửi
        private byte[] Serialize(object obj)
        {
            //Tạo stream để lưu trữ mảng byte đầu ra
            MemoryStream stream = new MemoryStream();
            //Dùng BinaryFormatter để phân mảnh
            BinaryFormatter bf = new BinaryFormatter();
            //Phân mảnh dữ liệu thành 1 mảng byte và lưu vào stream
            bf.Serialize(stream, obj);
            //Trả về 1 mảng byte
            return stream.ToArray();
        }

        //Hàm gửi gói tin cho server
        private void Send(string msg)
        {
            client.Send(Serialize(msg));
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            Send("<GetList>");
        }

        private void SuperUser_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string name = cb.Text;
            Send($"<Block>-{name}");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string name = cb.Text;
            Send($"<Unblock>-{name}");
        }
    }
}
