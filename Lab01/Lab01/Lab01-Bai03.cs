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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button_doc_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox_nhap.Text);
                switch (num)
                {
                    case 1:
                        textBox_kq.Text = "Một";
                        break;
                    case 2:
                        textBox_kq.Text = "Hai";
                        break;
                    case 3:
                        textBox_kq.Text = "Ba";
                        break;
                    case 4:
                        textBox_kq.Text = "Bốn";
                        break;
                    case 5:
                        textBox_kq.Text = "Năm";
                        break;
                    case 6:
                        textBox_kq.Text = "Sáu";
                        break;
                    case 7:
                        textBox_kq.Text = "Bảy";
                        break;
                    case 8:
                        textBox_kq.Text = "Tám";
                        break;
                    case 9:
                        textBox_kq.Text = "Chín";
                        break;
                    default:
                        MessageBox.Show("Nhập số từ 1 đến 9");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Nhập số từ 1 đến 9");
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            textBox_kq.Text = "";
            textBox_nhap.Text = "";
        }


    }
}
