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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button_tim_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;

            if (double.TryParse(textBox_sothunhat.Text, out num1) &&
                double.TryParse(textBox_sothuhai.Text, out num2) &&
                double.TryParse(textBox_sothuba.Text, out num3))
            {
                // Các giá trị nhập vào đều là số thực. Tìm số lớn nhất và nhỏ nhất.
                double maxNum = Math.Max(num1, Math.Max(num2, num3));
                double minNum = Math.Min(num1, Math.Min(num2, num3));

                // Hiển thị số lớn nhất và nhỏ nhất
                textbox_solonnhat.Text = maxNum.ToString();
                textBox_sonhonhat.Text = minNum.ToString();
            }
            else
            {
                // Một hoặc nhiều giá trị nhập vào không phải là số thực.
                MessageBox.Show("Vui lòng nhập vào số thực.");
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            textBox_sothunhat.Text = "";
            textBox_sothuhai.Text = "";
            textBox_sothuba.Text = "";
            textbox_solonnhat.Text = "";
            textBox_sonhonhat.Text = "";
        }

        private void buton_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
