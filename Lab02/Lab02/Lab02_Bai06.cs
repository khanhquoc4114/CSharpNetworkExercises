using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GetStartedWinForms;
using Microsoft.EntityFrameworkCore;

namespace Lab02
{
    public partial class Bai6 : Form
    {
        private MonAnsContext dbContext;

        public Bai6()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new MonAnsContext();

            // Uncomment the line below to start fresh with a new database.
             this.dbContext.Database.EnsureDeleted();
             this.dbContext.Database.EnsureCreated();

            this.dbContext.monan.Load(); // Load data from 'monan' table
            this.dbContext.nguoidung.Load();

            foreach (var monAn in dbContext.monan.Local)
            {
                var item = new ListViewItem(monAn.TenMonAn);
                listView1.Items.Add(item);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void button_random_Click(object sender, EventArgs e)
        {
            // Get all dishes
            var dishes = dbContext.monan.ToList();

            // Select a random dish
            var random = new Random();
            var randomDish = dishes[random.Next(dishes.Count)];

            // Get the corresponding NguoiDung
            var nguoiDung = dbContext.nguoidung.FirstOrDefault(nd => nd.IDNCC == randomDish.IDNCC);

            // Display the dish name and provider name in textBox_kq
            textBox_kq.Text = $"Món ăn: {randomDish.TenMonAn}, Người cung cấp: {nguoiDung?.HoVaTen}";

            // Display the dish image in pictureBox
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string imagePath = Path.Combine(projectDirectory, "Image", randomDish.HinhAnh);
            try
            {
                if (File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show($"File not found: {imagePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
            }
        }
    }
}