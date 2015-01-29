namespace MyGarment.ViewMaster
{
    partial class frmmsize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmsize));
            this.DtGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            this.SimpanTSB = new System.Windows.Forms.ToolStripButton();
            this.UbahTSB = new System.Windows.Forms.ToolStripButton();
            this.HapusTSB = new System.Windows.Forms.ToolStripButton();
            this.BatalTSB = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RecordTSB = new System.Windows.Forms.ToolStripButton();
            this.TutupTSB = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSizeID = new System.Windows.Forms.TextBox();
            this.txtActive = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TSTombol.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DtGrid
            // 
            this.DtGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrid.Location = new System.Drawing.Point(11, 84);
            this.DtGrid.Name = "DtGrid";
            this.DtGrid.ReadOnly = true;
            this.DtGrid.Size = new System.Drawing.Size(475, 178);
            this.DtGrid.TabIndex = 88;
            this.DtGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrid_CellClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // TSTombol
            // 
            this.TSTombol.BackColor = System.Drawing.Color.DarkGray;
            this.TSTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TSTombol.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSTombol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SimpanTSB,
            this.UbahTSB,
            this.HapusTSB,
            this.BatalTSB,
            this.ToolStripSeparator1,
            this.RecordTSB,
            this.TutupTSB});
            this.TSTombol.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TSTombol.Location = new System.Drawing.Point(0, 359);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(500, 25);
            this.TSTombol.TabIndex = 85;
            // 
            // SimpanTSB
            // 
            this.SimpanTSB.Image = ((System.Drawing.Image)(resources.GetObject("SimpanTSB.Image")));
            this.SimpanTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SimpanTSB.Name = "SimpanTSB";
            this.SimpanTSB.Size = new System.Drawing.Size(68, 22);
            this.SimpanTSB.Text = "Simpan";
            this.SimpanTSB.Click += new System.EventHandler(this.SimpanTSB_Click);
            // 
            // UbahTSB
            // 
            this.UbahTSB.Image = ((System.Drawing.Image)(resources.GetObject("UbahTSB.Image")));
            this.UbahTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UbahTSB.Name = "UbahTSB";
            this.UbahTSB.Size = new System.Drawing.Size(56, 22);
            this.UbahTSB.Text = "Ubah";
            this.UbahTSB.Click += new System.EventHandler(this.UbahTSB_Click);
            // 
            // HapusTSB
            // 
            this.HapusTSB.Image = ((System.Drawing.Image)(resources.GetObject("HapusTSB.Image")));
            this.HapusTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HapusTSB.Name = "HapusTSB";
            this.HapusTSB.Size = new System.Drawing.Size(61, 22);
            this.HapusTSB.Text = "Hapus";
            this.HapusTSB.Click += new System.EventHandler(this.HapusTSB_Click);
            // 
            // BatalTSB
            // 
            this.BatalTSB.Image = ((System.Drawing.Image)(resources.GetObject("BatalTSB.Image")));
            this.BatalTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BatalTSB.Name = "BatalTSB";
            this.BatalTSB.Size = new System.Drawing.Size(56, 22);
            this.BatalTSB.Text = "Batal";
            this.BatalTSB.Click += new System.EventHandler(this.BatalTSB_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // RecordTSB
            // 
            this.RecordTSB.Image = ((System.Drawing.Image)(resources.GetObject("RecordTSB.Image")));
            this.RecordTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RecordTSB.Name = "RecordTSB";
            this.RecordTSB.Size = new System.Drawing.Size(53, 22);
            this.RecordTSB.Text = "Find";
            this.RecordTSB.Click += new System.EventHandler(this.RecordTSB_Click);
            // 
            // TutupTSB
            // 
            this.TutupTSB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TutupTSB.Image = ((System.Drawing.Image)(resources.GetObject("TutupTSB.Image")));
            this.TutupTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TutupTSB.Name = "TutupTSB";
            this.TutupTSB.Size = new System.Drawing.Size(61, 22);
            this.TutupTSB.Text = "Tutup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(75, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 83;
            this.label4.Text = "Master Size";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(74, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Form ini digunakan untuk menyimpan daftar size yang ada pada perusahaan, berikut " +
                "informasi mengenai data yang ada.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(148, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "1=Active , 0= Not Active";
            // 
            // txtSizeID
            // 
            this.txtSizeID.BackColor = System.Drawing.SystemColors.Info;
            this.txtSizeID.Location = new System.Drawing.Point(91, 268);
            this.txtSizeID.Name = "txtSizeID";
            this.txtSizeID.Size = new System.Drawing.Size(129, 20);
            this.txtSizeID.TabIndex = 77;
            // 
            // txtActive
            // 
            this.txtActive.FormattingEnabled = true;
            this.txtActive.Items.AddRange(new object[] {
            "1",
            "0"});
            this.txtActive.Location = new System.Drawing.Point(91, 323);
            this.txtActive.Name = "txtActive";
            this.txtActive.Size = new System.Drawing.Size(39, 21);
            this.txtActive.TabIndex = 86;
            this.txtActive.Text = "1";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.pictureBox2);
            this.Panel1.Controls.Add(this.label5);
            this.Panel1.Location = new System.Drawing.Point(-1, -1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(487, 78);
            this.Panel1.TabIndex = 84;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(20, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(50, 50);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 82;
            this.PictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Active";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Size ID";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(91, 294);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(341, 20);
            this.txtDescription.TabIndex = 78;
            // 
            // frmmsize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 384);
            this.Controls.Add(this.DtGrid);
            this.Controls.Add(this.TSTombol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSizeID);
            this.Controls.Add(this.txtActive);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Name = "frmmsize";
            this.Text = "msize";
            this.Load += new System.EventHandler(this.msize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TSTombol.ResumeLayout(false);
            this.TSTombol.PerformLayout();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtGrid;
        internal System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.ToolStrip TSTombol;
        internal System.Windows.Forms.ToolStripButton SimpanTSB;
        internal System.Windows.Forms.ToolStripButton UbahTSB;
        internal System.Windows.Forms.ToolStripButton HapusTSB;
        internal System.Windows.Forms.ToolStripButton BatalTSB;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton RecordTSB;
        internal System.Windows.Forms.ToolStripButton TutupTSB;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSizeID;
        private System.Windows.Forms.ComboBox txtActive;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
    }
}