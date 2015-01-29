namespace MyGarment.ViewStore
{
    partial class frmgrntComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgrntComponent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Print = new System.Windows.Forms.ToolStripButton();
            this.cbStore = new System.Windows.Forms.ComboBox();
            this.TutupTSB = new System.Windows.Forms.ToolStripButton();
            this.UbahTSB = new System.Windows.Forms.ToolStripButton();
            this.SimpanTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cbJENIS = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.hStyleIDto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hUom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hGRNNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.HapusTSB = new System.Windows.Forms.ToolStripButton();
            this.cmdCustomer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.RecordTSB = new System.Windows.Forms.ToolStripButton();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateCreated = new System.Windows.Forms.DateTimePicker();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGRNNO = new System.Windows.Forms.TextBox();
            this.txtCustomerDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDIV = new System.Windows.Forms.ComboBox();
            this.txtRefer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            this.txtStyleDesc = new System.Windows.Forms.TextBox();
            this.txtItemsID = new System.Windows.Forms.TextBox();
            this.cmdStyle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.TSTombol.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(235, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 320;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 319;
            this.label12.Text = "Add by Style ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 317;
            this.label11.Text = "Store";
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
            // cbStore
            // 
            this.cbStore.FormattingEnabled = true;
            this.cbStore.Location = new System.Drawing.Point(379, 183);
            this.cbStore.Name = "cbStore";
            this.cbStore.Size = new System.Drawing.Size(230, 21);
            this.cbStore.TabIndex = 318;
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
            // UbahTSB
            // 
            this.UbahTSB.Image = ((System.Drawing.Image)(resources.GetObject("UbahTSB.Image")));
            this.UbahTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UbahTSB.Name = "UbahTSB";
            this.UbahTSB.Size = new System.Drawing.Size(56, 22);
            this.UbahTSB.Text = "Ubah";
            this.UbahTSB.Click += new System.EventHandler(this.UbahTSB_Click);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cbJENIS
            // 
            this.cbJENIS.FormattingEnabled = true;
            this.cbJENIS.Items.AddRange(new object[] {
            "RAW",
            "PROCESS",
            "PRODUCT",
            ""});
            this.cbJENIS.Location = new System.Drawing.Point(79, 182);
            this.cbJENIS.Name = "cbJENIS";
            this.cbJENIS.Size = new System.Drawing.Size(204, 21);
            this.cbJENIS.TabIndex = 315;
            this.cbJENIS.Text = "PROCESS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 314;
            this.label10.Text = "Type";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.hStyleIDto,
            this.hQuantity,
            this.hUom,
            this.hPONO,
            this.hGRNNO});
            this.dtGrid.Location = new System.Drawing.Point(12, 236);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrid.RowHeadersWidth = 50;
            this.dtGrid.Size = new System.Drawing.Size(958, 237);
            this.dtGrid.TabIndex = 310;
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
            this.hGINNo.HeaderText = "GINNo";
            this.hGINNo.Name = "hGINNo";
            this.hGINNo.Visible = false;
            // 
            // hID
            // 
            this.hID.HeaderText = "ID";
            this.hID.Name = "hID";
            this.hID.Width = 20;
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
            this.hColorID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hColorID.Visible = false;
            // 
            // hSizeID
            // 
            this.hSizeID.HeaderText = "SIZEID";
            this.hSizeID.Name = "hSizeID";
            this.hSizeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hSizeID.Visible = false;
            // 
            // hGrade
            // 
            this.hGrade.HeaderText = "GRADE";
            this.hGrade.Name = "hGrade";
            this.hGrade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hGrade.Visible = false;
            // 
            // hStyleID
            // 
            this.hStyleID.HeaderText = "StyleID Alloc";
            this.hStyleID.Name = "hStyleID";
            // 
            // hStyleIDto
            // 
            this.hStyleIDto.HeaderText = "StyleIDto";
            this.hStyleIDto.Name = "hStyleIDto";
            this.hStyleIDto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hStyleIDto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.hUom.Width = 50;
            // 
            // hPONO
            // 
            this.hPONO.HeaderText = "PONO";
            this.hPONO.Name = "hPONO";
            // 
            // hGRNNO
            // 
            this.hGRNNO.HeaderText = "GRNNO";
            this.hGRNNO.Name = "hGRNNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(41, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Component  Receive ";
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
            // cmdCustomer
            // 
            this.cmdCustomer.Image = ((System.Drawing.Image)(resources.GetObject("cmdCustomer.Image")));
            this.cmdCustomer.Location = new System.Drawing.Point(444, 46);
            this.cmdCustomer.Name = "cmdCustomer";
            this.cmdCustomer.Size = new System.Drawing.Size(28, 23);
            this.cmdCustomer.TabIndex = 300;
            this.cmdCustomer.UseVisualStyleBackColor = true;
            this.cmdCustomer.Click += new System.EventHandler(this.cmdCustomer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 299;
            this.label7.Text = "From";
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
            this.txtCustomerID.Location = new System.Drawing.Point(379, 48);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(59, 20);
            this.txtCustomerID.TabIndex = 298;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 297;
            this.label3.Text = "Date";
            // 
            // dateCreated
            // 
            this.dateCreated.Location = new System.Drawing.Point(79, 74);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(200, 20);
            this.dateCreated.TabIndex = 296;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(21, 13);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(16, 17);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 294;
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
            this.Panel1.TabIndex = 295;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 293;
            this.label1.Text = "GINNo";
            // 
            // txtGRNNO
            // 
            this.txtGRNNO.BackColor = System.Drawing.SystemColors.Info;
            this.txtGRNNO.Location = new System.Drawing.Point(79, 45);
            this.txtGRNNO.Name = "txtGRNNO";
            this.txtGRNNO.Size = new System.Drawing.Size(129, 20);
            this.txtGRNNO.TabIndex = 292;
            // 
            // txtCustomerDesc
            // 
            this.txtCustomerDesc.Location = new System.Drawing.Point(478, 48);
            this.txtCustomerDesc.Name = "txtCustomerDesc";
            this.txtCustomerDesc.Size = new System.Drawing.Size(131, 20);
            this.txtCustomerDesc.TabIndex = 301;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 303;
            this.label9.Text = "Divisi";
            // 
            // cbDIV
            // 
            this.cbDIV.FormattingEnabled = true;
            this.cbDIV.Location = new System.Drawing.Point(79, 100);
            this.cbDIV.Name = "cbDIV";
            this.cbDIV.Size = new System.Drawing.Size(184, 21);
            this.cbDIV.TabIndex = 302;
            // 
            // txtRefer
            // 
            this.txtRefer.Location = new System.Drawing.Point(379, 130);
            this.txtRefer.Name = "txtRefer";
            this.txtRefer.Size = new System.Drawing.Size(230, 20);
            this.txtRefer.TabIndex = 308;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 307;
            this.label5.Text = "Note";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(79, 127);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(204, 46);
            this.txtRemarks.TabIndex = 306;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 305;
            this.label2.Text = "Alamat";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(379, 75);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(230, 49);
            this.txtAddress.TabIndex = 304;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 309;
            this.label6.Text = "Refer to";
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
            this.TSTombol.Location = new System.Drawing.Point(0, 536);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(985, 25);
            this.TSTombol.TabIndex = 291;
            // 
            // txtStyleDesc
            // 
            this.txtStyleDesc.Location = new System.Drawing.Point(466, 501);
            this.txtStyleDesc.Name = "txtStyleDesc";
            this.txtStyleDesc.Size = new System.Drawing.Size(131, 20);
            this.txtStyleDesc.TabIndex = 316;
            this.txtStyleDesc.Visible = false;
            // 
            // txtItemsID
            // 
            this.txtItemsID.BackColor = System.Drawing.SystemColors.Info;
            this.txtItemsID.Location = new System.Drawing.Point(12, 505);
            this.txtItemsID.Name = "txtItemsID";
            this.txtItemsID.Size = new System.Drawing.Size(251, 20);
            this.txtItemsID.TabIndex = 311;
            // 
            // cmdStyle
            // 
            this.cmdStyle.Image = ((System.Drawing.Image)(resources.GetObject("cmdStyle.Image")));
            this.cmdStyle.Location = new System.Drawing.Point(101, 476);
            this.cmdStyle.Name = "cmdStyle";
            this.cmdStyle.Size = new System.Drawing.Size(28, 23);
            this.cmdStyle.TabIndex = 313;
            this.cmdStyle.UseVisualStyleBackColor = true;
            this.cmdStyle.Click += new System.EventHandler(this.cmdStyle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 312;
            this.label8.Text = "Add by ItemsID";
            // 
            // frmgrntComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbStore);
            this.Controls.Add(this.txtStyleDesc);
            this.Controls.Add(this.cbJENIS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmdStyle);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.txtItemsID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdCustomer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateCreated);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGRNNO);
            this.Controls.Add(this.txtCustomerDesc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbDIV);
            this.Controls.Add(this.txtRefer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TSTombol);
            this.Name = "frmgrntComponent";
            this.Text = "Grn Component";
            this.Load += new System.EventHandler(this.frmgrntComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.TSTombol.ResumeLayout(false);
            this.TSTombol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripButton Print;
        private System.Windows.Forms.ComboBox cbStore;
        internal System.Windows.Forms.ToolStripButton TutupTSB;
        internal System.Windows.Forms.ToolStripButton UbahTSB;
        internal System.Windows.Forms.ToolStripButton SimpanTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ComboBox cbJENIS;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.DataGridView dtGrid;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ToolStripButton HapusTSB;
        internal System.Windows.Forms.Button cmdCustomer;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ToolStripButton RecordTSB;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateCreated;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGRNNO;
        private System.Windows.Forms.TextBox txtCustomerDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbDIV;
        private System.Windows.Forms.TextBox txtRefer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ToolStrip TSTombol;
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
        private System.Windows.Forms.DataGridViewButtonColumn hStyleIDto;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn hUom;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn hGRNNO;
        private System.Windows.Forms.TextBox txtStyleDesc;
        private System.Windows.Forms.TextBox txtItemsID;
        internal System.Windows.Forms.Button cmdStyle;
        private System.Windows.Forms.Label label8;
    }
}