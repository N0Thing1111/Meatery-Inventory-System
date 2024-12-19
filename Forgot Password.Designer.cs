namespace MIS_PART_3
{
    partial class Forgot_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot_Password));
            pictureBox1 = new PictureBox();
            tbAnswer1 = new TextBox();
            tbAnswer2 = new TextBox();
            tbAnswer3 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(287, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tbAnswer1
            // 
            tbAnswer1.Location = new Point(418, 237);
            tbAnswer1.Name = "tbAnswer1";
            tbAnswer1.Size = new Size(100, 23);
            tbAnswer1.TabIndex = 3;
            // 
            // tbAnswer2
            // 
            tbAnswer2.Location = new Point(418, 271);
            tbAnswer2.Name = "tbAnswer2";
            tbAnswer2.Size = new Size(100, 23);
            tbAnswer2.TabIndex = 4;
            // 
            // tbAnswer3
            // 
            tbAnswer3.Location = new Point(418, 304);
            tbAnswer3.Name = "tbAnswer3";
            tbAnswer3.Size = new Size(100, 23);
            tbAnswer3.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 0);
            button1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(443, 345);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(281, 244);
            label2.Name = "label2";
            label2.Size = new Size(131, 16);
            label2.TabIndex = 2;
            label2.Text = "First Crush Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(299, 273);
            label3.Name = "label3";
            label3.Size = new Size(113, 16);
            label3.TabIndex = 2;
            label3.Text = "First Pet Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(321, 306);
            label4.Name = "label4";
            label4.Size = new Size(91, 16);
            label4.TabIndex = 2;
            label4.Text = "City Born in";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(205, 165);
            label1.Name = "label1";
            label1.Size = new Size(396, 64);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 0, 0);
            button2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(308, 345);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Forgot_Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbAnswer3);
            Controls.Add(tbAnswer2);
            Controls.Add(tbAnswer1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Forgot_Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPass";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbAnswer1;
        private TextBox tbAnswer2;
        private TextBox tbAnswer3;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private Button button2;
    }
}