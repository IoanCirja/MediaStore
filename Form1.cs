using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaStore
{
    public partial class Form1 : Form
    {
        private int page;
        private HttpClient httpClient;

        public Form1()
        {
            InitializeComponent();
            page = 1;
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.71 Safari/537.36");
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                page = 1;
                await LoadHTMLAsync("https://www.itgalaxy.ro/desktop-pc/pagina3/", page);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            page++;
            try
            {
                await LoadHTMLAsync("https://www.itgalaxy.ro/desktop-pc/pagina2/", page);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task LoadHTMLAsync(string url, int page)
        {
            try
            {
                var html = await httpClient.GetStringAsync(url);
                HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
                htmlDocument.LoadHtml(html);

                int cnt = 0;
                var imageNodes = htmlDocument.DocumentNode.SelectNodes("//img[@class='img-fluid inline-block img-animate']");
                if (imageNodes != null)
                {
                    int startIndex = (page - 1) * 6; // Calculate the starting index based on the page number

                    foreach (var imageNode in imageNodes.Skip(startIndex).Take(7))
                    {
                        var imageUrl = imageNode.GetAttributeValue("src", "");

                        var imageBytes = await httpClient.GetByteArrayAsync(imageUrl);
                        var imageStream = new MemoryStream(imageBytes);

                        // Dynamically find PictureBox control
                        PictureBox pictureBox = this.Controls.Find($"pictureBox{cnt}", true).FirstOrDefault() as PictureBox;
                        if (pictureBox != null)
                        {
                            pictureBox.Image = Image.FromStream(imageStream);
                        }

                        var textElement = htmlDocument.DocumentNode.SelectSingleNode($"(//h2[@class='name'])[{startIndex + cnt + 1}]");
                        var text = textElement?.InnerText.Trim();

                        var priceElement = htmlDocument.DocumentNode.SelectSingleNode($"(//span[@class='fw-bold mb-3 mb-md-0 color-secondary'])[{startIndex + cnt + 1}]");
                        var price = priceElement?.InnerText.Trim();

                        // Dynamically find TextBox control
                        TextBox textBox = this.Controls.Find($"name{cnt}", true).FirstOrDefault() as TextBox;
                        TextBox priceBox = this.Controls.Find($"price{cnt}", true).FirstOrDefault() as TextBox;

                        if (textBox != null)
                        {
                            textBox.Text = text ?? "No text found";
                            priceBox.Text = price ?? "No text found";
                        }
                        cnt++;
                    }

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            httpClient.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void name1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void price6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
