using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Text.Json;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lab3_Bai4
{
    public partial class Client : Form
    {
        // Kiểu dữ liệu của dsphim
        string[] veVot = { "A1", "A5", "C1", "C5" };
        string[] veVip = { "B2", "B3", "B4" };
        class ThongTinThanhToan
        {
            public string HoTen { get; set; }
            public string VeDaChon { get; set; }
            public string TenPhim { get; set; }
            public string PhongChieu { get; set; }
            public double SoTienTT { get; set; }
            public override string ToString()
            {
                return $"{HoTen}+{VeDaChon}+{TenPhim}+{PhongChieu}+{SoTienTT}";
            }
        }
        List<Phim> dsphim = new List<Phim>();
        class Phim
        {
            public string TenPhim { get; set; }
            public int GiaVeChuan { get; set; }
            public int[] PhongChieu { get; set; }
        }
        IPEndPoint IP;
        Socket client;
        public Client()
        {
            InitializeComponent();
        }

        private void control_button_Click(object sender, EventArgs e)
        {

            if (username_tb == null || username_tb.Text == "")
            {
                MessageBox.Show("Please type your name!", "Warning", MessageBoxButtons.OK);
                username_tb.Focus();
                return;
            }
            // Thiết lập kết nối
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8000);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Name = username_tb.Text;
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
            control_button.Enabled = false;
            username_tb.Enabled = false;
        }
        // Luồng lắng nghe server
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
                        {
                            dsphim = JsonSerializer.Deserialize<List<Phim>>(msg[1]);

                            // Sử dụng Invoke để cập nhật giao diện người dùng từ luồng khác
                            Invoke((MethodInvoker)delegate
                            {
                                // Xóa tất cả các mục hiện có trong ComboBox trước khi thêm mới
                                films_cbb.Items.Clear();

                                // Thêm từng phim vào ComboBox
                                foreach (Phim phim in dsphim)
                                {
                                    films_cbb.Items.Add(phim.TenPhim);
                                }

                                // Chọn mục đầu tiên làm mặc định
                                if (films_cbb.Items.Count > 0)
                                {
                                    films_cbb.SelectedIndex = 0;
                                }
                            });
                        }
                        else if (msg[0] == "<Success>")
                        {
                            MessageBox.Show("Bạn đã đặt vé thành công!");
                        }
                        else if (msg[0] == "<Fail>")
                        {
                            MessageBox.Show($"Vé {msg[1]} bạn đặt đã bị trùng!");
                        }
                        else if (msg[0] == "<CustomerInfo>")
                        {
                            string customerInfo = $"Username:{msg[1]}\nVe da chon: {msg[2]}\n Ten phim: {msg[3]}\n Phong Chieu:{msg[4]}\n Tien thanh toan: {msg[5]}\n---------------\n";
                            UpdateRichTextBox(customerInfo);
                        }
                        else if (msg[0] == "<CustomerNotFound>")
                        {
                            MessageBox.Show($"Khách hàng {username_tb} không tồn tại trong hệ thống!");
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
        //Hàm gửi gói tin cho server
        private void Send(string msg)
        {
            client.Send(Serialize(msg));
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
        // Event khi nhấn vào nút get
        private void get_btn_Click(object sender, EventArgs e)
        {
            Send("<GetFilms>-" + Name);
        }
        // Event khi thay đổi phim ở combobox
        private void films_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (films_cbb.SelectedItem != null)
            {
                // Lấy tên phim được chọn từ ComboBox
                string selectedFilmName = films_cbb.SelectedItem.ToString();

                // Tìm phim tương ứng trong danh sách dsphim
                Phim selectedPhim = dsphim.FirstOrDefault(phim => phim.TenPhim == selectedFilmName);

                // Kiểm tra xem phim có tồn tại hay không
                if (selectedPhim != null)
                {
                    // Xóa tất cả các mục hiện có trong ComboBox phòng chiếu trước khi thêm mới
                    room_cbb.Items.Clear();

                    // Thêm từng phòng chiếu vào ComboBox
                    foreach (int phong in selectedPhim.PhongChieu)
                    {
                        room_cbb.Items.Add(phong.ToString());
                    }

                    // Chọn mục đầu tiên làm mặc định
                    if (room_cbb.Items.Count > 0)
                    {
                        room_cbb.SelectedIndex = 0;
                    }
                }
            }
        }
        // Event khi nhấn vào nút buy
        private void buy_btn_Click(object sender, EventArgs e)
        {
            ThongTinThanhToan tickets = buyTicket();
            Send("<TTKH>-" + tickets.ToString());
        }
        // Hàm mua vé
        private ThongTinThanhToan buyTicket()
        {
            // Lấy tên phim được chọn từ ComboBox
            string selectedFilmName = films_cbb.SelectedItem.ToString();

            // Tìm phim tương ứng trong danh sách dsphim
            Phim phimDuocChon = dsphim.FirstOrDefault(phim => phim.TenPhim == selectedFilmName);

            // Kiểm tra xem phim có tồn tại hay không
            if (phimDuocChon != null)
            {
                // Lấy tên phòng chiếu được chọn từ ComboBox
                string phongChieu = room_cbb.SelectedItem.ToString();

                List<string> VeDaChon = new List<string>();
                double tongTien = 0;

                // Duyệt qua từng CheckBox trong groupBox1 để lấy thông tin vé đã chọn
                foreach (CheckBox checkBox in groupBox1.Controls.OfType<CheckBox>())
                {
                    if (checkBox.Checked)
                    {
                        string ghe = checkBox.Text;
                        VeDaChon.Add(ghe);

                        // Kiểm tra xem ghế có phải là VIP hoặc Vot không
                        if (phimDuocChon.PhongChieu.Contains(Convert.ToInt32(phongChieu)))
                        {
                            if (ghe.StartsWith("A") || ghe.StartsWith("C"))
                                tongTien += 0.25 * phimDuocChon.GiaVeChuan;
                            else if (ghe.StartsWith("B"))
                                tongTien += 2 * phimDuocChon.GiaVeChuan;
                            else
                                tongTien += phimDuocChon.GiaVeChuan;
                        }
                        else
                        {
                            MessageBox.Show("Ghế không phù hợp với phòng chiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                return new ThongTinThanhToan
                {
                    HoTen = username_tb.Text,
                    VeDaChon = string.Join(",", VeDaChon),
                    TenPhim = phimDuocChon.TenPhim,
                    PhongChieu = phongChieu,
                    SoTienTT = tongTien
                };
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin phim", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        // Event kiểm tra vé của người dùng
        private void check_btn_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu username đã được nhập vào
            if (!string.IsNullOrEmpty(username_tb.Text))
            {
                // Gửi yêu cầu kiểm tra vé đến server
                string message = "<TicketCheck>-" + username_tb.Text;
                Send(message);
            }
            else
            {
                MessageBox.Show("Please enter a username.", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UpdateRichTextBox(string info)
        {
            if (ticketInfo_richtextbox.InvokeRequired)
            {
                ticketInfo_richtextbox.Invoke(new MethodInvoker(delegate
                {
                    ticketInfo_richtextbox.AppendText(info);
                    ticketInfo_richtextbox.AppendText(Environment.NewLine);
                }));
            }
            else
            {
                ticketInfo_richtextbox.AppendText(info);
                ticketInfo_richtextbox.AppendText(Environment.NewLine);
            }
        }

    }
}
