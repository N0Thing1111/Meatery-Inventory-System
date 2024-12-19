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
    public partial class Dashboard : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\OneDrive\\Desktop\\MIS\\MISPART2.accdb;";
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadTotalRevenue();
            LoadTotalExpenses();
            DisplayTopSeller();
            DisplayLowStock();
            LoadInventoryGrid();
            LoadTotalUnitsSold();

        }
        private void LoadTotalRevenue()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM([Total Price]) FROM Sales WHERE [Date Sold] >= Date()-7";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    tbRevenue.Text = result != DBNull.Value ? $"₱{result:N2}" : "₱0.00";
                }
            }
        }

        private void LoadTotalExpenses()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(Amount) FROM Expenses WHERE [Date of Expense] >= Date()-7";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    tbExpenses.Text = result != DBNull.Value ? $"₱{result:N2}" : "₱0.00";
                }
            }
        }
        private void DisplayTopSeller()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT TOP 1 [Item Name], SUM([Quantity]) AS TotalSold
            FROM Sales
            WHERE [Date Sold] >= Date() - 7
            GROUP BY [Item Name]
            ORDER BY SUM([Quantity]) DESC";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblBestSeller.Text = $"{reader["Item Name"]} ({reader["TotalSold"]} sold)";
                        }
                        else
                        {
                            lblBestSeller.Text = "No sales data available.";
                        }
                    }
                }
            }
        }
        private void DisplayLowStock()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT [Item Name] FROM Inventory WHERE Quantity <= 3";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            lblLowStock.Text = "" + string.Join(", ",
                                reader.Cast<IDataRecord>().Select(r => r["Item Name"].ToString()));
                        }
                        else
                        {
                            lblLowStock.Text = "Sufficient Stock.";
                        }
                    }
                }
            }
        }


        private void LoadTotalUnitsSold()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(Quantity) FROM Sales WHERE [Date Sold] >= Date()-7";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    tbSold.Text = result != DBNull.Value ? result.ToString() : "0";
                }
            }
        }

        private void LoadInventoryGrid()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT [Item ID], [Item Name], Quantity, [Unit], [Sell Price], [Expiry/Best Before] FROM Inventory";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable inventoryTable = new DataTable();
                    adapter.Fill(inventoryTable);
                    dgvINV.DataSource = inventoryTable;
                }
            }
        }

        private void lblLowStock_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventory myForm = new Inventory();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sales myForm = new Sales();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Expenses myForm = new Expenses();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports myForm = new Reports();
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile myForm = new Profile();
            this.Hide();
            myForm.ShowDialog();
            this.Close();

        }
    }
 }

