namespace MIS_PART_3
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtReenterPassword = new TextBox();
            txtFirstCrush = new TextBox();
            txtFirstPet = new TextBox();
            txtCityBorn = new TextBox();
            btnEdit = new Button();
            btnChangePassword = new Button();
            btnLogOut = new Button();
            btnConfirmPassword = new Button();
            btnSave = new Button();
            cbPassword = new CheckBox();
            btnInvData = new Button();
            btnSaleData = new Button();
            btnReports = new Button();
            button1 = new Button();
            btnProfile = new Button();
            btnDasboard = new Button();
            btnArchive = new Button();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(322, 110);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(131, 23);
            txtFullName.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(322, 148);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(131, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(322, 187);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(131, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtReenterPassword
            // 
            txtReenterPassword.Location = new Point(322, 228);
            txtReenterPassword.Name = "txtReenterPassword";
            txtReenterPassword.Size = new Size(131, 23);
            txtReenterPassword.TabIndex = 3;
            // 
            // txtFirstCrush
            // 
            txtFirstCrush.Location = new Point(627, 107);
            txtFirstCrush.Name = "txtFirstCrush";
            txtFirstCrush.ReadOnly = true;
            txtFirstCrush.Size = new Size(131, 23);
            txtFirstCrush.TabIndex = 4;
            // 
            // txtFirstPet
            // 
            txtFirstPet.Location = new Point(627, 146);
            txtFirstPet.Name = "txtFirstPet";
            txtFirstPet.ReadOnly = true;
            txtFirstPet.Size = new Size(131, 23);
            txtFirstPet.TabIndex = 5;
            // 
            // txtCityBorn
            // 
            txtCityBorn.Location = new Point(627, 187);
            txtCityBorn.Name = "txtCityBorn";
            txtCityBorn.ReadOnly = true;
            txtCityBorn.Size = new Size(131, 23);
            txtCityBorn.TabIndex = 6;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 0, 0);
            btnEdit.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(216, 280);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(84, 40);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(64, 0, 0);
            btnChangePassword.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnChangePassword.ForeColor = SystemColors.Control;
            btnChangePassword.Location = new Point(437, 280);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(126, 40);
            btnChangePassword.TabIndex = 15;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(64, 0, 0);
            btnLogOut.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnLogOut.ForeColor = SystemColors.Control;
            btnLogOut.Location = new Point(216, 328);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(84, 25);
            btnLogOut.TabIndex = 16;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnConfirmPassword
            // 
            btnConfirmPassword.BackColor = Color.FromArgb(64, 0, 0);
            btnConfirmPassword.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnConfirmPassword.ForeColor = SystemColors.Control;
            btnConfirmPassword.Location = new Point(589, 280);
            btnConfirmPassword.Name = "btnConfirmPassword";
            btnConfirmPassword.Size = new Size(126, 40);
            btnConfirmPassword.TabIndex = 17;
            btnConfirmPassword.Text = "Confirm Password";
            btnConfirmPassword.UseVisualStyleBackColor = false;
            btnConfirmPassword.Visible = false;
            btnConfirmPassword.Click += btnConfirmPassword_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 0, 0);
            btnSave.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(322, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 40);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save Profile";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Location = new Point(473, 230);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(108, 19);
            cbPassword.TabIndex = 19;
            cbPassword.Text = "Show Password";
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // btnInvData
            // 
            btnInvData.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnInvData.Location = new Point(-1, 165);
            btnInvData.Name = "btnInvData";
            btnInvData.Size = new Size(128, 33);
            btnInvData.TabIndex = 27;
            btnInvData.Text = "Inventory Data";
            btnInvData.UseVisualStyleBackColor = true;
            btnInvData.Click += btnInvData_Click;
            // 
            // btnSaleData
            // 
            btnSaleData.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnSaleData.Location = new Point(-1, 216);
            btnSaleData.Name = "btnSaleData";
            btnSaleData.Size = new Size(128, 33);
            btnSaleData.TabIndex = 28;
            btnSaleData.Text = "Sales Data";
            btnSaleData.UseVisualStyleBackColor = true;
            btnSaleData.Click += btnSaleData_Click;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnReports.Location = new Point(-1, 272);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(128, 33);
            btnReports.TabIndex = 30;
            btnReports.Text = "Expenses Data";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // button1
            // 
            button1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            button1.Location = new Point(-1, 324);
            button1.Name = "button1";
            button1.Size = new Size(128, 33);
            button1.TabIndex = 31;
            button1.Text = "Reports";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackgroundImage = (Image)resources.GetObject("btnProfile.BackgroundImage");
            btnProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnProfile.Location = new Point(37, 374);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(51, 45);
            btnProfile.TabIndex = 36;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnDasboard
            // 
            btnDasboard.BackColor = Color.Transparent;
            btnDasboard.BackgroundImage = (Image)resources.GetObject("btnDasboard.BackgroundImage");
            btnDasboard.BackgroundImageLayout = ImageLayout.Stretch;
            btnDasboard.Location = new Point(37, 425);
            btnDasboard.Name = "btnDasboard";
            btnDasboard.Size = new Size(52, 49);
            btnDasboard.TabIndex = 37;
            btnDasboard.UseVisualStyleBackColor = false;
            btnDasboard.Click += btnDasboard_Click;
            // 
            // btnArchive
            // 
            btnArchive.BackgroundImage = (Image)resources.GetObject("btnArchive.BackgroundImage");
            btnArchive.BackgroundImageLayout = ImageLayout.Stretch;
            btnArchive.Location = new Point(37, 480);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(51, 45);
            btnArchive.TabIndex = 38;
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += btnArchive_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(857, 537);
            Controls.Add(btnArchive);
            Controls.Add(btnDasboard);
            Controls.Add(btnProfile);
            Controls.Add(button1);
            Controls.Add(btnReports);
            Controls.Add(btnSaleData);
            Controls.Add(btnInvData);
            Controls.Add(cbPassword);
            Controls.Add(btnSave);
            Controls.Add(btnConfirmPassword);
            Controls.Add(btnLogOut);
            Controls.Add(btnChangePassword);
            Controls.Add(btnEdit);
            Controls.Add(txtCityBorn);
            Controls.Add(txtFirstPet);
            Controls.Add(txtFirstCrush);
            Controls.Add(txtReenterPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            DoubleBuffered = true;
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtReenterPassword;
        private TextBox txtFirstCrush;
        private TextBox txtFirstPet;
        private TextBox txtCityBorn;
        private Button btnEdit;
        private Button btnChangePassword;
        private Button btnLogOut;
        private Button btnConfirmPassword;
        private Button btnSave;
        private CheckBox cbPassword;
        private Button btnInvData;
        private Button btnSaleData;
        private Button btnReports;
        private Button button1;
        private Button btnProfile;
        private Button btnDasboard;
        private Button btnArchive;
    }
}