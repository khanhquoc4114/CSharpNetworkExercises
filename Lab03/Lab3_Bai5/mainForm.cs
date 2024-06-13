using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using GetStartedWinForms;
using Lab03_Bai5;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Lab02
{
    public partial class mainForm : Form
    {
        private MonAnsContext dbContext;
        private int idncc;
        private List<MonAn> currentDishes;
        private TcpClient client;
        private CancellationTokenSource cancellationTokenSource;

        public mainForm(int idncc, TcpClient client) 
        {
            this.idncc = idncc;
            this.client = client; 
            InitializeComponent();
            this.Text = "IDNCC = " + idncc;
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
            this.cancellationTokenSource = new CancellationTokenSource();

            ListenForServerMessages();

        }
        private async Task ListenForServerMessages()
        {
            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // If the message is a reload data event
                    if (message.Contains("ReloadData"))
                    {
                        // Check if the form's handle has been created
                        if (this.IsHandleCreated)
                        {
                            // Use Invoke to update the UI on the main thread
                            this.Invoke((MethodInvoker)delegate
                            {
                                // Reload the data
                                LoadData(-1);

                                // Update the ListView
                                listView1.Items.Clear();
                                foreach (var monAn in this.currentDishes)
                                {
                                    var item = new ListViewItem(monAn.TenMonAn);
                                    listView1.Items.Add(item);
                                }
                            });
                        }
                    }

                    // Check if cancellation was requested
                    if (cancellationTokenSource.Token.IsCancellationRequested)
                    {
                        break;
                    }
                }
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            try
            {
                this.dbContext?.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}");
            }
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void button_random_Click(object sender, EventArgs e)
        {
            // Get all dishes
            var dishes = this.currentDishes; // Update this line

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
                    MessageBox.Show($"File not found: {imagePath}, hãy thêm ảnh vào thư mục Image");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
            }
        }

        //private void button_change_Click(object sender, EventArgs e)
        //{
        //    changeData changeDataForm = new changeData(this.dbContext, this.client);
        //    changeDataForm.FormClosed += (s, args) => this.Show();
        //    changeDataForm.Show();
        //    this.Hide();
        //}

        private void mainForm_Activated(object sender, EventArgs e)
        {
            LoadData(-1); // Load all data

            listView1.Items.Clear();
            foreach (var monAn in this.currentDishes) //load trong current dish
            {
                var item = new ListViewItem(monAn.TenMonAn);
                listView1.Items.Add(item);
            }
        }

        private void button_rieng_Click(object sender, EventArgs e)
        {
            LoadData(this.idncc); // Load data from the current provider

        }

        private void button_chung_Click(object sender, EventArgs e)
        {
            LoadData(-1); // Load all data
        }

        private void LoadData(int idncc)
        {
            IQueryable<MonAn> query;

            if (idncc == -1)
            {
                // Query all dishes
                query = this.dbContext.monan;
            }
            else
            {
                // Query only the dishes provided by the user with the given idncc
                query = this.dbContext.monan.Where(m => m.IDNCC == idncc);
            }

            this.currentDishes = query.ToList();

            listView1.Items.Clear();
            foreach (var monAn in this.currentDishes) //load trong current dish
            {
                var item = new ListViewItem(monAn.TenMonAn);
                listView1.Items.Add(item);
            }
        }


    }
}