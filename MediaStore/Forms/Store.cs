using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Text.RegularExpressions;
using Image = System.Drawing.Image;
using SiteManipulation;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Diagnostics;
using ExportLibrary;

namespace MediaStore
{
    public partial class Store : Form
    {
        /// <summary>
        /// Porțiunea curentă din pagina de pe site.
        /// </summary>
        private int _page;

        /// <summary>
        /// Client HTTP.
        /// </summary>
        private HttpClient _httpClient;

        /// <summary>
        /// Link-ul curent.
        /// </summary>
        private string _url;

        /// <summary>
        /// Pagină corespunzătoare de pe site a linkului curent (pagina1, pagina2, etc.).
        /// </summary>
        private int _pageIndex;

        /// <summary>
        /// Produse extrase.
        /// </summary>
        private static List<Product> _productList;

        /// <summary>
        /// Produse ce vor fi comparate.
        /// </summary>
        public static List<Product> _comparedList;

        /// <summary>
        /// Utilizatorul curent.
        /// </summary>
        private static User _currentUser;

        /// <summary>
        /// Navigatorul web.
        /// </summary>
        private static WebNavigator _webNavigator;

        /// <summary>
        /// Lista de produse valabile de pe site cu linkuri aferente.
        /// </summary>
        private Dictionary<string, string> _searchMappings;

        /// <summary>
        /// Indexul paginii curente.
        /// </summary>
        private static int _currentPage;

        /// <summary>
        /// Obține utilizatorul curent.
        /// </summary>
        public static User CurrentUser { get { return _currentUser; } }

        /// <summary>
        /// Constructorul clasei Store, ce face câteva modificări la nivel de interfață și configurează setările pentru scraping.
        /// Metoda inițializează componentele UI, setează evenimentele, și pregătește variabilele necesare pentru extragerea datelor de pe site.
        /// </summary>
        public Store()
        {
            // Inițializări
            InitializeComponent();

            pictureBox7.MouseDown += PictureBox_MouseDown;
            this.FormClosing += Closing;
            _searchMappings = URLS._websiteProducts;

            _page = 0;
            _pageIndex = 0;
            _currentPage = 1;
            label1.Text = 1.ToString();

            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.71 Safari/537.36");
            _productList = new List<Product>();
            _comparedList = new List<Product>();

            // Linkul de start
            _url = "https://www.itgalaxy.ro/laptopuri//pagina1/";

            pictureBox7.Image = ResizeImage(Resource.profile, 60, 60);
            searchResultsListBox.Visible = false;
        }

        /// <summary>
        /// Metoda ce setează utilizatorul curent.
        /// Aceasta actualizează obiectul static _currentUser cu noul utilizator specificat ca parametru.
        /// </summary>
        /// <param name="user">Utilizatorul ce urmează a fi setat.</param>
        public static void SetUser(User user)
        {
            _currentUser = user;
        }

        /// <summary>
        /// Metoda ce actualizează pe form utilizatorul curent.
        /// </summary>
        public void SetUserToForm()
        {
            textBox7.Text = _currentUser.Email;
        }

        /// <summary>
        /// Metoda ce încarcă primul set de produse extrase la pornirea aplicației.
        /// Aceasta inițializează pagina și încearcă să încarce HTML-ul paginii curente, gestionând eventualele erori.
        /// </summary>
        /// <param name="sender">Obiectul care declanșează evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _page = 1;
                await LoadHTMLAsync(_url, _page, true); // Obținem produsele
                _currentPage = 1;
                label1.Text = _currentPage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Metoda ce permite navigarea printre produsele de pe site din același URL corespunzător butonului "Next".
        /// Această metodă crește indexul paginii și actualizează URL-ul pentru a încărca următoarea pagină de produse.
        /// </summary>
        /// <param name="sender">Obiectul care declanșează evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            _page++;
            _pageIndex = (_page - 1) / 6 + 1; // Calculăm cele 6 produse de pe site pe care le extragem în pagina aplicației curente din totalul de 36/pagina

            try
            {
                _url = _url.Substring(0, _url.Length - 2) + _pageIndex.ToString() + "/"; // Actualizăm URL-ul cu pagina de pe site corectă

                int index = (_page % 6) == 0 ? 6 : _page % 6;
                await LoadHTMLAsync(_url, index, true); // Încărcăm HTML-ul paginii
                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Metoda ce permite navigarea printre produsele de pe site din același URL corespunzător butonului "Prev".
        /// Această metodă scade indexul paginii și actualizează URL-ul pentru a încărca pagina anterioară de produse.
        /// </summary>
        /// <param name="sender">Obiectul care declanșează evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            _page--;
            if (_page < 1) _page = 1;
            _pageIndex = (_page - 1) / 6 + 1; // Calculăm cele 6 produse de pe site pe care le extragem în pagina aplicației curente din totalul de 36/pagina

            try
            {
                _url = _url.Substring(0, _url.Length - 2) + _pageIndex.ToString() + "/"; // Actualizăm URL-ul cu pagina de pe site corectă

                int index = (_page % 6) == 0 ? 6 : _page % 6;
                await LoadHTMLAsync(_url, index, false); // Încărcăm HTML-ul paginii
                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //metoda ce extrage produse de pe site prin manipularea DOMULui oferit de site si extragerea selectorilor de tip xpath aferenti datelor dorite
        private async Task LoadHTMLAsync(string url, int page, bool next)
        {
            searchResultsListBox.Visible = false;


            ClearFormControls(this);
            string technical_details = "";

            try
            {
                var html = await _httpClient.GetStringAsync(url);
                HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
                htmlDocument.LoadHtml(html);

                int cnt = 1;
                var imageNodes = htmlDocument.DocumentNode.SelectNodes("//img[@class='img-fluid inline-block img-animate']");
                if (imageNodes != null)
                {
                    int startIndex = (page - 1) * 6; // Calculate the starting index based on the _page number

                    foreach (var imageNode in imageNodes.Skip(startIndex).Take(6))
                    {
                        var imageUrl = imageNode.GetAttributeValue("src", "");
                        Image image = null;

                        try
                        {
                            byte[] imageBytes = await _httpClient.GetByteArrayAsync(imageUrl);
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

                        PictureBox? pictureBox = this.Controls.Find($"pictureBox{cnt}", true).FirstOrDefault() as PictureBox;
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

                        TextBox? textBox = this.Controls.Find($"name{cnt - 1}", true).FirstOrDefault() as TextBox;
                        TextBox? priceBox = this.Controls.Find($"price{cnt}", true).FirstOrDefault() as TextBox;
                        TextBox? detailsBox = this.Controls.Find($"textBox{cnt}", true).FirstOrDefault() as TextBox;

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


            if (next)
            {
                _currentPage++;
            }
            else
            {
                if (_currentPage <= 1)
                {
                    _currentPage = 1;
                }
                else
                {
                    _currentPage--;
                }
            }
            label1.Text = _currentPage.ToString();

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
            _httpClient.Dispose();
        }


        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

                ToolStripMenuItem addToFavoritesMenuItem = new ToolStripMenuItem("Add to Favorites");
                ToolStripMenuItem removeFromFavoritesMenuItem = new ToolStripMenuItem("Remove from Favorites");
                ToolStripMenuItem goToWebsite = new ToolStripMenuItem("Go to Website");
                ToolStripMenuItem addToCompare = new ToolStripMenuItem("Add to Compare"); //max 3
                ToolStripMenuItem shareToWhapp = new ToolStripMenuItem("Share to Whatsapp");


                PictureBox pictureBox = sender as PictureBox;
                string identifier = pictureBox.Name.Replace("pictureBox", "");
                int id = int.Parse(identifier); // acum avem id ul picture boxului


                addToFavoritesMenuItem.Click += (menuItemSender, menuItemEventArgs) =>
                {
                    try
                    {
                        TextBox? nameBox = this.Controls.Find($"name{id - 1}", true).FirstOrDefault() as TextBox;
                        TextBox? priceBox = this.Controls.Find($"price{id}", true).FirstOrDefault() as TextBox;
                        TextBox? descriptionBox = this.Controls.Find($"TextBox{id}", true).FirstOrDefault() as TextBox;

                        string? name = nameBox.Text;
                        string? price = priceBox.Text;
                        string? description = descriptionBox.Text;

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

                removeFromFavoritesMenuItem.Click += (menuItemSender, menuItemEventArgs) =>
                {
                    try
                    {
                        TextBox? nameBox = this.Controls.Find($"name{id - 1}", true).FirstOrDefault() as TextBox;
                        TextBox? priceBox = this.Controls.Find($"price{id}", true).FirstOrDefault() as TextBox;
                        TextBox? descriptionBox = this.Controls.Find($"textBox{id}", true).FirstOrDefault() as TextBox;

                        string? name = nameBox.Text;
                        string? price = priceBox.Text;
                        string? description = descriptionBox.Text;

                        // Verifică dacă produsul există deja în baza de date
                        if (DataAccess.IsFavorite(name, price, description, _currentUser.Email))
                        {
                            DataAccess.RemoveFavorite(name, price, description, _currentUser.Email);
                            MessageBox.Show("Produsul a fost șters din lista de favorite.");
                        }
                        else
                        {
                            MessageBox.Show("Produsul nu există în lista de favorite.");
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
                        MessageBox.Show("Already have 3 elements in compare");
                    }




                };

                shareToWhapp.Click += async (menuItemSender, menuItemEventArgs) =>
                {
                    TextBox nameBox = this.Controls.Find($"name{id - 1}", true).FirstOrDefault() as TextBox;
                    if (nameBox != null && nameBox.Text != null)
                    {
                        string productName = nameBox.Text;
                        string searchUrl = $"https://www.itgalaxy.ro/search?q={Uri.EscapeDataString(productName)}";

                        try
                        {
                            IWebDriver driver = new ChromeDriver();
                            driver.Navigate().GoToUrl(searchUrl);

                            // Wait for the page to load and display the search results
                            await Task.Delay(3000);

                            // Find the first search result link (adjust the selector as needed)
                            var firstResultLink = driver.FindElement(By.CssSelector(".product-item a"));
                            string productLink = firstResultLink.GetAttribute("href");

                            driver.Quit();

                            // Construct WhatsApp URL
                            string whatsappUrl = $"https://api.whatsapp.com/send?text={Uri.EscapeDataString(productLink)}";

                            Process.Start(new ProcessStartInfo(whatsappUrl) { UseShellExecute = true });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error exporting link to WhatsApp: {ex.Message}");
                        }
                    }
                };


                contextMenuStrip.Items.Add(addToFavoritesMenuItem);
                contextMenuStrip.Items.Add(removeFromFavoritesMenuItem);
                contextMenuStrip.Items.Add(goToWebsite);
                contextMenuStrip.Items.Add(addToCompare);
                contextMenuStrip.Items.Add(shareToWhapp);


                contextMenuStrip.Show((Control)sender, e.Location);
            }
        }




        private Product searchProduct(string name)
        {
            return _productList.FirstOrDefault(p => p.name == name);
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
                ToolStripMenuItem excelMenuItem = new ToolStripMenuItem("Export as Excel");
                ToolStripMenuItem pdfMenuItem = new ToolStripMenuItem("Export as Pdf");

                ToolStripMenuItem logoutMenuItem = new ToolStripMenuItem("Logout");
                contextMenu.Items.Add(favoritesMenuItem);
                contextMenu.Items.Add(websiteMenuItem);
                contextMenu.Items.Add(logoutMenuItem);
                contextMenu.Items.Add(compareMenuItem);
                contextMenu.Items.Add(excelMenuItem);
                contextMenu.Items.Add(pdfMenuItem);


                // Asocierea evenimentelor pentru fiecare opțiune
                favoritesMenuItem.Click += (s, args) =>
                {
                    Favorites favoritesForm = new Favorites();
                    new Favorites().ShowDialog();
                };
                excelMenuItem.Click += (s, args) =>
                {
                    try
                    {
                        IExporter excelExporter = new ExcelExporter();
                        ProductExportFacade exportFacade = new ProductExportFacade(excelExporter, null);

                        // Generare nume fisier dinamic
                        string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExportProducts");
                        string fileName = $"products_{DateTime.Now:yyyy.MM.dd_HH.mm.ss}.xlsx";
                        string filePath = Path.Combine(folderPath, fileName);

                        // Creeaza folderul daca nu exista
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }

                        // Realizează exportul
                        exportFacade.ExportToExcel(_productList, filePath);

                        // Opțional, afișează un mesaj pentru utilizator
                        MessageBox.Show("Produsele au fost exportate în Excel cu succes!", "Export completat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Resetarea listei de produse (daca este necesar)
                        // _productList.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                };
                pdfMenuItem.Click += (s, args) =>
                {
                    try
                    {
                        IExporter pdfExporter = new PdfExporter();
                        ProductExportFacade exportFacade = new ProductExportFacade(null, pdfExporter);

                        // Generare nume fisier dinamic
                        string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExportProducts");
                        string fileName = $"products_{DateTime.Now:yyyy.MM.dd_HH.mm.ss}.pdf";
                        string filePath = Path.Combine(folderPath, fileName);

                        // Creeaza folderul daca nu exista
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }

                        // Realizeaza exportul
                        exportFacade.ExportToPdf(_productList, filePath);

                        // Optional, afiseaza un mesaj pentru utilizator
                        MessageBox.Show("Produsele au fost exportate în PDF cu succes!", "Export completat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Resetarea listei de produse (daca este necesar)
                        // _productList.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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

                    this.Hide();
                    new LoginForm().ShowDialog(this);


                };

                // Afișarea meniului contextual în poziția curentă a mouse-ului
                contextMenu.Show((Control)sender, e.Location);
            }
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                TerminateChromeDrivers();

                Environment.Exit(0);
            }
        }
        private void TerminateChromeDrivers()
        {
            Process[] chromeDrivers = Process.GetProcessesByName("chromedriver");

            foreach (Process chromeDriver in chromeDrivers)
            {
                try
                {
                    chromeDriver.Kill();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error terminating ChromeDriver process: {ex.Message}");
                }
            }
        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            searchResultsListBox.Visible = true;

            UpdateSearchResults(textBox8.Text);

        }
        private void UpdateSearchResults(string searchTerm)
        {
            searchResultsListBox.Items.Clear();

            foreach (var mapping in _searchMappings)
            {
                if (mapping.Key.StartsWith(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    searchResultsListBox.Items.Add(mapping.Key);
                }
            }
        }

        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTerm = searchResultsListBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedTerm) && _searchMappings.ContainsKey(selectedTerm))
            {
                _url = _searchMappings[selectedTerm];

                try
                {
                    _page = 1;
                    _currentPage = 0;
                    label1.Text = _currentPage.ToString();

                    await LoadHTMLAsync(_url, _page, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            searchResultsListBox.Visible = false;
        }
    }
}
