using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Bai4 : Form
    {
        private List<CheckBox> room1Seats = new List<CheckBox>();
        private List<CheckBox> room2Seats = new List<CheckBox>();
        private List<CheckBox> room3Seats = new List<CheckBox>();

        private DataTable dt = new DataTable();

        private bool seatSelected = false;

        public Bai4()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
            dt.Columns.Add("Phim", typeof(string));
            dt.Columns.Add("Rạp", typeof(string));
            dt.Columns.Add("Ghế", typeof(string));
            dt.Columns.Add("Giá", typeof(int));

            dataGridView1.Columns["Phim"].Width = 150;
            dataGridView1.Columns["Rạp"].Width = 50;
            dataGridView1.Columns["Ghế"].Width = 50;
            dataGridView1.Columns["Giá"].Width = 70;

            room1Seats = CreateRoomSeats(3, 5);
            room2Seats = CreateRoomSeats(3, 5);
            room3Seats = CreateRoomSeats(3, 5);
        }

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

        Dictionary<string, List<int>> movies = new Dictionary<string, List<int>>
            {
                { "Đào, phở và piano", new List<int> { 1, 2, 3 } },
                { "Mai", new List<int> { 2, 3 } },
                { "Gặp lại chị bầu", new List<int> { 1 } },
                { "Tarot", new List<int> { 3 } }
            };

        private void comboBox_phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seatSelected)
            {
                MessageBox.Show("Bạn đã chọn ghế xin không thể đổi phim.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_phim.SelectedIndex = comboBox_phim.Items.IndexOf(dt.Rows[0]["Phim"]);
                return;
            }

            string selectedMovie = comboBox_phim.SelectedItem.ToString();
            comboBox_rap.Items.Clear();
            foreach (int room in movies[selectedMovie])
            {
                comboBox_rap.Items.Add("Rạp " + room);
            }
        }
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
            List<CheckBox> selectedRoomSeats = selectedRoom == 1 ? room1Seats :
                                               selectedRoom == 2 ? room2Seats :
                                               room3Seats;
            foreach (CheckBox seat in selectedRoomSeats)
            {
                groupBox1.Controls.Add(seat);
            }
        }

        Dictionary<string, int> giaphim = new Dictionary<string, int>
            {
                { "Đào, phở và piano", 45000 },
                { "Mai", 100000 },
                { "Gặp lại chị bầu", 70000 },
                { "Tarot", 90000 }
            };
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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tên: {ten}");

            DataRow totalRow = dt.AsEnumerable().FirstOrDefault(row => row.Field<string>("Phim") == "Tổng");
            if (totalRow != null)
            {
                sb.AppendLine($"Tổng: {totalRow["Giá"]}");
            }

            MessageBox.Show(sb.ToString(), "Thông tin thanh toán");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
