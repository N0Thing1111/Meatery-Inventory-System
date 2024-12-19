using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO; 
using System.Windows.Forms;
using System.Drawing.Imaging; 



namespace MIS_PART_3
{
    public partial class Inventory : Form
    {

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;


        public Inventory()
        {
            InitializeComponent();
        }
        void GetINV()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\OneDrive\\Desktop\\MIS\\MISPART2.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM Inventory", conn);
            conn.Open();
            adapter.Fill(dt);
            dgvINV.DataSource = dt;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetINV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIN.Text) || string.IsNullOrWhiteSpace(tbBID.Text) ||
        string.IsNullOrWhiteSpace(tbQ.Text) || string.IsNullOrWhiteSpace(tbU.Text) ||
        string.IsNullOrWhiteSpace(tbCP.Text) || string.IsNullOrWhiteSpace(tbSP.Text) ||
        dtpEXP.Value == null || string.IsNullOrWhiteSpace(tbS.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Inventory ([Item Name], [Batch ID], [Quantity], [Unit], [Cost Price], [Sell Price], [Expiry/Best Before], [Supplier], [Date of Submission]) " +
                           "VALUES (@in, @bid, @q, @u, @cp, @sp, @exp, @s, @dos)";
            cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@in", tbIN.Text);
            cmd.Parameters.AddWithValue("@bid", tbBID.Text);
            cmd.Parameters.AddWithValue("@q", tbQ.Text);
            cmd.Parameters.AddWithValue("@u", tbU.Text);
            cmd.Parameters.AddWithValue("@cp", tbCP.Text);
            cmd.Parameters.AddWithValue("@sp", tbSP.Text);
            cmd.Parameters.AddWithValue("@exp", dtpEXP.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@s", tbS.Text);
            cmd.Parameters.AddWithValue("@dos", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item successfully added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                GetINV(); // Refresh the DataGridView
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbIN.Clear();
            tbBID.Clear();
            tbQ.Clear();
            tbU.Clear();
            tbCP.Clear();
            tbSP.Clear();
            dtpEXP.Value = DateTime.Now;
            tbS.Clear();

        }

        private void dgvINV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            tbIN.Text = dgvINV.CurrentRow.Cells[1].Value.ToString();
            tbBID.Text = dgvINV.CurrentRow.Cells[2].Value.ToString();
            tbQ.Text = dgvINV.CurrentRow.Cells[3].Value.ToString();
            tbU.Text = dgvINV.CurrentRow.Cells[4].Value.ToString();
            tbCP.Text = dgvINV.CurrentRow.Cells[5].Value.ToString();
            tbSP.Text = dgvINV.CurrentRow.Cells[6].Value.ToString();
            dtpEXP.Value = Convert.ToDateTime(dgvINV.CurrentRow.Cells[7].Value);
            tbS.Text = dgvINV.CurrentRow.Cells[8].Value.ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the current item details
            int itemId = Convert.ToInt32(dgvINV.CurrentRow.Cells[0].Value);
            string itemName = dgvINV.CurrentRow.Cells[1].Value.ToString();
            string batchId = dgvINV.CurrentRow.Cells[2].Value.ToString();
            int quantity = Convert.ToInt32(dgvINV.CurrentRow.Cells[3].Value);
            string unit = dgvINV.CurrentRow.Cells[4].Value.ToString();
            decimal costPrice = Convert.ToDecimal(dgvINV.CurrentRow.Cells[5].Value);
            decimal sellPrice = Convert.ToDecimal(dgvINV.CurrentRow.Cells[6].Value);
            DateTime expiry = Convert.ToDateTime(dgvINV.CurrentRow.Cells[7].Value);
            string supplier = dgvINV.CurrentRow.Cells[8].Value.ToString();
            DateTime dateOfSubmission = Convert.ToDateTime(dgvINV.CurrentRow.Cells[9].Value);
            DateTime dateArchived = DateTime.Now;

            try
            {
                conn.Open();

                // Step 1: Insert the item into the InventoryArchive table
                string archiveQuery = "INSERT INTO InventoryArchive ([Item ID], [Item Name], [Batch ID], [Quantity], [Unit], " +
                                      "[Cost Price], [Sell Price], [Expiry/Best Before], [Supplier], [Date of Submission], [Date Archived]) " +
                                      "VALUES (@id, @name, @batch, @quantity, @unit, @cost, @sell, @expiry, @supplier, @submission, @archived)";
                cmd = new OleDbCommand(archiveQuery, conn);
                cmd.Parameters.AddWithValue("@id", itemId);
                cmd.Parameters.AddWithValue("@name", itemName);
                cmd.Parameters.AddWithValue("@batch", batchId);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@unit", unit);
                cmd.Parameters.AddWithValue("@cost", costPrice);
                cmd.Parameters.AddWithValue("@sell", sellPrice);
                cmd.Parameters.AddWithValue("@expiry", expiry.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@supplier", supplier);
                cmd.Parameters.AddWithValue("@submission", dateOfSubmission.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@archived", dateArchived.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();

                // Step 2: Delete the item from the Inventory table
                string deleteQuery = "DELETE FROM Inventory WHERE [Item ID] = @id";
                cmd = new OleDbCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@id", itemId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Item has been archived successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error archiving item: " + ex.Message);
            }
            finally
            {
                conn.Close();
                GetINV(); // Refresh the DataGridView
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIN.Text) || string.IsNullOrWhiteSpace(tbBID.Text) ||
        string.IsNullOrWhiteSpace(tbQ.Text) || string.IsNullOrWhiteSpace(tbU.Text) ||
        string.IsNullOrWhiteSpace(tbCP.Text) || string.IsNullOrWhiteSpace(tbSP.Text) ||
        dtpEXP.Value == null || string.IsNullOrWhiteSpace(tbS.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "UPDATE Inventory SET [Item Name]=@in, [Batch ID]=@bid, [Quantity]=@q, [Unit]=@u, " +
                           "[Cost Price]=@cp, [Sell Price]=@sp, [Expiry/Best Before]=@exp, [Supplier]=@s, [Date Updated]=@du WHERE [Item ID]=@id";

            cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@in", tbIN.Text);
            cmd.Parameters.AddWithValue("@bid", tbBID.Text);
            cmd.Parameters.AddWithValue("@q", tbQ.Text);
            cmd.Parameters.AddWithValue("@u", tbU.Text);
            cmd.Parameters.AddWithValue("@cp", tbCP.Text);
            cmd.Parameters.AddWithValue("@sp", tbSP.Text);
            cmd.Parameters.AddWithValue("@exp", dtpEXP.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@s", tbS.Text);
            cmd.Parameters.AddWithValue("@du", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvINV.CurrentRow.Cells[0].Value));

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item successfully updated!");
                }
                else
                {
                    MessageBox.Show("No item was updated. Please ensure the selected item exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                GetINV();
            }

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM Inventory WHERE [Item Name] LIKE @search OR [Batch ID] LIKE @search";
            adapter = new OleDbDataAdapter(searchQuery, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + tbSearch.Text + "%");

            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            dgvINV.DataSource = dt;

        }

        private void btnInvData_Click(object sender, EventArgs e)
        {

        }

        private void btnExpenData_Click(object sender, EventArgs e)
        {
            Expenses myForm = new Expenses();
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
