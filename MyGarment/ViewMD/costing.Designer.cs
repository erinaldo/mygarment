namespace MyGarment.ViewMD
{
    partial class frmcosting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcosting));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HapusTSB = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UbahTSB = new System.Windows.Forms.ToolStripButton();
            this.RecordTSB = new System.Windows.Forms.ToolStripButton();
            this.SimpanTSB = new System.Windows.Forms.ToolStripButton();
            this.TutupTSB = new System.Windows.Forms.ToolStripButton();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCostingNo = new System.Windows.Forms.TextBox();
            this.dateCreated = new System.Windows.Forms.DateTimePicker();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStyleID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTypeID = new System.Windows.Forms.ComboBox();
            this.cmdCategory = new System.Windows.Forms.Button();
            this.cmdStyle = new System.Windows.Forms.Button();
            this.cmdCustomer = new System.Windows.Forms.Button();
            this.txtCategoryDesc = new System.Windows.Forms.TextBox();
            this.txtStyleDesc = new System.Windows.Forms.TextBox();
            this.txtCustomerDesc = new System.Windows.Forms.TextBox();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.cbDIV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.hCostingNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCostType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hConsumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hUom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCurrency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hKurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hAllowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSTombol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HapusTSB
            // 
            this.HapusTSB.Image = ((System.Drawing.Image)(resources.GetObject("HapusTSB.Image")));
            this.HapusTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HapusTSB.Name = "HapusTSB";
            this.HapusTSB.Size = new System.Drawing.Size(61, 22);
            this.HapusTSB.Text = "Hapus";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // RecordTSB
            // 
            this.RecordTSB.Image = ((System.Drawing.Image)(resources.GetObject("RecordTSB.Image")));
            this.RecordTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RecordTSB.Name = "RecordTSB";
            this.RecordTSB.Size = new System.Drawing.Size(53, 22);
            this.RecordTSB.Text = "Find";
            this.RecordTSB.Click += new System.EventHandler(this.RecordTSB_Click);
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
            this.TutupTSB.Click += new System.EventHandler(this.TutupTSB_Click);
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
            this.toolStripButton1});
            this.TSTombol.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TSTombol.Location = new System.Drawing.Point(0, 473);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(970, 25);
            this.TSTombol.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(41, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Costing";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(21, 11);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(16, 17);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 80;
            this.PictureBox1.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Location = new System.Drawing.Point(0, -2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(970, 38);
            this.Panel1.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Costing";
            // 
            // txtCostingNo
            // 
            this.txtCostingNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtCostingNo.Location = new System.Drawing.Point(96, 59);
            this.txtCostingNo.Name = "txtCostingNo";
            this.txtCostingNo.Size = new System.Drawing.Size(129, 20);
            this.txtCostingNo.TabIndex = 75;
            // 
            // dateCreated
            // 
            this.dateCreated.Location = new System.Drawing.Point(484, 79);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(200, 20);
            this.dateCreated.TabIndex = 86;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.BackColor = System.Drawing.SystemColors.Info;
            this.txtCategoryID.Location = new System.Drawing.Point(96, 138);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(72, 20);
            this.txtCategoryID.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Date";
            // 
            // txtStyleID
            // 
            this.txtStyleID.BackColor = System.Drawing.SystemColors.Info;
            this.txtStyleID.Location = new System.Drawing.Point(96, 167);
            this.txtStyleID.Name = "txtStyleID";
            this.txtStyleID.Size = new System.Drawing.Size(72, 20);
            this.txtStyleID.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "StyleID";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(96, 190);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 92;
            this.txtQty.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "Quantity";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.SystemColors.Info;
            this.txtCustomerID.Location = new System.Drawing.Point(484, 52);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(71, 20);
            this.txtCustomerID.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "Customer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 96;
            this.label8.Text = "Type";
            // 
            // cbTypeID
            // 
            this.cbTypeID.FormattingEnabled = true;
            this.cbTypeID.Location = new System.Drawing.Point(96, 109);
            this.cbTypeID.Name = "cbTypeID";
            this.cbTypeID.Size = new System.Drawing.Size(184, 21);
            this.cbTypeID.TabIndex = 97;
            // 
            // cmdCategory
            // 
            this.cmdCategory.Image = ((System.Drawing.Image)(resources.GetObject("cmdCategory.Image")));
            this.cmdCategory.Location = new System.Drawing.Point(174, 138);
            this.cmdCategory.Name = "cmdCategory";
            this.cmdCategory.Size = new System.Drawing.Size(28, 23);
            this.cmdCategory.TabIndex = 98;
            this.cmdCategory.UseVisualStyleBackColor = true;
            this.cmdCategory.Click += new System.EventHandler(this.cmdCategory_Click);
            // 
            // cmdStyle
            // 
            this.cmdStyle.Image = ((System.Drawing.Image)(resources.GetObject("cmdStyle.Image")));
            this.cmdStyle.Location = new System.Drawing.Point(174, 167);
            this.cmdStyle.Name = "cmdStyle";
            this.cmdStyle.Size = new System.Drawing.Size(28, 23);
            this.cmdStyle.TabIndex = 99;
            this.cmdStyle.UseVisualStyleBackColor = true;
            this.cmdStyle.Click += new System.EventHandler(this.cmdStyle_Click);
            // 
            // cmdCustomer
            // 
            this.cmdCustomer.Image = ((System.Drawing.Image)(resources.GetObject("cmdCustomer.Image")));
            this.cmdCustomer.Location = new System.Drawing.Point(561, 50);
            this.cmdCustomer.Name = "cmdCustomer";
            this.cmdCustomer.Size = new System.Drawing.Size(28, 23);
            this.cmdCustomer.TabIndex = 100;
            this.cmdCustomer.UseVisualStyleBackColor = true;
            this.cmdCustomer.Click += new System.EventHandler(this.cmdCustomer_Click);
            // 
            // txtCategoryDesc
            // 
            this.txtCategoryDesc.BackColor = System.Drawing.SystemColors.Info;
            this.txtCategoryDesc.Location = new System.Drawing.Point(208, 141);
            this.txtCategoryDesc.Name = "txtCategoryDesc";
            this.txtCategoryDesc.Size = new System.Drawing.Size(157, 20);
            this.txtCategoryDesc.TabIndex = 101;
            // 
            // txtStyleDesc
            // 
            this.txtStyleDesc.BackColor = System.Drawing.SystemColors.Info;
            this.txtStyleDesc.Location = new System.Drawing.Point(208, 167);
            this.txtStyleDesc.Name = "txtStyleDesc";
            this.txtStyleDesc.Size = new System.Drawing.Size(157, 20);
            this.txtStyleDesc.TabIndex = 102;
            // 
            // txtCustomerDesc
            // 
            this.txtCustomerDesc.Location = new System.Drawing.Point(595, 52);
            this.txtCustomerDesc.Name = "txtCustomerDesc";
            this.txtCustomerDesc.Size = new System.Drawing.Size(185, 20);
            this.txtCustomerDesc.TabIndex = 103;
            // 
            // dtGrid
            // 
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hCostingNo,
            this.hID,
            this.hCostType,
            this.hDescription,
            this.hWidth,
            this.hUsage,
            this.hConsumption,
            this.hUom,
            this.hPrice,
            this.hAmount,
            this.hCurrency,
            this.hKurs,
            this.hAllowance});
            this.dtGrid.Location = new System.Drawing.Point(12, 216);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrid.RowHeadersWidth = 50;
            this.dtGrid.Size = new System.Drawing.Size(946, 244);
            this.dtGrid.TabIndex = 105;
            this.dtGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtGrid_CellBeginEdit);
            this.dtGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellContentClick);
            this.dtGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtGrid_CellValidating);
            // 
            // cbDIV
            // 
            this.cbDIV.FormattingEnabled = true;
            this.cbDIV.Location = new System.Drawing.Point(96, 82);
            this.cbDIV.Name = "cbDIV";
            this.cbDIV.Size = new System.Drawing.Size(184, 21);
            this.cbDIV.TabIndex = 106;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 107;
            this.label9.Text = "Divisi";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // hCostingNo
            // 
            this.hCostingNo.HeaderText = "Costing No";
            this.hCostingNo.Name = "hCostingNo";
            this.hCostingNo.Visible = false;
            // 
            // hID
            // 
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = null;
            this.hID.DefaultCellStyle = dataGridViewCellStyle11;
            this.hID.HeaderText = "ID";
            this.hID.Name = "hID";
            this.hID.Visible = false;
            this.hID.Width = 40;
            // 
            // hCostType
            // 
            this.hCostType.HeaderText = "Cost Type";
            this.hCostType.Name = "hCostType";
            this.hCostType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hCostType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // hDescription
            // 
            this.hDescription.HeaderText = "Description";
            this.hDescription.Name = "hDescription";
            // 
            // hWidth
            // 
            this.hWidth.HeaderText = "Width";
            this.hWidth.Name = "hWidth";
            // 
            // hUsage
            // 
            this.hUsage.HeaderText = "Usage";
            this.hUsage.Name = "hUsage";
            // 
            // hConsumption
            // 
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.hConsumption.DefaultCellStyle = dataGridViewCellStyle12;
            this.hConsumption.FillWeight = 50F;
            this.hConsumption.HeaderText = "Consump";
            this.hConsumption.Name = "hConsumption";
            this.hConsumption.Width = 50;
            // 
            // hUom
            // 
            this.hUom.FillWeight = 50F;
            this.hUom.HeaderText = "Uom";
            this.hUom.Name = "hUom";
            this.hUom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hUom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hUom.Width = 50;
            // 
            // hPrice
            // 
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.hPrice.DefaultCellStyle = dataGridViewCellStyle13;
            this.hPrice.FillWeight = 50F;
            this.hPrice.HeaderText = "Price";
            this.hPrice.Name = "hPrice";
            this.hPrice.Width = 50;
            // 
            // hAmount
            // 
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.hAmount.DefaultCellStyle = dataGridViewCellStyle14;
            this.hAmount.HeaderText = "Amount";
            this.hAmount.Name = "hAmount";
            // 
            // hCurrency
            // 
            this.hCurrency.FillWeight = 50F;
            this.hCurrency.HeaderText = "Currency";
            this.hCurrency.Name = "hCurrency";
            this.hCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hCurrency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hCurrency.Width = 50;
            // 
            // hKurs
            // 
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            this.hKurs.DefaultCellStyle = dataGridViewCellStyle15;
            this.hKurs.FillWeight = 50F;
            this.hKurs.HeaderText = "Kurs";
            this.hKurs.Name = "hKurs";
            this.hKurs.Width = 50;
            // 
            // hAllowance
            // 
            this.hAllowance.HeaderText = "Allow (%)";
            this.hAllowance.Name = "hAllowance";
            this.hAllowance.Width = 50;
            // 
            // frmcosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 498);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbDIV);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.txtCustomerDesc);
            this.Controls.Add(this.txtStyleDesc);
            this.Controls.Add(this.txtCategoryDesc);
            this.Controls.Add(this.cmdCustomer);
            this.Controls.Add(this.cmdStyle);
            this.Controls.Add(this.cmdCategory);
            this.Controls.Add(this.cbTypeID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQty);
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
            this.Name = "frmcosting";
            this.Text = "costing";
            this.Load += new System.EventHandler(this.frmcosting_Load);
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

        internal System.Windows.Forms.ToolStripButton HapusTSB;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton UbahTSB;
        internal System.Windows.Forms.ToolStripButton RecordTSB;
        internal System.Windows.Forms.ToolStripButton SimpanTSB;
        internal System.Windows.Forms.ToolStripButton TutupTSB;
        internal System.Windows.Forms.ToolStrip TSTombol;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCostingNo;
        private System.Windows.Forms.DateTimePicker dateCreated;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStyleID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTypeID;
        internal System.Windows.Forms.Button cmdCategory;
        internal System.Windows.Forms.Button cmdStyle;
        internal System.Windows.Forms.Button cmdCustomer;
        private System.Windows.Forms.TextBox txtCategoryDesc;
        private System.Windows.Forms.TextBox txtStyleDesc;
        private System.Windows.Forms.TextBox txtCustomerDesc;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.ComboBox cbDIV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCostingNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hID;
        private System.Windows.Forms.DataGridViewComboBoxColumn hCostType;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn hWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn hUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn hConsumption;
        private System.Windows.Forms.DataGridViewComboBoxColumn hUom;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn hAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn hCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn hKurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn hAllowance;
    }
}