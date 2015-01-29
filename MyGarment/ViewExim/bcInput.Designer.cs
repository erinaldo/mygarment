namespace MyGarment.ViewExim
{
    partial class frmbcInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbcInput));
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtBLNO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.cbTypeID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDocNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AjuDate = new System.Windows.Forms.DateTimePicker();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            this.SimpanTSB = new System.Windows.Forms.ToolStripButton();
            this.UbahTSB = new System.Windows.Forms.ToolStripButton();
            this.HapusTSB = new System.Windows.Forms.ToolStripButton();
            this.RecordTSB = new System.Windows.Forms.ToolStripButton();
            this.TutupTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Print = new System.Windows.Forms.ToolStripButton();
            this.New = new System.Windows.Forms.ToolStripButton();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoAju = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BLDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.DocDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbJenis = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbAlasan = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTransNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbDIV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateCreated = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.hTransNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hTransNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hItemsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hStyleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hUOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCurrency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hKurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.TSTombol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtBLNO
            // 
            this.txtBLNO.Location = new System.Drawing.Point(97, 98);
            this.txtBLNO.Name = "txtBLNO";
            this.txtBLNO.Size = new System.Drawing.Size(100, 20);
            this.txtBLNO.TabIndex = 177;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 178;
            this.label10.Text = "No BL";
            // 
            // dtGrid
            // 
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hTransNo1,
            this.hID1,
            this.hTransNo,
            this.hID,
            this.hItemsID,
            this.hStyleID,
            this.hDescription,
            this.hQuantity,
            this.hUOM,
            this.hCurrency,
            this.hKurs,
            this.hPrice,
            this.hTotal});
            this.dtGrid.Location = new System.Drawing.Point(12, 217);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrid.RowHeadersWidth = 50;
            this.dtGrid.Size = new System.Drawing.Size(1040, 244);
            this.dtGrid.TabIndex = 174;
            this.dtGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellContentClick);
            this.dtGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellEndEdit);
            this.dtGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellValueChanged);
            // 
            // cbTypeID
            // 
            this.cbTypeID.FormattingEnabled = true;
            this.cbTypeID.Items.AddRange(new object[] {
            "PEMASUKAN",
            "PENGELUARAN"});
            this.cbTypeID.Location = new System.Drawing.Point(97, 152);
            this.cbTypeID.Name = "cbTypeID";
            this.cbTypeID.Size = new System.Drawing.Size(158, 21);
            this.cbTypeID.TabIndex = 167;
            this.cbTypeID.SelectedIndexChanged += new System.EventHandler(this.cbTypeID_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 166;
            this.label8.Text = "Type";
            // 
            // txtDocNo
            // 
            this.txtDocNo.Location = new System.Drawing.Point(460, 46);
            this.txtDocNo.Name = "txtDocNo";
            this.txtDocNo.Size = new System.Drawing.Size(100, 20);
            this.txtDocNo.TabIndex = 162;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 163;
            this.label6.Text = "No. Dokumen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 159;
            this.label3.Text = "Tgl Aju";
            // 
            // AjuDate
            // 
            this.AjuDate.Location = new System.Drawing.Point(97, 72);
            this.AjuDate.Name = "AjuDate";
            this.AjuDate.Size = new System.Drawing.Size(184, 20);
            this.AjuDate.TabIndex = 156;
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
            this.Print,
            this.New});
            this.TSTombol.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TSTombol.Location = new System.Drawing.Point(0, 501);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(1064, 25);
            this.TSTombol.TabIndex = 155;
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
            // 
            // New
            // 
            this.New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.New.Image = ((System.Drawing.Image)(resources.GetObject("New.Image")));
            this.New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(23, 22);
            this.New.Text = "New";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(21, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(16, 17);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 153;
            this.PictureBox1.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Location = new System.Drawing.Point(0, -1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1022, 38);
            this.Panel1.TabIndex = 154;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(41, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "BEA CUKAI DOKUMENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 152;
            this.label1.Text = "No Aju";
            // 
            // txtNoAju
            // 
            this.txtNoAju.BackColor = System.Drawing.SystemColors.Info;
            this.txtNoAju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoAju.Location = new System.Drawing.Point(97, 46);
            this.txtNoAju.Name = "txtNoAju";
            this.txtNoAju.Size = new System.Drawing.Size(250, 22);
            this.txtNoAju.TabIndex = 151;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 180;
            this.label2.Text = "Tgl BL";
            // 
            // BLDate
            // 
            this.BLDate.Location = new System.Drawing.Point(97, 126);
            this.BLDate.Name = "BLDate";
            this.BLDate.Size = new System.Drawing.Size(184, 20);
            this.BLDate.TabIndex = 179;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(381, 72);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 13);
            this.lblDate.TabIndex = 182;
            this.lblDate.Text = "Tgl Dokumen";
            // 
            // DocDate
            // 
            this.DocDate.Location = new System.Drawing.Point(460, 71);
            this.DocDate.Name = "DocDate";
            this.DocDate.Size = new System.Drawing.Size(184, 20);
            this.DocDate.TabIndex = 181;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(460, 97);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(184, 56);
            this.txtRemarks.TabIndex = 183;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 184;
            this.label7.Text = "Keterangan";
            // 
            // cbJenis
            // 
            this.cbJenis.FormattingEnabled = true;
            this.cbJenis.Location = new System.Drawing.Point(97, 179);
            this.cbJenis.Name = "cbJenis";
            this.cbJenis.Size = new System.Drawing.Size(71, 21);
            this.cbJenis.TabIndex = 186;
            this.cbJenis.SelectedIndexChanged += new System.EventHandler(this.cbJenis_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 185;
            this.label11.Text = "Jenis";
            // 
            // cbAlasan
            // 
            this.cbAlasan.FormattingEnabled = true;
            this.cbAlasan.Location = new System.Drawing.Point(224, 182);
            this.cbAlasan.Name = "cbAlasan";
            this.cbAlasan.Size = new System.Drawing.Size(123, 21);
            this.cbAlasan.TabIndex = 188;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 187;
            this.label12.Text = "Alasan";
            // 
            // txtTransNo
            // 
            this.txtTransNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtTransNo.Location = new System.Drawing.Point(735, 43);
            this.txtTransNo.Name = "txtTransNo";
            this.txtTransNo.Size = new System.Drawing.Size(184, 20);
            this.txtTransNo.TabIndex = 277;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(925, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 279;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 278;
            this.label5.Text = "TransNo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(381, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 283;
            this.label13.Text = "Tgl Invoice";
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.Location = new System.Drawing.Point(460, 184);
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Size = new System.Drawing.Size(184, 20);
            this.InvoiceDate.TabIndex = 282;
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(460, 159);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(100, 20);
            this.txtInvoice.TabIndex = 280;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(381, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 281;
            this.label14.Text = "Invoice No";
            // 
            // cbDIV
            // 
            this.cbDIV.FormattingEnabled = true;
            this.cbDIV.Location = new System.Drawing.Point(735, 69);
            this.cbDIV.Name = "cbDIV";
            this.cbDIV.Size = new System.Drawing.Size(86, 21);
            this.cbDIV.TabIndex = 175;
            this.cbDIV.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(656, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 176;
            this.label9.Text = "Divisi";
            this.label9.Visible = false;
            // 
            // dateCreated
            // 
            this.dateCreated.Location = new System.Drawing.Point(735, 98);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(184, 20);
            this.dateCreated.TabIndex = 284;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(662, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 285;
            this.label15.Text = "Date Created";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // hTransNo1
            // 
            this.hTransNo1.HeaderText = "TransNo1";
            this.hTransNo1.Name = "hTransNo1";
            this.hTransNo1.Visible = false;
            // 
            // hID1
            // 
            this.hID1.HeaderText = "ID1";
            this.hID1.Name = "hID1";
            this.hID1.Visible = false;
            this.hID1.Width = 40;
            // 
            // hTransNo
            // 
            this.hTransNo.HeaderText = "TransNo";
            this.hTransNo.Name = "hTransNo";
            // 
            // hID
            // 
            this.hID.HeaderText = "ID";
            this.hID.Name = "hID";
            this.hID.Width = 30;
            // 
            // hItemsID
            // 
            this.hItemsID.HeaderText = "ItemsID/StyleID";
            this.hItemsID.Name = "hItemsID";
            // 
            // hStyleID
            // 
            this.hStyleID.HeaderText = "StyleID";
            this.hStyleID.Name = "hStyleID";
            // 
            // hDescription
            // 
            this.hDescription.HeaderText = "Description";
            this.hDescription.Name = "hDescription";
            this.hDescription.Width = 200;
            // 
            // hQuantity
            // 
            this.hQuantity.HeaderText = "Quantity";
            this.hQuantity.Name = "hQuantity";
            this.hQuantity.Width = 70;
            // 
            // hUOM
            // 
            this.hUOM.HeaderText = "UOM";
            this.hUOM.Name = "hUOM";
            this.hUOM.Width = 60;
            // 
            // hCurrency
            // 
            this.hCurrency.HeaderText = "Currency";
            this.hCurrency.Name = "hCurrency";
            this.hCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hCurrency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hCurrency.Width = 60;
            // 
            // hKurs
            // 
            this.hKurs.HeaderText = "Kurs";
            this.hKurs.Name = "hKurs";
            this.hKurs.Width = 80;
            // 
            // hPrice
            // 
            this.hPrice.HeaderText = "Price";
            this.hPrice.Name = "hPrice";
            this.hPrice.Width = 80;
            // 
            // hTotal
            // 
            this.hTotal.HeaderText = "Total";
            this.hTotal.Name = "hTotal";
            // 
            // frmbcInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 526);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateCreated);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.InvoiceDate);
            this.Controls.Add(this.txtInvoice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTransNo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAlasan);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbJenis);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.DocDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BLDate);
            this.Controls.Add(this.txtBLNO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.cbTypeID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDocNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AjuDate);
            this.Controls.Add(this.TSTombol);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNoAju);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbDIV);
            this.Name = "frmbcInput";
            this.Text = "bcInput";
            this.Load += new System.EventHandler(this.frmbcInput_Load);
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

        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.TextBox txtBLNO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.ComboBox cbTypeID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDocNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker AjuDate;
        internal System.Windows.Forms.ToolStrip TSTombol;
        internal System.Windows.Forms.ToolStripButton SimpanTSB;
        internal System.Windows.Forms.ToolStripButton UbahTSB;
        internal System.Windows.Forms.ToolStripButton HapusTSB;
        internal System.Windows.Forms.ToolStripButton RecordTSB;
        internal System.Windows.Forms.ToolStripButton TutupTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Print;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoAju;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BLDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker DocDate;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbJenis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbAlasan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTransNo;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker InvoiceDate;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripButton New;
        private System.Windows.Forms.ComboBox cbDIV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateCreated;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn hTransNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hTransNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hItemsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hStyleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn hUOM;
        private System.Windows.Forms.DataGridViewComboBoxColumn hCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn hKurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn hTotal;


    }
}