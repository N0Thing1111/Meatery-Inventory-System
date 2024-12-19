namespace MIS_PART_3
{
    partial class Expenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            dgvEXPEN = new DataGridView();
            tbEN = new TextBox();
            tbA = new TextBox();
            tbS = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            tbSearch = new TextBox();
            label9 = new Label();
            btnExpenData = new Button();
            btnSaleData = new Button();
            btnInvData = new Button();
            btnReports = new Button();
            btnUpdate = new Button();
            dtpDOE = new DateTimePicker();
            btnDasboard = new Button();
            btnProfile = new Button();
            btnArchive = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEXPEN).BeginInit();
            SuspendLayout();
            // 
            // dgvEXPEN
            // 
            dgvEXPEN.AllowUserToAddRows = false;
            dgvEXPEN.AllowUserToDeleteRows = false;
            dgvEXPEN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEXPEN.Location = new Point(202, 79);
            dgvEXPEN.Name = "dgvEXPEN";
            dgvEXPEN.ReadOnly = true;
            dgvEXPEN.Size = new Size(542, 251);
            dgvEXPEN.TabIndex = 0;
            dgvEXPEN.CellEnter += dgvINV_CellEnter;
            // 
            // tbEN
            // 
            tbEN.Location = new Point(406, 372);
            tbEN.Name = "tbEN";
            tbEN.Size = new Size(91, 23);
            tbEN.TabIndex = 2;
            // 
            // tbA
            // 
            tbA.Location = new Point(406, 407);
            tbA.Name = "tbA";
            tbA.Size = new Size(91, 23);
            tbA.TabIndex = 3;
            // 
            // tbS
            // 
            tbS.Location = new Point(406, 475);
            tbS.Name = "tbS";
            tbS.Size = new Size(91, 23);
            tbS.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(64, 0, 0);
            btnAdd.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(562, 367);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 28);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(64, 0, 0);
            btnClear.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.Control;
            btnClear.Location = new Point(562, 451);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 28);
            btnClear.TabIndex = 12;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(262, 50);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(214, 23);
            tbSearch.TabIndex = 21;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            label9.Location = new Point(200, 57);
            label9.Name = "label9";
            label9.Size = new Size(56, 16);
            label9.TabIndex = 22;
            label9.Text = "Search";
            label9.Click += label9_Click;
            // 
            // btnExpenData
            // 
            btnExpenData.BackColor = SystemColors.ActiveCaptionText;
            btnExpenData.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnExpenData.ForeColor = SystemColors.Control;
            btnExpenData.Location = new Point(-1, 273);
            btnExpenData.Name = "btnExpenData";
            btnExpenData.Size = new Size(128, 33);
            btnExpenData.TabIndex = 23;
            btnExpenData.Text = "Expenses Data";
            btnExpenData.UseVisualStyleBackColor = false;
            btnExpenData.Click += btnExpenData_Click;
            // 
            // btnSaleData
            // 
            btnSaleData.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnSaleData.Location = new Point(-1, 219);
            btnSaleData.Name = "btnSaleData";
            btnSaleData.Size = new Size(128, 33);
            btnSaleData.TabIndex = 24;
            btnSaleData.Text = "Sales Data";
            btnSaleData.UseVisualStyleBackColor = true;
            btnSaleData.Click += btnSaleData_Click;
            // 
            // btnInvData
            // 
            btnInvData.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnInvData.Location = new Point(-1, 165);
            btnInvData.Name = "btnInvData";
            btnInvData.Size = new Size(128, 33);
            btnInvData.TabIndex = 25;
            btnInvData.Text = "Inventory Data";
            btnInvData.UseVisualStyleBackColor = true;
            btnInvData.Click += button3_Click;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnReports.Location = new Point(-1, 322);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(128, 33);
            btnReports.TabIndex = 26;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(64, 0, 0);
            btnUpdate.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(562, 407);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 28);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "EDIT";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dtpDOE
            // 
            dtpDOE.Format = DateTimePickerFormat.Short;
            dtpDOE.Location = new Point(406, 441);
            dtpDOE.Name = "dtpDOE";
            dtpDOE.Size = new Size(91, 23);
            dtpDOE.TabIndex = 27;
            // 
            // btnDasboard
            // 
            btnDasboard.BackColor = Color.Transparent;
            btnDasboard.BackgroundImage = (Image)resources.GetObject("btnDasboard.BackgroundImage");
            btnDasboard.BackgroundImageLayout = ImageLayout.Stretch;
            btnDasboard.Location = new Point(37, 430);
            btnDasboard.Name = "btnDasboard";
            btnDasboard.Size = new Size(52, 49);
            btnDasboard.TabIndex = 28;
            btnDasboard.UseVisualStyleBackColor = false;
            btnDasboard.Click += btnDasboard_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackgroundImage = (Image)resources.GetObject("btnProfile.BackgroundImage");
            btnProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnProfile.Location = new Point(37, 379);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(51, 45);
            btnProfile.TabIndex = 34;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnArchive
            // 
            btnArchive.BackgroundImage = (Image)resources.GetObject("btnArchive.BackgroundImage");
            btnArchive.BackgroundImageLayout = ImageLayout.Stretch;
            btnArchive.Location = new Point(38, 485);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(51, 45);
            btnArchive.TabIndex = 35;
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += btnArchive_Click;
            // 
            // Expenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(857, 537);
            Controls.Add(btnArchive);
            Controls.Add(btnProfile);
            Controls.Add(btnDasboard);
            Controls.Add(dtpDOE);
            Controls.Add(btnReports);
            Controls.Add(btnInvData);
            Controls.Add(btnSaleData);
            Controls.Add(btnExpenData);
            Controls.Add(label9);
            Controls.Add(tbSearch);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(tbS);
            Controls.Add(tbA);
            Controls.Add(tbEN);
            Controls.Add(dgvEXPEN);
            DoubleBuffered = true;
            Name = "Expenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEXPEN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEXPEN;
        private TextBox tbEN;
        private TextBox tbA;
        private TextBox tbS;
        private Button btnAdd;
        private Button btnClear;
        private TextBox tbSearch;
        private Label label9;
        private Button btnExpenData;
        private Button btnSaleData;
        private Button btnInvData;
        private Button btnReports;
        private Button btnUpdate;
        private DateTimePicker dtpDOE;
        private Button btnDasboard;
        private Button btnProfile;
        private Button btnArchive;
    }
}
