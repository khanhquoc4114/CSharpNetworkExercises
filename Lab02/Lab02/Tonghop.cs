using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Tonghop : Form
    {
        public Tonghop()
        {
            InitializeComponent();
            foreach (Control control in splitContainer1.Panel2.Controls)
            {
                originalControls.Add(control);
            }
        }

        List<Control> originalControls = new List<Control>();

        private void button_thoat_Click(object sender, EventArgs e)
        {

            splitContainer1.Panel2.Controls.Clear();

            foreach (Control control in originalControls)
            {
                splitContainer1.Panel2.Controls.Add(control);
            }

        }
        private void button_Bai1_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các controls hiện tại
            splitContainer1.Panel2.Controls.Clear();

            // Hiển thị Bai1
            Bai1 bai1 = new Bai1();
            bai1.TopLevel = false;
            bai1.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai1);
            bai1.Dock = DockStyle.Fill;
            bai1.Show();
        }


        private void button_Bai2_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các controls hiện tại
            splitContainer1.Panel2.Controls.Clear();

            // Hiển thị Bai1
            Bai2 bai2 = new Bai2();
            bai2.TopLevel = false;
            bai2.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai2);
            bai2.Dock = DockStyle.Fill;
            bai2.Show();
        }

        private void button_Bai3_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các controls hiện tại
            splitContainer1.Panel2.Controls.Clear();

            // Hiển thị Bai3
            Bai3 bai3 = new Bai3();
            bai3.TopLevel = false;
            bai3.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai3);
            bai3.Dock = DockStyle.Fill;
            bai3.Show();
        }

        private void button_Bai4_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các controls hiện tại
            splitContainer1.Panel2.Controls.Clear();

            // Hiển thị Bai4
            Bai4 bai4 = new Bai4();
            bai4.TopLevel = false;
            bai4.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai4);
            bai4.Dock = DockStyle.Fill;
            bai4.Show();
        }

        private void button_Bai5_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các controls hiện tại
            splitContainer1.Panel2.Controls.Clear();

            // Hiển thị Bai5
            Bai5 bai5 = new Bai5();
            bai5.TopLevel = false;
            bai5.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai5);
            bai5.Dock = DockStyle.Fill;
            bai5.Show();
        }

        private void button_Bai6_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các controls hiện tại
            splitContainer1.Panel2.Controls.Clear();

            // Hiển thị Bai6
            Bai6 bai6 = new Bai6();
            bai6.TopLevel = false;
            bai6.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai6);
            bai6.Dock = DockStyle.Fill;
            bai6.Show();
        }


        private void button_Bai7_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các controls hiện tại
            splitContainer1.Panel2.Controls.Clear();

            // Hiển thị Bai7
            Bai7 bai7 = new Bai7();
            bai7.TopLevel = false;
            bai7.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai7);
            bai7.Dock = DockStyle.Fill;
            bai7.Show();
        }
    }
}
