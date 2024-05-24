namespace MediaStore
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            labelWelcome = new Label();
            buttonExit = new Button();
            buttonBackToLogin = new Button();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            labelUserLastName = new Label();
            labelUserFirstName = new Label();
            buttonRegister = new Button();
            textBoxPhone = new TextBox();
            labelPhone = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxRePassword = new TextBox();
            labelRePassword = new Label();
            label1 = new Label();
            label2 = new Label();
            button_Help = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.BackColor = Color.Transparent;
            labelWelcome.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(409, 118);
            labelWelcome.Margin = new Padding(2, 0, 2, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(159, 32);
            labelWelcome.TabIndex = 14;
            labelWelcome.Text = "Register an";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(860, 105);
            buttonExit.Margin = new Padding(2, 3, 2, 3);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(111, 53);
            buttonExit.TabIndex = 13;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonBackToLogin
            // 
            buttonBackToLogin.Location = new Point(838, 42);
            buttonBackToLogin.Margin = new Padding(2, 3, 2, 3);
            buttonBackToLogin.Name = "buttonBackToLogin";
            buttonBackToLogin.Size = new Size(133, 57);
            buttonBackToLogin.TabIndex = 12;
            buttonBackToLogin.Text = "← Go to Login";
            buttonBackToLogin.UseVisualStyleBackColor = true;
            buttonBackToLogin.Click += buttonBackToLogin_Click;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(470, 260);
            textBoxLastName.Margin = new Padding(2, 3, 2, 3);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(237, 27);
            textBoxLastName.TabIndex = 11;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(470, 215);
            textBoxFirstName.Margin = new Padding(2, 3, 2, 3);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(237, 27);
            textBoxFirstName.TabIndex = 10;
            // 
            // labelUserLastName
            // 
            labelUserLastName.AutoSize = true;
            labelUserLastName.BackColor = Color.Transparent;
            labelUserLastName.Location = new Point(354, 270);
            labelUserLastName.Margin = new Padding(2, 0, 2, 0);
            labelUserLastName.Name = "labelUserLastName";
            labelUserLastName.Size = new Size(89, 20);
            labelUserLastName.TabIndex = 9;
            labelUserLastName.Text = "Last name: *";
            // 
            // labelUserFirstName
            // 
            labelUserFirstName.AutoSize = true;
            labelUserFirstName.BackColor = Color.Transparent;
            labelUserFirstName.Location = new Point(354, 214);
            labelUserFirstName.Margin = new Padding(2, 0, 2, 0);
            labelUserFirstName.Name = "labelUserFirstName";
            labelUserFirstName.Size = new Size(93, 20);
            labelUserFirstName.TabIndex = 8;
            labelUserFirstName.Text = "First Name: *";
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.Wheat;
            buttonRegister.Location = new Point(470, 523);
            buttonRegister.Margin = new Padding(2, 3, 2, 3);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(133, 57);
            buttonRegister.TabIndex = 15;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(470, 313);
            textBoxPhone.Margin = new Padding(2, 3, 2, 3);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(237, 27);
            textBoxPhone.TabIndex = 17;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.BackColor = Color.Transparent;
            labelPhone.Location = new Point(354, 315);
            labelPhone.Margin = new Padding(2, 0, 2, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(63, 20);
            labelPhone.TabIndex = 16;
            labelPhone.Text = "Phone: *";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(470, 361);
            textBoxEmail.Margin = new Padding(2, 3, 2, 3);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(237, 27);
            textBoxEmail.TabIndex = 19;
            // 
            // labelEmail
            // 
            labelEmail.AccessibleRole = AccessibleRole.OutlineButton;
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Location = new Point(354, 364);
            labelEmail.Margin = new Padding(2, 0, 2, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(59, 20);
            labelEmail.TabIndex = 18;
            labelEmail.Text = "Email: *";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(470, 411);
            textBoxPassword.Margin = new Padding(2, 3, 2, 3);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(237, 27);
            textBoxPassword.TabIndex = 21;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Location = new Point(354, 414);
            labelPassword.Margin = new Padding(2, 0, 2, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(83, 20);
            labelPassword.TabIndex = 20;
            labelPassword.Text = "Password: *";
            // 
            // textBoxRePassword
            // 
            textBoxRePassword.Location = new Point(470, 467);
            textBoxRePassword.Margin = new Padding(2, 3, 2, 3);
            textBoxRePassword.Name = "textBoxRePassword";
            textBoxRePassword.PasswordChar = '*';
            textBoxRePassword.Size = new Size(237, 27);
            textBoxRePassword.TabIndex = 23;
            // 
            // labelRePassword
            // 
            labelRePassword.AutoSize = true;
            labelRePassword.BackColor = Color.Transparent;
            labelRePassword.Location = new Point(354, 470);
            labelRePassword.Margin = new Padding(2, 0, 2, 0);
            labelRePassword.Name = "labelRePassword";
            labelRePassword.Size = new Size(104, 20);
            labelRePassword.TabIndex = 22;
            labelRePassword.Text = "Re Password: *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(644, 664);
            label1.Name = "label1";
            label1.Size = new Size(327, 20);
            label1.TabIndex = 24;
            label1.Text = "**This will also create an account on ITGalaxy.ro!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(354, 150);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(380, 32);
            label2.TabIndex = 25;
            label2.Text = "account for ScrapeMaster** ↓";
            // 
            // button_Help
            // 
            button_Help.Location = new Point(885, 165);
            button_Help.Margin = new Padding(3, 4, 3, 4);
            button_Help.Name = "button_Help";
            button_Help.Size = new Size(86, 46);
            button_Help.TabIndex = 60;
            button_Help.Text = "Help";
            button_Help.UseVisualStyleBackColor = true;
            button_Help.Click += button_Help_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(998, 693);
            Controls.Add(button_Help);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxRePassword);
            Controls.Add(labelRePassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(labelPhone);
            Controls.Add(buttonRegister);
            Controls.Add(labelWelcome);
            Controls.Add(buttonExit);
            Controls.Add(buttonBackToLogin);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelUserLastName);
            Controls.Add(labelUserFirstName);
            Name = "RegisterForm";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label labelWelcome;
        private Button buttonExit;
        private Button buttonBackToLogin;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label labelUserLastName;
        private Label labelUserFirstName;
        private Button buttonRegister;
        private TextBox textBoxPhone;
        private Label labelPhone;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private TextBox textBoxRePassword;
        private Label labelRePassword;
        private Label label1;
        private Label label2;
        private Button button_Help;
    }
}