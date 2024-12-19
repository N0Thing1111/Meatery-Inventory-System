using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Org.BouncyCastle.Security;


namespace MIS_PART_3
{
    public partial class Reports : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\\Users\\Lenovo\\OneDrive\\Desktop\\MIS\\MISPART2.accdb;";
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            LoadInventoryData(startDate, endDate); // Pass date range to filter inventory
            LoadSalesData(startDate, endDate);
            LoadExpensesData(startDate, endDate);
            CalculateSummary(startDate, endDate);
        }

        private void LoadInventoryData(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT [Item Name], [Quantity], [Unit], [Cost Price], [Sell Price] " +
                   "FROM Inventory WHERE [Date of Submission] BETWEEN ? AND ?";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("?", startDate.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("?", endDate.ToString("MM/dd/yyyy"));

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Debugging: Print rows to ensure data is retrieved
                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine(string.Join(", ", row.ItemArray));
                    }

                    dgvInventory.DataSource = null;
                    dgvInventory.DataSource = dt; // Update DataGridView
                }
            }
        }
        private void LoadSalesData(DateTime startDate, DateTime endDate)
        {
            // Query to select only required fields and format the date
            string query = "SELECT [Sales ID], Format([Date Sold], 'MM/dd/yyyy') AS [Date Sold], [Item Name], [Quantity], [Total Price] " +
                           "FROM Sales WHERE CDate([Date Sold]) BETWEEN ? AND ?";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("?", startDate.ToShortDateString());
                cmd.Parameters.AddWithValue("?", endDate.ToShortDateString());

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSales.DataSource = dt; // Update DataGridView with simplified data
                }
            }
        }

        private void LoadExpensesData(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT [Expense ID], [Expense Name], [Amount], [Date of Expense], [Supplier] FROM Expenses WHERE [Date of Expense] BETWEEN ? AND ?";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("?", startDate.ToShortDateString()); // Format as string
                cmd.Parameters.AddWithValue("?", endDate.ToShortDateString());

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvExpenses.DataSource = dt;
                }
            }
        }

        private void CalculateSummary(DateTime startDate, DateTime endDate)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                // Total Sales
                string salesQuery = "SELECT SUM([Total Price]) FROM Sales WHERE [Date Sold] BETWEEN ? AND ?";
                OleDbCommand salesCmd = new OleDbCommand(salesQuery, conn);
                salesCmd.Parameters.AddWithValue("?", startDate.ToShortDateString());
                salesCmd.Parameters.AddWithValue("?", endDate.ToShortDateString());
                object salesResult = salesCmd.ExecuteScalar();
                decimal totalSales = salesResult != DBNull.Value ? Convert.ToDecimal(salesResult) : 0;

                // Total Expenses
                string expenseQuery = "SELECT SUM([Amount]) FROM Expenses WHERE [Date of Expense] BETWEEN ? AND ?";
                OleDbCommand expenseCmd = new OleDbCommand(expenseQuery, conn);
                expenseCmd.Parameters.AddWithValue("?", startDate.ToShortDateString());
                expenseCmd.Parameters.AddWithValue("?", endDate.ToShortDateString());
                object expenseResult = expenseCmd.ExecuteScalar();
                decimal totalExpenses = expenseResult != DBNull.Value ? Convert.ToDecimal(expenseResult) : 0;

                // Display summary
                lblTotalSales.Text = $"Total Sales: ₱{totalSales:N2}";
                lblTotalExpenses.Text = $"Total Expenses: ₱{totalExpenses:N2}";
                lblNetProfit.Text = $"Net Profit: ₱{totalSales - totalExpenses:N2}";
            }
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF File|*.pdf",
                Title = "Save Report as PDF"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportReportWithPdfSharp(saveFileDialog.FileName);
            }
        }

        private void ExportReportWithPdfSharp(string filePath)
        {
            // Register encoding provider for legacy encodings
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            // Create a new PDF document
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "Meatery Inventory Report";

            // Add a new page
            PdfPage page = pdf.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Fonts for the document
            XFont titleFont = new XFont("Verdana", 18, XFontStyle.Bold);
            XFont headerFont = new XFont("Verdana", 10, XFontStyle.Bold);
            XFont contentFont = new XFont("Verdana", 10, XFontStyle.Regular);

            // Set initial positions
            double yPosition = 40;

            // Add the report title
            gfx.DrawString("Meatery Inventory Report", titleFont, XBrushes.Black, new XRect(0, yPosition, page.Width, 20), XStringFormats.TopCenter);
            yPosition += 30;

            // Add summary
            gfx.DrawString($"{lblTotalSales.Text}", contentFont, XBrushes.Black, new XPoint(50, yPosition));
            yPosition += 20;
            gfx.DrawString($"{lblTotalExpenses.Text}", contentFont, XBrushes.Black, new XPoint(50, yPosition));
            yPosition += 20;
            gfx.DrawString($"{lblNetProfit.Text}", contentFont, XBrushes.Black, new XPoint(50, yPosition));
            yPosition += 30;

            // Add simplified tables with specified columns
            yPosition = AddSimplifiedTableToPDF(page, gfx, dgvSales, "Sales Data", new[] { "Date Sold", "Item Name", "Quantity", "Total Price" }, yPosition, headerFont, contentFont);
            yPosition = AddSimplifiedTableToPDF(page, gfx, dgvExpenses, "Expenses Data", new[] { "Expense Name", "Amount", "Date of Expense", "Supplier" }, yPosition, headerFont, contentFont);
            yPosition = AddSimplifiedTableToPDF(page, gfx, dgvInventory, "Inventory Data", new[] { "Item Name", "Quantity", "Unit", "Cost Price", "Sell Price" }, yPosition, headerFont, contentFont);

            // Save the PDF
            pdf.Save(filePath);
            MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private double AddSimplifiedTableToPDF(PdfPage page, XGraphics gfx, DataGridView dgv, string title, string[] columnsToInclude, double yPosition, XFont headerFont, XFont contentFont)
        {
            // Check if space is enough for the table title, headers, and rows
            if (yPosition > page.Height - 100)
            {
                page = page.Owner.AddPage();
                gfx = XGraphics.FromPdfPage(page);
                yPosition = 40; // Reset position for new page
            }

            // Add table title
            gfx.DrawString(title, headerFont, XBrushes.Black, new XPoint(40, yPosition));
            yPosition += 20;

            // Add column headers
            double xPosition = 40;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                gfx.DrawString(column.HeaderText, headerFont, XBrushes.Black, new XPoint(xPosition, yPosition));
                xPosition += 120; // Adjust column width
            }
            yPosition += 20;

            // Add data rows
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    xPosition = 40; // Reset xPosition for each row
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        var cellValue = cell.Value;
                        if (cellValue is DateTime dateValue) // Format date fields
                        {
                            gfx.DrawString(dateValue.ToString("MM/dd/yyyy"), contentFont, XBrushes.Black, new XPoint(xPosition, yPosition));
                        }
                        else
                        {
                            gfx.DrawString(cellValue?.ToString() ?? "", contentFont, XBrushes.Black, new XPoint(xPosition, yPosition));
                        }
                        xPosition += 120; // Adjust column width
                    }
                    yPosition += 20;

                    // Check if a new page is needed
                    if (yPosition > page.Height - 50)
                    {
                        page = page.Owner.AddPage();
                        gfx = XGraphics.FromPdfPage(page);
                        yPosition = 40; // Reset yPosition for new page
                    }
                }
            }

            yPosition += 20; // Add spacing after the table
            return yPosition;
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
