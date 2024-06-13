using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Lab4_Bai4
{
    public partial class Lab4_Bai4 : Form
    {
        public class Movie
        {
            public string Title { get; set; }
            public string DetailUrl { get; set; }
            public string ImageUrl { get; set; }
        }

        private List<Movie> movies = new List<Movie>();

        public Lab4_Bai4()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            progressBarLoading.Visible = true;
            await LoadMoviesAsync();
        }

        private async Task LoadMoviesAsync()
        {
            movies = await GetMoviesAsync("https://betacinemas.vn/phim.htm");
            SaveMoviesToJson(movies, "movies.json");
            PopulateFlowLayoutPanel(movies);
        }

        private async Task<List<Movie>> GetMoviesAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(response);

                var movieNodes = doc.DocumentNode.SelectNodes("//div[@class='row']/div[contains(@class, 'col-lg-4')]");
                if (movieNodes != null)
                {
                    progressBarLoading.Maximum = movieNodes.Count;

                    foreach (var node in movieNodes)
                    {
                        var titleNode = node.SelectSingleNode(".//h3/a");
                        var imageNode = node.SelectSingleNode(".//img");

                        if (titleNode != null && imageNode != null)
                        {
                            var movie = new Movie
                            {
                                Title = titleNode.InnerText.Trim(),
                                DetailUrl = "https://betacinemas.vn" + titleNode.Attributes["href"].Value,
                                ImageUrl = imageNode.Attributes["src"].Value
                            };
                            movies.Add(movie);
                        }
                        progressBarLoading.PerformStep();
                    }
                }
                return movies;
            }
        }

        private void SaveMoviesToJson(List<Movie> movies, string filePath)
        {
            var json = JsonConvert.SerializeObject(movies, formatting: Formatting.Indented);
            System.IO.File.WriteAllText(filePath, json);
        }

        private async void PopulateFlowLayoutPanel(List<Movie> movies)
        {
            flowLayoutPanelMovies.Controls.Clear();
            flowLayoutPanelMovies.AutoScroll = true;
            flowLayoutPanelMovies.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelMovies.WrapContents = false;

            foreach (var movie in movies)
            {
                var moviePanel = new Panel
                {
                    Width = flowLayoutPanelMovies.Width,
                    Height = 150,
                    Margin = new Padding(4),
                    BorderStyle = BorderStyle.FixedSingle
                };

                var pictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 100,
                    Height = 150,
                    Image = await LoadImageAsync(movie.ImageUrl)
                };

                var label = new Label
                {
                    Text = movie.Title,
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = false,
                    Height = 150,
                    Width = moviePanel.Width - pictureBox.Width - 20,
                    Location = new Point(pictureBox.Width + 10, 0),
                    Padding = new Padding(10, 0, 0, 0),
                    Font = new Font("Segoe UI", 12, FontStyle.Bold)
                };

                moviePanel.Controls.Add(pictureBox);
                moviePanel.Controls.Add(label);
                moviePanel.Tag = movie.DetailUrl;

                moviePanel.Cursor = Cursors.Hand;

                moviePanel.Click += MoviePanel_Click;
                pictureBox.Click += (s, e) => MoviePanel_Click(moviePanel, e);
                label.Click += (s, e) => MoviePanel_Click(moviePanel, e);

                flowLayoutPanelMovies.Controls.Add(moviePanel);
            }
        }


        private async Task<Image> LoadImageAsync(string imageUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(imageUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            return Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error loading image: {ex.Message}");
                }
                return null;
            }
        }


        private void MoviePanel_Click(object sender, EventArgs e)
        {
            if (sender is Panel panel && panel.Tag is string url)
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to open link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
