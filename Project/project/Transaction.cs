using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T3M77J9\MIRZA;Integrated Security=True");
        int Bal;
        private void CheckBalance()
        {
            con.Open();
            string query = "select * from AccountTb1 where ACCNum=" + amountCHK.Text + "";
            SqlCommand cmd = new SqlCommand(query,con);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                BalanceLabel.Text = "$"+dr["ACBal"].ToString();
                Bal = Convert.ToInt32(dr["ACBal"].ToString());
            }
            con.Close();
        }
        private void CheckAvailableBalance()
        {
            //con.Open();
            string query = "select * from AccountTb1 where ACCNum=" + TransferFrom.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                label3.Text = "$" + dr["ACBal"].ToString();
                Bal = Convert.ToInt32(dr["ACBal"].ToString());
            }
            //con.Close();
        }
        private void GetNewBalance()
        {
            con.Open();
            string query = "select * from AccountTb1 where ACCNum='" + amountCHK.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //BalanceLabel.Text = "$" + dr["ACBal"].ToString();
                Bal = Convert.ToInt32(dr["ACBal"].ToString());
            }
            con.Close();
        }
        private void Transaction_Load(object sender, EventArgs e)
        {

        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (amountCHK.Text == "")
            {
                MessageBox.Show("Enter Account Number");
            }
            else
            {
                CheckBalance();
                if (BalanceLabel.Text == "YourBalance")
                {
                    MessageBox.Show("Account Not Found");
                    amountCHK.Text = "";
                }
            }
        }

        private void withdrawACC_TextChanged(object sender, EventArgs e)
        {

        }
        private void deposit()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTb1 (TName,TDate,TAmt,TACNum)values(@TN,@TD,@TA,@TAC)", con);
                cmd.Parameters.AddWithValue("@TN", "Deposit");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", DepositAmount.Text);
                cmd.Parameters.AddWithValue("@TAC", DepositAcc.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void Withdraw()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTb1 (TName,TDate,TAmt,TACNum)values(@TN,@TD,@TA,@TAC)", con);
                cmd.Parameters.AddWithValue("@TN", "Withdraw");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", withdrawAmount.Text);
                cmd.Parameters.AddWithValue("@TAC", withdrawACC.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void SubstractBal()
        {
            GetNewBalance();
            int newBal = Bal - Convert.ToInt32(TransferAmount.Text);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update AccountTb1 set ACBal=@AB where ACCNum=@AcKey", con);
                cmd.Parameters.AddWithValue("@AB", newBal);
                cmd.Parameters.AddWithValue("@AcKey", TransferFrom.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddBal()
        {
            GetNewBalance();
            int newBal = Bal + Convert.ToInt32(TransferAmount.Text);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update AccountTb1 set ACBal=@AB where ACCNum=@AcKey", con);
                cmd.Parameters.AddWithValue("@AB", newBal);
                cmd.Parameters.AddWithValue("@AcKey", TransferTo.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Deposit_Click(object sender, EventArgs e)
        {
            if (DepositAcc.Text == "" || DepositAmount.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                deposit();
                GetNewBalance();
                int newBal=Bal+Convert.ToInt32(DepositAmount.Text);
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTb1 set ACBal=@AB where ACCNum=@AcKey", con);
                    cmd.Parameters.AddWithValue("@AB", newBal);
                    cmd.Parameters.AddWithValue("@AcKey", DepositAcc.Text );
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Deposit !!!");
                    con.Close();
                    DepositAcc.Text = "";
                    DepositAmount.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            if (withdrawACC.Text == "" || withdrawAmount.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                Withdraw();
                GetNewBalance();
                if (Bal < Convert.ToInt32(withdrawAmount.Text))
                {
                    MessageBox.Show("Insufisiant Balance");
                }
                else
                {
                    int newBal = Bal - Convert.ToInt32(withdrawAmount.Text);
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Update AccountTb1 set ACBal=@AB where ACCNum=@AcKey", con);
                        cmd.Parameters.AddWithValue("@AB", newBal);
                        cmd.Parameters.AddWithValue("@AcKey", withdrawACC.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Amount Withdrawn !!!");
                        con.Close();
                        withdrawAmount.Text = "";
                        withdrawACC.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (TransferFrom.Text == "")
            {
                MessageBox.Show("Enter Source Account number");
            }
            else 
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from AccountTb1 where ACCNum=@AcKey", con);
                cmd.Parameters.AddWithValue("@AcKey", TransferFrom.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CheckAvailableBalance();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Account Does not Exist");
                    TransferFrom.Text = "";
                }
            con.Close();
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (TransferTo.Text == "")
            {
                MessageBox.Show("Enter Destination Account number");
            }
            else
            {
                con.Open(); 
                SqlCommand cmd = new SqlCommand("select count(*) from AccountTb1 where ACCNum=@AcKey", con);
                cmd.Parameters.AddWithValue("@AcKey", TransferTo.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CheckAvailableBalance();
                    MessageBox.Show("Account Found");
                    con.Close();
                    if (TransferTo.Text == TransferFrom.Text)
                    {
                        MessageBox.Show("Source and Destination Accounts are same");
                        TransferTo.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Account Does not Exist");
                    TransferTo.Text = "";
                }
                con.Close();
            }
        }
        private void transfer()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransferTb1 (TrSrc,TrDest,TrAmt,TrDate)values(@TrS,@TrD,@TrA,@TrDt)", con);
                cmd.Parameters.AddWithValue("@TrS", TransferFrom.Text);
                cmd.Parameters.AddWithValue("@TrD", TransferTo.Text);
                cmd.Parameters.AddWithValue("@TrA", TransferAmount.Text);
                cmd.Parameters.AddWithValue("@TrDt", DateTime.Now.Date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Money Transfered");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void Transfer_Click(object sender, EventArgs e)
        {
            if (TransferTo.Text == "" || TransferFrom.Text == "" || TransferAmount.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (Convert.ToInt16(TransferAmount.Text) > Bal)
            {
                MessageBox.Show("Insufisiant Balance");
            }
            else
            {
                transfer();
                SubstractBal();
                AddBal();
                TransferFrom.Text = "";
                TransferTo.Text = "";
                TransferAmount.Text = "";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
