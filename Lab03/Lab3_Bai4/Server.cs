using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab3_Bai4
{
    public partial class Server : Form
    {
        // Khai bao danh sach phim
        string jsonData;
        List<ThongTinThanhToan> DanhSachKhachHang = new List<ThongTinThanhToan>();
        class ThongTinThanhToan
        {
            public string HoTen { get; set; }
            public string VeDaChon { get; set; }
            public string TenPhim { get; set; }
            public string PhongChieu { get; set; }
            public double SoTienTT { get; set; }
        }
        class Phim
        {
            public string TenPhim { get; set; }
            public int GiaVeChuan { get; set; }
            public int[] PhongChieu { get; set; }
        }
        IPEndPoint IP;
        Socket server;
        List<Socket> clientlist;
        Dictionary<Socket, string> clientDictionary = new Dictionary<Socket, string>();
        public Server()
        {
            InitializeComponent();
        }

        // Event khi nhấn vào nút Start
        private void control_btn_Click(object sender, EventArgs e)
        {
            // Thiết lập kết nối
            clientlist = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8000);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(IP);
            // Luông lắng nghe liên tục để kết nối nhiều clients
            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        AddMessage("A client connected.\n");
                        // Mỗi client kết nối thành công sẽ tạo luồng lắng nghe riêng
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8000);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            listen.IsBackground = true;
            listen.Start();
            start_btn.Enabled = false;
            stop_btn.Enabled = true;
            AddMessage("Start listening...\n");
        }

        // Hàm để gửi gói tin cho client chỉ định
        private void Send(Socket client, string msg)
        {
            client.Send(Serialize(msg));
        }

        // Luồng lắng nghe liên tục từ mỗi client
        private void Receive(object obj)
        {
            Socket client = (Socket)obj;
            clientlist.Add(client);
            try
            {
                while (true)
                {
                    // Tạo mảng byte để nhận dữ liệu
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    // Gom mảnh dữ liệu thành dạng string
                    string message = (string)Deserialize(data);
                    if (message != null)
                    {
                        AddMessage(message + "\n");
                        string[] msg = message.Split('-');
                        if (msg[0] == "<GetFilms>") // client yêu cầu danh sách phim
                        {
                            clientDictionary.Add(client, msg[1]);
                            Send(client, "<FilmsJson>-" + jsonData);
                            AddMessage("Đã gửi danh sách phim cho client!\n");
                        }
                        else if (msg[0] == "<TTKH>")
                        {
                            // <TTKH>-<Username>-<VeDaChon>-<TenPhim>-<PhongChieu>-<SoTienThanhToan>
                            string[] str = msg[1].Split('+');
                            string vetrung = CheckTickets(msg[1], DanhSachKhachHang);
                            if (vetrung == "")
                            {
                                ThemKhachHang(msg[1]);
                                Send(client, "<Success>-");
                                AddMessage("The customer has successfully booked the ticket.\n");
                            }
                            else
                            {
                                Send(client, "<Fail>-" + vetrung);
                                AddMessage("The customer booked a duplicate ticket.\n");
                            }
                        }
                        else if (msg[0] == "<TicketCheck>")
                        {
                            string[] parts = message.Split('-');
                            string username = parts[1];

                            // Tìm kiếm khách hàng trong danh sách
                            ThongTinThanhToan customer = DanhSachKhachHang.FirstOrDefault(c => c.HoTen == username);

                            if (customer != null)
                            {
                                // Nếu khách hàng tồn tại, gửi thông tin về cho client
                                string response = $"<CustomerInfo>-{customer.HoTen}-{customer.VeDaChon}-{customer.TenPhim}-{customer.PhongChieu}-{customer.SoTienTT}";
                                Send(client, response);
                                AddMessage($"Sent customer info for {customer.HoTen} to client.\n");
                            }
                            else
                            {
                                // Nếu khách hàng không tồn tại, thông báo cho client
                                Send(client, "<CustomerNotFound>");
                                AddMessage($"Customer {username} not found.\n");
                            }


                        }
                    }
                }
            }
            catch
            {
                clientlist.Remove(client);
                clientDictionary.Remove(client);
                AddMessage("A client disconnected.\n");
                client.Close();
            }
        }
        //2 hàm để cập nhật log an toàn khi chương trình có đa luồng
        private delegate void SafeCallDelegate(string text);
        private void AddMessage(string str)
        {
            if (msg_rtb.InvokeRequired)
            {
                var d = new SafeCallDelegate(AddMessage);
                msg_rtb.Invoke(d, new object[] { str });
            }
            else
            {
                msg_rtb.Text += str;
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
        // Event khi nhấn vào nút add
        private void add_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        using (StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8))
                        {
                            jsonData = streamReader.ReadToEnd();
                            //dsphim = JsonSerializer.Deserialize<List<Phim>>(jsonData);
                        }
                    }
                    AddMessage("Successfully loaded JSON file.\n");
                }
                catch (Exception ex)
                {
                    AddMessage("Error loading JSON file: " + ex.Message + "\n");
                }
            }
        }
        // Hàm kiểm tra vé đã đặt của khách hàng
        private string CheckTickets(string ttkh, List<ThongTinThanhToan> dskh)
        {
            // ttkh = <Username>+<VeDaChon>-<TenPhim>-<PhongChieu>-<SoTienThanhToan>
            string[] parts = ttkh.Split('+');
            string[] dsVe1 = parts[1].Split(',');

            HashSet<string> vetrungSet = new HashSet<string>();

            foreach (ThongTinThanhToan kh in dskh)
            {
                if (kh.TenPhim == parts[2] && kh.PhongChieu == parts[3])
                {
                    string[] dsVe2 = kh.VeDaChon.Split(',');
                    foreach (string ve1 in dsVe1)
                    {
                        foreach (string ve2 in dsVe2)
                        {
                            if (ve1 == ve2)
                            {
                                vetrungSet.Add(ve2);
                            }
                        }
                    }
                }
            }

            // Chuyển tập hợp thành chuỗi để trả về
            string vetrung = string.Join(",", vetrungSet);
            return vetrung;
        }


        private void ThemKhachHang(string ttkh)
        {
            string[] parts = ttkh.Split('+');
            string tenKhachHangMoi = parts[0];
            ThongTinThanhToan thongTinKhachHangMoi = new ThongTinThanhToan
            {
                HoTen = parts[0],
                VeDaChon = parts[1],
                TenPhim = parts[2],
                PhongChieu = parts[3],
                SoTienTT = double.Parse(parts[4])
            };

            bool foundExistingCustomer = false;

            // Duyệt qua danh sách khách hàng hiện tại để kiểm tra xem có khách hàng nào cùng tên, cùng phim, cùng phòng chiếu không
            foreach (ThongTinThanhToan kh in DanhSachKhachHang)
            {
                if (kh.HoTen == tenKhachHangMoi && kh.TenPhim == thongTinKhachHangMoi.TenPhim && kh.PhongChieu == thongTinKhachHangMoi.PhongChieu)
                {
                    // Tên của khách hàng mới, tên phim và phòng chiếu trùng với một khách hàng có sẵn trong danh sách
                    // Tổng hợp thông tin của họ
                    foundExistingCustomer = true;

                    // Tổng hợp thông tin vé đã chọn
                    string[] veDaChonMoi = thongTinKhachHangMoi.VeDaChon.Split(',');
                    string[] veDaChonCu = kh.VeDaChon.Split(',');
                    List<string> veDaChonTongHop = new List<string>();

                    foreach (string ve in veDaChonMoi)
                    {
                        if (!veDaChonCu.Contains(ve))
                        {
                            veDaChonTongHop.Add(ve);
                        }
                    }

                    foreach (string ve in veDaChonCu)
                    {
                        veDaChonTongHop.Add(ve);
                    }

                    kh.VeDaChon = string.Join(",", veDaChonTongHop);

                    // Tổng hợp số tiền thanh toán
                    kh.SoTienTT += thongTinKhachHangMoi.SoTienTT;

                    break; // Dừng vòng lặp sau khi tìm thấy khách hàng trùng và đã tổng hợp thông tin
                }
            }

            // Nếu không tìm thấy khách hàng nào trùng tên, cùng phim và cùng phòng chiếu, thêm khách hàng mới vào danh sách
            if (!foundExistingCustomer)
            {
                DanhSachKhachHang.Add(thongTinKhachHangMoi);
            }
        }

        // Event khi nhấn vào nút Stop
        private void stop_btn_Click(object sender, EventArgs e)
        {
            server.Close();
            stop_btn.Enabled = false;
            start_btn.Enabled = true;
            AddMessage("Stop listening.\n");
        }

    }
}
