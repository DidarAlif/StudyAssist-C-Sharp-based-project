
namespace StudyAssist
{
    partial class Attendance
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
            this.BckBtn = new System.Windows.Forms.Button();
            this.CrtBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AttSttsSb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AttnDatePc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TtrIdIb = new System.Windows.Forms.ComboBox();
            this.TnameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.AttnDgv = new System.Windows.Forms.DataGridView();
            this.RstBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttnDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(179, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 34);
            this.label7.TabIndex = 27;
            this.label7.Text = "Attendance List";
            // 
            // BckBtn
            // 
            this.BckBtn.Location = new System.Drawing.Point(437, 133);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(75, 23);
            this.BckBtn.TabIndex = 36;
            this.BckBtn.Text = "Back";
            this.BckBtn.UseVisualStyleBackColor = true;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // CrtBtn
            // 
            this.CrtBtn.Location = new System.Drawing.Point(136, 133);
            this.CrtBtn.Name = "CrtBtn";
            this.CrtBtn.Size = new System.Drawing.Size(75, 23);
            this.CrtBtn.TabIndex = 34;
            this.CrtBtn.Text = "Create";
            this.CrtBtn.UseVisualStyleBackColor = true;
            this.CrtBtn.Click += new System.EventHandler(this.CrtBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(234, 133);
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
            this.label6.Location = new System.Drawing.Point(456, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Status";
            // 
            // AttSttsSb
            // 
            this.AttSttsSb.FormattingEnabled = true;
            this.AttSttsSb.Items.AddRange(new object[] {
            "Present ",
            "Absent"});
            this.AttSttsSb.Location = new System.Drawing.Point(459, 95);
            this.AttSttsSb.Name = "AttSttsSb";
            this.AttSttsSb.Size = new System.Drawing.Size(106, 21);
            this.AttSttsSb.TabIndex = 31;
            this.AttSttsSb.Text = "Choose";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Date";
            // 
            // AttnDatePc
            // 
            this.AttnDatePc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AttnDatePc.Location = new System.Drawing.Point(336, 96);
            this.AttnDatePc.Name = "AttnDatePc";
            this.AttnDatePc.Size = new System.Drawing.Size(117, 20);
            this.AttnDatePc.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tutor List";
            // 
            // TtrIdIb
            // 
            this.TtrIdIb.FormattingEnabled = true;
            this.TtrIdIb.Location = new System.Drawing.Point(83, 96);
            this.TtrIdIb.Name = "TtrIdIb";
            this.TtrIdIb.Size = new System.Drawing.Size(104, 21);
            this.TtrIdIb.TabIndex = 24;
            this.TtrIdIb.Text = "Choose";
            this.TtrIdIb.SelectionChangeCommitted += new System.EventHandler(this.TtrIdIb_SelectionChangeCommitted);
            // 
            // TnameTb
            // 
            this.TnameTb.Enabled = false;
            this.TnameTb.Location = new System.Drawing.Point(193, 97);
            this.TnameTb.Name = "TnameTb";
            this.TnameTb.Size = new System.Drawing.Size(137, 20);
            this.TnameTb.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tutor Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudyAssist.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(591, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendance";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 54);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::StudyAssist.Properties.Resources.images__1_;
            this.pictureBox5.Location = new System.Drawing.Point(12, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(84, 54);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // AttnDgv
            // 
            this.AttnDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.AttnDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttnDgv.Location = new System.Drawing.Point(1, 229);
            this.AttnDgv.Name = "AttnDgv";
            this.AttnDgv.Size = new System.Drawing.Size(647, 255);
            this.AttnDgv.TabIndex = 43;
            this.AttnDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttnDgv_CellContentClick);
            // 
            // RstBtn
            // 
            this.RstBtn.Location = new System.Drawing.Point(336, 133);
            this.RstBtn.Name = "RstBtn";
            this.RstBtn.Size = new System.Drawing.Size(75, 23);
            this.RstBtn.TabIndex = 44;
            this.RstBtn.Text = "Reset";
            this.RstBtn.UseVisualStyleBackColor = true;
            this.RstBtn.Click += new System.EventHandler(this.RstBtn_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 490);
            this.Controls.Add(this.RstBtn);
            this.Controls.Add(this.AttnDgv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BckBtn);
            this.Controls.Add(this.CrtBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AttSttsSb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AttnDatePc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TtrIdIb);
            this.Controls.Add(this.TnameTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(326, 82);
            this.Name = "Attendance";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttnDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BckBtn;
        private System.Windows.Forms.Button CrtBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox AttSttsSb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker AttnDatePc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TtrIdIb;
        private System.Windows.Forms.TextBox TnameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView AttnDgv;
        private System.Windows.Forms.Button RstBtn;
    }
}