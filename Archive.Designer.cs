namespace MIS_PART_3
{
    partial class Archive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archive));
            dgvArchive = new DataGridView();
            btnRestore = new Button();
            btnDeletePermanently = new Button();
            btnRollback = new Button();
            btnHome = new Button();
            btnSaveBackup = new Button();
            btnClearData = new Button();
            btnInv = new Button();
            btnSales = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArchive).BeginInit();
            SuspendLayout();
            // 
            // dgvArchive
            // 
            dgvArchive.AllowUserToAddRows = false;
            dgvArchive.AllowUserToDeleteRows = false;
            dgvArchive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchive.Location = new Point(195, 98);
            dgvArchive.Name = "dgvArchive";
            dgvArchive.ReadOnly = true;
            dgvArchive.Size = new Size(498, 202);
            dgvArchive.TabIndex = 0;
            dgvArchive.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnRestore
            // 
            btnRestore.BackColor = Color.FromArgb(64, 0, 0);
            btnRestore.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnRestore.ForeColor = SystemColors.Control;
            btnRestore.Location = new Point(223, 434);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(75, 32);
            btnRestore.TabIndex = 1;
            btnRestore.Text = "Restore";
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click;
            // 
            // btnDeletePermanently
            // 
            btnDeletePermanently.BackColor = Color.FromArgb(64, 0, 0);
            btnDeletePermanently.Font = new Font("MS Reference Sans Serif", 8F, FontStyle.Bold);
            btnDeletePermanently.ForeColor = SystemColors.Control;
            btnDeletePermanently.Location = new Point(304, 434);
            btnDeletePermanently.Name = "btnDeletePermanently";
            btnDeletePermanently.Size = new Size(148, 31);
            btnDeletePermanently.TabIndex = 2;
            btnDeletePermanently.Text = "Delete Permanently";
            btnDeletePermanently.UseVisualStyleBackColor = false;
            btnDeletePermanently.Click += btnDeletePermanently_Click;
            // 
            // btnRollback
            // 
            btnRollback.BackColor = Color.FromArgb(64, 0, 0);
            btnRollback.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnRollback.ForeColor = SystemColors.Control;
            btnRollback.Location = new Point(675, 414);
            btnRollback.Name = "btnRollback";
            btnRollback.Size = new Size(101, 32);
            btnRollback.TabIndex = 3;
            btnRollback.Text = "Rollback";
            btnRollback.UseVisualStyleBackColor = false;
            btnRollback.Click += btnRollback_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Stretch;
            btnHome.Location = new Point(33, 430);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(56, 47);
            btnHome.TabIndex = 4;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnSaveBackup
            // 
            btnSaveBackup.BackColor = Color.FromArgb(64, 0, 0);
            btnSaveBackup.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnSaveBackup.ForeColor = SystemColors.Control;
            btnSaveBackup.Location = new Point(543, 414);
            btnSaveBackup.Name = "btnSaveBackup";
            btnSaveBackup.Size = new Size(112, 32);
            btnSaveBackup.TabIndex = 5;
            btnSaveBackup.Text = "Save Backup";
            btnSaveBackup.UseVisualStyleBackColor = false;
            btnSaveBackup.Click += btnSaveBackup_Click;
            // 
            // btnClearData
            // 
            btnClearData.BackColor = Color.FromArgb(64, 0, 0);
            btnClearData.Font = new Font("MS Reference Sans Serif", 8F, FontStyle.Bold);
            btnClearData.ForeColor = SystemColors.Control;
            btnClearData.Location = new Point(602, 452);
            btnClearData.Name = "btnClearData";
            btnClearData.Size = new Size(119, 32);
            btnClearData.TabIndex = 6;
            btnClearData.Text = "Clear ALL Data";
            btnClearData.UseVisualStyleBackColor = false;
            btnClearData.Click += btnClearData_Click;
            // 
            // btnInv
            // 
            btnInv.BackColor = Color.Transparent;
            btnInv.BackgroundImage = (Image)resources.GetObject("btnInv.BackgroundImage");
            btnInv.BackgroundImageLayout = ImageLayout.Stretch;
            btnInv.Location = new Point(33, 377);
            btnInv.Name = "btnInv";
            btnInv.Size = new Size(56, 47);
            btnInv.TabIndex = 17;
            btnInv.UseVisualStyleBackColor = false;
            btnInv.Click += btnInv_Click;
            // 
            // btnSales
            // 
            btnSales.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnSales.Location = new Point(-4, 263);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(132, 27);
            btnSales.TabIndex = 16;
            btnSales.Text = "Expenses Data";
            btnSales.Click += btnSales_Click;
            // 
            // button3
            // 
            button3.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            button3.Location = new Point(-4, 306);
            button3.Name = "button3";
            button3.Size = new Size(132, 27);
            button3.TabIndex = 15;
            button3.Text = "Reports";
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            button4.Location = new Point(-4, 169);
            button4.Name = "button4";
            button4.Size = new Size(132, 23);
            button4.TabIndex = 14;
            button4.Text = "Inventory Data";
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            button5.Location = new Point(-4, 215);
            button5.Name = "button5";
            button5.Size = new Size(132, 23);
            button5.TabIndex = 13;
            button5.Text = "Sales Data";
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Location = new Point(33, 483);
            button6.Name = "button6";
            button6.Size = new Size(56, 47);
            button6.TabIndex = 12;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Archive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(857, 537);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnSales);
            Controls.Add(btnInv);
            Controls.Add(btnClearData);
            Controls.Add(btnSaveBackup);
            Controls.Add(btnHome);
            Controls.Add(btnRollback);
            Controls.Add(btnDeletePermanently);
            Controls.Add(btnRestore);
            Controls.Add(dgvArchive);
            DoubleBuffered = true;
            Name = "Archive";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Archive";
            Load += Archive_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArchive).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvArchive;
        private Button btnRestore;
        private Button btnDeletePermanently;
        private Button btnRollback;
        private Button btnHome;
        private Button btnSaveBackup;
        private Button btnClearData;
        private Button btnInv;
        private Button btnSales;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}