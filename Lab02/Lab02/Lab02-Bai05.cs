﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
namespace Lab02
{
    public partial class Bai5 : Form

    {
        public class Phim
        {
            [JsonProperty("TenPhim")]
            public string ten { get; set; }
            [JsonProperty("GiaVeChuan")]
            public int giavechuan { get; set; }
            [JsonProperty("PhongChieu")]
            public List<int> phongchieu { get; set; }
        }
        public class ThongKePhim
        {
            public string Tenphim { get; set; }
            public int Vedaban { get; set; }
            public int Veconlai { get; set; }
            public float TyLe { get; set; }
            public int DoanhThu { get; set; }
            public int Hang { get; set; }
        }
        // danh sách để export
        Dictionary<string, ThongKePhim> danhSachThongKePhim = new Dictionary<string, ThongKePhim>();

        //tạo danh sách phòng chiếu cho trường hợp thêm các file json
        private Dictionary<int, List<CheckBox>> roomSeats = new Dictionary<int, List<CheckBox>>();

        //lưu thông vé đã bán
        Dictionary<string, List<string>> soldTickets = new Dictionary<string, List<string>>();

        private DataTable dt = new DataTable();

        private bool seatSelected = false;

        public Bai5()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //khởi tạo bảng tính tiền
            dataGridView1.DataSource = dt;
            dt.Columns.Add("Phim", typeof(string));
            dt.Columns.Add("Rạp", typeof(string));
            dt.Columns.Add("Ghế", typeof(string));
            dt.Columns.Add("Giá", typeof(int));

            dataGridView1.Columns["Phim"].Width = 150;
            dataGridView1.Columns["Rạp"].Width = 50;
            dataGridView1.Columns["Ghế"].Width = 50;
            dataGridView1.Columns["Giá"].Width = 70;

        }

        //tạo phòng chiếu
        private List<CheckBox> CreateRoomSeats(int totalRows, int totalColumns)
        {
            List<CheckBox> seats = new List<CheckBox>();
            for (int i = 0; i < totalRows; i++)
            {
                for (int j = 0; j < totalColumns; j++)
                {
                    string text = $"{(char)('A' + i)}{j + 1}";
                    CheckBox checkBox = CreateCheckBox(text, 60 + i * 60, 60 + j * 60);
                    seats.Add(checkBox);
                }
            }

            return seats;
        }
        //tạo 1 ghế ngồi
        private CheckBox CreateCheckBox(string text, int top, int left)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Text = text;
            checkBox.Height = 24;
            checkBox.Width = 49;
            checkBox.Top = top;
            checkBox.Left = left;
            checkBox.CheckedChanged += checkBox_CheckedChanged;
            return checkBox;
        }
        // ánh xạ phim và phòng chiếu
        Dictionary<string, List<int>> movies = new Dictionary<string, List<int>>
            {
            };
        //xử lý combobox phim
        private void comboBox_phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seatSelected)
            {
                MessageBox.Show("Bạn đã chọn ghế xin không thể đổi phim.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_phim.SelectedIndex = comboBox_phim.Items.IndexOf(dt.Rows[0]["Phim"]);
                return;
            }
            groupBox1.Controls.Clear();

            string selectedMovie = comboBox_phim.SelectedItem.ToString();
            comboBox_rap.Items.Clear();
            foreach (int room in movies[selectedMovie])
            {
                comboBox_rap.Items.Add("Rạp " + room);
            }
            comboBox_rap.Text = "";
        }
        //xử lý combobox rạp
        private void comboBox_rap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seatSelected)
            {
                MessageBox.Show("Bạn đã chọn ghế xin không thể đổi phòng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_rap.SelectedIndex = comboBox_rap.Items.IndexOf("Rạp " + dt.Rows[0]["Rạp"]);
                return;
            }

            groupBox1.Controls.Clear();

            int selectedRoom = int.Parse(comboBox_rap.SelectedItem.ToString().Split(' ')[1]);

            groupBox1.Text = "Rạp " + selectedRoom;
            if (roomSeats.ContainsKey(selectedRoom))
            {
                List<CheckBox> selectedRoomSeats = roomSeats[selectedRoom];
                foreach (CheckBox seat in selectedRoomSeats)
                {
                    groupBox1.Controls.Add(seat);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng chiếu đã chọn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //ánh xạ phim và giá vé    
        Dictionary<string, int> giaphim = new Dictionary<string, int>
            {
            };
        //ánh xạ ghế và tỉ lệ giá 
        Dictionary<string, float> gia_ghe = new Dictionary<string, float>
            {
                { "A1", 0.25f }, { "A5", 0.25f }, { "C1", 0.25f }, { "C5", 0.25f }, {"B1", 0.25f},{ "B5" , 0.25f },
                { "A2", 1f }, { "A3", 1f }, { "A4", 1f }, { "C2", 1f }, { "C3", 1f }, { "C4", 1f },
                { "B2", 2f }, { "B3", 2f }, { "B4", 2f }
            };
        private int tinh_tien(string movie, string seat)
        {
            int basePrice = giaphim[movie];

            float factor = gia_ghe[seat];

            int seatPrice = (int)(basePrice * factor);

            return seatPrice;
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string selectedMovie = comboBox_phim.SelectedItem.ToString();
            string selectedSeat = checkBox.Text;

            if (checkBox.Checked)
            {
                string selectedRoom = comboBox_rap.SelectedItem.ToString().Split(' ')[1];

                int seatPrice = tinh_tien(selectedMovie, selectedSeat);

                dt.Rows.Add(selectedMovie, selectedRoom, selectedSeat, seatPrice);

                seatSelected = true;
            }
            else
            {
                DataRow rowToRemove = dt.AsEnumerable().FirstOrDefault(row => row.Field<string>("Ghế") == selectedSeat && row.Field<string>("Phim") == selectedMovie);
                if (rowToRemove != null)
                {
                    dt.Rows.Remove(rowToRemove);
                }

                if (dt.AsEnumerable().FirstOrDefault(row => row.Field<string>("Phim") != "Tổng") == null)
                {
                    seatSelected = false;
                }
            }

            AddTotalRow();
        }
        private void AddTotalRow()
        {
            DataRow totalRow = dt.AsEnumerable().FirstOrDefault(row => row.Field<string>("Phim") == "Tổng");
            if (totalRow != null)
            {
                dt.Rows.Remove(totalRow);
            }

            int totalPrice = 0;
            foreach (DataRow row in dt.Rows)
            {
                totalPrice += Convert.ToInt32(row["Giá"]);
            }

            totalRow = dt.NewRow();
            totalRow["Phim"] = "Tổng";
            totalRow["Rạp"] = "";
            totalRow["Ghế"] = "";
            totalRow["Giá"] = totalPrice;
            dt.Rows.Add(totalRow);
        }

        private void button_thanhtoan_Click(object sender, EventArgs e)
        {
            string ten = textBox_ten.Text;
            textBox_ten.Clear();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tên: {ten}");

            DataRow totalRow = dt.AsEnumerable().FirstOrDefault(row => row.Field<string>("Phim") == "Tổng");
            if (totalRow != null)
            {
                sb.AppendLine($"Tổng: {totalRow["Giá"]}");
            }

            MessageBox.Show(sb.ToString(), "Thông tin thanh toán");

            // huỷ trạng thái có thể chọn sau khi mua vé
            foreach (DataRow row in dt.Rows)
            {
                string movie = row["Phim"].ToString();
                string seat = row["Ghế"].ToString();
                if (!soldTickets.ContainsKey(movie))
                {
                    soldTickets[movie] = new List<string>();
                }
                soldTickets[movie].Add(seat);
                CheckBox checkBox = groupBox1.Controls.OfType<CheckBox>().FirstOrDefault(c => c.Text == seat);
                if (checkBox != null)
                {
                    checkBox.Enabled = false;
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                string tenPhim = row["Phim"].ToString();
                if (tenPhim == "Tổng") continue;
                int gia = Convert.ToInt32(row["Giá"]);
                if (!danhSachThongKePhim.ContainsKey(tenPhim))
                {
                    danhSachThongKePhim[tenPhim] = new ThongKePhim { Tenphim = tenPhim, Vedaban = 0, DoanhThu = 0 };
                }
                danhSachThongKePhim[tenPhim].Vedaban++;
                danhSachThongKePhim[tenPhim].DoanhThu += gia;
            }
            // Xóa bảng thanh toán
            dt.Clear();

            //trả trạng thái chọn ghế về 0
            seatSelected = false;
            // Tính toán thống kê

        }
        private void button_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON files (*.json)|*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        string json = sr.ReadToEnd();
                        List<Phim> phims = JsonConvert.DeserializeObject<List<Phim>>(json);
                        foreach (var mv in phims)
                        {
                            if (!movies.ContainsKey(mv.ten))
                            {
                                movies.Add(mv.ten, mv.phongchieu);
                                comboBox_phim.Items.Add(mv.ten);
                                giaphim.Add(mv.ten, mv.giavechuan);
                            }

                            //tạo phòng chiếu chưa có
                            foreach (var room in mv.phongchieu)
                            {
                                if (!roomSeats.ContainsKey(room))
                                {
                                    roomSeats[room] = CreateRoomSeats(3, 5);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading JSON file: " + ex.Message);
                }
            }
        }

        private void button_static_Click(object sender, EventArgs e)
        {
            int tongSoGhe = roomSeats.Values.Sum(room => room.Count);
            List<ThongKePhim> thongKe = danhSachThongKePhim.Values.ToList();
            foreach (var tk in thongKe)
            {
                tk.Veconlai = tongSoGhe - tk.Vedaban;
                tk.TyLe = (float)tk.Vedaban / tongSoGhe;
            }
            thongKe = thongKe.OrderByDescending(s => s.DoanhThu).ToList();
            for (int i = 0; i < thongKe.Count; i++)
            {
                thongKe[i].Hang = i + 1;
            }

            // Xuất ra JSON
            string json = JsonConvert.SerializeObject(thongKe, Formatting.Indented);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, json);
            }
        }
    }
}
