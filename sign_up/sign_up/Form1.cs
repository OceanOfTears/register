namespace sign_up
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sign_in newForm = new sign_in(this);
            this.Hide();
            newForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sign_up newForm = new sign_up(this);
            this.Hide();
            newForm.Show();
        }
    }
}