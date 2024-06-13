using System;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Bai3_1 : Form
    {
        public Bai3_1()
        {
            InitializeComponent();
        }

        private string doc12chuso(long num)
        {
            num = Math.Abs(num);
            string[] dv = { "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hangchuc = { "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

            string str = num.ToString().PadLeft(12, '0');
            string[] parts = new string[4];
            for (int i = 0; i < 4; i++)
            {
                parts[i] = str.Substring(i * 3, 3);
            }

            string result = "";
            string[] labels = { " tỷ ", " triệu ", " nghìn ", "" };
            for (int i = 0; i < 4; i++)
            {
                char[] arr = parts[i].ToCharArray();
                string partResult = "";

                for (int j = 0; j < 3; j++)
                {
                    if (arr[j] != '0')
                    {
                        if (j == 0) partResult += dv[int.Parse(arr[j].ToString()) - 1] + " trăm ";
                        else if (j == 1)
                        {
                            partResult += hangchuc[int.Parse(arr[j].ToString()) - 1] + " ";
                        }
                        else if (j == 2)
                        {
                            if (arr[j] == '1' && arr[j - 1] != '0' && arr[j - 1] != '1') partResult += "mốt";
                            else if (arr[j] == '5' && arr[j - 1] != '0') partResult += "lăm";
                            else partResult += dv[int.Parse(arr[j].ToString()) - 1];
                        }
                    }
                    else
                    {
                        if (i == 1 && num > 1000000000 && j == 0 && (arr[j + 1] != '0' || arr[j + 2] != '0')) partResult += "không trăm ";
                        if (i == 2 && num > 1000000 && j == 0 && (arr[j + 1] != '0' || arr[j + 2] != '0')) partResult += "không trăm ";
                        if (i == 3 && num > 1000 && j == 0 && (arr[j + 1] != '0' || arr[j + 2] != '0')) partResult += "không trăm ";

                        if (i == 1 && num > 1000000000 && j == 1 && arr[j] == '0' && arr[j + 1] != '0') partResult += "lẻ ";
                        if (i == 2 && num > 1000000 && j == 1 && arr[j] == '0' && arr[j + 1] != '0') partResult += "lẻ ";
                        if (i == 3 && num > 1000 && j == 1 && arr[j] == '0' && arr[j + 1] != '0') partResult += "lẻ ";
                        if (j == 1 && arr[j] == '0' && arr[j + 1] != '0' && arr[j - 1] != '0') partResult += "lẻ ";
                    }
                }

                if (!string.IsNullOrEmpty(partResult))
                {
                    result += partResult + labels[i];
                }
            }

            return result;
        }

        private void button_doc_Click(object sender, EventArgs e)
        {
            try
            {
                long num = long.Parse(textBox_nhap.Text);
                if (Math.Abs(num).ToString().Length > 12)
                {
                    MessageBox.Show("Nhập số nguyên có 12 chữ số trở xuống");
                }

                else if (num == 0)
                {
                    textBox_kq.Text = "Không";
                }
                else
                {
                    string result = num < 0 ? "âm " : "";
                    result += doc12chuso(Math.Abs(num));
                    textBox_kq.Text = result;
                }
            }
            catch
            {
                MessageBox.Show("Nhập số nguyên có 12 chữ số trở xuống");
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            textBox_kq.Text = "";
            textBox_nhap.Text = "";
        }
    }
}