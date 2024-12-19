using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO; 
using System.Windows.Forms;
using System.Drawing.Imaging;
using ExcelDataReader;


namespace MIS_PART_3
{
    public partial class Sales : Form
    {

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;


        public Sales()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\OneDrive\\Desktop\\MIS\\MISPART2.accdb");
        }
        void GetSales()
        {
            string query = "SELECT [Sales ID], [Date Sold], [Item ID], [Item Name], [Quantity], [Unit Price], [Total Price] FROM Sales";

            using (var connection = new OleDbConnection(conn.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (var adapter = new OleDbDataAdapter(query, connection))
                    {
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSales.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GetSales();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text) || string.IsNullOrWhiteSpace(tbIN.Text) ||
                string.IsNullOrWhiteSpace(tbQ.Text) || string.IsNullOrWhiteSpace(tbUP.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(tbQ.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Invalid quantity value.");
                return;
            }

            decimal unitPrice = decimal.Parse(tbUP.Text);
            decimal totalPrice = unitPrice * quantity;

            string checkStockQuery = "SELECT [Quantity] FROM Inventory WHERE [Item ID] = @itemId";
            string insertQuery = "INSERT INTO Sales ([Date Sold], [Item ID], [Item Name], [Quantity], [Unit Price], [Total Price]) " +
                                 "VALUES (@dateSold, @itemId, @itemName, @quantity, @unitPrice, @totalPrice)";
            string updateInventoryQuery = "UPDATE Inventory SET [Quantity] = [Quantity] - @quantity WHERE [Item ID] = @itemId";
           

            try
            {
                conn.Open();

                // Check available stock
                cmd = new OleDbCommand(checkStockQuery, conn);
                cmd.Parameters.AddWithValue("@itemId", tbID.Text);
                int availableStock = Convert.ToInt32(cmd.ExecuteScalar());

                if (availableStock < quantity)
                {
                    MessageBox.Show("Insufficient stock. Available quantity: " + availableStock);
                    return;
                }

                cmd = new OleDbCommand(insertQuery, conn);
                cmd.Parameters.Add("?", OleDbType.Date).Value = dtpDS.Value; // Date Sold
                cmd.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(tbID.Text); // Item ID (explicitly as Integer)
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = tbIN.Text; // Item Name
                cmd.Parameters.Add("?", OleDbType.Integer).Value = quantity; // Quantity
                cmd.Parameters.Add("?", OleDbType.Currency).Value = unitPrice; // Unit Price
                cmd.Parameters.Add("?", OleDbType.Currency).Value = totalPrice; // Total Price

                cmd.ExecuteNonQuery();

                // Update Inventory table
                cmd = new OleDbCommand(updateInventoryQuery, conn);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@itemId", tbID.Text);
                cmd.ExecuteNonQuery();



                MessageBox.Show("Sale recorded successfully and inventory updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                GetSales();
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbIN.Clear();
            tbQ.Clear();
            tbUP.Clear();
            tbTP.Clear();

            dtpDS.Value = DateTime.Now;


        }

        private void dgvINV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSales.CurrentRow != null)
            {
                var cells = dgvSales.CurrentRow.Cells;
                tbID.Text = cells[2]?.Value?.ToString() ?? string.Empty;
                tbIN.Text = cells[3]?.Value?.ToString() ?? string.Empty;
                tbQ.Text = cells[4]?.Value?.ToString() ?? string.Empty;
                tbUP.Text = cells[5]?.Value?.ToString() ?? string.Empty;
                tbTP.Text = cells[6]?.Value?.ToString() ?? string.Empty;

                if (DateTime.TryParse(cells[1]?.Value?.ToString(), out DateTime dateSold))
                {
                    dtpDS.Value = dateSold;
                }
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Register the encoding provider
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                    using (FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(fs))
                        {
                            // Read Excel data
                            var config = new ExcelDataSetConfiguration
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration
                                {
                                    UseHeaderRow = true // Use the first row as header
                                }
                            };

                            DataSet result = reader.AsDataSet(config);
                            DataTable excelData = result.Tables[0]; // First sheet

                            // Validate required columns
                            string[] requiredColumns = { "Item Name", "Quantity", "Unit Price", "Date Sold" };
                            foreach (string column in requiredColumns)
                            {
                                if (!excelData.Columns.Contains(column))
                                {
                                    MessageBox.Show($"Missing required column: {column}");
                                    return;
                                }
                            }

                            conn.Open(); // Open the connection before the transaction

                            using (var transaction = conn.BeginTransaction())
                            {
                                try
                                {
                                    foreach (DataRow row in excelData.Rows)
                                    {
                                        // Safely parse and validate each column
                                        string itemName = row["Item Name"].ToString().Trim();

                                        if (!int.TryParse(row["Quantity"].ToString(), out int quantity) || quantity <= 0)
                                        {
                                            Console.WriteLine($"Invalid or missing Quantity in row: {row}");
                                            continue; // Skip rows with invalid Quantity
                                        }

                                        if (!decimal.TryParse(row["Unit Price"].ToString(), out decimal unitPrice) || unitPrice <= 0)
                                        {
                                            Console.WriteLine($"Invalid or missing Unit Price in row: {row}");
                                            continue; // Skip rows with invalid Unit Price
                                        }

                                        // Validate and parse "Date Sold"
                                        if (!DateTime.TryParse(row["Date Sold"].ToString(), out DateTime dateSold))
                                        {
                                            Console.WriteLine($"Invalid or missing Date Sold in row: {row}");
                                            continue; // Skip rows with invalid Date Sold
                                        }

                                        decimal totalPrice = quantity * unitPrice;

                                        // Check inventory availability by item name and get the corresponding Item ID
                                        string inventoryQuery = "SELECT [Item ID], [Quantity] FROM Inventory WHERE [Item Name] = @itemName";
                                        cmd = new OleDbCommand(inventoryQuery, conn, transaction);
                                        cmd.Parameters.AddWithValue("@itemName", itemName);

                                        using (OleDbDataReader inventoryReader = cmd.ExecuteReader())
                                        {
                                            if (!inventoryReader.Read())
                                            {
                                                MessageBox.Show($"Item '{itemName}' not found in inventory.");
                                                continue; // Skip if item not found
                                            }

                                            int itemId = Convert.ToInt32(inventoryReader["Item ID"]);
                                            int currentInventory = Convert.ToInt32(inventoryReader["Quantity"]);

                                            if (currentInventory < quantity)
                                            {
                                                MessageBox.Show($"Insufficient stock for Item '{itemName}'. Requested: {quantity}, Available: {currentInventory}");
                                                continue; // Skip rows with insufficient inventory
                                            }

                                            // Insert into Sales table
                                            string insertQuery = "INSERT INTO Sales ([Date Sold], [Item ID], [Item Name], [Quantity], [Unit Price], [Total Price]) " +
                                                                 "VALUES (?, ?, ?, ?, ?, ?)";

                                            cmd = new OleDbCommand(insertQuery, conn, transaction);
                                            cmd.Parameters.Add("?", OleDbType.Date).Value = dateSold;
                                            cmd.Parameters.Add("?", OleDbType.Integer).Value = itemId; // Use Item ID
                                            cmd.Parameters.Add("?", OleDbType.VarChar).Value = itemName; // Use Item Name
                                            cmd.Parameters.Add("?", OleDbType.Integer).Value = quantity;
                                            cmd.Parameters.Add("?", OleDbType.Currency).Value = unitPrice;
                                            cmd.Parameters.Add("?", OleDbType.Currency).Value = totalPrice;

                                            cmd.ExecuteNonQuery();

                                            // Update Inventory table
                                            string updateInventoryQuery = "UPDATE Inventory SET [Quantity] = [Quantity] - ? WHERE [Item ID] = ?";
                                            cmd = new OleDbCommand(updateInventoryQuery, conn, transaction);
                                            cmd.Parameters.Add("?", OleDbType.Integer).Value = quantity;
                                            cmd.Parameters.Add("?", OleDbType.Integer).Value = itemId; // Use Item ID

                                            cmd.ExecuteNonQuery();
                                        }


                                    }

                                    transaction.Commit();
                                    MessageBox.Show("Import and inventory update completed successfully.");
                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Error during database operation: " + ex.Message);
                                }
                            }
                        }
                    }

                    GetSales(); // Refresh the sales data grid or UI
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading Excel file: " + ex.Message);
                }
                finally
                {
                    conn.Close(); // Ensure connection is closed
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text) || string.IsNullOrWhiteSpace(tbIN.Text) ||
        string.IsNullOrWhiteSpace(tbQ.Text) || string.IsNullOrWhiteSpace(tbUP.Text) ||
        string.IsNullOrWhiteSpace(tbTP.Text) || dtpDS.Value == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "UPDATE Sales SET [Date Sold]=@dateSold, [Item ID]=@itemId, [Item Name]=@itemName, " +
                           "[Quantity]=@quantity, [Unit Price]=@unitPrice, [Total Price]=@totalPrice " +
                           "WHERE [Sales ID]=@salesId";

            cmd = new OleDbCommand(query, conn);

            // Bind parameters
            cmd.Parameters.AddWithValue("@dateSold", dtpDS.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@itemId", tbID.Text);
            cmd.Parameters.AddWithValue("@itemName", tbIN.Text);
            cmd.Parameters.AddWithValue("@quantity", tbQ.Text);
            cmd.Parameters.AddWithValue("@unitPrice", tbUP.Text);
            cmd.Parameters.AddWithValue("@totalPrice", tbTP.Text);

            // Use the Sales ID from the currently selected row
            if (dgvSales.CurrentRow != null)
            {
                cmd.Parameters.AddWithValue("@salesId", Convert.ToInt32(dgvSales.CurrentRow.Cells["Sales ID"].Value));
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sale record successfully updated!");
                }
                else
                {
                    MessageBox.Show("No sale record was updated. Please ensure the selected sale exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                GetSales();
            }

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM Sales WHERE [Item ID] LIKE @search OR [Item Name] LIKE @search";
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\\Users\\Ryzen 3\\Desktop\\MIS\\MISPART2.accdb");

            try
            {
                conn.Open();
                adapter = new OleDbDataAdapter(searchQuery, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + tbSearch.Text + "%");

                dt = new DataTable();
                adapter.Fill(dt);
                dgvSales.DataSource = dt;
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

        private void btnInvData_Click(object sender, EventArgs e)
        {
            Inventory myForm = new Inventory();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnExpenData_Click(object sender, EventArgs e)
        {
            Expenses myForm = new Expenses();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbID.Text))
            {
                string query = "SELECT [Item Name], [Sell Price] FROM Inventory WHERE [Item ID] = @itemId";
                using (var connection = new OleDbConnection(conn.ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        using (var command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@itemId", tbID.Text);
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    tbIN.Text = reader["Item Name"].ToString();
                                    tbUP.Text = reader["Sell Price"].ToString();
                                }
                                else
                                {
                                    tbIN.Clear();
                                    tbUP.Clear();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void tbIN_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbIN.Text))
            {
                string query = "SELECT [Item ID], [Sell Price] FROM Inventory WHERE [Item Name] = @itemName";
                using (var connection = new OleDbConnection(conn.ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        using (var command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@itemName", tbIN.Text);
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    tbID.Text = reader["Item ID"].ToString();
                                    tbUP.Text = reader["Sell Price"].ToString();
                                }
                                else
                                {
                                    tbID.Clear();
                                    tbUP.Clear();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void tbQ_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbQ.Text, out int quantity) && decimal.TryParse(tbUP.Text, out decimal unitPrice))
            {
                tbTP.Text = (quantity * unitPrice).ToString();
            }
            else
            {
                tbTP.Clear();
            }
        }

        private void btnSaleData_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

            Reports myForm = new Reports();
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
