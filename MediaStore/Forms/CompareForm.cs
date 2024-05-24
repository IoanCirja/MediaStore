/***************************************************************************
 *                                                                         *
 *  Fisier:      CompareForm.cs                                            *
 *               Funcționalitate adăugată de Cîrja Ioan                    *
 *                                           Mihălucă Mădălina-Maria       *
 *                                           Popa Andrei                   *
 *                                           Sandu Delia-Andreea           *
 * Descriere:   Acest fișier conține clasa CompareForm care definește      *
 *              comportamentul și aspectul ferestrei de comparare a        *
 *              produselor.                                                *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 ***************************************************************************/


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
using System.Diagnostics;


namespace MediaStore
{
    public partial class CompareForm : Form
    {
        #region Constructor

        /// <summary>
        /// Constructorul clasei CompareForm.
        /// </summary>
        public CompareForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Evenimentul care are loc când se încarcă fereastra de comparare a produselor.
        /// </summary>
        private void CompareForm_Load(object sender, EventArgs e)
        {
            // Verifică dacă lista de produse comparate conține cel puțin un produs și încarcă informațiile acestora în câmpurile corespunzătoare
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

            // Verifică dacă lista de produse comparate conține cel puțin doi produse și încarcă informațiile acestora în câmpurile corespunzătoare
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

            // Verifică dacă lista de produse comparate conține cel puțin trei produse și încarcă informațiile acestora în câmpurile corespunzătoare
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

        /// <summary>
        /// Evenimentul care are loc când se dă click pe butonul de Înapoi.
        /// </summary>
        private void Return_Click(object sender, EventArgs e)
        {
            // Curăță controalele formularului și șterge lista de produse comparate
            ClearFormControls(this);
            Store._comparedList.Clear();
            this.Hide();
        }

        /// <summary>
        /// Metodă care curăță controalele formularului.
        /// </summary>
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

        // <summary>
        /// Evenimentul care are loc când se apasă butonul dreapta al mouse-ului pe o imagine.
        /// </summary>
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

                // Adaugă opțiunile de meniu
                ToolStripMenuItem removeMenuItem = new ToolStripMenuItem("Remove");

                // Obține PictureBox-ul pe care s-a dat click
                PictureBox? pictureBox = sender as PictureBox;
                string identifier = pictureBox.Name.Replace("pictureBox", "");
                int id = int.Parse(identifier); // acum avem id ul picture boxului

                removeMenuItem.Click += (menuItemSender, menuItemEventArgs) =>
                {
                    TextBox? nameBox = this.Controls.Find($"name{id + 1}", true).FirstOrDefault() as TextBox;
                    TextBox? priceBox = this.Controls.Find($"price{id + 1}", true).FirstOrDefault() as TextBox;
                    TextBox? descriptionBox = this.Controls.Find($"textBox{id + 1}", true).FirstOrDefault() as TextBox;

                    // Find the PictureBox control
                    PictureBox? pictureBox = this.Controls.Find($"pictureBox{id}", true).FirstOrDefault() as PictureBox;

                    // Clear the TextBox controls
                    if (nameBox != null) nameBox.Text = "";
                    if (priceBox != null) priceBox.Text = "";
                    if (descriptionBox != null) descriptionBox.Text = "";

                    // Clear the PictureBox image
                    if (pictureBox != null) pictureBox.Image = null;

                    // Elimină produsul din lista de comparare
                    if (id < Store._comparedList.Count)
                    {
                        Store._comparedList.RemoveAt(id);
                    }

                };

                contextMenuStrip.Items.Add(removeMenuItem);

                contextMenuStrip.Show((Control)sender, e.Location);
            }
        }

        /// <summary>
        /// Metodă care deschide un help pentru utilizator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Help_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }


}
