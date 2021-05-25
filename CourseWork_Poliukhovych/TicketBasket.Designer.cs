namespace CourseWork_Poliukhovych
{
    partial class TicketBasket
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelX = new System.Windows.Forms.PictureBox();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEnter = new System.Windows.Forms.Label();
            this.textBoxEnter = new System.Windows.Forms.TextBox();
            this.labelQuestionAboutPlace = new System.Windows.Forms.Label();
            this.front = new System.Windows.Forms.Button();
            this.stage = new System.Windows.Forms.Label();
            this.centre = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelToBuy = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.checkBoxBook = new System.Windows.Forms.CheckBox();
            this.checkBoxBuy = new System.Windows.Forms.CheckBox();
            this.labelBuyOrBook = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            this.panelToBuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "CashBox";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CancelX);
            this.panel1.Controls.Add(this.pictureBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 86);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TicketBasket_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TicketBasket_MouseMove);
            // 
            // CancelX
            // 
            this.CancelX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelX.Image = global::CourseWork_Poliukhovych.Properties.Resources.iconfinder_cross_4115230;
            this.CancelX.Location = new System.Drawing.Point(767, -1);
            this.CancelX.Name = "CancelX";
            this.CancelX.Size = new System.Drawing.Size(32, 30);
            this.CancelX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CancelX.TabIndex = 8;
            this.CancelX.TabStop = false;
            this.CancelX.Click += new System.EventHandler(this.CancelX_Click);
            // 
            // pictureBack
            // 
            this.pictureBack.Image = global::CourseWork_Poliukhovych.Properties.Resources.toback;
            this.pictureBack.Location = new System.Drawing.Point(-1, -1);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(43, 33);
            this.pictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBack.TabIndex = 20;
            this.pictureBack.TabStop = false;
            this.pictureBack.Click += new System.EventHandler(this.PictureBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEnter.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnter.Location = new System.Drawing.Point(13, 105);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(314, 27);
            this.labelEnter.TabIndex = 5;
            this.labelEnter.Text = "Enter the number of tickets";
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnter.Location = new System.Drawing.Point(353, 102);
            this.textBoxEnter.Multiline = true;
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(70, 35);
            this.textBoxEnter.TabIndex = 6;
            // 
            // labelQuestionAboutPlace
            // 
            this.labelQuestionAboutPlace.AutoSize = true;
            this.labelQuestionAboutPlace.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionAboutPlace.Location = new System.Drawing.Point(12, 150);
            this.labelQuestionAboutPlace.Name = "labelQuestionAboutPlace";
            this.labelQuestionAboutPlace.Size = new System.Drawing.Size(328, 27);
            this.labelQuestionAboutPlace.TabIndex = 7;
            this.labelQuestionAboutPlace.Text = "Where would you like to sit?";
            // 
            // front
            // 
            this.front.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.front.Cursor = System.Windows.Forms.Cursors.Hand;
            this.front.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.front.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.front.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.front.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.front.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.front.Location = new System.Drawing.Point(12, 208);
            this.front.Name = "front";
            this.front.Size = new System.Drawing.Size(324, 35);
            this.front.TabIndex = 8;
            this.front.Text = "Near the front";
            this.front.UseVisualStyleBackColor = false;
            this.front.Click += new System.EventHandler(this.Click_Button);
            // 
            // stage
            // 
            this.stage.AutoSize = true;
            this.stage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stage.Location = new System.Drawing.Point(102, 187);
            this.stage.Name = "stage";
            this.stage.Size = new System.Drawing.Size(107, 18);
            this.stage.TabIndex = 9;
            this.stage.Text = "theatrical stage";
            // 
            // centre
            // 
            this.centre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.centre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.centre.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.centre.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.centre.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.centre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.centre.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centre.Location = new System.Drawing.Point(12, 249);
            this.centre.Name = "centre";
            this.centre.Size = new System.Drawing.Size(324, 35);
            this.centre.TabIndex = 12;
            this.centre.Text = "Somewhere in the middle";
            this.centre.UseVisualStyleBackColor = false;
            this.centre.Click += new System.EventHandler(this.Click_Button);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(12, 294);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(324, 35);
            this.back.TabIndex = 16;
            this.back.Text = "Near the back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.Click_Button);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // panelToBuy
            // 
            this.panelToBuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelToBuy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelToBuy.Controls.Add(this.buttonOk);
            this.panelToBuy.Controls.Add(this.checkBoxBook);
            this.panelToBuy.Controls.Add(this.checkBoxBuy);
            this.panelToBuy.Controls.Add(this.labelBuyOrBook);
            this.panelToBuy.Controls.Add(this.labelEnter);
            this.panelToBuy.Controls.Add(this.textBoxEnter);
            this.panelToBuy.Location = new System.Drawing.Point(363, 150);
            this.panelToBuy.Name = "panelToBuy";
            this.panelToBuy.Size = new System.Drawing.Size(437, 188);
            this.panelToBuy.TabIndex = 19;
            // 
            // buttonOk
            // 
            this.buttonOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOk.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonOk.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(162, 142);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(102, 35);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // checkBoxBook
            // 
            this.checkBoxBook.AutoSize = true;
            this.checkBoxBook.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBook.Location = new System.Drawing.Point(268, 51);
            this.checkBoxBook.Name = "checkBoxBook";
            this.checkBoxBook.Size = new System.Drawing.Size(77, 26);
            this.checkBoxBook.TabIndex = 2;
            this.checkBoxBook.Text = "Book";
            this.checkBoxBook.UseVisualStyleBackColor = true;
            this.checkBoxBook.CheckedChanged += new System.EventHandler(this.CheckBoxBook_CheckedChanged);
            // 
            // checkBoxBuy
            // 
            this.checkBoxBuy.AutoSize = true;
            this.checkBoxBuy.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBuy.Location = new System.Drawing.Point(83, 51);
            this.checkBoxBuy.Name = "checkBoxBuy";
            this.checkBoxBuy.Size = new System.Drawing.Size(66, 26);
            this.checkBoxBuy.TabIndex = 1;
            this.checkBoxBuy.Text = "Buy";
            this.checkBoxBuy.UseVisualStyleBackColor = true;
            this.checkBoxBuy.CheckedChanged += new System.EventHandler(this.CheckBoxBuy_CheckedChanged);
            // 
            // labelBuyOrBook
            // 
            this.labelBuyOrBook.AutoSize = true;
            this.labelBuyOrBook.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuyOrBook.Location = new System.Drawing.Point(33, 11);
            this.labelBuyOrBook.Name = "labelBuyOrBook";
            this.labelBuyOrBook.Size = new System.Drawing.Size(375, 27);
            this.labelBuyOrBook.TabIndex = 0;
            this.labelBuyOrBook.Text = "Would you like to BUY or BOOK?";
            // 
            // TicketBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelToBuy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back);
            this.Controls.Add(this.centre);
            this.Controls.Add(this.stage);
            this.Controls.Add(this.front);
            this.Controls.Add(this.labelQuestionAboutPlace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketBasket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketBasket";
            this.Load += new System.EventHandler(this.TicketBasket_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TicketBasket_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TicketBasket_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            this.panelToBuy.ResumeLayout(false);
            this.panelToBuy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.TextBox textBoxEnter;
        private System.Windows.Forms.Label labelQuestionAboutPlace;
        private System.Windows.Forms.Button front;
        private System.Windows.Forms.Label stage;
        private System.Windows.Forms.Button centre;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelToBuy;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.CheckBox checkBoxBook;
        private System.Windows.Forms.CheckBox checkBoxBuy;
        private System.Windows.Forms.Label labelBuyOrBook;
        private System.Windows.Forms.PictureBox pictureBack;
        private System.Windows.Forms.PictureBox CancelX;
    }
}