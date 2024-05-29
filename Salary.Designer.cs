
namespace StudyAssist
{
    partial class Salary
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
            this.label7 = new System.Windows.Forms.Label();
            this.BckBtn = new System.Windows.Forms.Button();
            this.CrtBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MgrDrnRb = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.MgrIdtb = new System.Windows.Forms.ComboBox();
            this.MgrNmNb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MgrAmntMb = new System.Windows.Forms.TextBox();
            this.SlryDgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlryDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(223, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 34);
            this.label7.TabIndex = 44;
            this.label7.Text = "Salary Data";
            // 
            // BckBtn
            // 
            this.BckBtn.Location = new System.Drawing.Point(357, 132);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(75, 23);
            this.BckBtn.TabIndex = 51;
            this.BckBtn.Text = "Back";
            this.BckBtn.UseVisualStyleBackColor = true;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // CrtBtn
            // 
            this.CrtBtn.Location = new System.Drawing.Point(229, 132);
            this.CrtBtn.Name = "CrtBtn";
            this.CrtBtn.Size = new System.Drawing.Size(75, 23);
            this.CrtBtn.TabIndex = 49;
            this.CrtBtn.Text = "Pay Salary";
            this.CrtBtn.UseVisualStyleBackColor = true;
            this.CrtBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Duration";
            // 
            // MgrDrnRb
            // 
            this.MgrDrnRb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MgrDrnRb.Location = new System.Drawing.Point(331, 95);
            this.MgrDrnRb.Name = "MgrDrnRb";
            this.MgrDrnRb.Size = new System.Drawing.Size(117, 20);
            this.MgrDrnRb.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Manager List";
            // 
            // MgrIdtb
            // 
            this.MgrIdtb.FormattingEnabled = true;
            this.MgrIdtb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.MgrIdtb.Location = new System.Drawing.Point(78, 95);
            this.MgrIdtb.Name = "MgrIdtb";
            this.MgrIdtb.Size = new System.Drawing.Size(104, 21);
            this.MgrIdtb.TabIndex = 41;
            this.MgrIdtb.Text = "Choose";
            this.MgrIdtb.SelectionChangeCommitted += new System.EventHandler(this.MgrIdtb_SelectionChangeCommitted);
            // 
            // MgrNmNb
            // 
            this.MgrNmNb.Enabled = false;
            this.MgrNmNb.Location = new System.Drawing.Point(188, 96);
            this.MgrNmNb.Name = "MgrNmNb";
            this.MgrNmNb.Size = new System.Drawing.Size(137, 20);
            this.MgrNmNb.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Manager Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 54);
            this.panel1.TabIndex = 38;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::StudyAssist.Properties.Resources.download__1_;
            this.pictureBox4.Location = new System.Drawing.Point(26, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudyAssist.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(595, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MgrAmntMb
            // 
            this.MgrAmntMb.Enabled = false;
            this.MgrAmntMb.Location = new System.Drawing.Point(454, 94);
            this.MgrAmntMb.Name = "MgrAmntMb";
            this.MgrAmntMb.Size = new System.Drawing.Size(121, 20);
            this.MgrAmntMb.TabIndex = 53;
            // 
            // SlryDgv
            // 
            this.SlryDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.SlryDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SlryDgv.Location = new System.Drawing.Point(-1, 236);
            this.SlryDgv.Name = "SlryDgv";
            this.SlryDgv.Size = new System.Drawing.Size(646, 255);
            this.SlryDgv.TabIndex = 54;
            this.SlryDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SlryDgv_CellContentClick);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 490);
            this.Controls.Add(this.SlryDgv);
            this.Controls.Add(this.MgrAmntMb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BckBtn);
            this.Controls.Add(this.CrtBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MgrDrnRb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MgrIdtb);
            this.Controls.Add(this.MgrNmNb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlryDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BckBtn;
        private System.Windows.Forms.Button CrtBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker MgrDrnRb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MgrIdtb;
        private System.Windows.Forms.TextBox MgrNmNb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox MgrAmntMb;
        private System.Windows.Forms.DataGridView SlryDgv;
    }
}