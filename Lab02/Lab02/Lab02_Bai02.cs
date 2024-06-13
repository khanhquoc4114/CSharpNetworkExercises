using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            richTextBox_kq.Clear();
            textBox_filename.Clear();
            textBox_size.Clear();
            textBox_url.Clear();
            textBox_linecount.Clear();
            textBox_wordcount.Clear();
            textBox_charactercount.Clear();
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt";
            if(ofd.ShowDialog() == DialogResult.OK)
            {   //name
                textBox_filename.Text = ofd.SafeFileName;
                //url
                textBox_url.Text = ofd.FileName;
                //size
                FileInfo fi = new FileInfo(ofd.FileName);
                textBox_size.Text = fi.Length.ToString();
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        richTextBox_kq.Text = sr.ReadToEnd();
                    }
                    //linecount
                    int lineCount = richTextBox_kq.Lines.Length;
                    textBox_linecount.Text = lineCount.ToString();

                    //wordcount
                    //chữ phải gồm các kí tự ghép lại
                    //hàm regax này tìm các từ mà ở trong từ đó không có kí tự khoảng cách (\b là biên giới của từ, \s là khoảng trắng)
                    int wordcount = Regex.Matches(richTextBox_kq.Text, @"\b\S+\b").Count;
                    textBox_wordcount.Text = wordcount.ToString();

                    //charactercount
                    // kí tự là các kí hiệu đã được thống nhất
                    int charactercount = richTextBox_kq.Text.Count(c => !Char.IsWhiteSpace(c));
                    textBox_charactercount.Text = charactercount.ToString();
                }

            }
        }
    }
}
