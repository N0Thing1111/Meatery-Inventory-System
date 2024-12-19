namespace MIS_PART_3
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnExportReport = new Button();
            btnGenerateReport = new Button();
            dgvInventory = new DataGridView();
            dgvSales = new DataGridView();
            dgvExpenses = new DataGridView();
            lblTotalSales = new Label();
            lblTotalExpenses = new Label();
            lblNetProfit = new Label();
            btnInvData = new Button();
            btnSaleData = new Button();
            btnExpenData = new Button();
            btnReports = new Button();
            btnProfile = new Button();
            btnDasboard = new Button();
            btnArchive = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(628, 118);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(85, 23);
            dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(735, 118);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(88, 23);
            dtpEndDate.TabIndex = 1;
            // 
            // btnExportReport
            // 
            btnExportReport.BackColor = Color.FromArgb(64, 0, 0);
            btnExportReport.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnExportReport.ForeColor = Color.White;
            btnExportReport.Location = new Point(656, 351);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(143, 32);
            btnExportReport.TabIndex = 2;
            btnExportReport.Text = "Export Report";
            btnExportReport.UseVisualStyleBackColor = false;
            btnExportReport.Click += btnExportReport_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.FromArgb(64, 0, 0);
            btnGenerateReport.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(656, 311);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(143, 34);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(187, 52);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.Size = new Size(406, 158);
            dgvInventory.TabIndex = 4;
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AllowUserToDeleteRows = false;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(187, 210);
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.Size = new Size(406, 151);
            dgvSales.TabIndex = 5;
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AllowUserToDeleteRows = false;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Location = new Point(187, 361);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.Size = new Size(406, 144);
            dgvExpenses.TabIndex = 6;
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Location = new Point(642, 214);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(61, 15);
            lblTotalSales.TabIndex = 7;
            lblTotalSales.Text = "Total Sales";
            // 
            // lblTotalExpenses
            // 
            lblTotalExpenses.AutoSize = true;
            lblTotalExpenses.Location = new Point(642, 253);
            lblTotalExpenses.Name = "lblTotalExpenses";
            lblTotalExpenses.Size = new Size(83, 15);
            lblTotalExpenses.TabIndex = 8;
            lblTotalExpenses.Text = "Total Expenses";
            // 
            // lblNetProfit
            // 
            lblNetProfit.AutoSize = true;
            lblNetProfit.Location = new Point(642, 174);
            lblNetProfit.Name = "lblNetProfit";
            lblNetProfit.Size = new Size(61, 15);
            lblNetProfit.TabIndex = 9;
            lblNetProfit.Text = "Net Profit:";
            // 
            // btnInvData
            // 
            btnInvData.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnInvData.Location = new Point(-2, 171);
            btnInvData.Name = "btnInvData";
            btnInvData.Size = new Size(128, 33);
            btnInvData.TabIndex = 26;
            btnInvData.Text = "Inventory Data";
            btnInvData.UseVisualStyleBackColor = true;
            btnInvData.Click += btnInvData_Click;
            // 
            // btnSaleData
            // 
            btnSaleData.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnSaleData.Location = new Point(-2, 223);
            btnSaleData.Name = "btnSaleData";
            btnSaleData.Size = new Size(128, 33);
            btnSaleData.TabIndex = 27;
            btnSaleData.Text = "Sales Data";
            btnSaleData.UseVisualStyleBackColor = true;
            btnSaleData.Click += btnSaleData_Click;
            // 
            // btnExpenData
            // 
            btnExpenData.BackColor = SystemColors.ActiveCaptionText;
            btnExpenData.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnExpenData.ForeColor = SystemColors.Control;
            btnExpenData.Location = new Point(-2, 322);
            btnExpenData.Name = "btnExpenData";
            btnExpenData.Size = new Size(128, 33);
            btnExpenData.TabIndex = 28;
            btnExpenData.Text = "Reports";
            btnExpenData.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnReports.Location = new Point(-2, 272);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(128, 33);
            btnReports.TabIndex = 29;
            btnReports.Text = "Expenses Data";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackgroundImage = (Image)resources.GetObject("btnProfile.BackgroundImage");
            btnProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnProfile.Location = new Point(32, 380);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(51, 45);
            btnProfile.TabIndex = 35;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnDasboard
            // 
            btnDasboard.BackColor = Color.Transparent;
            btnDasboard.BackgroundImage = (Image)resources.GetObject("btnDasboard.BackgroundImage");
            btnDasboard.BackgroundImageLayout = ImageLayout.Stretch;
            btnDasboard.Location = new Point(31, 431);
            btnDasboard.Name = "btnDasboard";
            btnDasboard.Size = new Size(52, 49);
            btnDasboard.TabIndex = 36;
            btnDasboard.UseVisualStyleBackColor = false;
            btnDasboard.Click += btnDasboard_Click;
            // 
            // btnArchive
            // 
            btnArchive.BackgroundImage = (Image)resources.GetObject("btnArchive.BackgroundImage");
            btnArchive.BackgroundImageLayout = ImageLayout.Stretch;
            btnArchive.Location = new Point(31, 485);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(51, 45);
            btnArchive.TabIndex = 37;
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += btnArchive_Click;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(857, 537);
            Controls.Add(btnArchive);
            Controls.Add(btnDasboard);
            Controls.Add(btnProfile);
            Controls.Add(btnReports);
            Controls.Add(btnExpenData);
            Controls.Add(btnSaleData);
            Controls.Add(btnInvData);
            Controls.Add(lblNetProfit);
            Controls.Add(lblTotalExpenses);
            Controls.Add(lblTotalSales);
            Controls.Add(dgvExpenses);
            Controls.Add(dgvSales);
            Controls.Add(dgvInventory);
            Controls.Add(btnGenerateReport);
            Controls.Add(btnExportReport);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            DoubleBuffered = true;
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnExportReport;
        private Button btnGenerateReport;
        private DataGridView dgvInventory;
        private DataGridView dgvSales;
        private DataGridView dgvExpenses;
        private Label lblTotalSales;
        private Label lblTotalExpenses;
        private Label lblNetProfit;
        private Button btnInvData;
        private Button btnSaleData;
        private Button btnExpenData;
        private Button btnReports;
        private Button btnProfile;
        private Button btnDasboard;
        private Button btnArchive;
    }
}