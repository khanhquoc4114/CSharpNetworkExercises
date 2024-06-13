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
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if(textBox_nhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
                return;
            }
            listBox1.Items.Add(textBox_nhap.Text);
            textBox_nhap.Text = "";
        }

        private void button_tim_Click(object sender, EventArgs e)
        {   
            if(listBox1.Items.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng");
                return;
            }
            Random rand = new Random();
            int index = rand.Next(listBox1.Items.Count);
            textBox_show.Text = listBox1.Items[index].ToString();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
