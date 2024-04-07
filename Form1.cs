using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace MediaStore
{
    public partial class Form1 : Form
    {
        private int page;
        private HttpClient httpClient;
        private string url;
        private int pageIndex;

        public Form1()
        {
            InitializeComponent();
            page = 0;
            pageIndex = 0;
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.71 Safari/537.36");
            url = "https://www.itgalaxy.ro/laptopuri/pagina1/";
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                page = 1;
                await LoadHTMLAsync(url, page);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            page++;
            pageIndex = (page - 1) / 6 + 1;


            try
            {
                url = "https://www.itgalaxy.ro/laptopuri/pagina" + pageIndex.ToString() + "/";
                int index = (page % 6) == 0 ? 6 : page % 6;
                await LoadHTMLAsync(url, index);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async  void button2_Click(object sender, EventArgs e)
        {
            page--;
            pageIndex = (page - 1) / 6 + 1;


            try
            {

                url = "https://www.itgalaxy.ro/laptopuri/pagina" + pageIndex.ToString() + "/";
                int index = (page % 6) == 0 ? 6 : page % 6;
                await LoadHTMLAsync(url, index);

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

                int cnt = 1;
                var imageNodes = htmlDocument.DocumentNode.SelectNodes("//img[@class='img-fluid inline-block img-animate']");
                if (imageNodes != null)
                {
                    int startIndex = (page - 1) * 6; // Calculate the starting index based on the page number

                    foreach (var imageNode in imageNodes.Skip(startIndex).Take(6))
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

                        var textElement = htmlDocument.DocumentNode.SelectSingleNode($"(//h2[@class='name'])[{startIndex + cnt}]");
                        var text = textElement?.InnerText.Trim();

                        var priceElement = htmlDocument.DocumentNode.SelectSingleNode($"(//span[@class='fw-bold mb-3 mb-md-0 color-secondary'])[{startIndex + cnt}]");
                        var price = priceElement?.InnerText.Trim();

                        // Dynamically find TextBox control
                        TextBox textBox = this.Controls.Find($"name{cnt -1}", true).FirstOrDefault() as TextBox;
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
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

                ToolStripMenuItem addToFavoritesMenuItem = new ToolStripMenuItem("Add to Favorites");
                ToolStripMenuItem goToWebsite = new ToolStripMenuItem("Go to Website");

                PictureBox pictureBox = sender as PictureBox;
                string identifier = pictureBox.Name.Replace("pictureBox", "");
                int id = int.Parse(identifier); // acum avem id ul picture boxului






                addToFavoritesMenuItem.Click += (menuItemSender, menuItemEventArgs) =>
                {
                    MessageBox.Show("Added to favorites!");
                };

                goToWebsite.Click += (menuItemSender, menuItemEventArgs) =>
                {
                    //TextBox nameBox = this.Controls.Find($"name{id -1}", true).FirstOrDefault() as TextBox;
                    //string company = nameBox.Text.Split(' ')[1];

                    //string removedCompany = nameBox.Text.Replace("Laptop " + company + " ", "");
                    //removedCompany = removedCompany.Replace(" ", "-");
                    
                    //string url = "https://www.itgalaxy.ro/laptopuri/" + company + "/" + removedCompany;
                    //url = url.ToLower();
                    //MessageBox.Show(url);
                    //System.Diagnostics.Process.Start("cmd", $"/c start \"\" \"{url}\"");
                };

                contextMenuStrip.Items.Add(addToFavoritesMenuItem);
                contextMenuStrip.Items.Add(goToWebsite);


                contextMenuStrip.Show((Control)sender, e.Location);
            }
        }



    }
}
