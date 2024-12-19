namespace MIS_PART_3
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            dgvINV = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnDasboard = new Button();
            tbRevenue = new TextBox();
            tbExpenses = new TextBox();
            tbSold = new TextBox();
            lblLowStock = new Label();
            lblBestSeller = new Label();
            btnArchive = new Button();
            btnProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvINV).BeginInit();
            SuspendLayout();
            // 
            // dgvINV
            // 
            dgvINV.AllowUserToAddRows = false;
            dgvINV.AllowUserToDeleteRows = false;
            dgvINV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvINV.Location = new Point(219, 165);
            dgvINV.Name = "dgvINV";
            dgvINV.ReadOnly = true;
            dgvINV.Size = new Size(561, 236);
            dgvINV.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            button1.Location = new Point(0, 165);
            button1.Name = "button1";
            button1.Size = new Size(124, 30);
            button1.TabIndex = 1;
            button1.Text = "Inventory Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            button2.Location = new Point(0, 213);
            button2.Name = "button2";
            button2.Size = new Size(124, 30);
            button2.TabIndex = 2;
            button2.Text = "Sales Data";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            button3.Location = new Point(0, 263);
            button3.Name = "button3";
            button3.Size = new Size(124, 30);
            button3.TabIndex = 3;
            button3.Text = "Expenses Data";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            button4.Location = new Point(0, 313);
            button4.Name = "button4";
            button4.Size = new Size(124, 30);
            button4.TabIndex = 4;
            button4.Text = "Reports";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnDasboard
            // 
            btnDasboard.BackColor = Color.Transparent;
            btnDasboard.BackgroundImage = (Image)resources.GetObject("btnDasboard.BackgroundImage");
            btnDasboard.BackgroundImageLayout = ImageLayout.Stretch;
            btnDasboard.Location = new Point(32, 425);
            btnDasboard.Name = "btnDasboard";
            btnDasboard.Size = new Size(51, 49);
            btnDasboard.TabIndex = 5;
            btnDasboard.UseVisualStyleBackColor = false;
            // 
            // tbRevenue
            // 
            tbRevenue.Location = new Point(184, 100);
            tbRevenue.Name = "tbRevenue";
            tbRevenue.ReadOnly = true;
            tbRevenue.Size = new Size(119, 23);
            tbRevenue.TabIndex = 6;
            // 
            // tbExpenses
            // 
            tbExpenses.Location = new Point(425, 100);
            tbExpenses.Name = "tbExpenses";
            tbExpenses.ReadOnly = true;
            tbExpenses.Size = new Size(119, 23);
            tbExpenses.TabIndex = 7;
            // 
            // tbSold
            // 
            tbSold.Location = new Point(661, 100);
            tbSold.Name = "tbSold";
            tbSold.ReadOnly = true;
            tbSold.Size = new Size(119, 23);
            tbSold.TabIndex = 8;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Location = new Point(265, 469);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(38, 15);
            lblLowStock.TabIndex = 9;
            lblLowStock.Text = "label1";
            lblLowStock.Click += lblLowStock_Click;
            // 
            // lblBestSeller
            // 
            lblBestSeller.AutoSize = true;
            lblBestSeller.Location = new Point(567, 469);
            lblBestSeller.Name = "lblBestSeller";
            lblBestSeller.Size = new Size(38, 15);
            lblBestSeller.TabIndex = 10;
            lblBestSeller.Text = "label2";
            // 
            // btnArchive
            // 
            btnArchive.BackgroundImage = (Image)resources.GetObject("btnArchive.BackgroundImage");
            btnArchive.BackgroundImageLayout = ImageLayout.Stretch;
            btnArchive.Location = new Point(32, 480);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(51, 45);
            btnArchive.TabIndex = 11;
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += btnArchive_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackgroundImage = (Image)resources.GetObject("btnProfile.BackgroundImage");
            btnProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnProfile.Location = new Point(32, 374);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(51, 45);
            btnProfile.TabIndex = 12;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(857, 537);
            Controls.Add(btnProfile);
            Controls.Add(btnArchive);
            Controls.Add(lblBestSeller);
            Controls.Add(lblLowStock);
            Controls.Add(tbSold);
            Controls.Add(tbExpenses);
            Controls.Add(tbRevenue);
            Controls.Add(btnDasboard);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvINV);
            DoubleBuffered = true;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvINV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvINV;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnDasboard;
        private TextBox tbRevenue;
        private TextBox tbExpenses;
        private TextBox tbSold;
        private Label lblLowStock;
        private Label lblBestSeller;
        private Button btnArchive;
        private Button btnProfile;
    }
}