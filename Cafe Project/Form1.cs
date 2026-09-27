using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace Cafe_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            ds.Show();
            this.Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "yasha.unzila" && txtPassword.Text == "pass")
            {
                Dashboard ds = new Dashboard("Admin");
                ds.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
