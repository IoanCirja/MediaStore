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
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(308, 64);
            labelWelcome.Margin = new Padding(2, 0, 2, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(140, 32);
            labelWelcome.TabIndex = 14;
            labelWelcome.Text = "Welcome!";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(492, 472);
            buttonExit.Margin = new Padding(2, 3, 2, 3);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(74, 40);
            buttonExit.TabIndex = 13;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonBackToLogin
            // 
            buttonBackToLogin.Location = new Point(205, 546);
            buttonBackToLogin.Margin = new Padding(2, 3, 2, 3);
            buttonBackToLogin.Name = "buttonBackToLogin";
            buttonBackToLogin.Size = new Size(74, 40);
            buttonBackToLogin.TabIndex = 12;
            buttonBackToLogin.Text = "Login";
            buttonBackToLogin.UseVisualStyleBackColor = true;
            buttonBackToLogin.Click += buttonBackToLogin_Click;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(367, 184);
            textBoxLastName.Margin = new Padding(2, 3, 2, 3);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(237, 27);
            textBoxLastName.TabIndex = 11;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(367, 139);
            textBoxFirstName.Margin = new Padding(2, 3, 2, 3);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(237, 27);
            textBoxFirstName.TabIndex = 10;
            // 
            // labelUserLastName
            // 
            labelUserLastName.AutoSize = true;
            labelUserLastName.Location = new Point(218, 195);
            labelUserLastName.Margin = new Padding(2, 0, 2, 0);
            labelUserLastName.Name = "labelUserLastName";
            labelUserLastName.Size = new Size(89, 20);
            labelUserLastName.TabIndex = 9;
            labelUserLastName.Text = "Last name: *";
            // 
            // labelUserFirstName
            // 
            labelUserFirstName.AutoSize = true;
            labelUserFirstName.Location = new Point(218, 139);
            labelUserFirstName.Margin = new Padding(2, 0, 2, 0);
            labelUserFirstName.Name = "labelUserFirstName";
            labelUserFirstName.Size = new Size(93, 20);
            labelUserFirstName.TabIndex = 8;
            labelUserFirstName.Text = "First Name: *";
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(374, 472);
            buttonRegister.Margin = new Padding(2, 3, 2, 3);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(74, 40);
            buttonRegister.TabIndex = 15;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(367, 237);
            textBoxPhone.Margin = new Padding(2, 3, 2, 3);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(237, 27);
            textBoxPhone.TabIndex = 17;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(218, 240);
            labelPhone.Margin = new Padding(2, 0, 2, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(63, 20);
            labelPhone.TabIndex = 16;
            labelPhone.Text = "Phone: *";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(367, 286);
            textBoxEmail.Margin = new Padding(2, 3, 2, 3);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(237, 27);
            textBoxEmail.TabIndex = 19;
            // 
            // labelEmail
            // 
            labelEmail.AccessibleRole = AccessibleRole.OutlineButton;
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(218, 289);
            labelEmail.Margin = new Padding(2, 0, 2, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(59, 20);
            labelEmail.TabIndex = 18;
            labelEmail.Text = "Email: *";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(367, 335);
            textBoxPassword.Margin = new Padding(2, 3, 2, 3);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(237, 27);
            textBoxPassword.TabIndex = 21;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(218, 338);
            labelPassword.Margin = new Padding(2, 0, 2, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(83, 20);
            labelPassword.TabIndex = 20;
            labelPassword.Text = "Password: *";
            // 
            // textBoxRePassword
            // 
            textBoxRePassword.Location = new Point(367, 391);
            textBoxRePassword.Margin = new Padding(2, 3, 2, 3);
            textBoxRePassword.Name = "textBoxRePassword";
            textBoxRePassword.PasswordChar = '*';
            textBoxRePassword.Size = new Size(237, 27);
            textBoxRePassword.TabIndex = 23;
            // 
            // labelRePassword
            // 
            labelRePassword.AutoSize = true;
            labelRePassword.Location = new Point(218, 394);
            labelRePassword.Margin = new Padding(2, 0, 2, 0);
            labelRePassword.Name = "labelRePassword";
            labelRePassword.Size = new Size(104, 20);
            labelRePassword.TabIndex = 22;
            labelRePassword.Text = "Re Password: *";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 622);
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
            Text = "RegisterForm";
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
    }
}