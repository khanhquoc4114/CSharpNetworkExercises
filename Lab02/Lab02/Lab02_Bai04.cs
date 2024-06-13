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


    public partial class Bai4 : Form
    {
        public class Student
        {
            public string Name { get; set; }
            public int StudentId { get; set; }
            public string PhoneNumber { get; set; }
            public float Score1 { get; set; }
            public float Score2 { get; set; }
            public float Score3 { get; set; }
            public float AverageScore { get; set; }
        }

        private List<Student> lstudent = new List<Student>();
        public Bai4()
        {
            InitializeComponent();
        }

        private void AddStudent(string name, string id, string phone, float score1, float score2, float score3)
        {
            Student student = new Student
            {
                Name = name,
                StudentId = int.Parse(id),
                PhoneNumber = phone,
                Score1 = score1,
                Score2 = score2,
                Score3 = score3,
                AverageScore = (score1 + score2 + score3) / 3
            };
            lstudent.Add(student);
        }
        private void button_add_Click(object sender, EventArgs e)
        {

            string name = textBox_name.Text;
            string id = textBox_id.Text;
            string phone = textBox_phone.Text;
            string score1Text = textBox_c1.Text;
            string score2Text = textBox_c2.Text;
            string score3Text = textBox_c3.Text;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(score1Text) ||
                string.IsNullOrWhiteSpace(score2Text) ||
                string.IsNullOrWhiteSpace(score3Text))
            {
                MessageBox.Show("Cac o khong duoc bo trong. Vui long kiem tra lai.");
                return;
            }

            float score1, score2, score3;

            try
            {
                score1 = float.Parse(score1Text);
                score2 = float.Parse(score2Text);
                score3 = float.Parse(score3Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Diem phai la so. Vui long kiem tra lai.");
                return;
            }


            if (id.Length != 8 || !id.All(Char.IsDigit))
            {
                MessageBox.Show("Ma so sinh vien phai dai 8 don vi va chi chua so");
                return;
            }

            if (phone.Length != 10 || phone[0] != '0' || !phone.All(Char.IsDigit))
            {
                MessageBox.Show("So dien thoai phai bat dau bang so 0 va co 10 chu so.");
                return;
            }

            if (score1 < 0 || score1 > 10 || score2 < 0 || score2 > 10 || score3 < 0 || score3 > 10)
            {
                MessageBox.Show("Diem so phai >= 0 va <= 10");
                return;
            }

            // Add the student information to richTextBox_show
            richTextBox_show.AppendText(name + "\n");
            richTextBox_show.AppendText(id + "\n");
            richTextBox_show.AppendText(phone + "\n");
            richTextBox_show.AppendText(score1 + "\n");
            richTextBox_show.AppendText(score2 + "\n");
            richTextBox_show.AppendText(score3 + "\n");
            richTextBox_show.AppendText("\n\n");

            textBox_name.Clear();
            textBox_id.Clear();
            textBox_phone.Clear();
            textBox_c1.Clear();
            textBox_c2.Clear();
            textBox_c3.Clear();
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "text.txt|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.Append))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(richTextBox_show.Text);
                }
            }
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "text|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string name, id, phone;
                        float score1, score2, score3;
                        while ((name = sr.ReadLine()) != null)
                        {
                            id = sr.ReadLine();
                            phone = sr.ReadLine();
                            score1 = float.Parse(sr.ReadLine());
                            score2 = float.Parse(sr.ReadLine());
                            score3 = float.Parse(sr.ReadLine());

                            AddStudent(name, id, phone, score1, score2, score3);

                            richTextBox_show.AppendText(name + "\n");
                            richTextBox_show.AppendText(id + "\n");
                            richTextBox_show.AppendText(phone + "\n");
                            richTextBox_show.AppendText(score1 + "\n");
                            richTextBox_show.AppendText(score2 + "\n");
                            richTextBox_show.AppendText(score3 + "\n");
                            richTextBox_show.AppendText(lstudent.Last().AverageScore.ToString());
                            richTextBox_show.AppendText("\n\n");

                            // Skip the empty line between students
                            sr.ReadLine();
                            sr.ReadLine();
                        }
                        if (lstudent.Count > 0)
                        {
                            DisplayStudent(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private int currentStudentIndex = 0;

        private void button_back_Click(object sender, EventArgs e)
        {
            // Đảm bảo rằng chúng ta không đi quá xa về phía sau
            if (currentStudentIndex > 0)
            {
                currentStudentIndex--;
                DisplayStudent(currentStudentIndex);
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            // Đảm bảo rằng chúng ta không đi quá xa về phía trước
            if (currentStudentIndex < lstudent.Count - 1)
            {
                currentStudentIndex++;
                DisplayStudent(currentStudentIndex);
            }
        }

        // Hàm để hiển thị thông tin của một sinh viên dựa trên chỉ mục
        private void DisplayStudent(int index)
        {
            if (index >= 0 && index < lstudent.Count)
            {
                Student student = lstudent[index];
                textBox_showid.Text = student.StudentId.ToString();
                textBox_showphone.Text = student.PhoneNumber;
                // Cập nhật các hộp văn bản khác tương tự
                textBox_showname.Text = student.Name;
                textBox_showc1.Text = student.Score1.ToString();
                textBox_showc2.Text = student.Score2.ToString();
                textBox_showc3.Text = student.Score3.ToString();
                textBox_showaverage.Text = student.AverageScore.ToString();
                label_index.Text = (index + 1).ToString();
            }
        }
    }
}
