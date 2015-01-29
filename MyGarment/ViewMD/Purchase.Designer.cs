namespace MyGarment.ViewFinance
{
    partial class frmPurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchase));
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.hPONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCostingNo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hCostingID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hItemsID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQtyPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPricePurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hUOMPurchase = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hConvert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hUom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hCurrency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hKurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerDesc = new System.Windows.Forms.TextBox();
            this.HapusTSB = new System.Windows.Forms.ToolStripButton();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKurs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDIV = new System.Windows.Forms.ComboBox();
            this.Print = new System.Windows.Forms.ToolStripButton();
            this.UbahTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.RecordTSB = new System.Windows.Forms.ToolStripButton();
            this.TutupTSB = new System.Windows.Forms.ToolStripButton();
            this.cmdCustomer = new System.Windows.Forms.Button();
            this.SimpanTSB = new System.Windows.Forms.ToolStripButton();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateCreated = new System.Windows.Forms.DateTimePicker();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPONO = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtRefer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeliveryToDesc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDeliveryTo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAddresTo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateETA = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dateETD = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dateDue = new System.Windows.Forms.DateTimePicker();
            this.cbCourier = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbTerms = new System.Windows.Forms.ComboBox();
            this.cmdCekbudget = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.TSTombol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGrid
            // 
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hPONO,
            this.hID,
            this.hCostingNo,
            this.hCostingID,
            this.hItemsID,
            this.hDescription,
            this.hQtyPurchase,
            this.hPricePurchase,
            this.hUOMPurchase,
            this.hConvert,
            this.hQuantity,
            this.hPrice,
            this.hUom,
            this.hCurrency,
            this.hKurs});
            this.dtGrid.Location = new System.Drawing.Point(12, 228);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrid.RowHeadersWidth = 50;
            this.dtGrid.Size = new System.Drawing.Size(1177, 259);
            this.dtGrid.TabIndex = 142;
            this.dtGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtGrid_CellBeginEdit);
            this.dtGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellClick);
            this.dtGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellContentClick);
            this.dtGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellEndEdit);
            this.dtGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtGrid_EditingControlShowing);
            this.dtGrid.Click += new System.EventHandler(this.dtGrid_Click);
            // 
            // hPONO
            // 
            this.hPONO.HeaderText = "PONO";
            this.hPONO.Name = "hPONO";
            this.hPONO.Visible = false;
            // 
            // hID
            // 
            this.hID.HeaderText = "ID";
            this.hID.Name = "hID";
            this.hID.Visible = false;
            this.hID.Width = 20;
            // 
            // hCostingNo
            // 
            this.hCostingNo.DefaultCellStyle = dataGridViewCellStyle9;
            this.hCostingNo.HeaderText = "Costing No";
            this.hCostingNo.Name = "hCostingNo";
            this.hCostingNo.Width = 110;
            // 
            // hCostingID
            // 
            this.hCostingID.HeaderText = "CostingID";
            this.hCostingID.Name = "hCostingID";
            this.hCostingID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hCostingID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hCostingID.Width = 110;
            // 
            // hItemsID
            // 
            this.hItemsID.DefaultCellStyle = dataGridViewCellStyle10;
            this.hItemsID.HeaderText = "Items ID";
            this.hItemsID.Name = "hItemsID";
            // 
            // hDescription
            // 
            this.hDescription.HeaderText = "Description";
            this.hDescription.Name = "hDescription";
            this.hDescription.Width = 350;
            // 
            // hQtyPurchase
            // 
            this.hQtyPurchase.HeaderText = "Qty Purchase";
            this.hQtyPurchase.Name = "hQtyPurchase";
            this.hQtyPurchase.Width = 50;
            // 
            // hPricePurchase
            // 
            this.hPricePurchase.HeaderText = "Price Purchase";
            this.hPricePurchase.Name = "hPricePurchase";
            this.hPricePurchase.Width = 50;
            // 
            // hUOMPurchase
            // 
            this.hUOMPurchase.HeaderText = "UOM Purchase";
            this.hUOMPurchase.Name = "hUOMPurchase";
            this.hUOMPurchase.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hUOMPurchase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hUOMPurchase.Width = 70;
            // 
            // hConvert
            // 
            this.hConvert.HeaderText = "Convert";
            this.hConvert.Name = "hConvert";
            this.hConvert.Width = 50;
            // 
            // hQuantity
            // 
            this.hQuantity.HeaderText = "Quantity";
            this.hQuantity.Name = "hQuantity";
            this.hQuantity.Width = 50;
            // 
            // hPrice
            // 
            dataGridViewCellStyle11.Format = "N6";
            dataGridViewCellStyle11.NullValue = null;
            this.hPrice.DefaultCellStyle = dataGridViewCellStyle11;
            this.hPrice.FillWeight = 50F;
            this.hPrice.HeaderText = "Price";
            this.hPrice.Name = "hPrice";
            this.hPrice.Width = 50;
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
            // hCurrency
            // 
            this.hCurrency.FillWeight = 50F;
            this.hCurrency.HeaderText = "Currency";
            this.hCurrency.Name = "hCurrency";
            this.hCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hCurrency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hCurrency.Visible = false;
            this.hCurrency.Width = 70;
            // 
            // hKurs
            // 
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.hKurs.DefaultCellStyle = dataGridViewCellStyle12;
            this.hKurs.FillWeight = 50F;
            this.hKurs.HeaderText = "Kurs";
            this.hKurs.Name = "hKurs";
            this.hKurs.Visible = false;
            this.hKurs.Width = 50;
            // 
            // txtCustomerDesc
            // 
            this.txtCustomerDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtCustomerDesc.Location = new System.Drawing.Point(483, 43);
            this.txtCustomerDesc.Name = "txtCustomerDesc";
            this.txtCustomerDesc.ReadOnly = true;
            this.txtCustomerDesc.Size = new System.Drawing.Size(131, 20);
            this.txtCustomerDesc.TabIndex = 141;
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
            // cbCurrency
            // 
            this.cbCurrency.BackColor = System.Drawing.Color.White;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(79, 174);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(71, 21);
            this.cbCurrency.TabIndex = 148;
            this.cbCurrency.SelectedIndexChanged += new System.EventHandler(this.cbCurrency_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(156, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 147;
            this.label11.Text = "Kurs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 146;
            this.label10.Text = "Currency";
            // 
            // txtKurs
            // 
            this.txtKurs.BackColor = System.Drawing.Color.White;
            this.txtKurs.Location = new System.Drawing.Point(206, 174);
            this.txtKurs.Name = "txtKurs";
            this.txtKurs.Size = new System.Drawing.Size(77, 20);
            this.txtKurs.TabIndex = 145;
            this.txtKurs.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 144;
            this.label9.Text = "Divisi";
            // 
            // cbDIV
            // 
            this.cbDIV.FormattingEnabled = true;
            this.cbDIV.Location = new System.Drawing.Point(79, 99);
            this.cbDIV.Name = "cbDIV";
            this.cbDIV.Size = new System.Drawing.Size(184, 21);
            this.cbDIV.TabIndex = 143;
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
            // UbahTSB
            // 
            this.UbahTSB.Image = ((System.Drawing.Image)(resources.GetObject("UbahTSB.Image")));
            this.UbahTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UbahTSB.Name = "UbahTSB";
            this.UbahTSB.Size = new System.Drawing.Size(56, 22);
            this.UbahTSB.Text = "Ubah";
            this.UbahTSB.Click += new System.EventHandler(this.UbahTSB_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(41, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Purchasing";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.TutupTSB.Click += new System.EventHandler(this.TutupTSB_Click);
            // 
            // cmdCustomer
            // 
            this.cmdCustomer.Image = ((System.Drawing.Image)(resources.GetObject("cmdCustomer.Image")));
            this.cmdCustomer.Location = new System.Drawing.Point(449, 41);
            this.cmdCustomer.Name = "cmdCustomer";
            this.cmdCustomer.Size = new System.Drawing.Size(28, 23);
            this.cmdCustomer.TabIndex = 138;
            this.cmdCustomer.UseVisualStyleBackColor = true;
            this.cmdCustomer.Click += new System.EventHandler(this.cmdCustomer_Click);
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
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtCustomerID.Location = new System.Drawing.Point(384, 43);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(59, 20);
            this.txtCustomerID.TabIndex = 132;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 133;
            this.label7.Text = "Supplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 127;
            this.label3.Text = "Date";
            // 
            // dateCreated
            // 
            this.dateCreated.Location = new System.Drawing.Point(79, 73);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(200, 20);
            this.dateCreated.TabIndex = 124;
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
            this.TSTombol.Location = new System.Drawing.Point(0, 513);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(1201, 25);
            this.TSTombol.TabIndex = 123;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(21, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(16, 17);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 121;
            this.PictureBox1.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Location = new System.Drawing.Point(0, -1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(970, 38);
            this.Panel1.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "PoNo";
            // 
            // txtPONO
            // 
            this.txtPONO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPONO.Location = new System.Drawing.Point(79, 44);
            this.txtPONO.Name = "txtPONO";
            this.txtPONO.ReadOnly = true;
            this.txtPONO.Size = new System.Drawing.Size(129, 20);
            this.txtPONO.TabIndex = 119;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(384, 70);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(230, 62);
            this.txtAddress.TabIndex = 153;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 154;
            this.label2.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 156;
            this.label5.Text = "Note";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(79, 126);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(204, 46);
            this.txtRemarks.TabIndex = 155;
            // 
            // txtRefer
            // 
            this.txtRefer.Location = new System.Drawing.Point(384, 138);
            this.txtRefer.Name = "txtRefer";
            this.txtRefer.Size = new System.Drawing.Size(230, 20);
            this.txtRefer.TabIndex = 157;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 158;
            this.label6.Text = "Refer to";
            // 
            // txtDeliveryToDesc
            // 
            this.txtDeliveryToDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtDeliveryToDesc.Location = new System.Drawing.Point(792, 43);
            this.txtDeliveryToDesc.Name = "txtDeliveryToDesc";
            this.txtDeliveryToDesc.ReadOnly = true;
            this.txtDeliveryToDesc.Size = new System.Drawing.Size(178, 20);
            this.txtDeliveryToDesc.TabIndex = 162;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(758, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 161;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDeliveryTo
            // 
            this.txtDeliveryTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtDeliveryTo.Location = new System.Drawing.Point(693, 43);
            this.txtDeliveryTo.Name = "txtDeliveryTo";
            this.txtDeliveryTo.ReadOnly = true;
            this.txtDeliveryTo.Size = new System.Drawing.Size(59, 20);
            this.txtDeliveryTo.TabIndex = 159;
            this.txtDeliveryTo.TextChanged += new System.EventHandler(this.txtDeliveryTo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 160;
            this.label8.Text = "Delivery To";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(621, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 164;
            this.label12.Text = "Alamat";
            // 
            // txtAddresTo
            // 
            this.txtAddresTo.Location = new System.Drawing.Point(693, 69);
            this.txtAddresTo.Multiline = true;
            this.txtAddresTo.Name = "txtAddresTo";
            this.txtAddresTo.Size = new System.Drawing.Size(277, 55);
            this.txtAddresTo.TabIndex = 163;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(628, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 166;
            this.label14.Text = "ETA";
            // 
            // dateETA
            // 
            this.dateETA.Location = new System.Drawing.Point(693, 132);
            this.dateETA.Name = "dateETA";
            this.dateETA.Size = new System.Drawing.Size(200, 20);
            this.dateETA.TabIndex = 165;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(628, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 168;
            this.label15.Text = "ETD";
            // 
            // dateETD
            // 
            this.dateETD.Location = new System.Drawing.Point(693, 158);
            this.dateETD.Name = "dateETD";
            this.dateETD.Size = new System.Drawing.Size(200, 20);
            this.dateETD.TabIndex = 167;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(899, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 170;
            this.label16.Text = "Due Date";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // dateDue
            // 
            this.dateDue.Location = new System.Drawing.Point(958, 157);
            this.dateDue.Name = "dateDue";
            this.dateDue.Size = new System.Drawing.Size(200, 20);
            this.dateDue.TabIndex = 169;
            this.dateDue.ValueChanged += new System.EventHandler(this.dateDue_ValueChanged);
            // 
            // cbCourier
            // 
            this.cbCourier.FormattingEnabled = true;
            this.cbCourier.Location = new System.Drawing.Point(384, 164);
            this.cbCourier.Name = "cbCourier";
            this.cbCourier.Size = new System.Drawing.Size(230, 21);
            this.cbCourier.TabIndex = 172;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(312, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 171;
            this.label17.Text = "Courier";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(899, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 173;
            this.label13.Text = "Terms";
            // 
            // cbTerms
            // 
            this.cbTerms.FormattingEnabled = true;
            this.cbTerms.Location = new System.Drawing.Point(958, 131);
            this.cbTerms.Name = "cbTerms";
            this.cbTerms.Size = new System.Drawing.Size(210, 21);
            this.cbTerms.TabIndex = 174;
            // 
            // cmdCekbudget
            // 
            this.cmdCekbudget.Location = new System.Drawing.Point(1041, 199);
            this.cmdCekbudget.Name = "cmdCekbudget";
            this.cmdCekbudget.Size = new System.Drawing.Size(75, 23);
            this.cmdCekbudget.TabIndex = 175;
            this.cmdCekbudget.Text = "Cek Budget";
            this.cmdCekbudget.UseVisualStyleBackColor = true;
            this.cmdCekbudget.Click += new System.EventHandler(this.cmdCekbudget_Click);
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 538);
            this.Controls.Add(this.cmdCekbudget);
            this.Controls.Add(this.cbTerms);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbCourier);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dateDue);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateETD);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateETA);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAddresTo);
            this.Controls.Add(this.txtDeliveryToDesc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDeliveryTo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRefer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.txtCustomerDesc);
            this.Controls.Add(this.cbCurrency);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtKurs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbDIV);
            this.Controls.Add(this.cmdCustomer);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateCreated);
            this.Controls.Add(this.TSTombol);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPONO);
            this.Name = "frmPurchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.Shown += new System.EventHandler(this.frmPurchase_Shown);
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

        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.TextBox txtCustomerDesc;
        internal System.Windows.Forms.ToolStripButton HapusTSB;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKurs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbDIV;
        private System.Windows.Forms.ToolStripButton Print;
        internal System.Windows.Forms.ToolStripButton UbahTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ToolStripButton RecordTSB;
        internal System.Windows.Forms.ToolStripButton TutupTSB;
        internal System.Windows.Forms.Button cmdCustomer;
        internal System.Windows.Forms.ToolStripButton SimpanTSB;
        private System.Windows.Forms.TextBox txtCustomerID;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateCreated;
        internal System.Windows.Forms.ToolStrip TSTombol;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPONO;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtRefer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeliveryToDesc;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDeliveryTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAddresTo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateETA;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateETD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateDue;
        private System.Windows.Forms.ComboBox cbCourier;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbTerms;
        private System.Windows.Forms.Button cmdCekbudget;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn hID;
        private System.Windows.Forms.DataGridViewButtonColumn hCostingNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn hCostingID;
        private System.Windows.Forms.DataGridViewButtonColumn hItemsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQtyPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPricePurchase;
        private System.Windows.Forms.DataGridViewComboBoxColumn hUOMPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn hConvert;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPrice;
        private System.Windows.Forms.DataGridViewComboBoxColumn hUom;
        private System.Windows.Forms.DataGridViewComboBoxColumn hCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn hKurs;
    }
}