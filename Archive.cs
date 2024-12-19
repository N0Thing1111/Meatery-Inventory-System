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
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MIS_PART_3
{
    public partial class Archive : Form
    {


        private OleDbConnection conn;
        private OleDbCommand cmd;
        private OleDbDataAdapter adapter;
        private DataTable archiveTable;
        public Archive()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider = Microsoft.ACE.OleDb.12.0; Data Source = C:\\Users\\Lenovo\\OneDrive\\Desktop\\MIS\\MISPART2.accdb");
            LoadArchiveData();
        }
        private void LoadArchiveData()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close(); // Ensure any previous connection is closed
                }

                conn.Open(); // Open the connection

                string query = "SELECT * FROM InventoryArchive";
                adapter = new OleDbDataAdapter(query, conn);
                archiveTable = new DataTable();
                adapter.Fill(archiveTable);
                dgvArchive.DataSource = archiveTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading archive data: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close(); // Close the connection in the finally block
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Archive_Load(object sender, EventArgs e)
        {

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (dgvArchive.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvArchive.SelectedRows[0];

                // Extract necessary fields from the selected row
                string itemId = selectedRow.Cells["Item ID"].Value.ToString();
                string itemName = selectedRow.Cells["Item Name"].Value.ToString();
                string batchId = selectedRow.Cells["Batch ID"].Value.ToString();
                int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                string unit = selectedRow.Cells["Unit"].Value.ToString();
                decimal costPrice = Convert.ToDecimal(selectedRow.Cells["Cost Price"].Value);
                decimal sellPrice = Convert.ToDecimal(selectedRow.Cells["Sell Price"].Value);
                DateTime expiryDate = Convert.ToDateTime(selectedRow.Cells["Expiry/Best Before"].Value);
                string supplier = selectedRow.Cells["Supplier"].Value.ToString();
                DateTime dateRestored = DateTime.Now;

                try
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close(); // Ensure previous connection is closed
                    }

                    conn.Open();

                    // Step 1: Insert record into Inventory
                    string restoreQuery = "INSERT INTO Inventory ([Item ID], [Item Name], [Batch ID], [Quantity], [Unit], [Cost Price], [Sell Price], [Expiry/Best Before], [Supplier], [Date of Submission]) " +
                                          "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                    cmd = new OleDbCommand(restoreQuery, conn);
                    cmd.Parameters.AddWithValue("?", itemId);
                    cmd.Parameters.AddWithValue("?", itemName);
                    cmd.Parameters.AddWithValue("?", batchId);
                    cmd.Parameters.AddWithValue("?", quantity);
                    cmd.Parameters.AddWithValue("?", unit);
                    cmd.Parameters.AddWithValue("?", costPrice);
                    cmd.Parameters.AddWithValue("?", sellPrice);
                    cmd.Parameters.AddWithValue("?", expiryDate.ToString("MM/dd/yyyy"));
                    cmd.Parameters.AddWithValue("?", supplier);
                    cmd.Parameters.AddWithValue("?", dateRestored.ToString("MM/dd/yyyy"));
                    cmd.ExecuteNonQuery();

                    // Step 2: Delete record from InventoryArchive
                    string deleteQuery = "DELETE FROM InventoryArchive WHERE [Item ID] = ? AND [Batch ID] = ?";
                    cmd = new OleDbCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("?", itemId);
                    cmd.Parameters.AddWithValue("?", batchId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Item restored successfully.");
                    LoadArchiveData(); // Refresh the archive table
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error restoring item: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close(); // Ensure the connection is always closed
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to restore.");
            }
        }

        private void btnDeletePermanently_Click(object sender, EventArgs e)
        {
            if (dgvArchive.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvArchive.SelectedRows[0];
                int archivedId = Convert.ToInt32(selectedRow.Cells["Archive ID"].Value);

                try
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM InventoryArchive WHERE [Archive ID] = ?";
                    cmd = new OleDbCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("?", archivedId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Item deleted permanently.");
                    LoadArchiveData(); // Refresh the archive table
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting item: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void btnRollback_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to rollback to the latest backup?",
                                                   "Confirm Rollback", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        // Clear current data
                        string clearInventory = "DELETE FROM Inventory";
                        string clearSales = "DELETE FROM Sales";
                        string clearExpenses = "DELETE FROM Expenses";

                        ExecuteNonQuery(clearInventory, conn, transaction);
                        ExecuteNonQuery(clearSales, conn, transaction);
                        ExecuteNonQuery(clearExpenses, conn, transaction);

                        // Restore from backup
                        string restoreInventory = "INSERT INTO Inventory SELECT * FROM InventoryBackup";
                        string restoreSales = "INSERT INTO Sales SELECT * FROM SalesBackup";
                        string restoreExpenses = "INSERT INTO Expenses SELECT * FROM ExpensesBackup";

                        ExecuteNonQuery(restoreInventory, conn, transaction);
                        ExecuteNonQuery(restoreSales, conn, transaction);
                        ExecuteNonQuery(restoreExpenses, conn, transaction);

                        transaction.Commit();
                        MessageBox.Show("Rollback to backup completed successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during rollback: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Dashboard myForm = new Dashboard();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnSaveBackup_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    // Clear existing backup data
                    string clearInventoryBackup = "DELETE FROM InventoryBackup";
                    string clearSalesBackup = "DELETE FROM SalesBackup";
                    string clearExpensesBackup = "DELETE FROM ExpensesBackup";

                    ExecuteNonQuery(clearInventoryBackup, conn, transaction);
                    ExecuteNonQuery(clearSalesBackup, conn, transaction);
                    ExecuteNonQuery(clearExpensesBackup, conn, transaction);

                    // Save current data to backup
                    string saveInventoryBackup = "INSERT INTO InventoryBackup SELECT * FROM Inventory";
                    string saveSalesBackup = "INSERT INTO SalesBackup SELECT * FROM Sales";
                    string saveExpensesBackup = "INSERT INTO ExpensesBackup SELECT * FROM Expenses";

                    ExecuteNonQuery(saveInventoryBackup, conn, transaction);
                    ExecuteNonQuery(saveSalesBackup, conn, transaction);
                    ExecuteNonQuery(saveExpensesBackup, conn, transaction);

                    transaction.Commit();
                    MessageBox.Show("Backup saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving backup: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void ExecuteNonQuery(string query, OleDbConnection connection, OleDbTransaction transaction)
        {
            using (cmd = new OleDbCommand(query, connection, transaction))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete ALL data from Inventory, Sales, and Expenses? This action cannot be undone.",
                                                   "Confirm Clear All", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        // Clear all data
                        string clearInventory = "DELETE FROM Inventory";
                        string clearSales = "DELETE FROM Sales";
                        string clearExpenses = "DELETE FROM Expenses";

                        ExecuteNonQuery(clearInventory, conn, transaction);
                        ExecuteNonQuery(clearSales, conn, transaction);
                        ExecuteNonQuery(clearExpenses, conn, transaction);

                        transaction.Commit();
                        MessageBox.Show("All data cleared successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error clearing all data: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inventory myForm = new Inventory();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sales myForm = new Sales();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Expenses myForm = new Expenses();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reports myForm = new Reports();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            Profile myForm = new Profile();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
