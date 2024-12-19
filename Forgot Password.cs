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
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }
        string connectionString = @"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\OneDrive\\Desktop\\MIS\\MISPART2.accdb;";
        private void button1_Click(object sender, EventArgs e)
        {
            // Get user input from textboxes
            string answer1 = tbAnswer1.Text.Trim();
            string answer2 = tbAnswer2.Text.Trim();
            string answer3 = tbAnswer3.Text.Trim();

            // Validate answers by querying the database
            bool isValid = ValidateSecurityAnswers(answer1, answer2, answer3);

            // If answers are correct, redirect to the main dashboard
            if (isValid)
            {
                MessageBox.Show("Answers are correct! Redirecting to the dashboard...");
                Dashboard myForm = new Dashboard();
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect answers. Please try again.");
            }
        }

        private bool ValidateSecurityAnswers(string answer1, string answer2, string answer3)
        {
            // Query the database to get the answers from the user
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to retrieve the answers from the database (assuming UserID is 1)
                    string query = "SELECT Answer1, Answer2, Answer3 FROM ForgotPass WHERE ID = '1'";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string correctAnswer1 = reader["Answer1"].ToString().Trim();
                        string correctAnswer2 = reader["Answer2"].ToString().Trim();
                        string correctAnswer3 = reader["Answer3"].ToString().Trim();

                        // Compare user input with the stored answers
                        return answer1.Equals(correctAnswer1, StringComparison.OrdinalIgnoreCase) &&
                               answer2.Equals(correctAnswer2, StringComparison.OrdinalIgnoreCase) &&
                               answer3.Equals(correctAnswer3, StringComparison.OrdinalIgnoreCase);
                    }
                    else
                    {
                        MessageBox.Show("No data found for the user.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login myForm = new Login();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
