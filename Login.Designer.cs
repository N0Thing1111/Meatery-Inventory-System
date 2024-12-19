namespace MIS_PART_3
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            tbUser = new TextBox();
            tbPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            btnForgot = new Button();
            cbPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(258, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 260);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tbUser
            // 
            tbUser.Location = new Point(341, 283);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(169, 23);
            tbUser.TabIndex = 1;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(341, 330);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(169, 23);
            tbPass.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(386, 264);
            label1.Name = "label1";
            label1.Size = new Size(83, 16);
            label1.TabIndex = 3;
            label1.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            label2.Location = new Point(382, 311);
            label2.Name = "label2";
            label2.Size = new Size(87, 16);
            label2.TabIndex = 3;
            label2.Text = "PASSWORD";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(64, 0, 0);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(391, 396);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(78, 25);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnForgot
            // 
            btnForgot.BackColor = Color.FromArgb(64, 0, 0);
            btnForgot.FlatStyle = FlatStyle.Popup;
            btnForgot.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            btnForgot.ForeColor = SystemColors.Control;
            btnForgot.Location = new Point(341, 447);
            btnForgot.Name = "btnForgot";
            btnForgot.Size = new Size(169, 25);
            btnForgot.TabIndex = 5;
            btnForgot.Text = "Forgot Password";
            btnForgot.UseVisualStyleBackColor = false;
            btnForgot.Click += btnForgot_Click;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.BackColor = Color.Transparent;
            cbPassword.CheckAlign = ContentAlignment.MiddleRight;
            cbPassword.Location = new Point(402, 359);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(108, 19);
            cbPassword.TabIndex = 6;
            cbPassword.Text = "Show Password";
            cbPassword.UseVisualStyleBackColor = false;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(857, 537);
            Controls.Add(cbPassword);
            Controls.Add(btnForgot);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPass);
            Controls.Add(tbUser);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbUser;
        private TextBox tbPass;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Button btnForgot;
        private CheckBox cbPassword;
    }
}