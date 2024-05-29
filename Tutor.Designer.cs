
namespace StudyAssist
{
    partial class Tutor
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
            this.label7 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DltBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TSubSb = new System.Windows.Forms.ComboBox();
            this.TsalSa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TGenGb = new System.Windows.Forms.ComboBox();
            this.TnameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TDobDb = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TPhnPb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TAddFb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TtrDgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtrDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(226, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 34);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tutor List";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(425, 154);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 36;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DltBtn
            // 
            this.DltBtn.Location = new System.Drawing.Point(324, 154);
            this.DltBtn.Name = "DltBtn";
            this.DltBtn.Size = new System.Drawing.Size(75, 23);
            this.DltBtn.TabIndex = 35;
            this.DltBtn.Text = "Delete";
            this.DltBtn.UseVisualStyleBackColor = true;
            this.DltBtn.Click += new System.EventHandler(this.DltBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(124, 154);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 34;
            this.AddBtn.Text = "Create";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(222, 154);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 33;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Subject";
            // 
            // TSubSb
            // 
            this.TSubSb.FormattingEnabled = true;
            this.TSubSb.Items.AddRange(new object[] {
            "Physics",
            "Chemistry",
            "Biology",
            "Math",
            "Accounting",
            "Geography",
            "English"});
            this.TSubSb.Location = new System.Drawing.Point(360, 82);
            this.TSubSb.Name = "TSubSb";
            this.TSubSb.Size = new System.Drawing.Size(84, 21);
            this.TSubSb.TabIndex = 31;
            this.TSubSb.Text = "Choose";
            // 
            // TsalSa
            // 
            this.TsalSa.Location = new System.Drawing.Point(450, 82);
            this.TsalSa.Name = "TsalSa";
            this.TsalSa.Size = new System.Drawing.Size(147, 20);
            this.TsalSa.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Gender";
            // 
            // TGenGb
            // 
            this.TGenGb.FormattingEnabled = true;
            this.TGenGb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.TGenGb.Location = new System.Drawing.Point(188, 82);
            this.TGenGb.Name = "TGenGb";
            this.TGenGb.Size = new System.Drawing.Size(72, 21);
            this.TGenGb.TabIndex = 24;
            this.TGenGb.Text = "Choose";
            // 
            // TnameTb
            // 
            this.TnameTb.Location = new System.Drawing.Point(45, 83);
            this.TnameTb.Name = "TnameTb";
            this.TnameTb.Size = new System.Drawing.Size(137, 20);
            this.TnameTb.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tutor";
            // 
            // TDobDb
            // 
            this.TDobDb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDobDb.Location = new System.Drawing.Point(266, 83);
            this.TDobDb.Name = "TDobDb";
            this.TDobDb.Size = new System.Drawing.Size(88, 20);
            this.TDobDb.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 54);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::StudyAssist.Properties.Resources.images1;
            this.pictureBox3.Location = new System.Drawing.Point(41, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudyAssist.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(599, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // TPhnPb
            // 
            this.TPhnPb.Location = new System.Drawing.Point(45, 128);
            this.TPhnPb.Name = "TPhnPb";
            this.TPhnPb.Size = new System.Drawing.Size(147, 20);
            this.TPhnPb.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Phone";
            // 
            // TAddFb
            // 
            this.TAddFb.Location = new System.Drawing.Point(198, 128);
            this.TAddFb.Name = "TAddFb";
            this.TAddFb.Size = new System.Drawing.Size(399, 20);
            this.TAddFb.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Address";
            // 
            // TtrDgv
            // 
            this.TtrDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.TtrDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TtrDgv.Location = new System.Drawing.Point(1, 233);
            this.TtrDgv.Name = "TtrDgv";
            this.TtrDgv.Size = new System.Drawing.Size(647, 255);
            this.TtrDgv.TabIndex = 42;
            this.TtrDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TtrDgv_CellContentClick);
            // 
            // Tutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 490);
            this.Controls.Add(this.TtrDgv);
            this.Controls.Add(this.TAddFb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TPhnPb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DltBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TSubSb);
            this.Controls.Add(this.TsalSa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TGenGb);
            this.Controls.Add(this.TnameTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TDobDb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(526, 12);
            this.Name = "Tutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtrDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button DltBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TSubSb;
        private System.Windows.Forms.TextBox TsalSa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TGenGb;
        private System.Windows.Forms.TextBox TnameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TDobDb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TPhnPb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TAddFb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView TtrDgv;
    }
}