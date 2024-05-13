namespace MediaStore
{
    partial class loginForm
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
            labelUserName = new Label();
            labelPassword = new Label();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            buttonRegister = new Button();
            buttonExit = new Button();
            labelWelcome = new Label();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(131, 93);
            labelUserName.Margin = new Padding(2, 0, 2, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(66, 15);
            labelUserName.TabIndex = 0;
            labelUserName.Text = "User name:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(131, 141);
            labelPassword.Margin = new Padding(2, 0, 2, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Password:";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(262, 93);
            textBoxUserName.Margin = new Padding(2);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(152, 23);
            textBoxUserName.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(262, 133);
            textBoxPassword.Margin = new Padding(2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(152, 23);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(134, 248);
            buttonRegister.Margin = new Padding(2);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(65, 30);
            buttonRegister.TabIndex = 4;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(385, 193);
            buttonExit.Margin = new Padding(2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(65, 30);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(210, 37);
            labelWelcome.Margin = new Padding(2, 0, 2, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(110, 26);
            labelWelcome.TabIndex = 6;
            labelWelcome.Text = "Welcome!";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(282, 193);
            buttonLogin.Margin = new Padding(2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(65, 30);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 353);
            Controls.Add(buttonLogin);
            Controls.Add(labelWelcome);
            Controls.Add(buttonExit);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Margin = new Padding(2);
            Name = "loginForm";
            Text = "Login";
            Load += loginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonLogin;
    }
}

