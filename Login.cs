using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Imaging;
using static System.Windows.Forms.DataFormats;
using System.Net.Mail;
using System.Net;


namespace MIS_PART_3
{
    public partial class Login : Form
    {

        OleDbConnection conn;
        OleDbCommand cmd;


        private int loginAttempts = 0;
        public Login()
        {
            InitializeComponent();

        }
        private void Login_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\OneDrive\\Desktop\\MIS\\MISPART2.accdb");
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {

           
            if (string.IsNullOrWhiteSpace(tbUser.Text) || string.IsNullOrWhiteSpace(tbPass.Text))
            {
                MessageBox.Show("Please fill in both Username and Password.");
                return;
            }

         
            string query = "SELECT COUNT(*) FROM Account WHERE Username = @username AND [Password] = @password";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", tbUser.Text);
            cmd.Parameters.AddWithValue("@password", tbPass.Text);

            try
            {
                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Login successful!");
                    
                    Dashboard myForm = new Dashboard();
                    this.Hide();
                    myForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {

            Forgot_Password myForm = new Forgot_Password();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                tbPass.PasswordChar = '\0'; 
            }
            else
            {
                tbPass.PasswordChar = '*'; 
            }
        }
    }
}

