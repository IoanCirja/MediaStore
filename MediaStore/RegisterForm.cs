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
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string lastName = textBoxLastName.Text;
            string firstName = textBoxFirstName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            string password = textBoxPassword.Text;
            string rePassword = textBoxRePassword.Text; 

            if ( string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName) || 
                 string.IsNullOrWhiteSpace(email)    || string.IsNullOrWhiteSpace(phone)     || 
                 string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(rePassword) )
            {
                MessageBox.Show("Aveti campuri necompletate.", "Eroare");
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
    }
}
