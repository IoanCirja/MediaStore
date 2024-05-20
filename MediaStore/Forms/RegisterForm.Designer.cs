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
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(147, 25);
            labelWelcome.Margin = new Padding(2, 0, 2, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(383, 26);
            labelWelcome.TabIndex = 14;
            labelWelcome.Text = "Register an account for ScrapeMaster!";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(450, 348);
            buttonExit.Margin = new Padding(2, 2, 2, 2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(116, 43);
            buttonExit.TabIndex = 13;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonBackToLogin
            // 
            buttonBackToLogin.Location = new Point(176, 348);
            buttonBackToLogin.Margin = new Padding(2, 2, 2, 2);
            buttonBackToLogin.Name = "buttonBackToLogin";
            buttonBackToLogin.Size = new Size(116, 43);
            buttonBackToLogin.TabIndex = 12;
            buttonBackToLogin.Text = "Go to Login";
            buttonBackToLogin.UseVisualStyleBackColor = true;
            buttonBackToLogin.Click += buttonBackToLogin_Click;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(321, 138);
            textBoxLastName.Margin = new Padding(2, 2, 2, 2);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(208, 23);
            textBoxLastName.TabIndex = 11;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(321, 104);
            textBoxFirstName.Margin = new Padding(2, 2, 2, 2);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(208, 23);
            textBoxFirstName.TabIndex = 10;
            // 
            // labelUserLastName
            // 
            labelUserLastName.AutoSize = true;
            labelUserLastName.Location = new Point(191, 146);
            labelUserLastName.Margin = new Padding(2, 0, 2, 0);
            labelUserLastName.Name = "labelUserLastName";
            labelUserLastName.Size = new Size(72, 15);
            labelUserLastName.TabIndex = 9;
            labelUserLastName.Text = "Last name: *";
            // 
            // labelUserFirstName
            // 
            labelUserFirstName.AutoSize = true;
            labelUserFirstName.Location = new Point(191, 104);
            labelUserFirstName.Margin = new Padding(2, 0, 2, 0);
            labelUserFirstName.Name = "labelUserFirstName";
            labelUserFirstName.Size = new Size(75, 15);
            labelUserFirstName.TabIndex = 8;
            labelUserFirstName.Text = "First Name: *";
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(310, 348);
            buttonRegister.Margin = new Padding(2, 2, 2, 2);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(116, 43);
            buttonRegister.TabIndex = 15;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(321, 178);
            textBoxPhone.Margin = new Padding(2, 2, 2, 2);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(208, 23);
            textBoxPhone.TabIndex = 17;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(191, 180);
            labelPhone.Margin = new Padding(2, 0, 2, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(52, 15);
            labelPhone.TabIndex = 16;
            labelPhone.Text = "Phone: *";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(321, 214);
            textBoxEmail.Margin = new Padding(2, 2, 2, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(208, 23);
            textBoxEmail.TabIndex = 19;
            // 
            // labelEmail
            // 
            labelEmail.AccessibleRole = AccessibleRole.OutlineButton;
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(191, 217);
            labelEmail.Margin = new Padding(2, 0, 2, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(47, 15);
            labelEmail.TabIndex = 18;
            labelEmail.Text = "Email: *";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(321, 251);
            textBoxPassword.Margin = new Padding(2, 2, 2, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(208, 23);
            textBoxPassword.TabIndex = 21;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(191, 254);
            labelPassword.Margin = new Padding(2, 0, 2, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(68, 15);
            labelPassword.TabIndex = 20;
            labelPassword.Text = "Password: *";
            // 
            // textBoxRePassword
            // 
            textBoxRePassword.Location = new Point(321, 293);
            textBoxRePassword.Margin = new Padding(2, 2, 2, 2);
            textBoxRePassword.Name = "textBoxRePassword";
            textBoxRePassword.PasswordChar = '*';
            textBoxRePassword.Size = new Size(208, 23);
            textBoxRePassword.TabIndex = 23;
            // 
            // labelRePassword
            // 
            labelRePassword.AutoSize = true;
            labelRePassword.Location = new Point(191, 296);
            labelRePassword.Margin = new Padding(2, 0, 2, 0);
            labelRePassword.Name = "labelRePassword";
            labelRePassword.Size = new Size(84, 15);
            labelRePassword.TabIndex = 22;
            labelRePassword.Text = "Re Password: *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 61);
            label1.Name = "label1";
            label1.Size = new Size(250, 15);
            label1.TabIndex = 24;
            label1.Text = "This will also create an account on ITGalaxy.ro!";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 466);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
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
    }
}