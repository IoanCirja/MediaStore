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
    public partial class CompareForm : Form
    {
        public CompareForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void price1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompareForm_Load(object sender, EventArgs e)
        {
            price1.Text = Store._comparedList[0].price;
            price2.Text = Store._comparedList[1].price;
            price3.Text = Store._comparedList[2].price;


            textBox1.Text = Store._comparedList[0].description;
            textBox2.Text = Store._comparedList[1].description;
            textBox3.Text = Store._comparedList[2].description;


            name1.Text = Store._comparedList[0].name;
            name2.Text = Store._comparedList[1].name;
            name3.Text = Store._comparedList[2].name;


            pictureBox1.Image = Store._comparedList[0].image;
            pictureBox2.Image = Store._comparedList[1].image;

            pictureBox3.Image = Store._comparedList[2].image;





        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void price2_TextChanged(object sender, EventArgs e)
        {

        }

        private void name3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            Store._comparedList.Clear();
            this.Hide();
        }
    }
}
