using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO; 
using System.Windows.Forms;
using System.Drawing.Imaging; 



namespace MIS_PART_3
{
    public partial class Expenses : Form
    {

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;



        public Expenses()
        {
            InitializeComponent();
        }
        void GetEXP()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\OneDrive\\Desktop\\MIS\\MISPART2.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM Expenses", conn);
            conn.Open();
            adapter.Fill(dt);
            dgvEXPEN.DataSource = dt;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetEXP();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEN.Text) || string.IsNullOrWhiteSpace(tbA.Text) || string.IsNullOrWhiteSpace(tbS.Text) || dtpDOE.Value == null || string.IsNullOrWhiteSpace(tbS.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Expenses ([Expense Name], [Amount], [Date of Expense], [Supplier]) " +
                           "VALUES (@en, @a, @doe, @s)";
            cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@en", tbEN.Text);
            cmd.Parameters.AddWithValue("@a", tbA.Text);
            cmd.Parameters.AddWithValue("@doe", dtpDOE.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@s", tbS.Text);


            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Expense successfully added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                GetEXP();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            tbEN.Clear();
            tbA.Clear();
            tbS.Clear();
            dtpDOE.Value = DateTime.Now;


        }

        private void dgvINV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            tbEN.Text = dgvEXPEN.CurrentRow.Cells[1].Value.ToString();
            tbA.Text = dgvEXPEN.CurrentRow.Cells[2].Value.ToString();
            dtpDOE.Value = Convert.ToDateTime(dgvEXPEN.CurrentRow.Cells[3].Value);
            tbS.Text = dgvEXPEN.CurrentRow.Cells[4].Value.ToString();


        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEN.Text) || string.IsNullOrWhiteSpace(tbA.Text) ||
       string.IsNullOrWhiteSpace(tbS.Text) || dtpDOE.Value == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }


            string query = "UPDATE Expenses SET [Expense Name] = @en, [Amount] = @a, [Date of Expense] = @doe, " +
                           "[Supplier] = @s WHERE [Expense ID] = @id";


            cmd = new OleDbCommand(query, conn);


            cmd.Parameters.AddWithValue("@en", tbEN.Text);
            cmd.Parameters.AddWithValue("@a", tbA.Text);
            cmd.Parameters.AddWithValue("@doe", dtpDOE.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@s", tbS.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvEXPEN.CurrentRow.Cells[0].Value));

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Expense successfully updated!");
                }
                else
                {
                    MessageBox.Show("No expense was updated. Please ensure the selected item exists.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                GetEXP();
            }

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM Expenses WHERE [Expense Name] LIKE @search OR [Expense ID] LIKE @search";
            adapter = new OleDbDataAdapter(searchQuery, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + tbSearch.Text + "%");

            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            dgvEXPEN.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inventory myForm = new Inventory();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnExpenData_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSaleData_Click(object sender, EventArgs e)
        {
            Sales myForm = new Sales();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnDasboard_Click(object sender, EventArgs e)
        {
            Dashboard myForm = new Dashboard();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
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

        private void btnArchive_Click(object sender, EventArgs e)
        {
            Archive myForm = new Archive();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
