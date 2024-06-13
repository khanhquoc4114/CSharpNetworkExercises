using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void buttonxet_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string[] parts = input.Split(',');

            if (parts.Length < 2 || !parts[0].Where(c => !char.IsWhiteSpace(c)).All(char.IsLetter))
            {
                MessageBox.Show("Sai format");
                return;
            }

            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dt.Columns.Add("Môn", typeof(string));
            dt.Columns.Add("Điểm", typeof(double));
            double[] scores = new double[parts.Length - 1];

            for (int i = 1; i < parts.Length; i++)
            {
                //kiểm tra part[i] có phải là số hay không nếu có thì gán vào score[i-1]
                if (!double.TryParse(parts[i].Trim(), out scores[i - 1]))
                {
                    MessageBox.Show("Sai format");
                    return;
                }
                dt.Rows.Add($"Môn {i}", scores[i - 1]);
            }

            string name = parts[0].Trim();
            textBox_ten.Text = name;
            double average = scores.Average();
            dt.Rows.Add("Trung bình", average);
            dt.Rows.Add("Điểm cao nhất", scores.Max());
            dt.Rows.Add("Điểm thấp nhất", scores.Min());
            dt.Rows.Add("Số môn đậu", scores.Count(s => s >= 5));
            dt.Rows.Add("Số môn rớt", scores.Length - scores.Count(s => s >= 5));

            string classification;
            if (average >= 8 && scores.All(s => s >= 6.5))
                classification = "Giỏi";
            else if (average >= 6.5 && scores.All(s => s >= 5))
                classification = "Khá";
            else if (average >= 5 && scores.All(s => s >= 3.5))
                classification = "TB";
            else if (average >= 3.5 && scores.All(s => s >= 2))
                classification = "Yếu";
            else
                classification = "Kém";

            textBox_class.Text = classification;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
