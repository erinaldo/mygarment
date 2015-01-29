namespace MyGarment.ViewStore
{
    partial class frmginComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmginComponent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbJENIS = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdPONO = new System.Windows.Forms.Button();
            this.txtPONO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbStore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRefer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.hDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hGINNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hGINNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hItemsID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hJenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hColorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hSizeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hStyleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hUom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmdCustomer = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SimpanTSB = new System.Windows.Forms.ToolStripButton();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            this.UbahTSB = new System.Windows.Forms.ToolStripButton();
            this.HapusTSB = new System.Windows.Forms.ToolStripButton();
            this.RecordTSB = new System.Windows.Forms.ToolStripButton();
            this.TutupTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Print = new System.Windows.Forms.ToolStripButton();
            this.dateCreated = new System.Windows.Forms.DateTimePicker();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtGRNNO = new System.Windows.Forms.TextBox();
            this.txtCustomerDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDIV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.TSTombol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbJENIS
            // 
            this.cbJENIS.FormattingEnabled = true;
            this.cbJENIS.Items.AddRange(new object[] {
            "RAW",
            "PROCESS",
            "PRODUCT",
            ""});
            this.cbJENIS.Location = new System.Drawing.Point(79, 185);
            this.cbJENIS.Name = "cbJENIS";
            this.cbJENIS.Size = new System.Drawing.Size(204, 21);
            this.cbJENIS.TabIndex = 246;
            this.cbJENIS.Text = "PROCESS";
            this.cbJENIS.SelectedIndexChanged += new System.EventHandler(this.cbJENIS_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 245;
            this.label10.Text = "Type";
            // 
            // cmdPONO
            // 
            this.cmdPONO.Image = ((System.Drawing.Image)(resources.GetObject("cmdPONO.Image")));
            this.cmdPONO.Location = new System.Drawing.Point(571, 42);
            this.cmdPONO.Name = "cmdPONO";
            this.cmdPONO.Size = new System.Drawing.Size(28, 23);
            this.cmdPONO.TabIndex = 244;
            this.cmdPONO.UseVisualStyleBackColor = true;
            this.cmdPONO.Click += new System.EventHandler(this.cmdPONO_Click);
            // 
            // txtPONO
            // 
            this.txtPONO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPONO.Location = new System.Drawing.Point(384, 45);
            this.txtPONO.Name = "txtPONO";
            this.txtPONO.ReadOnly = true;
            this.txtPONO.Size = new System.Drawing.Size(181, 20);
            this.txtPONO.TabIndex = 242;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 243;
            this.label8.Text = "PONO";
            // 
            // cbStore
            // 
            this.cbStore.FormattingEnabled = true;
            this.cbStore.Location = new System.Drawing.Point(384, 182);
            this.cbStore.Name = "cbStore";
            this.cbStore.Size = new System.Drawing.Size(230, 21);
            this.cbStore.TabIndex = 241;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(41, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Process Issue";
            // 
            // txtRefer
            // 
            this.txtRefer.Location = new System.Drawing.Point(384, 156);
            this.txtRefer.Name = "txtRefer";
            this.txtRefer.Size = new System.Drawing.Size(230, 20);
            this.txtRefer.TabIndex = 238;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 237;
            this.label5.Text = "Note";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(79, 127);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(204, 46);
            this.txtRemarks.TabIndex = 236;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 235;
            this.label2.Text = "Alamat";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(312, 185);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 240;
            this.label17.Text = "Store";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(384, 101);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(230, 49);
            this.txtAddress.TabIndex = 234;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 239;
            this.label6.Text = "Refer To";
            // 
            // dtGrid
            // 
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hDel,
            this.hGINNo1,
            this.hID1,
            this.hGINNo,
            this.hID,
            this.hItemsID,
            this.hDescription,
            this.hJenis,
            this.hColorID,
            this.hSizeID,
            this.hGrade,
            this.hStyleID,
            this.hPONO,
            this.hQuantity,
            this.hUom});
            this.dtGrid.Location = new System.Drawing.Point(12, 244);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrid.RowHeadersWidth = 50;
            this.dtGrid.Size = new System.Drawing.Size(695, 244);
            this.dtGrid.TabIndex = 231;
            // 
            // hDel
            // 
            this.hDel.HeaderText = "Del";
            this.hDel.Name = "hDel";
            this.hDel.Width = 30;
            // 
            // hGINNo1
            // 
            this.hGINNo1.HeaderText = "GRNNo1";
            this.hGINNo1.Name = "hGINNo1";
            this.hGINNo1.Visible = false;
            // 
            // hID1
            // 
            this.hID1.HeaderText = "ID1";
            this.hID1.Name = "hID1";
            this.hID1.Visible = false;
            // 
            // hGINNo
            // 
            this.hGINNo.HeaderText = "GRNNo";
            this.hGINNo.Name = "hGINNo";
            this.hGINNo.Visible = false;
            // 
            // hID
            // 
            this.hID.HeaderText = "ID";
            this.hID.Name = "hID";
            this.hID.Width = 30;
            // 
            // hItemsID
            // 
            this.hItemsID.DefaultCellStyle = dataGridViewCellStyle1;
            this.hItemsID.HeaderText = "Items ID";
            this.hItemsID.Name = "hItemsID";
            // 
            // hDescription
            // 
            this.hDescription.HeaderText = "Description";
            this.hDescription.Name = "hDescription";
            this.hDescription.Width = 250;
            // 
            // hJenis
            // 
            this.hJenis.HeaderText = "Jenis";
            this.hJenis.Name = "hJenis";
            this.hJenis.Visible = false;
            this.hJenis.Width = 60;
            // 
            // hColorID
            // 
            this.hColorID.HeaderText = "ColorID";
            this.hColorID.Name = "hColorID";
            this.hColorID.Visible = false;
            // 
            // hSizeID
            // 
            this.hSizeID.HeaderText = "SIZEID";
            this.hSizeID.Name = "hSizeID";
            this.hSizeID.Visible = false;
            // 
            // hGrade
            // 
            this.hGrade.HeaderText = "GRADE";
            this.hGrade.Name = "hGrade";
            this.hGrade.Visible = false;
            // 
            // hStyleID
            // 
            this.hStyleID.HeaderText = "StyleID Alloc";
            this.hStyleID.Name = "hStyleID";
            // 
            // hPONO
            // 
            this.hPONO.HeaderText = "PONO";
            this.hPONO.Name = "hPONO";
            this.hPONO.Visible = false;
            // 
            // hQuantity
            // 
            this.hQuantity.HeaderText = "Quantity";
            this.hQuantity.Name = "hQuantity";
            this.hQuantity.Width = 50;
            // 
            // hUom
            // 
            this.hUom.FillWeight = 50F;
            this.hUom.HeaderText = "Uom";
            this.hUom.Name = "hUom";
            this.hUom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hUom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hUom.Width = 70;
            // 
            // cmdCustomer
            // 
            this.cmdCustomer.Image = ((System.Drawing.Image)(resources.GetObject("cmdCustomer.Image")));
            this.cmdCustomer.Location = new System.Drawing.Point(449, 72);
            this.cmdCustomer.Name = "cmdCustomer";
            this.cmdCustomer.Size = new System.Drawing.Size(28, 23);
            this.cmdCustomer.TabIndex = 229;
            this.cmdCustomer.UseVisualStyleBackColor = true;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtCustomerID.Location = new System.Drawing.Point(384, 74);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(59, 20);
            this.txtCustomerID.TabIndex = 227;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 228;
            this.label7.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 226;
            this.label3.Text = "Date";
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
            // TSTombol
            // 
            this.TSTombol.BackColor = System.Drawing.Color.DarkGray;
            this.TSTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TSTombol.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSTombol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SimpanTSB,
            this.UbahTSB,
            this.HapusTSB,
            this.ToolStripSeparator1,
            this.RecordTSB,
            this.TutupTSB,
            this.toolStripSeparator2,
            this.Print});
            this.TSTombol.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TSTombol.Location = new System.Drawing.Point(0, 523);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(722, 25);
            this.TSTombol.TabIndex = 224;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Print
            // 
            this.Print.Image = ((System.Drawing.Image)(resources.GetObject("Print.Image")));
            this.Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(56, 22);
            this.Print.Text = "Print";
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // dateCreated
            // 
            this.dateCreated.Location = new System.Drawing.Point(79, 74);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(200, 20);
            this.dateCreated.TabIndex = 225;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(21, 13);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(16, 17);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 222;
            this.PictureBox1.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(970, 38);
            this.Panel1.TabIndex = 223;
            // 
            // txtGRNNO
            // 
            this.txtGRNNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtGRNNO.Location = new System.Drawing.Point(79, 45);
            this.txtGRNNO.Name = "txtGRNNO";
            this.txtGRNNO.ReadOnly = true;
            this.txtGRNNO.Size = new System.Drawing.Size(129, 20);
            this.txtGRNNO.TabIndex = 220;
            // 
            // txtCustomerDesc
            // 
            this.txtCustomerDesc.Location = new System.Drawing.Point(483, 74);
            this.txtCustomerDesc.Name = "txtCustomerDesc";
            this.txtCustomerDesc.Size = new System.Drawing.Size(131, 20);
            this.txtCustomerDesc.TabIndex = 230;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 233;
            this.label9.Text = "Divisi";
            // 
            // cbDIV
            // 
            this.cbDIV.FormattingEnabled = true;
            this.cbDIV.Location = new System.Drawing.Point(79, 100);
            this.cbDIV.Name = "cbDIV";
            this.cbDIV.Size = new System.Drawing.Size(184, 21);
            this.cbDIV.TabIndex = 232;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 221;
            this.label1.Text = "PINNo";
            // 
            // frmginComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 548);
            this.Controls.Add(this.cbJENIS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmdPONO);
            this.Controls.Add(this.txtPONO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbStore);
            this.Controls.Add(this.txtRefer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.cmdCustomer);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TSTombol);
            this.Controls.Add(this.dateCreated);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.txtGRNNO);
            this.Controls.Add(this.txtCustomerDesc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbDIV);
            this.Controls.Add(this.label1);
            this.Name = "frmginComponent";
            this.Text = "Issue Component";
            this.Load += new System.EventHandler(this.frmginComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.TSTombol.ResumeLayout(false);
            this.TSTombol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbJENIS;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Button cmdPONO;
        private System.Windows.Forms.TextBox txtPONO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbStore;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRefer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtGrid;
        internal System.Windows.Forms.Button cmdCustomer;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ToolStripButton SimpanTSB;
        internal System.Windows.Forms.ToolStrip TSTombol;
        internal System.Windows.Forms.ToolStripButton UbahTSB;
        internal System.Windows.Forms.ToolStripButton HapusTSB;
        internal System.Windows.Forms.ToolStripButton RecordTSB;
        internal System.Windows.Forms.ToolStripButton TutupTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Print;
        private System.Windows.Forms.DateTimePicker dateCreated;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.TextBox txtGRNNO;
        private System.Windows.Forms.TextBox txtCustomerDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbDIV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn hGINNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hGINNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hID;
        private System.Windows.Forms.DataGridViewButtonColumn hItemsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn hJenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn hColorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hSizeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn hStyleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQuantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn hUom;

    }
}