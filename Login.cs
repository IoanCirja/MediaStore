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
using Microsoft.Data.Sqlite;

namespace MediaStore
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            if (DataAccess.Login(username, password))
            {
                MessageBox.Show("Autentificare reușită!");
                textBoxUserName.Clear();
                textBoxPassword.Clear();
                this.Hide();
                new Store().ShowDialog();


            }
            else
            {
                MessageBox.Show("Nume de utilizator sau parolă incorecte!");
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //buttonLogin.Visible = false;

            //List<Label> labels = new List<Label>();
            //List<TextBox> textBoxes = new List<TextBox>();

            //string[] labelTexts = { "Email:", "Phone:", "Address:" };

            //int verticalGap = 50;
            //int orizontalGap = 150;

            //int startX = textBoxPassword.Left - 115;
            //int startY = textBoxPassword.Top + 100;

            //for (int i = 0; i < labelTexts.Length; i++)
            //{
            //    Label label = new Label();
            //    label.Text = labelTexts[i];
            //    label.Location = new Point(startX, startY + i * verticalGap);

            //    labels.Add(label);

            //    TextBox textBox = new TextBox();
            //    textBox.Location = new Point(startX + orizontalGap, startY + i * verticalGap);

            //    textBoxes.Add(textBox);
            //}

            //foreach (Label label in labels)
            //{
            //    Controls.Add(label);
            //}

            //foreach (TextBox textBox in textBoxes)
            //{
            //    Controls.Add(textBox);
            //}


            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            if (DataAccess.Register(username, password))
            {
                MessageBox.Show("Înregistrare reușită!");
                // Continuă cu logica pentru înregistrare
            }
            else
            {
                MessageBox.Show("Numele de utilizator există deja!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Microsoft.Data.Sqlite;
//namespace Login
//{
//    public partial class loginForm : Form
//    {
//        private enum FormMode
//        {
//            Login,
//            Register
//        }

//        private FormMode currentMode;

//        public loginForm()
//        {
//            InitializeComponent();
//            ShowWelcomeInterface(); 
//        }

//        private void ShowWelcomeInterface()
//        {
//            labelWelcome.Visible = true;
//            Button buttonShowLogin = new Button();
//            Button buttonShowRegister = new Button(); 

//            buttonShowLogin.Visible = true;
//            buttonShowLogin.Text = "Login";

//            buttonShowRegister.Visible = true;
//            buttonShowRegister.Text = "Register";

//        }
//        private void ShowLoginInterface()
//        {
//            // Ascunde elementele pentru inregistrare
//            textBoxUserName.Visible = false;
//            textBoxPassword.Visible = false;
//            labelUserName.Visible = false;
//            labelPassword.Visible = false;
//            buttonLogin.Visible = false;

//            // Afișează butonul pentru autentificare și butonul pentru înregistrare
//            //buttonShowLogin.Visible = true;
//            //buttonShowRegister.Visible = true;

//            currentMode = FormMode.Login;
//        }

//        private void ShowRegisterInterface()
//        {
//            // Ascunde butonul pentru autentificare și butonul pentru înregistrare
//            //buttonShowLogin.Visible = false;
//           //buttonShowRegister.Visible = false;

//            // Afișează elementele pentru înregistrare
//            textBoxUserName.Visible = true;
//            textBoxPassword.Visible = true;
//            labelUserName.Visible = true;
//            labelPassword.Visible = true;
//            buttonRegister.Visible = true;

//            currentMode = FormMode.Register;
//        }

//        private void buttonShowLogin_Click(object sender, EventArgs e)
//        {
//            ShowLoginInterface();
//        }

//        private void buttonShowRegister_Click(object sender, EventArgs e)
//        {
//            ShowRegisterInterface();
//        }

//        private void buttonLogin_Click(object sender, EventArgs e)
//        {
//            // Logica pentru autentificare
//        }

//        private void buttonRegister_Click(object sender, EventArgs e)
//        {
//            // Logica pentru înregistrare
//        }
//    }
//}