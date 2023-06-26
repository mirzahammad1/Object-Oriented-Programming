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
    public partial class addAcc : Form
    {
        public addAcc()
        {
            InitializeComponent();
            DisplyAccount(); 
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T3M77J9\MIRZA;Integrated Security=True");
        int Key = 0;

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Account");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AccountTb1 where ACCNum=@AcKey", con);
                    cmd.Parameters.AddWithValue("@AcKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Deleted !!!");
                    con.Close();
                    Reset();
                    DisplyAccount();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    throw;
                }
            }
        }
        private void DisplyAccount()
        {
            con.Open();
            string Query = "select * from AccountTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AccountDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Reset()
        {
            ACNameTb.Text = "";
            ACPhoneTh.Text = "";
            ACaddressTb.Text = "";
            ACGen.SelectedIndex = -1;
            ACOucc.Text = "";
            ACInc.Text = "";
        }
        private void Submitbtn_Click(object sender, EventArgs e)
        {
            if (ACNameTb.Text == "" || ACPhoneTh.Text == "" || ACaddressTb.Text == "" ||
                ACGen.SelectedIndex == -1 || ACOucc.Text == "" ||ACInc.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand ("insert into AccountTb1 (ACName,ACPhone,ACAddress,ACGen,ACOccup,ACInc,ACBal) values (@AN,@AP,@AA,@AG,@AO,@AI,@AB)",con);
                    cmd.Parameters.AddWithValue("@AN",ACNameTb.Text);
                    cmd.Parameters.AddWithValue("@AP",ACPhoneTh.Text);
                    cmd.Parameters.AddWithValue("@AA",ACaddressTb.Text);
                    cmd.Parameters.AddWithValue("@AG",ACGen.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO",ACOucc.Text);
                    cmd.Parameters.AddWithValue("@AI",ACInc.Text);
                    cmd.Parameters.AddWithValue("@AB",0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created !!!");
                    con.Close();
                    Reset();
                    DisplyAccount();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    throw;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccountDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ACNameTb.Text = AccountDGV.SelectedRows[0].Cells[1].Value.ToString();
            ACPhoneTh.Text = AccountDGV.SelectedRows[0].Cells[2].Value.ToString();
            ACaddressTb.Text = AccountDGV.SelectedRows[0].Cells[3].Value.ToString();
            ACGen.SelectedItem = AccountDGV.SelectedRows[0].Cells[4].Value.ToString();
            ACOucc.Text = AccountDGV.SelectedRows[0].Cells[5].Value.ToString();
            ACInc.Text = AccountDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (ACNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AccountDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (ACNameTb.Text == "" || ACPhoneTh.Text == "" || ACaddressTb.Text == "" ||
                ACGen.SelectedIndex == -1 || ACOucc.Text == "" || ACInc.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update AccountTb1 set ACName=@AC,ACPhone=@AP,ACAddress=@AA,ACGen=@AG,ACOccup=@AO,ACInc=@AI where ACCNum=@AcKey", con);
                    cmd.Parameters.AddWithValue("@AN", ACNameTb.Text);
                    cmd.Parameters.AddWithValue("@AP", ACPhoneTh.Text);
                    cmd.Parameters.AddWithValue("@AA", ACaddressTb.Text);
                    cmd.Parameters.AddWithValue("@AG", ACGen.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", ACOucc.Text);
                    cmd.Parameters.AddWithValue("@AI", ACInc.Text);
                    cmd.Parameters.AddWithValue("@AcKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Updated !!!");
                    con.Close();
                    Reset();
                    DisplyAccount();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    throw;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void addAcc_Load(object sender, EventArgs e)
        {

        }

        private void ACPhoneTh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
