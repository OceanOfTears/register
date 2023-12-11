using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml;

namespace sign_up
{
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }

        public sign_up(Form1 f)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string mail = email.Text;
            string pass = password.Text;
            string phone = phone_number.Text;
            string pass2 = password2.Text;
            if (pass == pass2)
            {
                string path = "C:\\Users\\User\\Desktop\\яблочный спас всех спас\\c#\\sign_up\\sign_up\\bin\\Debug\\net6.0-windows\\data.xml";
                if (user.Trim() == "" || mail.Trim() == "" || pass.Trim() == "" || phone.Trim() == "")
                {
                    MessageBox.Show("oшибка, заполните все поля.");
                }
                else
                {

                    XmlDocument xml = new XmlDocument();
                    try
                    {
                        xml.Load(path);
                    }
                    catch (Exception)
                    {
                        XmlDeclaration newdoc = xml.CreateXmlDeclaration("1.0", "UTF-8", null);
                        xml.AppendChild(newdoc);
                        XmlElement root = xml.CreateElement("data");
                        xml.AppendChild(root);
                        xml.Save("data.xml");
                    }
                    XmlElement suser = xml.CreateElement("user");
                    XmlElement reg = xml.CreateElement("login");
                    XmlElement gmail = xml.CreateElement("mail");
                    XmlElement number = xml.CreateElement("number");
                    XmlElement pswrd = xml.CreateElement("password");

                    reg.InnerText = user;
                    gmail.InnerText = mail;
                    number.InnerText = phone;
                    pswrd.InnerText = pass;

                    suser.AppendChild(reg);
                    suser.AppendChild(gmail);
                    suser.AppendChild(number);
                    suser.AppendChild(pswrd);
                    xml.DocumentElement.AppendChild(suser);
                    xml.Save("data.xml");

                    MessageBox.Show("registred!!");
                    Form1 newForm = new Form1();
                    newForm.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("пароли не совпадают, повторите попытку");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Close();
        }
    }
}
