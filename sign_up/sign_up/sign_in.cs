using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace sign_up
{
    public partial class sign_in : Form
    {
        public sign_in()
        {
            InitializeComponent();
        }
        public sign_in(Form1 f)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\User\\Desktop\\яблочный спас всех спас\\c#\\sign_up\\sign_up\\bin\\Debug\\net6.0-windows\\data.xml";
            XDocument xdoc = XDocument.Load(path);
            string user = username.Text;
            string pass = password.Text;
            int count = xdoc.Descendants("login").Count();
            foreach (var userElement in xdoc.Descendants("user"))
            {
                int i = 0;
                i += 1;
                string loginValue = userElement.Element("login")?.Value;
                string passwordValue = userElement.Element("password")?.Value;
                string numberValue = userElement.Element("number")?.Value;
                string mailValue = userElement.Element("mail")?.Value;
                if (loginValue == user && passwordValue == pass)
                {

                    Form2 tmp = new Form2(user, pass, numberValue, mailValue);
                    tmp.Show();
                    this.Hide();
                    break;
                }
                if (i == count)
                {
                    MessageBox.Show("неверный логин и(или) пароль");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
