namespace MediaStore
{
    partial class CompareForm
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            price1 = new TextBox();
            price2 = new TextBox();
            price3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            name1 = new TextBox();
            name2 = new TextBox();
            name3 = new TextBox();
            Return = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(51, 28);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 285);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(589, 28);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(421, 285);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(1153, 28);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(421, 285);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // price1
            // 
            price1.BackColor = SystemColors.Control;
            price1.BorderStyle = BorderStyle.None;
            price1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price1.Location = new Point(50, 263);
            price1.Margin = new Padding(3, 4, 3, 4);
            price1.Multiline = true;
            price1.Name = "price1";
            price1.Size = new Size(422, 51);
            price1.TabIndex = 6;
            price1.TextChanged += price1_TextChanged;
            // 
            // price2
            // 
            price2.BackColor = SystemColors.Control;
            price2.BorderStyle = BorderStyle.None;
            price2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price2.Location = new Point(589, 249);
            price2.Margin = new Padding(3, 4, 3, 4);
            price2.Multiline = true;
            price2.Name = "price2";
            price2.Size = new Size(421, 64);
            price2.TabIndex = 7;
            price2.TextChanged += price2_TextChanged;
            // 
            // price3
            // 
            price3.BackColor = SystemColors.Control;
            price3.BorderStyle = BorderStyle.None;
            price3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price3.Location = new Point(1153, 263);
            price3.Margin = new Padding(3, 4, 3, 4);
            price3.Multiline = true;
            price3.Name = "price3";
            price3.Size = new Size(433, 51);
            price3.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(51, 492);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(421, 361);
            textBox1.TabIndex = 39;
            textBox1.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(589, 513);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(421, 340);
            textBox2.TabIndex = 40;
            textBox2.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(1153, 503);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(421, 351);
            textBox3.TabIndex = 41;
            textBox3.TextChanged += textBox5_TextChanged;
            // 
            // name1
            // 
            name1.BackColor = SystemColors.Control;
            name1.BorderStyle = BorderStyle.None;
            name1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name1.Location = new Point(51, 421);
            name1.Margin = new Padding(3, 4, 3, 4);
            name1.Multiline = true;
            name1.Name = "name1";
            name1.Size = new Size(421, 64);
            name1.TabIndex = 42;
            name1.Text = "Se incarca...";
            name1.TextChanged += name1_TextChanged;
            // 
            // name2
            // 
            name2.BackColor = SystemColors.Control;
            name2.BorderStyle = BorderStyle.None;
            name2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name2.Location = new Point(589, 421);
            name2.Margin = new Padding(3, 4, 3, 4);
            name2.Multiline = true;
            name2.Name = "name2";
            name2.Size = new Size(421, 64);
            name2.TabIndex = 43;
            name2.Text = "Se incarca...";
            // 
            // name3
            // 
            name3.BackColor = SystemColors.Control;
            name3.BorderStyle = BorderStyle.None;
            name3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name3.Location = new Point(1153, 421);
            name3.Margin = new Padding(3, 4, 3, 4);
            name3.Multiline = true;
            name3.Name = "name3";
            name3.Size = new Size(421, 75);
            name3.TabIndex = 44;
            name3.Text = "Se incarca...";
            name3.TextChanged += name3_TextChanged;
            // 
            // Return
            // 
            Return.Location = new Point(1535, 865);
            Return.Margin = new Padding(3, 4, 3, 4);
            Return.Name = "Return";
            Return.Size = new Size(86, 31);
            Return.TabIndex = 45;
            Return.Text = "Return";
            Return.UseVisualStyleBackColor = true;
            Return.Click += Return_Click;
            // 
            // CompareForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1651, 912);
            Controls.Add(Return);
            Controls.Add(name3);
            Controls.Add(name2);
            Controls.Add(name1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(price3);
            Controls.Add(price2);
            Controls.Add(price1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "CompareForm";
            Text = "CompareForm";
            Load += CompareForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox price1;
        private TextBox price2;
        private TextBox price3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox name1;
        private TextBox name2;
        private TextBox name3;
        private Button Return;
    }
}