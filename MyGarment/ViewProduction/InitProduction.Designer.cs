namespace MyGarment.ViewProduction
{
    partial class frmInitProduction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInitProduction));
            this.dtColor = new System.Windows.Forms.DataGridView();
            this.hJONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hStyleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hColorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDelivery = new JThomas.Controls.DataGridViewMaskedTextColumn();
            this.hStart = new JThomas.Controls.DataGridViewMaskedTextColumn();
            this.hClose = new JThomas.Controls.DataGridViewMaskedTextColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJONO = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            this.SimpanTSB = new System.Windows.Forms.ToolStripButton();
            this.TutupTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtStyleID = new System.Windows.Forms.TextBox();
            this.dtSize = new System.Windows.Forms.DataGridView();
            this.dStyleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSizeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dQtyPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNoUrut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsumption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtColor)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.TSTombol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSize)).BeginInit();
            this.SuspendLayout();
            // 
            // dtColor
            // 
            this.dtColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtColor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hJONO,
            this.hStyleID,
            this.hColorID,
            this.hDelivery,
            this.hStart,
            this.hClose});
            this.dtColor.Location = new System.Drawing.Point(12, 101);
            this.dtColor.Name = "dtColor";
            this.dtColor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtColor.RowHeadersWidth = 50;
            this.dtColor.Size = new System.Drawing.Size(657, 98);
            this.dtColor.TabIndex = 107;
            // 
            // hJONO
            // 
            this.hJONO.HeaderText = "JONO";
            this.hJONO.Name = "hJONO";
            // 
            // hStyleID
            // 
            this.hStyleID.HeaderText = "Style";
            this.hStyleID.Name = "hStyleID";
            // 
            // hColorID
            // 
            this.hColorID.HeaderText = "Color";
            this.hColorID.Name = "hColorID";
            // 
            // hDelivery
            // 
            dataGridViewCellStyle1.Format = "\"dd/MM/yyyy\"";
            this.hDelivery.DefaultCellStyle = dataGridViewCellStyle1;
            this.hDelivery.HeaderText = "Delivery";
            this.hDelivery.Mask = "00/00/0000";
            this.hDelivery.Name = "hDelivery";
            this.hDelivery.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hDelivery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // hStart
            // 
            dataGridViewCellStyle2.Format = "\"dd/MM/yyyy\"";
            this.hStart.DefaultCellStyle = dataGridViewCellStyle2;
            this.hStart.HeaderText = "Start Date";
            this.hStart.Mask = "00/00/0000";
            this.hStart.Name = "hStart";
            this.hStart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // hClose
            // 
            dataGridViewCellStyle3.Format = "\"dd/MM/yyyy\"";
            this.hClose.DefaultCellStyle = dataGridViewCellStyle3;
            this.hClose.HeaderText = "Close Date";
            this.hClose.Mask = "00/00/0000";
            this.hClose.Name = "hClose";
            this.hClose.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hClose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Location = new System.Drawing.Point(12, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(714, 38);
            this.Panel1.TabIndex = 106;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(19, 8);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(16, 17);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 122;
            this.PictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(41, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Initial Production";
            // 
            // txtJONO
            // 
            this.txtJONO.BackColor = System.Drawing.SystemColors.Info;
            this.txtJONO.Location = new System.Drawing.Point(81, 58);
            this.txtJONO.Name = "txtJONO";
            this.txtJONO.Size = new System.Drawing.Size(196, 20);
            this.txtJONO.TabIndex = 277;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(283, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 279;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 278;
            this.label8.Text = "JONO";
            // 
            // TSTombol
            // 
            this.TSTombol.BackColor = System.Drawing.Color.DarkGray;
            this.TSTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TSTombol.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSTombol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SimpanTSB,
            this.TutupTSB,
            this.toolStripSeparator2});
            this.TSTombol.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TSTombol.Location = new System.Drawing.Point(0, 498);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(697, 25);
            this.TSTombol.TabIndex = 280;
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
            // TutupTSB
            // 
            this.TutupTSB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TutupTSB.Image = ((System.Drawing.Image)(resources.GetObject("TutupTSB.Image")));
            this.TutupTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TutupTSB.Name = "TutupTSB";
            this.TutupTSB.Size = new System.Drawing.Size(61, 22);
            this.TutupTSB.Text = "Tutup";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // txtStyleID
            // 
            this.txtStyleID.Location = new System.Drawing.Point(433, 61);
            this.txtStyleID.Name = "txtStyleID";
            this.txtStyleID.Size = new System.Drawing.Size(236, 20);
            this.txtStyleID.TabIndex = 281;
            // 
            // dtSize
            // 
            this.dtSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dStyleID,
            this.dSizeID,
            this.dQtyPlan,
            this.dNoUrut,
            this.dRatio});
            this.dtSize.Location = new System.Drawing.Point(12, 253);
            this.dtSize.Name = "dtSize";
            this.dtSize.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtSize.RowHeadersWidth = 50;
            this.dtSize.Size = new System.Drawing.Size(655, 226);
            this.dtSize.TabIndex = 282;
            // 
            // dStyleID
            // 
            this.dStyleID.HeaderText = "Style";
            this.dStyleID.Name = "dStyleID";
            // 
            // dSizeID
            // 
            this.dSizeID.HeaderText = "Size";
            this.dSizeID.Name = "dSizeID";
            // 
            // dQtyPlan
            // 
            this.dQtyPlan.HeaderText = "Qty Plan";
            this.dQtyPlan.Name = "dQtyPlan";
            // 
            // dNoUrut
            // 
            this.dNoUrut.HeaderText = "LineNo";
            this.dNoUrut.Name = "dNoUrut";
            // 
            // dRatio
            // 
            this.dRatio.HeaderText = "Ratio";
            this.dRatio.Name = "dRatio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 283;
            this.label1.Text = "Style";
            // 
            // txtConsumption
            // 
            this.txtConsumption.Location = new System.Drawing.Point(69, 227);
            this.txtConsumption.Name = "txtConsumption";
            this.txtConsumption.Size = new System.Drawing.Size(100, 20);
            this.txtConsumption.TabIndex = 284;
            this.txtConsumption.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 285;
            this.label2.Text = "Consp";
            // 
            // frmInitProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConsumption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtSize);
            this.Controls.Add(this.txtStyleID);
            this.Controls.Add(this.TSTombol);
            this.Controls.Add(this.txtJONO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtColor);
            this.Controls.Add(this.Panel1);
            this.Name = "frmInitProduction";
            this.Text = "InitProduction";
            ((System.ComponentModel.ISupportInitialize)(this.dtColor)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.TSTombol.ResumeLayout(false);
            this.TSTombol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtColor;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJONO;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ToolStrip TSTombol;
        internal System.Windows.Forms.ToolStripButton SimpanTSB;
        internal System.Windows.Forms.ToolStripButton TutupTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.TextBox txtStyleID;
        private System.Windows.Forms.DataGridView dtSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dStyleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSizeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dQtyPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNoUrut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRatio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hJONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn hStyleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hColorID;
        private JThomas.Controls.DataGridViewMaskedTextColumn hDelivery;
        private JThomas.Controls.DataGridViewMaskedTextColumn hStart;
        private JThomas.Controls.DataGridViewMaskedTextColumn hClose;
        private System.Windows.Forms.TextBox txtConsumption;
        private System.Windows.Forms.Label label2;
    }
}