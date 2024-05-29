
namespace StudyAssist
{
    partial class Schedule
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
            this.components = new System.ComponentModel.Container();
            this.EddWb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BckBtn = new System.Windows.Forms.Button();
            this.CrtBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EdescEb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EdtMe = new System.Windows.Forms.DateTimePicker();
            this.ScdlDgv = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DltBtn = new System.Windows.Forms.Button();
            this.EdtBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScdlDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // EddWb
            // 
            this.EddWb.Location = new System.Drawing.Point(455, 95);
            this.EddWb.Name = "EddWb";
            this.EddWb.Size = new System.Drawing.Size(122, 20);
            this.EddWb.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(234, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 34);
            this.label7.TabIndex = 60;
            this.label7.Text = "Schedule";
            // 
            // BckBtn
            // 
            this.BckBtn.Location = new System.Drawing.Point(425, 142);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(76, 23);
            this.BckBtn.TabIndex = 66;
            this.BckBtn.Text = "Back";
            this.BckBtn.UseVisualStyleBackColor = true;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // CrtBtn
            // 
            this.CrtBtn.Location = new System.Drawing.Point(124, 142);
            this.CrtBtn.Name = "CrtBtn";
            this.CrtBtn.Size = new System.Drawing.Size(76, 23);
            this.CrtBtn.TabIndex = 64;
            this.CrtBtn.Text = "Create";
            this.CrtBtn.UseVisualStyleBackColor = true;
            this.CrtBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Date and Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Date";
            // 
            // EdescEb
            // 
            this.EdescEb.Location = new System.Drawing.Point(62, 95);
            this.EdescEb.Name = "EdescEb";
            this.EdescEb.Size = new System.Drawing.Size(138, 20);
            this.EdescEb.TabIndex = 56;
            this.EdescEb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Class";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 54);
            this.panel1.TabIndex = 54;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::StudyAssist.Properties.Resources.download__2_1;
            this.pictureBox7.Location = new System.Drawing.Point(22, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(71, 51);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
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
            this.label1.Size = new System.Drawing.Size(186, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schedule";
            // 
            // EdtMe
            // 
            this.EdtMe.Location = new System.Drawing.Point(222, 95);
            this.EdtMe.Name = "EdtMe";
            this.EdtMe.Size = new System.Drawing.Size(201, 20);
            this.EdtMe.TabIndex = 59;
            this.EdtMe.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ScdlDgv
            // 
            this.ScdlDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScdlDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScdlDgv.Location = new System.Drawing.Point(0, 236);
            this.ScdlDgv.Name = "ScdlDgv";
            this.ScdlDgv.Size = new System.Drawing.Size(647, 255);
            this.ScdlDgv.TabIndex = 69;
            this.ScdlDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScdlDgv_CellContentClick);
            // 
            // DltBtn
            // 
            this.DltBtn.Location = new System.Drawing.Point(324, 142);
            this.DltBtn.Name = "DltBtn";
            this.DltBtn.Size = new System.Drawing.Size(76, 23);
            this.DltBtn.TabIndex = 65;
            this.DltBtn.Text = "Delete";
            this.DltBtn.UseVisualStyleBackColor = true;
            this.DltBtn.Click += new System.EventHandler(this.DltBtn_Click);
            // 
            // EdtBtn
            // 
            this.EdtBtn.Location = new System.Drawing.Point(222, 142);
            this.EdtBtn.Name = "EdtBtn";
            this.EdtBtn.Size = new System.Drawing.Size(76, 23);
            this.EdtBtn.TabIndex = 63;
            this.EdtBtn.Text = "Edit";
            this.EdtBtn.UseVisualStyleBackColor = true;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 492);
            this.Controls.Add(this.ScdlDgv);
            this.Controls.Add(this.EddWb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BckBtn);
            this.Controls.Add(this.DltBtn);
            this.Controls.Add(this.CrtBtn);
            this.Controls.Add(this.EdtBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EdescEb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EdtMe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScdlDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EddWb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BckBtn;
        private System.Windows.Forms.Button CrtBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EdescEb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker EdtMe;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DataGridView ScdlDgv;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button DltBtn;
        private System.Windows.Forms.Button EdtBtn;
    }
}