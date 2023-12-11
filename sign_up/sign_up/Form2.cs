using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sign_up
{
    public partial class Form2 : Form
    {
        public Form2(string user, string pass, string numberValue, string mailValue)
        {
            InitializeComponent();
            label1.Text = user;
            label2.Text = mailValue;
            label3.Text = numberValue;
            label4.Text = pass;

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public  void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sign_in newForm = new sign_in();
            newForm.Show();
            this.Close();
        }
    }
}
