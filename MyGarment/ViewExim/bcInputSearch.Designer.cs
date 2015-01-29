namespace MyGarment.ViewExim
{
    partial class frmbcInputSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbcInputSearch));
            this.DtGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.TutupTSB = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtOfficer = new System.Windows.Forms.TextBox();
            this.RecordTSB = new System.Windows.Forms.ToolStripButton();
            this.txtGRNNO = new System.Windows.Forms.TextBox();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPONO = new System.Windows.Forms.TextBox();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrid)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.TSTombol.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtGrid
            // 
            this.DtGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrid.Location = new System.Drawing.Point(10, 85);
            this.DtGrid.Name = "DtGrid";
            this.DtGrid.ReadOnly = true;
            this.DtGrid.Size = new System.Drawing.Size(664, 181);
            this.DtGrid.TabIndex = 91;
            this.DtGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrid_CellContentClick);
            this.DtGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrid_CellDoubleClick);
            this.DtGrid.DoubleClick += new System.EventHandler(this.DtGrid_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "ItemsID/StyleID";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Maroon;
            this.Label3.Location = new System.Drawing.Point(64, 13);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(205, 16);
            this.Label3.TabIndex = 34;
            this.Label3.Text = "Bea Cukai Dokument Search";
            // 
            // txtStyle
            // 
            this.txtStyle.Location = new System.Drawing.Point(87, 65);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(129, 20);
            this.txtStyle.TabIndex = 82;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Doc No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Created By";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Location = new System.Drawing.Point(-1, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(675, 78);
            this.Panel1.TabIndex = 92;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(64, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(390, 30);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Form ini digunakan untuk mencari currency";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(9, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(50, 50);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 33;
            this.PictureBox1.TabStop = false;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(292, 36);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(164, 20);
            this.txtCustomer.TabIndex = 76;
            // 
            // txtOfficer
            // 
            this.txtOfficer.Location = new System.Drawing.Point(292, 13);
            this.txtOfficer.Name = "txtOfficer";
            this.txtOfficer.Size = new System.Drawing.Size(164, 20);
            this.txtOfficer.TabIndex = 75;
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
            // txtGRNNO
            // 
            this.txtGRNNO.BackColor = System.Drawing.SystemColors.Info;
            this.txtGRNNO.Location = new System.Drawing.Point(87, 13);
            this.txtGRNNO.Name = "txtGRNNO";
            this.txtGRNNO.Size = new System.Drawing.Size(129, 20);
            this.txtGRNNO.TabIndex = 67;
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtStyle);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCustomer);
            this.panel2.Controls.Add(this.txtOfficer);
            this.panel2.Controls.Add(this.txtGRNNO);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPONO);
            this.panel2.Location = new System.Drawing.Point(10, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 100);
            this.panel2.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Trans No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "No Aju";
            // 
            // txtPONO
            // 
            this.txtPONO.Location = new System.Drawing.Point(87, 39);
            this.txtPONO.Name = "txtPONO";
            this.txtPONO.Size = new System.Drawing.Size(129, 20);
            this.txtPONO.TabIndex = 68;
            // 
            // TSTombol
            // 
            this.TSTombol.BackColor = System.Drawing.Color.DarkGray;
            this.TSTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TSTombol.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSTombol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSeparator1,
            this.RecordTSB,
            this.TutupTSB});
            this.TSTombol.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TSTombol.Location = new System.Drawing.Point(0, 417);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(691, 25);
            this.TSTombol.TabIndex = 94;
            // 
            // frmbcInputSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 442);
            this.Controls.Add(this.DtGrid);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TSTombol);
            this.Name = "frmbcInputSearch";
            this.Text = "bcInputSearch";
            this.Load += new System.EventHandler(this.frmbcInputSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGrid)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TSTombol.ResumeLayout(false);
            this.TSTombol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox txtStyle;
        private System.Windows.Forms.ToolStripButton TutupTSB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtOfficer;
        private System.Windows.Forms.ToolStripButton RecordTSB;
        private System.Windows.Forms.TextBox txtGRNNO;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPONO;
        private System.Windows.Forms.ToolStrip TSTombol;
    }
}