namespace MyGarment.ViewMD
{
    partial class frmjoborder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmjoborder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.txtCustomerDesc = new System.Windows.Forms.TextBox();
            this.txtStyleDesc = new System.Windows.Forms.TextBox();
            this.HapusTSB = new System.Windows.Forms.ToolStripButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDIV = new System.Windows.Forms.ComboBox();
            this.txtCategoryDesc = new System.Windows.Forms.TextBox();
            this.Print = new System.Windows.Forms.ToolStripButton();
            this.UbahTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.RecordTSB = new System.Windows.Forms.ToolStripButton();
            this.TutupTSB = new System.Windows.Forms.ToolStripButton();
            this.cmdCustomer = new System.Windows.Forms.Button();
            this.SimpanTSB = new System.Windows.Forms.ToolStripButton();
            this.cmdStyle = new System.Windows.Forms.Button();
            this.cmdCategory = new System.Windows.Forms.Button();
            this.cbTypeID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStyleID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.dateCreated = new System.Windows.Forms.DateTimePicker();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            this.Approve = new System.Windows.Forms.ToolStripButton();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCostingNo = new System.Windows.Forms.TextBox();
            this.txtPOCustomer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtWash = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.hOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPOCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hColorID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hSizeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hNoUrut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDelivery = new JThomas.Controls.DataGridViewMaskedTextColumn();
            this.hQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCuttingQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hAllowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDelRow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.hOrderNo,
            this.hPOCustomer,
            this.hDestination,
            this.hColorID,
            this.hSizeID,
            this.hNoUrut,
            this.hDelivery,
            this.hQuantity,
            this.hCuttingQty,
            this.hAllowance,
            this.hDelRow});
            this.dtGrid.Location = new System.Drawing.Point(12, 217);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrid.RowHeadersWidth = 50;
            this.dtGrid.Size = new System.Drawing.Size(962, 244);
            this.dtGrid.TabIndex = 142;
            this.dtGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtGrid_CellBeginEdit);
            this.dtGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellClick);
            this.dtGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellContentClick);
            this.dtGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellValueChanged);
            this.dtGrid.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dtGrid_ColumnWidthChanged);
            this.dtGrid.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dtGrid_Scroll);
            // 
            // txtCustomerDesc
            // 
            this.txtCustomerDesc.Location = new System.Drawing.Point(499, 57);
            this.txtCustomerDesc.Name = "txtCustomerDesc";
            this.txtCustomerDesc.Size = new System.Drawing.Size(185, 20);
            this.txtCustomerDesc.TabIndex = 141;
            // 
            // txtStyleDesc
            // 
            this.txtStyleDesc.BackColor = System.Drawing.SystemColors.Info;
            this.txtStyleDesc.Location = new System.Drawing.Point(500, 113);
            this.txtStyleDesc.Name = "txtStyleDesc";
            this.txtStyleDesc.Size = new System.Drawing.Size(157, 20);
            this.txtStyleDesc.TabIndex = 140;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 144;
            this.label9.Text = "Divisi";
            // 
            // cbDIV
            // 
            this.cbDIV.FormattingEnabled = true;
            this.cbDIV.Location = new System.Drawing.Point(96, 138);
            this.cbDIV.Name = "cbDIV";
            this.cbDIV.Size = new System.Drawing.Size(184, 21);
            this.cbDIV.TabIndex = 143;
            // 
            // txtCategoryDesc
            // 
            this.txtCategoryDesc.BackColor = System.Drawing.SystemColors.Info;
            this.txtCategoryDesc.Location = new System.Drawing.Point(500, 87);
            this.txtCategoryDesc.Name = "txtCategoryDesc";
            this.txtCategoryDesc.Size = new System.Drawing.Size(157, 20);
            this.txtCategoryDesc.TabIndex = 139;
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
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "JOB ORDER";
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
            this.cmdCustomer.Location = new System.Drawing.Point(465, 55);
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
            // cmdStyle
            // 
            this.cmdStyle.Image = ((System.Drawing.Image)(resources.GetObject("cmdStyle.Image")));
            this.cmdStyle.Location = new System.Drawing.Point(466, 113);
            this.cmdStyle.Name = "cmdStyle";
            this.cmdStyle.Size = new System.Drawing.Size(28, 23);
            this.cmdStyle.TabIndex = 137;
            this.cmdStyle.UseVisualStyleBackColor = true;
            this.cmdStyle.Click += new System.EventHandler(this.cmdStyle_Click);
            // 
            // cmdCategory
            // 
            this.cmdCategory.Image = ((System.Drawing.Image)(resources.GetObject("cmdCategory.Image")));
            this.cmdCategory.Location = new System.Drawing.Point(466, 84);
            this.cmdCategory.Name = "cmdCategory";
            this.cmdCategory.Size = new System.Drawing.Size(28, 23);
            this.cmdCategory.TabIndex = 136;
            this.cmdCategory.UseVisualStyleBackColor = true;
            this.cmdCategory.Click += new System.EventHandler(this.cmdCategory_Click);
            // 
            // cbTypeID
            // 
            this.cbTypeID.FormattingEnabled = true;
            this.cbTypeID.Location = new System.Drawing.Point(388, 139);
            this.cbTypeID.Name = "cbTypeID";
            this.cbTypeID.Size = new System.Drawing.Size(184, 21);
            this.cbTypeID.TabIndex = 135;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 134;
            this.label8.Text = "Type";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.SystemColors.Info;
            this.txtCustomerID.Location = new System.Drawing.Point(388, 57);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(71, 20);
            this.txtCustomerID.TabIndex = 132;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(96, 86);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 130;
            this.txtQty.Text = "0";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 133;
            this.label7.Text = "Customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 131;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 129;
            this.label5.Text = "StyleID";
            // 
            // txtStyleID
            // 
            this.txtStyleID.BackColor = System.Drawing.SystemColors.Info;
            this.txtStyleID.Location = new System.Drawing.Point(388, 113);
            this.txtStyleID.Name = "txtStyleID";
            this.txtStyleID.Size = new System.Drawing.Size(72, 20);
            this.txtStyleID.TabIndex = 128;
            this.txtStyleID.TextChanged += new System.EventHandler(this.txtStyleID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 127;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "Category";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.BackColor = System.Drawing.SystemColors.Info;
            this.txtCategoryID.Location = new System.Drawing.Point(388, 84);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(72, 20);
            this.txtCategoryID.TabIndex = 125;
            this.txtCategoryID.TextChanged += new System.EventHandler(this.txtCategoryID_TextChanged);
            // 
            // dateCreated
            // 
            this.dateCreated.Location = new System.Drawing.Point(96, 112);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(184, 20);
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
            this.Print,
            this.Approve});
            this.TSTombol.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TSTombol.Location = new System.Drawing.Point(0, 474);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(986, 25);
            this.TSTombol.TabIndex = 123;
            // 
            // Approve
            // 
            this.Approve.Image = ((System.Drawing.Image)(resources.GetObject("Approve.Image")));
            this.Approve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(75, 22);
            this.Approve.Text = "Approve";
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
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Job Order";
            // 
            // txtCostingNo
            // 
            this.txtCostingNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtCostingNo.Location = new System.Drawing.Point(96, 60);
            this.txtCostingNo.Name = "txtCostingNo";
            this.txtCostingNo.Size = new System.Drawing.Size(129, 20);
            this.txtCostingNo.TabIndex = 119;
            // 
            // txtPOCustomer
            // 
            this.txtPOCustomer.Location = new System.Drawing.Point(96, 165);
            this.txtPOCustomer.Name = "txtPOCustomer";
            this.txtPOCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtPOCustomer.TabIndex = 145;
            this.txtPOCustomer.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 146;
            this.label10.Text = "PO Customer";
            this.label10.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(759, 55);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(211, 52);
            this.txtRemarks.TabIndex = 147;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(690, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 148;
            this.label11.Text = "Remarks";
            // 
            // txtWash
            // 
            this.txtWash.BackColor = System.Drawing.Color.White;
            this.txtWash.Location = new System.Drawing.Point(759, 113);
            this.txtWash.Multiline = true;
            this.txtWash.Name = "txtWash";
            this.txtWash.Size = new System.Drawing.Size(211, 47);
            this.txtWash.TabIndex = 149;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(690, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 150;
            this.label12.Text = "Wash";
            // 
            // hOrderNo
            // 
            this.hOrderNo.HeaderText = "OrderNo";
            this.hOrderNo.Name = "hOrderNo";
            this.hOrderNo.Visible = false;
            this.hOrderNo.Width = 60;
            // 
            // hPOCustomer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.hPOCustomer.DefaultCellStyle = dataGridViewCellStyle1;
            this.hPOCustomer.HeaderText = "PO Customer";
            this.hPOCustomer.Name = "hPOCustomer";
            this.hPOCustomer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // hDestination
            // 
            this.hDestination.FillWeight = 50F;
            this.hDestination.HeaderText = "Destination";
            this.hDestination.Name = "hDestination";
            this.hDestination.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hDestination.Width = 150;
            // 
            // hColorID
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.hColorID.DefaultCellStyle = dataGridViewCellStyle2;
            this.hColorID.HeaderText = "ColorID";
            this.hColorID.Name = "hColorID";
            this.hColorID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hColorID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // hSizeID
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.hSizeID.DefaultCellStyle = dataGridViewCellStyle3;
            this.hSizeID.HeaderText = "Size ID";
            this.hSizeID.Name = "hSizeID";
            this.hSizeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hSizeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // hNoUrut
            // 
            this.hNoUrut.HeaderText = "Column";
            this.hNoUrut.Name = "hNoUrut";
            this.hNoUrut.Width = 50;
            // 
            // hDelivery
            // 
            dataGridViewCellStyle4.Format = "00/00/0000";
            dataGridViewCellStyle4.NullValue = null;
            this.hDelivery.DefaultCellStyle = dataGridViewCellStyle4;
            this.hDelivery.FillWeight = 50F;
            this.hDelivery.HeaderText = "Delivery";
            this.hDelivery.Mask = "00/00/0000";
            this.hDelivery.Name = "hDelivery";
            this.hDelivery.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hDelivery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hDelivery.Width = 80;
            // 
            // hQuantity
            // 
            this.hQuantity.FillWeight = 50F;
            this.hQuantity.HeaderText = "Quantity";
            this.hQuantity.Name = "hQuantity";
            this.hQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hQuantity.Width = 50;
            // 
            // hCuttingQty
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.hCuttingQty.DefaultCellStyle = dataGridViewCellStyle5;
            this.hCuttingQty.FillWeight = 50F;
            this.hCuttingQty.HeaderText = "Cutting Qty";
            this.hCuttingQty.Name = "hCuttingQty";
            this.hCuttingQty.ReadOnly = true;
            this.hCuttingQty.Width = 50;
            // 
            // hAllowance
            // 
            this.hAllowance.HeaderText = "Allow (%)";
            this.hAllowance.Name = "hAllowance";
            this.hAllowance.Width = 50;
            // 
            // hDelRow
            // 
            this.hDelRow.HeaderText = "Del Row";
            this.hDelRow.Name = "hDelRow";
            // 
            // frmjoborder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 499);
            this.Controls.Add(this.txtWash);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPOCustomer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.txtCustomerDesc);
            this.Controls.Add(this.txtStyleDesc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbDIV);
            this.Controls.Add(this.txtCategoryDesc);
            this.Controls.Add(this.cmdCustomer);
            this.Controls.Add(this.cmdStyle);
            this.Controls.Add(this.cmdCategory);
            this.Controls.Add(this.cbTypeID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStyleID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.dateCreated);
            this.Controls.Add(this.TSTombol);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCostingNo);
            this.Name = "frmjoborder";
            this.Text = "joborder";
            this.Load += new System.EventHandler(this.frmjoborder_Load);
            this.Shown += new System.EventHandler(this.frmjoborder_Shown);
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
        private System.Windows.Forms.TextBox txtStyleDesc;
        internal System.Windows.Forms.ToolStripButton HapusTSB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbDIV;
        private System.Windows.Forms.TextBox txtCategoryDesc;
        private System.Windows.Forms.ToolStripButton Print;
        internal System.Windows.Forms.ToolStripButton UbahTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ToolStripButton RecordTSB;
        internal System.Windows.Forms.ToolStripButton TutupTSB;
        internal System.Windows.Forms.Button cmdCustomer;
        internal System.Windows.Forms.ToolStripButton SimpanTSB;
        internal System.Windows.Forms.Button cmdStyle;
        internal System.Windows.Forms.Button cmdCategory;
        private System.Windows.Forms.ComboBox cbTypeID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStyleID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.DateTimePicker dateCreated;
        internal System.Windows.Forms.ToolStrip TSTombol;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCostingNo;
        private System.Windows.Forms.TextBox txtPOCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtWash;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripButton Approve;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPOCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDestination;
        private System.Windows.Forms.DataGridViewComboBoxColumn hColorID;
        private System.Windows.Forms.DataGridViewComboBoxColumn hSizeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNoUrut;
        private JThomas.Controls.DataGridViewMaskedTextColumn hDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCuttingQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn hAllowance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hDelRow;

    }
}