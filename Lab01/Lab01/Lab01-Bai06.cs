using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            DateTime selectedDate = dateTimePicker1.Value;
            string cung = timcung(selectedDate);
            textBox.Text = cung;
        }

        private string timcung(DateTime date)
        {

            int day = date.Day;
            int month = date.Month;

            if ((month == 3 && day >= 21) || (month == 4 && day <= 20))
            {
                return "Bạch Dương";
            }
            else if ((month == 4 && day >= 21) || (month == 5 && day <= 21))
            {
                return "Kim Ngưu";
            }
            else if ((month == 5 && day >= 22) || (month == 6 && day <= 21))
            {
                return "Song Tử";
            }
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
            {
                return "Cự Giải";
            }
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
            {
                return "Sư Tử";
            }
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 23))
            {
                return "Xử Nữ";
            }
            else if ((month == 9 && day >= 24) || (month == 10 && day <= 23))
            {
                return "Thiên Bình";
            }
            else if ((month == 10 && day >= 24) || (month == 11 && day <= 22))
            {
                return "Thần Nông";
            }
            else if ((month == 11 && day >= 23) || (month == 12 && day <= 21))
            {
                return "Nhân Mã";
            }
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 20))
            {
                return "Ma Kết";
            }
            else if ((month == 1 && day >= 21) || (month == 2 && day <= 19))
            {
                return "Bảo Bình";
            }
            else if ((month == 2 && day >= 20) || (month == 3 && day <= 20))
            {
                return "Song Ngư";
            }
            else
            {
                return "Invalid date";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Bai6_Load(object sender, EventArgs e)
        {

        }
    }
}
