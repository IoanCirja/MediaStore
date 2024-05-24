/***************************************************************************
 *                                                                         *
 *  Fișier:      LoginForm.cs                                              *
 *               Funcționalitate adăugată de Cîrja Ioan                    *
 *                                         Mihălucă Mădălina-Maria         *
 *                                         Popa Andrei                     *
 *                                         Sandu Delia-Andreea             *
 * Descriere:   Acest fișier conține clasa LoginForm, care definește       *
 *              comportamentul și aspectul ferestrei de autentificare      *
 *              pentru aplicația MediaStore. Clasa gestionează procesele   *
 *              de autentificare a utilizatorilor.                         *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 ***************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.Sqlite;
using OpenQA.Selenium.DevTools.V121.Emulation;


namespace MediaStore
{
    public partial class LoginForm : Form
    {
        #region Constructor

        /// <summary>
        /// Constructorul clasei LoginForm.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = buttonLogin;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gestionează evenimentul de apăsare a butonului pentru funcționalitatea de autentificare.
        /// </summary>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            if (DataAccess.Login(email, password))
            {
                textBoxEmail.Clear();
                textBoxPassword.Clear();

                try
                {
                    Store.SetUser(DataAccess.GetUser().Where(x => x.Email == email && x.Password == password).FirstOrDefault());
                    this.Hide();
                    new Store().ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Email sau parolă incorecte!");
            }
        }

        /// <summary>
        /// Gestionează evenimentul de apăsare a butonului pentru deschiderea formularului de înregistrare.
        /// </summary>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

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
