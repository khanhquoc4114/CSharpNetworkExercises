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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void songuyen1_TextChanged(object sender, EventArgs e)
        {

        }

        private void songuyen2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_tinh_Click(object sender, EventArgs e)
        {
            int num1, num2;

            // Kiểm tra xem songuyen1 và songuyen2 có phải là số nguyên không
            bool isNum1 = int.TryParse(textBox_songuyen1.Text, out num1);
            bool isNum2 = int.TryParse(textBox_songuyen2.Text, out num2);

            if (!isNum1 || !isNum2)
            {
                // Nếu một trong hai không phải là số nguyên, hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ vào cả hai ô.", "Lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Nếu cả hai đều là số nguyên, tính tổng và hiển thị kết quả
                int sum = num1 + num2;
                textBox_ketqua.Text = sum.ToString();
            }
        }
    }
}
