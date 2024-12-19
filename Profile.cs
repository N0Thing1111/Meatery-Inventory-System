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

namespace MIS_PART_3
{
    public partial class Profile : Form
    {
        private OleDbConnection conn;

        public Profile()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\OneDrive\\Desktop\\MIS\\MISPART2.accdb");
            LoadProfileData();
        }
        private void LoadProfileData()
        {
            try
            {
                conn.Open();

                // Load Account Data
                string accountQuery = "SELECT FullName, Password, Username FROM Account";
                using (var cmd = new OleDbCommand(accountQuery, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtFullName.Text = reader["FullName"].ToString();
                        txtPassword.Text = reader["Password"].ToString();
                        txtUsername.Text = reader["Username"].ToString();
                    }
                }

                // Load Security Answers Data (Corrected to use Answer1, Answer2, Answer3)
                string securityQuery = "SELECT Answer1, Answer2, Answer3 FROM ForgotPass";
                using (var cmd = new OleDbCommand(securityQuery, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtFirstCrush.Text = reader["Answer1"].ToString(); // First Crush Answer
                        txtFirstPet.Text = reader["Answer2"].ToString();   // First Pet Answer
                        txtCityBorn.Text = reader["Answer3"].ToString();   // City Born In Answer
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtUsername.ReadOnly = false;
            txtFullName.ReadOnly = false;
            txtFirstCrush.ReadOnly = false;
            txtFirstPet.ReadOnly = false;
            txtCityBorn.ReadOnly = false;
            btnSave.Visible = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // Enable Password Fields
            txtPassword.ReadOnly = false;
            txtReenterPassword.ReadOnly = false;
            btnConfirmPassword.Visible = true;
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtReenterPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            try
            {
                conn.Open();

                // Update Password
                string updatePasswordQuery = "UPDATE Account SET [Password] = ? WHERE [Username] = ?";
                using (var cmd = new OleDbCommand(updatePasswordQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", txtPassword.Text);
                    cmd.Parameters.AddWithValue("?", txtUsername.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Password updated successfully.");

                // Reset Fields
                txtPassword.ReadOnly = true;
                txtReenterPassword.ReadOnly = true;
                btnConfirmPassword.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Update Username and Full Name
                string updateAccountQuery = "UPDATE Account SET [FullName] = ?, [Username] = ?";
                using (var cmd = new OleDbCommand(updateAccountQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", txtFullName.Text);
                    cmd.Parameters.AddWithValue("?", txtUsername.Text);
                    cmd.ExecuteNonQuery();
                }

                // Update Security Answers
                string updateSecurityQuery = "UPDATE ForgotPass SET [Answer1] = ?, [Answer2] = ?, [Answer3] = ?";
                using (var cmd = new OleDbCommand(updateSecurityQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", txtFirstCrush.Text);
                    cmd.Parameters.AddWithValue("?", txtFirstPet.Text);
                    cmd.Parameters.AddWithValue("?", txtCityBorn.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Profile updated successfully.");

                // Reset Fields
                txtUsername.ReadOnly = true;
                txtFullName.ReadOnly = true;
                txtFirstCrush.ReadOnly = true;
                txtFirstPet.ReadOnly = true;
                txtCityBorn.ReadOnly = true;
                btnSave.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving profile data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login myForm = new Login();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnInvData_Click(object sender, EventArgs e)
        {
            Inventory myForm = new Inventory();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnSaleData_Click(object sender, EventArgs e)
        {
            Sales myForm = new Sales();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Expenses myForm = new Expenses();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports myForm = new Reports();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile myForm = new Profile();
            this.Hide();    
            myForm.ShowDialog();
            this.Close();
        }

        private void btnDasboard_Click(object sender, EventArgs e)
        {
            Dashboard myForm = new Dashboard();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            Archive myForm = new Archive();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
