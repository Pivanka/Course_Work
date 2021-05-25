namespace CourseWork_Poliukhovych
{
    partial class Authorization
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminpass = new System.Windows.Forms.TextBox();
            this.adminlogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.CancelX = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 121);
            this.panel1.TabIndex = 12;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginButton.Location = new System.Drawing.Point(314, 38);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(158, 38);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(262, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(262, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login";
            // 
            // adminpass
            // 
            this.adminpass.Font = new System.Drawing.Font("Arial Unicode MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminpass.Location = new System.Drawing.Point(270, 259);
            this.adminpass.Name = "adminpass";
            this.adminpass.PasswordChar = '*';
            this.adminpass.Size = new System.Drawing.Size(255, 44);
            this.adminpass.TabIndex = 9;
            this.adminpass.UseSystemPasswordChar = true;
            // 
            // adminlogin
            // 
            this.adminlogin.Font = new System.Drawing.Font("Arial Unicode MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminlogin.Location = new System.Drawing.Point(270, 160);
            this.adminlogin.Multiline = true;
            this.adminlogin.Name = "adminlogin";
            this.adminlogin.Size = new System.Drawing.Size(255, 44);
            this.adminlogin.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork_Poliukhovych.Properties.Resources.password;
            this.pictureBox1.Location = new System.Drawing.Point(364, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBack
            // 
            this.pictureBack.Image = global::CourseWork_Poliukhovych.Properties.Resources.toback;
            this.pictureBack.Location = new System.Drawing.Point(0, 1);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(43, 33);
            this.pictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBack.TabIndex = 21;
            this.pictureBack.TabStop = false;
            this.pictureBack.Click += new System.EventHandler(this.PictureBack_Click);
            // 
            // CancelX
            // 
            this.CancelX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelX.Image = global::CourseWork_Poliukhovych.Properties.Resources.iconfinder_cross_4115230;
            this.CancelX.Location = new System.Drawing.Point(768, 1);
            this.CancelX.Name = "CancelX";
            this.CancelX.Size = new System.Drawing.Size(32, 30);
            this.CancelX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CancelX.TabIndex = 22;
            this.CancelX.TabStop = false;
            this.CancelX.Click += new System.EventHandler(this.CancelX_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelX);
            this.Controls.Add(this.pictureBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminpass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Authorization_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Authorization_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminpass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox adminlogin;
        private System.Windows.Forms.PictureBox pictureBack;
        private System.Windows.Forms.PictureBox CancelX;
    }
}