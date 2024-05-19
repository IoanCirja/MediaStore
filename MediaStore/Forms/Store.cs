using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

using System.Text.RegularExpressions;

using Image = System.Drawing.Image;
using SiteManipulation;

using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace MediaStore
{
    public partial class Store : Form
    {
        private int page;
        private HttpClient httpClient;
        private string url;
        private int pageIndex;
        private static List<Product> _productList;
        public static List<Product> _comparedList;
        private static User _currentUser;
        private static WebNavigator _webNavigator;


        public static User CurrentUser { get { return _currentUser; } }

        public Store()
        {
            InitializeComponent();

            pictureBox7.MouseDown += PictureBox_MouseDown;

            page = 0;
            pageIndex = 0;
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.71 Safari/537.36");
            _productList = new List<Product>();
            _comparedList = new List<Product>();
            url = "https://www.itgalaxy.ro/laptopuri//pagina1/";

            pictureBox7.Image = ResizeImage(Resource.profile, 60, 60);

        }
        public static void SetUser(User user)
        {
            _currentUser = user;

        }

        public void SetUserToForm()
        {
            textBox7.Text = _currentUser.Email;

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
            MessageBox.Show("page: " + page.ToString() + "pageindex: " + pageIndex.ToString());


            try
            {
                url = url.Substring(0, url.Length - 2) + pageIndex.ToString() + "/";
                MessageBox.Show(url);

                int index = (page % 6) == 0 ? 6 : page % 6;
                await LoadHTMLAsync(url, index);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            page--;
            if (page < 1) page = 1;
            pageIndex = (page - 1) / 6 + 1;
            MessageBox.Show("page: " + page.ToString() + "pageindex: " + pageIndex.ToString());


            try
            {

                url = url.Substring(0, url.Length - 2) + pageIndex.ToString() + "/";
                MessageBox.Show(url);

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
            ClearFormControls(this);
            string technical_details = "";

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
                        Image image = null;

                        try
                        {
                            byte[] imageBytes = await httpClient.GetByteArrayAsync(imageUrl);
                            if (imageBytes == null || imageBytes.Length == 0)
                            {
                                throw new Exception("Image data is empty.");
                            }

                            using (MemoryStream imageStream = new MemoryStream(imageBytes))
                            {
                                image = Image.FromStream(imageStream);
                            }

                            // Resize the image to 140x150 pixels
                            image = ResizeImage(image, 140, 150);
                        }
                        catch
                        {
                            // Load the fallback image if there's an error
                            try
                            {
                                image = Image.FromFile("notfound.jpg");

                                // Resize the fallback image to 140x150 pixels
                                image = ResizeImage(image, 140, 150);
                            }
                            catch (Exception fallbackEx)
                            {
                                MessageBox.Show($"Error loading fallback image: {fallbackEx.Message}");
                            }
                        }

                        PictureBox pictureBox = this.Controls.Find($"pictureBox{cnt}", true).FirstOrDefault() as PictureBox;
                        if (pictureBox != null)
                        {
                            pictureBox.Image = image;
                        }
                        else
                        {
                            MessageBox.Show($"PictureBox pictureBox{cnt} not found.");
                        }

                        var textElement = htmlDocument.DocumentNode.SelectSingleNode($"(//h2[@class='name'])[{startIndex + cnt}]");
                        var text = textElement?.InnerText.Trim() ?? "";

                        var description = htmlDocument.DocumentNode.SelectSingleNode($"(//ul[@class='list-unstyled'])[{startIndex + cnt}]");
                        if (description != null)
                        {
                            var listItems = description.SelectNodes(".//li");
                            if (listItems != null)
                            {
                                technical_details = "";
                                foreach (var item in listItems)
                                {
                                    var spanElement = item.SelectSingleNode(".//span");
                                    if (spanElement != null)
                                    {
                                        technical_details += spanElement.InnerText.Trim();
                                    }
                                    technical_details += "\r\n";
                                }
                            }
                        }
                        else
                        {
                            technical_details = "";
                        }

                        var priceElement = htmlDocument.DocumentNode.SelectSingleNode($"(//span[@class='fw-bold mb-3 mb-md-0 color-secondary'])[{startIndex + cnt}]");
                        var price = priceElement?.InnerText.Trim() ?? "";

                        TextBox textBox = this.Controls.Find($"name{cnt - 1}", true).FirstOrDefault() as TextBox;
                        TextBox priceBox = this.Controls.Find($"price{cnt}", true).FirstOrDefault() as TextBox;
                        TextBox detailsBox = this.Controls.Find($"textBox{cnt}", true).FirstOrDefault() as TextBox;

                        if (textBox != null)
                        {
                            textBox.Text = text;
                        }
                        else
                        {
                            MessageBox.Show($"TextBox name{cnt - 1} not found.");
                        }

                        if (priceBox != null)
                        {
                            priceBox.Text = price;
                        }
                        else
                        {
                            MessageBox.Show($"TextBox price{cnt} not found.");
                        }

                        if (detailsBox != null)
                        {
                            detailsBox.Text = technical_details;
                        }
                        else
                        {
                            MessageBox.Show($"TextBox textBox{cnt} not found.");
                        }

                        cnt++;

                        Product product = new Product(image, text, price, technical_details, Regex.Match(url, @"galaxy\.ro/([^/]+)").Groups[1].Value);
                        if (!_productList.Any(p => p.name == text))
                        {
                            // Add the new product to the list
                            _productList.Add(product);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No image nodes found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading HTML: {ex.Message}\n{ex.StackTrace}");
            }

            SetUserToForm();
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            // Create a new bitmap with the specified size and a transparent background
            var destImage = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, new Rectangle(0, 0, width, height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            // Make the white background transparent
            for (int y = 0; y < destImage.Height; y++)
            {
                for (int x = 0; x < destImage.Width; x++)
                {
                    Color pixelColor = destImage.GetPixel(x, y);
                    if (pixelColor.R > 240 && pixelColor.G > 240 && pixelColor.B > 240) // adjust the threshold as needed
                    {
                        destImage.SetPixel(x, y, Color.Transparent);
                    }
                }
            }

            return destImage;
        }





        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            httpClient.Dispose();
        }


        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

                ToolStripMenuItem addToFavoritesMenuItem = new ToolStripMenuItem("Add to Favorites");
                ToolStripMenuItem goToWebsite = new ToolStripMenuItem("Go to Website");
                ToolStripMenuItem addToCompare = new ToolStripMenuItem("Add to Compare"); //max 3

                PictureBox pictureBox = sender as PictureBox;
                string identifier = pictureBox.Name.Replace("pictureBox", "");
                int id = int.Parse(identifier); // acum avem id ul picture boxului






                addToFavoritesMenuItem.Click += (menuItemSender, menuItemEventArgs) =>
                {
                    try
                    {
                        TextBox nameBox = this.Controls.Find($"name{id - 1}", true).FirstOrDefault() as TextBox;
                        TextBox priceBox = this.Controls.Find($"textBox{id}", true).FirstOrDefault() as TextBox;
                        TextBox descriptionBox = this.Controls.Find($"price{id}", true).FirstOrDefault() as TextBox;

                        string name = nameBox.Text;
                        string price = priceBox.Text;
                        string description = descriptionBox.Text;

                        // Verifică dacă produsul există deja în baza de date
                        if (!DataAccess.IsFavorite(name, price, description, _currentUser.Email))
                        {
                            // Adaugă produsul în baza de date
                            if (DataAccess.AddFavorite(name, price, description, _currentUser.Email))
                            {
                                MessageBox.Show("Produsul a fost adăugat la favorite.");
                            }
                            else
                            {
                                MessageBox.Show("Eroare la adăugarea produsului la favorite. Vă rugăm să încercați din nou mai târziu.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Produsul există deja în lista de favorite.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                };

                goToWebsite.Click += (menuItemSender, menuItemEventArgs) =>
                {
                    TextBox nameBox = this.Controls.Find($"name{id - 1}", true).FirstOrDefault() as TextBox;

                    IWebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://www.itgalaxy.ro/");
                    driver.Manage().Window.Maximize();

                    var searchText = driver.FindElement(By.Id("search-box"));
                    searchText.SendKeys(nameBox.Text);
                    searchText.SendKeys(OpenQA.Selenium.Keys.Enter);


                };

                //adaug la comparat
                addToCompare.Click += (menuItemSender, menuItemEventArgs) =>
                {
                    TextBox nameBox = this.Controls.Find($"name{id - 1}", true).FirstOrDefault() as TextBox;

                    if (nameBox != null && nameBox.Text != null && _comparedList.Count < 3)
                    {
                        if (!_comparedList.Any(p => p.name == nameBox.Text))
                        {
                            // Add the new product to the list
                            _comparedList.Add(searchProduct(nameBox.Text));
                        }
                        else
                        {
                            MessageBox.Show("Item already added to compare!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Already have 3 elements in comaprte");
                    }




                };

                contextMenuStrip.Items.Add(addToFavoritesMenuItem);
                contextMenuStrip.Items.Add(goToWebsite);
                contextMenuStrip.Items.Add(addToCompare);


                contextMenuStrip.Show((Control)sender, e.Location);
            }
        }




        private Product searchProduct(string name)
        {
            return _productList.FirstOrDefault(p => p.name == name);



        }


        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _webNavigator = new WebNavigator();

            _webNavigator.Login(_currentUser.Email, _currentUser.Password);
        }



        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = comboBox1.SelectedItem.ToString();

            url = URLS.UrlDispenser(selectedText);

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

        private void ClearFormControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (control is PictureBox pictureBox)
                {
                    if (pictureBox != pictureBox7)
                    {
                        pictureBox.Image = null; // Clear the image
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ChooseProduct().ShowDialog();
        }




        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Crearea meniului contextual
                ContextMenuStrip contextMenu = new ContextMenuStrip();

                // Adăugarea opțiunilor în meniu
                ToolStripMenuItem favoritesMenuItem = new ToolStripMenuItem("See Favorites");
                ToolStripMenuItem websiteMenuItem = new ToolStripMenuItem("Go to Website");
                ToolStripMenuItem compareMenuItem = new ToolStripMenuItem("Compare");

                ToolStripMenuItem logoutMenuItem = new ToolStripMenuItem("Logout");
                contextMenu.Items.Add(favoritesMenuItem);
                contextMenu.Items.Add(websiteMenuItem);
                contextMenu.Items.Add(logoutMenuItem);
                contextMenu.Items.Add(compareMenuItem);


                // Asocierea evenimentelor pentru fiecare opțiune
                favoritesMenuItem.Click += (s, args) =>
                {
                    Favorites favoritesForm = new Favorites();
                    new Favorites().ShowDialog();
                };
                compareMenuItem.Click += (s, args) =>
                {
                    new CompareForm().ShowDialog();

                };
                websiteMenuItem.Click += (s, args) =>
                {
                    _webNavigator = new WebNavigator();
                    _webNavigator.Login(_currentUser.Email, _currentUser.Password);
                };
                logoutMenuItem.Click += (s, args) =>
                {
                    ClearFormControls(this);
                    _currentUser = null;
                    this.Close();
                    this.Hide();
                    new LoginForm().ShowDialog(this);

                };

                // Afișarea meniului contextual în poziția curentă a mouse-ului
                contextMenu.Show((Control)sender, e.Location);
            }
        }


    }
}
