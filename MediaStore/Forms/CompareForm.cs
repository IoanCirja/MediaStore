using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MediaStore
{
    public partial class CompareForm : Form
    {
        public CompareForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void price1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompareForm_Load(object sender, EventArgs e)
        {
            if (Store._comparedList.Count > 0)
            {
                price1.Text = Store._comparedList[0].price;
                textBox1.Text = Store._comparedList[0].description;
                name1.Text = Store._comparedList[0].name;
                pictureBox0.Image = Store._comparedList[0].image;
            }
            else
            {
                price1.Visible = false;
                textBox1.Visible = false;
                name1.Visible = false;
                pictureBox0.Visible = false;
            }

            if (Store._comparedList.Count > 1)
            {
                price2.Text = Store._comparedList[1].price;
                textBox2.Text = Store._comparedList[1].description;
                name2.Text = Store._comparedList[1].name;
                pictureBox1.Image = Store._comparedList[1].image;
            }
            else
            {
                price2.Visible = false;
                textBox2.Visible = false;
                name2.Visible = false;
                pictureBox1.Visible = false;
            }

            if (Store._comparedList.Count > 2)
            {
                price3.Text = Store._comparedList[2].price;
                textBox3.Text = Store._comparedList[2].description;
                name3.Text = Store._comparedList[2].name;
                pictureBox2.Image = Store._comparedList[2].image;
            }
            else
            {
                price3.Visible = false;
                textBox3.Visible = false;
                name3.Visible = false;
                pictureBox2.Visible = false;
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void price2_TextChanged(object sender, EventArgs e)
        {

        }

        private void name3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            ClearFormControls(this);
            Store._comparedList.Clear();
            this.Hide();
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
                    pictureBox.Image = null;
                }
            }
        }

        private void name1_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

                ToolStripMenuItem removeMenuItem = new ToolStripMenuItem("Remove");
                ToolStripMenuItem addToFavoritesMenuItem = new ToolStripMenuItem("Add To Favorites");
                ToolStripMenuItem goToWebsiteMenuItem = new ToolStripMenuItem("Go to Website");



                PictureBox? pictureBox = sender as PictureBox;
                string identifier = pictureBox.Name.Replace("pictureBox", "");
                int id = int.Parse(identifier); // acum avem id ul picture boxului


                addToFavoritesMenuItem.Click += (menuItemSender, menuItemEventArgs) =>
                {
                    MessageBox.Show("added to favorites");
                };

                //goToWebsiteMenuItem.Click += (menuItemSender, menuItemEventArgs) =>
                //{



                //    IWebDriver driver = new ChromeDriver();
                //    driver.Navigate().GoToUrl("https://www.itgalaxy.ro/");
                //    driver.Manage().Window.Maximize();

                //    var searchText = driver.FindElement(By.Id("search-box"));
                //    searchText.SendKeys(nameBox.Text);
                //    searchText.SendKeys(OpenQA.Selenium.Keys.Enter);


                //};

                //adaug la comparat
                removeMenuItem.Click += (menuItemSender, menuItemEventArgs) =>
                {
                    TextBox? nameBox = this.Controls.Find($"name{id + 1}", true).FirstOrDefault() as TextBox;
                    TextBox? priceBox = this.Controls.Find($"price{id + 1}", true).FirstOrDefault() as TextBox;
                    TextBox? descriptionBox = this.Controls.Find($"textBox{id +1}", true).FirstOrDefault() as TextBox;

                    // Find the PictureBox control
                    PictureBox? pictureBox = this.Controls.Find($"pictureBox{id}", true).FirstOrDefault() as PictureBox;

                    // Clear the TextBox controls
                    if (nameBox != null) nameBox.Text = "";
                    if (priceBox != null) priceBox.Text = "";
                    if (descriptionBox != null) descriptionBox.Text = "";

                    // Clear the PictureBox image
                    if (pictureBox != null) pictureBox.Image = null;





                };

                contextMenuStrip.Items.Add(addToFavoritesMenuItem);
                contextMenuStrip.Items.Add(removeMenuItem);
                contextMenuStrip.Items.Add(goToWebsiteMenuItem);


                contextMenuStrip.Show((Control)sender, e.Location);
            }
        }
    }
}
