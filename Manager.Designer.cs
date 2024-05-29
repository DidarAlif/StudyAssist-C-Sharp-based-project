
namespace StudyAssist
{
    partial class Manager
    {
        private const string Mgr = "Manager";

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MgrNameTb = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.MgrGenGb = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.Label();
            this.DobPb = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.Label();
            this.SalarySb = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.Branch = new System.Windows.Forms.Label();
            this.branchCb = new System.Windows.Forms.ComboBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.CrtBtn = new System.Windows.Forms.Button();
            this.DltBtn = new System.Windows.Forms.Button();
            this.BckBtn = new System.Windows.Forms.Button();
            this.MgrDvg = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MgrDvg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 54);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::StudyAssist.Properties.Resources.download__5_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudyAssist.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(597, 12);
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
            this.label1.Size = new System.Drawing.Size(165, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manager";
            // 
            // MgrNameTb
            // 
            this.MgrNameTb.Location = new System.Drawing.Point(45, 89);
            this.MgrNameTb.Name = "MgrNameTb";
            this.MgrNameTb.Size = new System.Drawing.Size(137, 20);
            this.MgrNameTb.TabIndex = 7;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(42, 73);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 6;
            this.name.Text = "Name";
            // 
            // MgrGenGb
            // 
            this.MgrGenGb.FormattingEnabled = true;
            this.MgrGenGb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.MgrGenGb.Location = new System.Drawing.Point(188, 88);
            this.MgrGenGb.Name = "MgrGenGb";
            this.MgrGenGb.Size = new System.Drawing.Size(72, 21);
            this.MgrGenGb.TabIndex = 8;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(185, 73);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(42, 13);
            this.gender.TabIndex = 9;
            this.gender.Text = "Gender";
            // 
            // DobPb
            // 
            this.DobPb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DobPb.Location = new System.Drawing.Point(266, 89);
            this.DobPb.Name = "DobPb";
            this.DobPb.Size = new System.Drawing.Size(88, 20);
            this.DobPb.TabIndex = 10;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(263, 73);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(66, 13);
            this.Date.TabIndex = 11;
            this.Date.Text = "Date of Birth";
            // 
            // SalarySb
            // 
            this.SalarySb.Location = new System.Drawing.Point(450, 88);
            this.SalarySb.Name = "SalarySb";
            this.SalarySb.Size = new System.Drawing.Size(147, 20);
            this.SalarySb.TabIndex = 13;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(447, 72);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(36, 13);
            this.Salary.TabIndex = 12;
            this.Salary.Text = "Salary";
            // 
            // Branch
            // 
            this.Branch.AutoSize = true;
            this.Branch.Location = new System.Drawing.Point(357, 73);
            this.Branch.Name = "Branch";
            this.Branch.Size = new System.Drawing.Size(41, 13);
            this.Branch.TabIndex = 15;
            this.Branch.Text = "Branch";
            // 
            // branchCb
            // 
            this.branchCb.FormattingEnabled = true;
            this.branchCb.Items.AddRange(new object[] {
            "Dhanmondi",
            "Motijheel",
            "Kalabagan",
            "Mirpur",
            "Farmgate",
            "Bonani",
            "Gulshan",
            "Mohammadpur"});
            this.branchCb.Location = new System.Drawing.Point(360, 88);
            this.branchCb.Name = "branchCb";
            this.branchCb.Size = new System.Drawing.Size(84, 21);
            this.branchCb.TabIndex = 14;
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(221, 124);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 16;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // CrtBtn
            // 
            this.CrtBtn.Location = new System.Drawing.Point(123, 124);
            this.CrtBtn.Name = "CrtBtn";
            this.CrtBtn.Size = new System.Drawing.Size(75, 23);
            this.CrtBtn.TabIndex = 17;
            this.CrtBtn.Text = "Create";
            this.CrtBtn.UseVisualStyleBackColor = true;
            this.CrtBtn.Click += new System.EventHandler(this.CrtBtn_Click);
            // 
            // DltBtn
            // 
            this.DltBtn.Location = new System.Drawing.Point(323, 124);
            this.DltBtn.Name = "DltBtn";
            this.DltBtn.Size = new System.Drawing.Size(75, 23);
            this.DltBtn.TabIndex = 18;
            this.DltBtn.Text = "Delete";
            this.DltBtn.UseVisualStyleBackColor = true;
            this.DltBtn.Click += new System.EventHandler(this.DltBtn_Click);
            // 
            // BckBtn
            // 
            this.BckBtn.Location = new System.Drawing.Point(424, 124);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(75, 23);
            this.BckBtn.TabIndex = 19;
            this.BckBtn.Text = "Back";
            this.BckBtn.UseVisualStyleBackColor = true;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // MgrDvg
            // 
            this.MgrDvg.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.MgrDvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MgrDvg.Location = new System.Drawing.Point(0, 209);
            this.MgrDvg.Name = "MgrDvg";
            this.MgrDvg.Size = new System.Drawing.Size(647, 255);
            this.MgrDvg.TabIndex = 20;
            this.MgrDvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MgrDvg_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(215, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 34);
            this.label7.TabIndex = 10;
            this.label7.Text = "Manager List";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 490);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MgrDvg);
            this.Controls.Add(this.BckBtn);
            this.Controls.Add(this.DltBtn);
            this.Controls.Add(this.CrtBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.Branch);
            this.Controls.Add(this.branchCb);
            this.Controls.Add(this.SalarySb);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.DobPb);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.MgrGenGb);
            this.Controls.Add(this.MgrNameTb);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MgrDvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox MgrNameTb;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ComboBox MgrGenGb;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.DateTimePicker DobPb;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox SalarySb;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label Branch;
        private System.Windows.Forms.ComboBox branchCb;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button CrtBtn;
        private System.Windows.Forms.Button DltBtn;
        private System.Windows.Forms.Button BckBtn;
        private System.Windows.Forms.DataGridView MgrDvg;
        private System.Windows.Forms.Label label7;
    }
}