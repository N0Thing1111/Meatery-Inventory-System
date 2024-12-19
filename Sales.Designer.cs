namespace MIS_PART_3
{
    partial class Sales
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            dgvSales = new DataGridView();
            tbID = new TextBox();
            tbIN = new TextBox();
            tbQ = new TextBox();
            tbUP = new TextBox();
            tbTP = new TextBox();
            dtpDS = new DateTimePicker();
            btnAdd = new Button();
            btnEdit = new Button();
            btnImport = new Button();
            btnClear = new Button();
            tbSearch = new TextBox();
            label9 = new Label();
            btnReports = new Button();
            btnInvData = new Button();
            btnSaleData = new Button();
            btnExpenData = new Button();
            btnDasboard = new Button();
            btnProfile = new Button();
            btnArchive = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AllowUserToDeleteRows = false;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(206, 73);
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.Size = new Size(542, 251);
            dgvSales.TabIndex = 0;
            dgvSales.CellEnter += dgvINV_CellEnter;
            // 
            // tbID
            // 
            tbID.Location = new Point(301, 400);
            tbID.Name = "tbID";
            tbID.Size = new Size(91, 23);
            tbID.TabIndex = 1;
            tbID.TextChanged += tbID_TextChanged;
            // 
            // tbIN
            // 
            tbIN.Location = new Point(301, 434);
            tbIN.Name = "tbIN";
            tbIN.Size = new Size(91, 23);
            tbIN.TabIndex = 2;
            tbIN.TextChanged += tbIN_TextChanged;
            // 
            // tbQ
            // 
            tbQ.Location = new Point(532, 367);
            tbQ.Name = "tbQ";
            tbQ.Size = new Size(91, 23);
            tbQ.TabIndex = 3;
            tbQ.TextChanged += tbQ_TextChanged;
            // 
            // tbUP
            // 
            tbUP.Location = new Point(532, 400);
            tbUP.Name = "tbUP";
            tbUP.Size = new Size(91, 23);
            tbUP.TabIndex = 4;
            // 
            // tbTP
            // 
            tbTP.Location = new Point(532, 434);
            tbTP.Name = "tbTP";
            tbTP.Size = new Size(91, 23);
            tbTP.TabIndex = 5;
            // 
            // dtpDS
            // 
            dtpDS.Format = DateTimePickerFormat.Short;
            dtpDS.Location = new Point(301, 366);
            dtpDS.Name = "dtpDS";
            dtpDS.Size = new Size(91, 23);
            dtpDS.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(64, 0, 0);
            btnAdd.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(670, 361);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 28);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 0, 0);
            btnEdit.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(670, 395);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(78, 28);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnUpdate_Click;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.FromArgb(64, 0, 0);
            btnImport.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnImport.ForeColor = SystemColors.Control;
            btnImport.Location = new Point(670, 429);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(78, 28);
            btnImport.TabIndex = 11;
            btnImport.Text = "IMPORT";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(64, 0, 0);
            btnClear.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.Control;
            btnClear.Location = new Point(670, 463);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 28);
            btnClear.TabIndex = 12;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(273, 44);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(214, 23);
            tbSearch.TabIndex = 21;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(229, 47);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 22;
            label9.Text = "Search";
            // 
            // btnReports
            // 
            btnReports.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnReports.Location = new Point(-1, 321);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(127, 33);
            btnReports.TabIndex = 30;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnInvData
            // 
            btnInvData.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnInvData.Location = new Point(-1, 171);
            btnInvData.Name = "btnInvData";
            btnInvData.Size = new Size(127, 33);
            btnInvData.TabIndex = 29;
            btnInvData.Text = "Inventory Data";
            btnInvData.UseVisualStyleBackColor = true;
            btnInvData.Click += btnInvData_Click;
            // 
            // btnSaleData
            // 
            btnSaleData.BackColor = Color.Black;
            btnSaleData.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnSaleData.ForeColor = SystemColors.Control;
            btnSaleData.Location = new Point(-1, 219);
            btnSaleData.Name = "btnSaleData";
            btnSaleData.Size = new Size(127, 33);
            btnSaleData.TabIndex = 28;
            btnSaleData.Text = "Sales Data";
            btnSaleData.UseVisualStyleBackColor = false;
            btnSaleData.Click += btnSaleData_Click;
            // 
            // btnExpenData
            // 
            btnExpenData.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnExpenData.Location = new Point(-1, 270);
            btnExpenData.Name = "btnExpenData";
            btnExpenData.Size = new Size(127, 33);
            btnExpenData.TabIndex = 27;
            btnExpenData.Text = "Expenses Data";
            btnExpenData.UseVisualStyleBackColor = true;
            btnExpenData.Click += btnExpenData_Click;
            // 
            // btnDasboard
            // 
            btnDasboard.BackColor = Color.Transparent;
            btnDasboard.BackgroundImage = (Image)resources.GetObject("btnDasboard.BackgroundImage");
            btnDasboard.BackgroundImageLayout = ImageLayout.Stretch;
            btnDasboard.Location = new Point(30, 425);
            btnDasboard.Name = "btnDasboard";
            btnDasboard.Size = new Size(52, 49);
            btnDasboard.TabIndex = 31;
            btnDasboard.UseVisualStyleBackColor = false;
            btnDasboard.Click += btnDasboard_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackgroundImage = (Image)resources.GetObject("btnProfile.BackgroundImage");
            btnProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnProfile.Location = new Point(31, 374);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(51, 45);
            btnProfile.TabIndex = 33;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnArchive
            // 
            btnArchive.BackgroundImage = (Image)resources.GetObject("btnArchive.BackgroundImage");
            btnArchive.BackgroundImageLayout = ImageLayout.Stretch;
            btnArchive.Location = new Point(31, 480);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(51, 45);
            btnArchive.TabIndex = 34;
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += btnArchive_Click;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(857, 537);
            Controls.Add(btnArchive);
            Controls.Add(btnProfile);
            Controls.Add(btnDasboard);
            Controls.Add(btnReports);
            Controls.Add(btnInvData);
            Controls.Add(btnSaleData);
            Controls.Add(btnExpenData);
            Controls.Add(label9);
            Controls.Add(tbSearch);
            Controls.Add(btnClear);
            Controls.Add(btnImport);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dtpDS);
            Controls.Add(tbTP);
            Controls.Add(tbUP);
            Controls.Add(tbQ);
            Controls.Add(tbIN);
            Controls.Add(tbID);
            Controls.Add(dgvSales);
            DoubleBuffered = true;
            Name = "Sales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSales;
        private TextBox tbID;
        private TextBox tbIN;
        private TextBox tbQ;
        private TextBox tbUP;
        private TextBox tbTP;
        private DateTimePicker dtpDS;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnImport;
        private Button btnClear;
        private TextBox tbSearch;
        private Label label9;
        private Button btnReports;
        private Button btnInvData;
        private Button btnSaleData;
        private Button btnExpenData;
        private Button btnDasboard;
        private Button btnProfile;
        private Button btnArchive;
    }
}
