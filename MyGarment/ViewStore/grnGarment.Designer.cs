namespace MyGarment.ViewStore
{
    partial class frmgrnCMT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgrnCMT));
            this.UbahTSB = new System.Windows.Forms.ToolStripButton();
            this.TutupTSB = new System.Windows.Forms.ToolStripButton();
            this.HapusTSB = new System.Windows.Forms.ToolStripButton();
            this.cbStore = new System.Windows.Forms.ComboBox();
            this.RecordTSB = new System.Windows.Forms.ToolStripButton();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdCustomer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateCreated = new System.Windows.Forms.DateTimePicker();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            this.SimpanTSB = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Print = new System.Windows.Forms.ToolStripButton();
            this.cbJENIS = new System.Windows.Forms.ComboBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGRNNO = new System.Windows.Forms.TextBox();
            this.txtCustomerDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDIV = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRefer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtJONO = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.hDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hGRNNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hGRNNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hItemsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hJenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hColorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hSizeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hGrade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hStyleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hUom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hConvert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQtyPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hUOMPurchase = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TSTombol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
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
            // TutupTSB
            // 
            this.TutupTSB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TutupTSB.Image = ((System.Drawing.Image)(resources.GetObject("TutupTSB.Image")));
            this.TutupTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TutupTSB.Name = "TutupTSB";
            this.TutupTSB.Size = new System.Drawing.Size(61, 22);
            this.TutupTSB.Text = "Tutup";
            this.TutupTSB.Click += new System.EventHandler(this.TutupTSB_Click);
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
            // cbStore
            // 
            this.cbStore.FormattingEnabled = true;
            this.cbStore.Location = new System.Drawing.Point(382, 185);
            this.cbStore.Name = "cbStore";
            this.cbStore.Size = new System.Drawing.Size(230, 21);
            this.cbStore.TabIndex = 241;
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
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.SystemColors.Info;
            this.txtCustomerID.Location = new System.Drawing.Point(382, 77);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(59, 20);
            this.txtCustomerID.TabIndex = 227;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdCustomer
            // 
            this.cmdCustomer.Image = ((System.Drawing.Image)(resources.GetObject("cmdCustomer.Image")));
            this.cmdCustomer.Location = new System.Drawing.Point(447, 75);
            this.cmdCustomer.Name = "cmdCustomer";
            this.cmdCustomer.Size = new System.Drawing.Size(28, 23);
            this.cmdCustomer.TabIndex = 229;
            this.cmdCustomer.UseVisualStyleBackColor = true;
            this.cmdCustomer.Click += new System.EventHandler(this.cmdCustomer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 228;
            this.label7.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 226;
            this.label3.Text = "Date";
            // 
            // dateCreated
            // 
            this.dateCreated.Location = new System.Drawing.Point(75, 74);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(200, 20);
            this.dateCreated.TabIndex = 225;
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
            this.TSTombol.Location = new System.Drawing.Point(0, 547);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(1203, 25);
            this.TSTombol.TabIndex = 224;
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
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // cbJENIS
            // 
            this.cbJENIS.FormattingEnabled = true;
            this.cbJENIS.Items.AddRange(new object[] {
            "RAW",
            "PROCESS",
            "PRODUCT",
            ""});
            this.cbJENIS.Location = new System.Drawing.Point(75, 185);
            this.cbJENIS.Name = "cbJENIS";
            this.cbJENIS.Size = new System.Drawing.Size(204, 21);
            this.cbJENIS.TabIndex = 246;
            this.cbJENIS.Text = "PRODUCT";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(17, 13);
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
            this.Panel1.Location = new System.Drawing.Point(-4, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1207, 38);
            this.Panel1.TabIndex = 223;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(41, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Garment Recieve";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 221;
            this.label1.Text = "GRNNo";
            // 
            // txtGRNNO
            // 
            this.txtGRNNO.BackColor = System.Drawing.SystemColors.Info;
            this.txtGRNNO.Location = new System.Drawing.Point(75, 45);
            this.txtGRNNO.Name = "txtGRNNO";
            this.txtGRNNO.Size = new System.Drawing.Size(129, 20);
            this.txtGRNNO.TabIndex = 220;
            // 
            // txtCustomerDesc
            // 
            this.txtCustomerDesc.Location = new System.Drawing.Point(481, 77);
            this.txtCustomerDesc.Name = "txtCustomerDesc";
            this.txtCustomerDesc.Size = new System.Drawing.Size(131, 20);
            this.txtCustomerDesc.TabIndex = 230;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 233;
            this.label9.Text = "Divisi";
            // 
            // cbDIV
            // 
            this.cbDIV.FormattingEnabled = true;
            this.cbDIV.Location = new System.Drawing.Point(75, 100);
            this.cbDIV.Name = "cbDIV";
            this.cbDIV.Size = new System.Drawing.Size(184, 21);
            this.cbDIV.TabIndex = 232;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(310, 188);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 240;
            this.label17.Text = "Store";
            // 
            // txtRefer
            // 
            this.txtRefer.Location = new System.Drawing.Point(382, 159);
            this.txtRefer.Name = "txtRefer";
            this.txtRefer.Size = new System.Drawing.Size(230, 20);
            this.txtRefer.TabIndex = 238;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 237;
            this.label5.Text = "Note";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(75, 127);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(204, 46);
            this.txtRemarks.TabIndex = 236;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 235;
            this.label2.Text = "Alamat";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(382, 104);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(230, 49);
            this.txtAddress.TabIndex = 234;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 239;
            this.label6.Text = "Surat Jalan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 245;
            this.label10.Text = "Type";
            // 
            // txtJONO
            // 
            this.txtJONO.BackColor = System.Drawing.SystemColors.Info;
            this.txtJONO.Location = new System.Drawing.Point(382, 48);
            this.txtJONO.Name = "txtJONO";
            this.txtJONO.Size = new System.Drawing.Size(196, 20);
            this.txtJONO.TabIndex = 247;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(584, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 249;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 248;
            this.label8.Text = "JONO";
            // 
            // dtGrid
            // 
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hDel,
            this.hGRNNo1,
            this.hID1,
            this.hGRNNo,
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
            this.hUom,
            this.hConvert,
            this.hQtyPurchase,
            this.hUOMPurchase});
            this.dtGrid.Location = new System.Drawing.Point(5, 231);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrid.RowHeadersWidth = 50;
            this.dtGrid.Size = new System.Drawing.Size(1198, 244);
            this.dtGrid.TabIndex = 250;
            // 
            // hDel
            // 
            this.hDel.HeaderText = "Del";
            this.hDel.Name = "hDel";
            this.hDel.Width = 30;
            // 
            // hGRNNo1
            // 
            this.hGRNNo1.HeaderText = "GRNNo1";
            this.hGRNNo1.Name = "hGRNNo1";
            this.hGRNNo1.Visible = false;
            // 
            // hID1
            // 
            this.hID1.HeaderText = "ID1";
            this.hID1.Name = "hID1";
            this.hID1.Visible = false;
            // 
            // hGRNNo
            // 
            this.hGRNNo.HeaderText = "GRNNo";
            this.hGRNNo.Name = "hGRNNo";
            this.hGRNNo.Visible = false;
            // 
            // hID
            // 
            this.hID.HeaderText = "ID";
            this.hID.Name = "hID";
            this.hID.Width = 30;
            // 
            // hItemsID
            // 
            this.hItemsID.HeaderText = "Style ID";
            this.hItemsID.Name = "hItemsID";
            this.hItemsID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hItemsID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // 
            // hSizeID
            // 
            this.hSizeID.HeaderText = "SIZEID";
            this.hSizeID.Name = "hSizeID";
            // 
            // hGrade
            // 
            this.hGrade.HeaderText = "GRADE";
            this.hGrade.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.hGrade.Name = "hGrade";
            this.hGrade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hGrade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // hStyleID
            // 
            this.hStyleID.HeaderText = "StyleID";
            this.hStyleID.Name = "hStyleID";
            // 
            // hPONO
            // 
            this.hPONO.HeaderText = "JONO";
            this.hPONO.Name = "hPONO";
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
            // hConvert
            // 
            this.hConvert.HeaderText = "Convert";
            this.hConvert.Name = "hConvert";
            this.hConvert.Visible = false;
            this.hConvert.Width = 50;
            // 
            // hQtyPurchase
            // 
            this.hQtyPurchase.HeaderText = "Qty Purchase";
            this.hQtyPurchase.Name = "hQtyPurchase";
            this.hQtyPurchase.Visible = false;
            this.hQtyPurchase.Width = 50;
            // 
            // hUOMPurchase
            // 
            this.hUOMPurchase.HeaderText = "UOM Purchase";
            this.hUOMPurchase.Name = "hUOMPurchase";
            this.hUOMPurchase.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hUOMPurchase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hUOMPurchase.Visible = false;
            this.hUOMPurchase.Width = 70;
            // 
            // frmgrnCMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 572);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.txtJONO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbStore);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.cmdCustomer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateCreated);
            this.Controls.Add(this.TSTombol);
            this.Controls.Add(this.cbJENIS);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGRNNO);
            this.Controls.Add(this.txtCustomerDesc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbDIV);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtRefer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Name = "frmgrnCMT";
            this.Text = "grnCMT";
            this.Load += new System.EventHandler(this.frmgrnCMT_Load);
            this.TSTombol.ResumeLayout(false);
            this.TSTombol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton UbahTSB;
        internal System.Windows.Forms.ToolStripButton TutupTSB;
        internal System.Windows.Forms.ToolStripButton HapusTSB;
        private System.Windows.Forms.ComboBox cbStore;
        internal System.Windows.Forms.ToolStripButton RecordTSB;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.Button cmdCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateCreated;
        internal System.Windows.Forms.ToolStrip TSTombol;
        internal System.Windows.Forms.ToolStripButton SimpanTSB;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Print;
        private System.Windows.Forms.ComboBox cbJENIS;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGRNNO;
        private System.Windows.Forms.TextBox txtCustomerDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbDIV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRefer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtJONO;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn hGRNNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hGRNNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hItemsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn hJenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn hColorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hSizeID;
        private System.Windows.Forms.DataGridViewComboBoxColumn hGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn hStyleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQuantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn hUom;
        private System.Windows.Forms.DataGridViewTextBoxColumn hConvert;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQtyPurchase;
        private System.Windows.Forms.DataGridViewComboBoxColumn hUOMPurchase;
    }
}