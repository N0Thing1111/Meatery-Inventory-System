namespace MIS_PART_3
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            dgvINV = new DataGridView();
            tbIN = new TextBox();
            tbBID = new TextBox();
            tbQ = new TextBox();
            tbU = new TextBox();
            tbCP = new TextBox();
            tbSP = new TextBox();
            tbS = new TextBox();
            dtpEXP = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvINV).BeginInit();
            SuspendLayout();
            // 
            // dgvINV
            // 
            dgvINV.AllowUserToAddRows = false;
            dgvINV.AllowUserToDeleteRows = false;
            dgvINV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvINV.Location = new Point(227, 85);
            dgvINV.Name = "dgvINV";
            dgvINV.ReadOnly = true;
            dgvINV.Size = new Size(524, 237);
            dgvINV.TabIndex = 0;
            dgvINV.CellEnter += dgvINV_CellEnter;
            // 
            // tbIN
            // 
            tbIN.Location = new Point(276, 369);
            tbIN.Name = "tbIN";
            tbIN.Size = new Size(91, 23);
            tbIN.TabIndex = 1;
            // 
            // tbBID
            // 
            tbBID.Location = new Point(276, 401);
            tbBID.Name = "tbBID";
            tbBID.Size = new Size(91, 23);
            tbBID.TabIndex = 2;
            // 
            // tbQ
            // 
            tbQ.Location = new Point(276, 440);
            tbQ.Name = "tbQ";
            tbQ.Size = new Size(91, 23);
            tbQ.TabIndex = 3;
            // 
            // tbU
            // 
            tbU.Location = new Point(276, 476);
            tbU.Name = "tbU";
            tbU.Size = new Size(91, 23);
            tbU.TabIndex = 4;
            // 
            // tbCP
            // 
            tbCP.Location = new Point(524, 369);
            tbCP.Name = "tbCP";
            tbCP.Size = new Size(91, 23);
            tbCP.TabIndex = 5;
            // 
            // tbSP
            // 
            tbSP.Location = new Point(524, 401);
            tbSP.Name = "tbSP";
            tbSP.Size = new Size(91, 23);
            tbSP.TabIndex = 6;
            // 
            // tbS
            // 
            tbS.Location = new Point(524, 476);
            tbS.Name = "tbS";
            tbS.Size = new Size(91, 23);
            tbS.TabIndex = 7;
            // 
            // dtpEXP
            // 
            dtpEXP.Format = DateTimePickerFormat.Short;
            dtpEXP.Location = new Point(524, 440);
            dtpEXP.Name = "dtpEXP";
            dtpEXP.Size = new Size(91, 23);
            dtpEXP.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(64, 0, 0);
            btnAdd.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(659, 367);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 28);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(64, 0, 0);
            btnUpdate.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(659, 401);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 28);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 0, 0);
            btnDelete.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(659, 435);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 28);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(64, 0, 0);
            btnClear.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.Control;
            btnClear.Location = new Point(659, 469);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 28);
            btnClear.TabIndex = 12;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(311, 46);
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
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(249, 48);
            label9.Name = "label9";
            label9.Size = new Size(56, 16);
            label9.TabIndex = 22;
            label9.Text = "Search";
            // 
            // btnReports
            // 
            btnReports.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnReports.Location = new Point(-3, 323);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(128, 33);
            btnReports.TabIndex = 30;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnInvData
            // 
            btnInvData.BackColor = SystemColors.ActiveCaptionText;
            btnInvData.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInvData.ForeColor = SystemColors.Control;
            btnInvData.Location = new Point(-3, 155);
            btnInvData.Name = "btnInvData";
            btnInvData.Size = new Size(130, 33);
            btnInvData.TabIndex = 29;
            btnInvData.Text = "Inventory Data";
            btnInvData.UseVisualStyleBackColor = false;
            btnInvData.Click += btnInvData_Click;
            // 
            // btnSaleData
            // 
            btnSaleData.BackColor = SystemColors.Control;
            btnSaleData.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnSaleData.ForeColor = Color.Black;
            btnSaleData.Location = new Point(-1, 210);
            btnSaleData.Name = "btnSaleData";
            btnSaleData.Size = new Size(126, 33);
            btnSaleData.TabIndex = 28;
            btnSaleData.Text = "Sales Data";
            btnSaleData.UseVisualStyleBackColor = false;
            btnSaleData.Click += btnSaleData_Click;
            // 
            // btnExpenData
            // 
            btnExpenData.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnExpenData.Location = new Point(-3, 266);
            btnExpenData.Name = "btnExpenData";
            btnExpenData.Size = new Size(128, 33);
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
            btnDasboard.Location = new Point(32, 425);
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
            btnProfile.Location = new Point(33, 374);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(51, 45);
            btnProfile.TabIndex = 32;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnArchive
            // 
            btnArchive.BackgroundImage = (Image)resources.GetObject("btnArchive.BackgroundImage");
            btnArchive.BackgroundImageLayout = ImageLayout.Stretch;
            btnArchive.Location = new Point(32, 480);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(51, 45);
            btnArchive.TabIndex = 33;
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += btnArchive_Click;
            // 
            // Inventory
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
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dtpEXP);
            Controls.Add(tbS);
            Controls.Add(tbSP);
            Controls.Add(tbCP);
            Controls.Add(tbU);
            Controls.Add(tbQ);
            Controls.Add(tbBID);
            Controls.Add(tbIN);
            Controls.Add(dgvINV);
            DoubleBuffered = true;
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvINV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvINV;
        private TextBox tbIN;
        private TextBox tbBID;
        private TextBox tbQ;
        private TextBox tbU;
        private TextBox tbCP;
        private TextBox tbSP;
        private TextBox tbS;
        private DateTimePicker dtpEXP;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
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
