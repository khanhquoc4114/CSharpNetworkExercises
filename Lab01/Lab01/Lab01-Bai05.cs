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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttontinh_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Hãy chọn phép tính");
                    return;
                }

                int A, B;
                if (!int.TryParse(textBox_nhapa.Text, out A) || !int.TryParse(textBox_nhapb.Text, out B))
                {
                    MessageBox.Show("Hãy nhập A B số nguyên");
                    return;
                }

                StringBuilder result = new StringBuilder();

                if (comboBox1.SelectedItem.ToString() == "Bảng cửu chương")
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        int value = (B - A) * i;
                        result.AppendLine($"{(B - A)} x {i} = {value}");
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "Tính toán giá trị")
                {
                    int sum1 = 1, sum2 = 0;
                    if(A < B)
                    {
                        result.AppendLine($"Số âm không có giao thừa");
                    }
                    else { 
                        for (int i = 1; i <= (A - B); i++)
                        {
                            sum1 *= i;
                        }
                    result.AppendLine($"{(A - B)}! = {sum1}");
                        }
                    for (int i = 1; i <= B; i++)
                    {
                        int value = (int)Math.Pow(A, i);
                        sum2 += value;
                    }

                    result.AppendLine($"S = {sum2}");
                }

                richTextBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            textBox_nhapa.Text = "";
            textBox_nhapb.Text = "";
            richTextBox1.Text = "";
        }
    }
}
