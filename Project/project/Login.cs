using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T3M77J9\MIRZA;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Enter Username and Password");
            }
            else if (UserName.Text == "fizza" || Password.Text == "1234"
                 || UserName.Text == "shazma" || Password.Text == "5678")
            {
                MainMenu menu = new MainMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username OR Password");
                UserName.Text = "";
                Password.Text = "";
            }
            con.Close();
        }


        private void button2_Click(object sender, EventArgs e)

        {
            Application.Exit();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}