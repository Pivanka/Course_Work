namespace CourseWork_Poliukhovych
{
    partial class BoxOffice
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxOffice));
            this.labelBoxOffice = new System.Windows.Forms.Label();
            this.checkedListChoose = new System.Windows.Forms.CheckedListBox();
            this.labelQuestionDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.FindText = new System.Windows.Forms.TextBox();
            this.listforbox = new System.Windows.Forms.ListBox();
            this.labelwithperfomances = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.findresult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CancelX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelX)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBoxOffice
            // 
            this.labelBoxOffice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBoxOffice.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBoxOffice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBoxOffice.Location = new System.Drawing.Point(0, 0);
            this.labelBoxOffice.Name = "labelBoxOffice";
            this.labelBoxOffice.Size = new System.Drawing.Size(485, 41);
            this.labelBoxOffice.TabIndex = 0;
            this.labelBoxOffice.Text = "Box Office";
            // 
            // checkedListChoose
            // 
            this.checkedListChoose.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkedListChoose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListChoose.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListChoose.FormattingEnabled = true;
            this.checkedListChoose.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.checkedListChoose.Location = new System.Drawing.Point(10, 72);
            this.checkedListChoose.Name = "checkedListChoose";
            this.checkedListChoose.Size = new System.Drawing.Size(204, 44);
            this.checkedListChoose.TabIndex = 14;
            this.checkedListChoose.SelectedIndexChanged += new System.EventHandler(this.CheckedListChoose_SelectedIndexChanged);
            // 
            // labelQuestionDate
            // 
            this.labelQuestionDate.AutoSize = true;
            this.labelQuestionDate.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionDate.Location = new System.Drawing.Point(6, 47);
            this.labelQuestionDate.Name = "labelQuestionDate";
            this.labelQuestionDate.Size = new System.Drawing.Size(395, 22);
            this.labelQuestionDate.TabIndex = 13;
            this.labelQuestionDate.Text = "do you want to choose a perfomance date?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Okay, just look for what you want";
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FindButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FindButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FindButton.Location = new System.Drawing.Point(337, 145);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(113, 37);
            this.FindButton.TabIndex = 18;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FindText
            // 
            this.FindText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.FindText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindText.Location = new System.Drawing.Point(10, 145);
            this.FindText.Multiline = true;
            this.FindText.Name = "FindText";
            this.FindText.Size = new System.Drawing.Size(321, 37);
            this.FindText.TabIndex = 17;
            // 
            // listforbox
            // 
            this.listforbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listforbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listforbox.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listforbox.FormattingEnabled = true;
            this.listforbox.ItemHeight = 20;
            this.listforbox.Location = new System.Drawing.Point(3, 39);
            this.listforbox.Name = "listforbox";
            this.listforbox.Size = new System.Drawing.Size(297, 280);
            this.listforbox.TabIndex = 1;
            // 
            // labelwithperfomances
            // 
            this.labelwithperfomances.AutoSize = true;
            this.labelwithperfomances.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwithperfomances.Location = new System.Drawing.Point(-1, 14);
            this.labelwithperfomances.Name = "labelwithperfomances";
            this.labelwithperfomances.Size = new System.Drawing.Size(217, 22);
            this.labelwithperfomances.TabIndex = 0;
            this.labelwithperfomances.Text = "Perfomances available";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.findresult);
            this.splitContainer1.Panel1.Controls.Add(this.labelBoxOffice);
            this.splitContainer1.Panel1.Controls.Add(this.labelQuestionDate);
            this.splitContainer1.Panel1.Controls.Add(this.checkedListChoose);
            this.splitContainer1.Panel1.Controls.Add(this.FindButton);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.FindText);
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SplitContainer1_MouseDown);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SplitContainer1_MouseMove);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.listforbox);
            this.splitContainer1.Panel2.Controls.Add(this.labelwithperfomances);
            this.splitContainer1.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SplitContainer1_MouseDown);
            this.splitContainer1.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SplitContainer1_MouseMove);
            this.splitContainer1.Size = new System.Drawing.Size(800, 422);
            this.splitContainer1.SplitterDistance = 489;
            this.splitContainer1.TabIndex = 22;
            this.splitContainer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SplitContainer1_MouseDown);
            this.splitContainer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SplitContainer1_MouseMove);
            // 
            // findresult
            // 
            this.findresult.AutoSize = true;
            this.findresult.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findresult.Location = new System.Drawing.Point(10, 188);
            this.findresult.Name = "findresult";
            this.findresult.Size = new System.Drawing.Size(68, 22);
            this.findresult.TabIndex = 20;
            this.findresult.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // CancelX
            // 
            this.CancelX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelX.Image = global::CourseWork_Poliukhovych.Properties.Resources.iconfinder_cross_4115230;
            this.CancelX.Location = new System.Drawing.Point(768, -3);
            this.CancelX.Name = "CancelX";
            this.CancelX.Size = new System.Drawing.Size(32, 32);
            this.CancelX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CancelX.TabIndex = 3;
            this.CancelX.TabStop = false;
            this.CancelX.Click += new System.EventHandler(this.CancelX_Click);
            // 
            // BoxOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelX);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoxOffice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoxOffice";
            this.Load += new System.EventHandler(this.BoxOffice_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SplitContainer1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SplitContainer1_MouseMove);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelBoxOffice;
        private System.Windows.Forms.CheckedListBox checkedListChoose;
        private System.Windows.Forms.Label labelQuestionDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox FindText;
        private System.Windows.Forms.ListBox listforbox;
        public System.Windows.Forms.Label labelwithperfomances;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label findresult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox CancelX;
    }
}

