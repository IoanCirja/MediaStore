﻿using System.Windows.Forms;

namespace MediaStore
{
    partial class Store
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            price2 = new TextBox();
            name1 = new TextBox();
            pictureBox2 = new PictureBox();
            price3 = new TextBox();
            name2 = new TextBox();
            pictureBox3 = new PictureBox();
            price4 = new TextBox();
            name3 = new TextBox();
            pictureBox4 = new PictureBox();
            price5 = new TextBox();
            name4 = new TextBox();
            pictureBox5 = new PictureBox();
            price6 = new TextBox();
            name5 = new TextBox();
            pictureBox6 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            Favorites = new ContextMenuStrip(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            textBox1 = new TextBox();
            price1 = new TextBox();
            name0 = new TextBox();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            pictureBox7 = new PictureBox();
            searchbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // price2
            // 
            price2.BackColor = SystemColors.Control;
            price2.BorderStyle = BorderStyle.None;
            price2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price2.Location = new Point(57, 430);
            price2.Name = "price2";
            price2.Size = new Size(379, 26);
            price2.TabIndex = 11;
            // 
            // name1
            // 
            name1.BackColor = SystemColors.Control;
            name1.BorderStyle = BorderStyle.None;
            name1.Location = new Point(211, 248);
            name1.Multiline = true;
            name1.Name = "name1";
            name1.Size = new Size(379, 48);
            name1.TabIndex = 7;
            name1.Text = "Se incarca...";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(57, 248);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(148, 208);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.MouseDown += pictureBox_MouseDown;
            // 
            // price3
            // 
            price3.BackColor = SystemColors.Control;
            price3.BorderStyle = BorderStyle.None;
            price3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price3.Location = new Point(57, 644);
            price3.Name = "price3";
            price3.Size = new Size(379, 26);
            price3.TabIndex = 17;
            // 
            // name2
            // 
            name2.BackColor = SystemColors.Control;
            name2.BorderStyle = BorderStyle.None;
            name2.Location = new Point(211, 462);
            name2.Multiline = true;
            name2.Name = "name2";
            name2.Size = new Size(379, 48);
            name2.TabIndex = 13;
            name2.Text = "Se incarca...";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(57, 462);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(148, 208);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox_MouseDown;
            // 
            // price4
            // 
            price4.BackColor = SystemColors.Control;
            price4.BorderStyle = BorderStyle.None;
            price4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price4.Location = new Point(596, 213);
            price4.Name = "price4";
            price4.Size = new Size(379, 26);
            price4.TabIndex = 23;
            // 
            // name3
            // 
            name3.BackColor = SystemColors.Control;
            name3.BorderStyle = BorderStyle.None;
            name3.Location = new Point(750, 23);
            name3.Multiline = true;
            name3.Name = "name3";
            name3.Size = new Size(379, 48);
            name3.TabIndex = 19;
            name3.Text = "Se incarca...";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(596, 34);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(148, 208);
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            pictureBox4.MouseDown += pictureBox_MouseDown;
            // 
            // price5
            // 
            price5.BackColor = SystemColors.Control;
            price5.BorderStyle = BorderStyle.None;
            price5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price5.Location = new Point(596, 430);
            price5.Name = "price5";
            price5.Size = new Size(379, 26);
            price5.TabIndex = 29;
            // 
            // name4
            // 
            name4.BackColor = SystemColors.Control;
            name4.BorderStyle = BorderStyle.None;
            name4.Location = new Point(750, 248);
            name4.Multiline = true;
            name4.Name = "name4";
            name4.Size = new Size(379, 48);
            name4.TabIndex = 25;
            name4.Text = "Se incarca...";
            name4.TextChanged += name4_TextChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(596, 248);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(148, 208);
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            pictureBox5.MouseDown += pictureBox_MouseDown;
            // 
            // price6
            // 
            price6.BackColor = SystemColors.Control;
            price6.BorderStyle = BorderStyle.None;
            price6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price6.Location = new Point(596, 644);
            price6.Name = "price6";
            price6.Size = new Size(379, 26);
            price6.TabIndex = 35;
            // 
            // name5
            // 
            name5.BackColor = SystemColors.Control;
            name5.BorderStyle = BorderStyle.None;
            name5.Location = new Point(750, 462);
            name5.Multiline = true;
            name5.Name = "name5";
            name5.Size = new Size(379, 48);
            name5.TabIndex = 31;
            name5.Text = "Se incarca...";
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(596, 462);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(148, 208);
            pictureBox6.TabIndex = 30;
            pictureBox6.TabStop = false;
            pictureBox6.MouseDown += pictureBox_MouseDown;
            // 
            // button1
            // 
            button1.Location = new Point(1397, 622);
            button1.Name = "button1";
            button1.Size = new Size(75, 50);
            button1.TabIndex = 36;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1290, 622);
            button2.Name = "button2";
            button2.Size = new Size(75, 48);
            button2.TabIndex = 37;
            button2.Text = "Prev";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Favorites
            // 
            Favorites.ImageScalingSize = new Size(20, 20);
            Favorites.Name = "contextMenuStrip1";
            Favorites.Size = new Size(61, 4);
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(222, 302);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(368, 154);
            textBox2.TabIndex = 39;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(222, 510);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(368, 160);
            textBox3.TabIndex = 40;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(765, 76);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(364, 166);
            textBox4.TabIndex = 41;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(765, 293);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(364, 163);
            textBox5.TabIndex = 42;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Control;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(765, 510);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(364, 160);
            textBox6.TabIndex = 43;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1245, 11);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(227, 23);
            textBox7.TabIndex = 44;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(222, 85);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 154);
            textBox1.TabIndex = 51;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // price1
            // 
            price1.BackColor = SystemColors.Control;
            price1.BorderStyle = BorderStyle.None;
            price1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price1.Location = new Point(57, 213);
            price1.Name = "price1";
            price1.Size = new Size(379, 26);
            price1.TabIndex = 50;
            // 
            // name0
            // 
            name0.BackColor = SystemColors.Control;
            name0.BorderStyle = BorderStyle.None;
            name0.Location = new Point(211, 23);
            name0.Multiline = true;
            name0.Name = "name0";
            name0.Size = new Size(379, 48);
            name0.TabIndex = 49;
            name0.Text = "Se incarca...";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(57, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 208);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox_MouseDown;
            // 
            // button5
            // 
            button5.Location = new Point(1147, 134);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(218, 49);
            button5.TabIndex = 52;
            button5.Text = "Choose Product";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(1147, 8);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(92, 63);
            pictureBox7.TabIndex = 53;
            pictureBox7.TabStop = false;
            // 
            // searchbtn
            // 
            searchbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbtn.ForeColor = Color.DodgerBlue;
            searchbtn.Location = new Point(1386, 134);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(86, 49);
            searchbtn.TabIndex = 54;
            searchbtn.Text = "🔍";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += button3_Click_1;
            // 
            // Store
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(0, 300);
            ClientSize = new Size(1487, 684);
            Controls.Add(searchbtn);
            Controls.Add(pictureBox7);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(price1);
            Controls.Add(name0);
            Controls.Add(pictureBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(price6);
            Controls.Add(name5);
            Controls.Add(pictureBox6);
            Controls.Add(price5);
            Controls.Add(name4);
            Controls.Add(pictureBox5);
            Controls.Add(price4);
            Controls.Add(name3);
            Controls.Add(pictureBox4);
            Controls.Add(price3);
            Controls.Add(name2);
            Controls.Add(pictureBox3);
            Controls.Add(price2);
            Controls.Add(name1);
            Controls.Add(pictureBox2);
            Name = "Store";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox price2;
        private TextBox name1;
        private PictureBox pictureBox2;
        private TextBox price3;
        private TextBox name2;
        private PictureBox pictureBox3;
        private TextBox price4;
        private TextBox name3;
        private PictureBox pictureBox4;
        private TextBox price5;
        private TextBox name4;
        private PictureBox pictureBox5;
        private TextBox price6;
        private TextBox name5;
        private PictureBox pictureBox6;
        private Button button1;
        private Button button2;
        private ContextMenuStrip Favorites;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private TextBox textBox1;
        private TextBox price1;
        private TextBox name0;
        private PictureBox pictureBox1;
        private Button button5;
        private PictureBox pictureBox7;
        private Button searchbtn;
    }
}
