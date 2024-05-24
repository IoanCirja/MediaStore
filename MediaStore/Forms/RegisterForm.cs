/***************************************************************************
 *                                                                         *
 *  Fișier:      Registerorm.cs                                            *
 *               Funcționalitate adăugată de Cîrja Ioan                    *
 *                                         Mihălucă Mădălina-Maria         *
 *                                         Popa Andrei                     *
 *                                         Sandu Delia-Andreea             *
 * Descriere:   Acest fișier conține clasa RegisterForm, care definește    *
 *              comportamentul și aspectul ferestrei de înregistrare       *
 *              pentru aplicația MediaStore. Clasa gestionează procesele   *
 *              de înregistrare a utilizatorilor.                          *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 ***************************************************************************/

using SiteManipulation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaStore
{
    public partial class RegisterForm : Form
    {
        #region Constructor

        /// <summary>
        /// Constructor pentru clasa RegisterForm.
        /// </summary>
        public RegisterForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gestionează evenimentul de apăsare a butonului pentru revenirea la fereastra de autentificare.
        /// </summary>
        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();
        }

        /// <summary>
        /// Gestionează evenimentul de apăsare a butonului pentru ieșirea din aplicație.
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Gestionează evenimentul de apăsare a butonului pentru înregistrarea unui nou utilizator.
        /// </summary>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string lastName = textBoxLastName.Text;
            string firstName = textBoxFirstName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            string password = textBoxPassword.Text;
            string rePassword = textBoxRePassword.Text;

            if (string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName) ||
                 string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) ||
                 string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(rePassword))
            {
                MessageBox.Show("Aveti campuri necompletate.", "Eroare");
            }
            else if (!phone.StartsWith("07") || phone.Length != 10)
            {
                MessageBox.Show("Numarul de telefon trebuie sa inceapa cu '07' și să aibă 10 caractere.", "Eroare");
            }
            else if (!password.Equals(rePassword))
            {
                MessageBox.Show("Parolele nu coincid.", "Eroare");
            }
            else if (!IsValidEmail(email))
            {
                MessageBox.Show("Adresa de email nu este valida.", "Eroare");
            }
            else
            {
                try
                {


                    bool success = DataAccess.Register(lastName, firstName, email, phone, password);

                    if (success)
                    {
                        MessageBox.Show("Inregistrat cu succes!", "Succes");
                        WebNavigator registerNav = new WebNavigator();
                        registerNav.Register(firstName, lastName, phone, email, password);
                    }
                    else
                    {
                        MessageBox.Show("Inregistrarea a eșuat. Exista deja un cont pe acest email sau a aparut o alta eroare.", "Eroare");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A aparut o eroare in timpul inregistrarii: " + ex.Message, "Eroare");
                }

                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                this.Hide();
            }
        }

        /// <summary>
        /// Verifică dacă o adresă de email este validă.
        /// </summary>
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Metodă care deschide un help pentru utilizator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Help_Click(object sender, EventArgs e)
        {
            string helpFilePath = Path.Combine(Application.StartupPath, "_MediaStore_UserHelp.chm");
            Help.ShowHelp(this, helpFilePath);
        }

        #endregion
    }
}
