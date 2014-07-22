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
            this.BatalTSB = new System.Windows.Forms.ToolStripButton();
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
            this.button3 = new System.Windows.Forms.Button();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTINGNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Widt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comsumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSTombol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BatalTSB
            // 
            this.BatalTSB.Image = ((System.Drawing.Image)(resources.GetObject("BatalTSB.Image")));
            this.BatalTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BatalTSB.Name = "BatalTSB";
            this.BatalTSB.Size = new System.Drawing.Size(56, 22);
            this.BatalTSB.Text = "Batal";
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
            this.BatalTSB,
            this.ToolStripSeparator1,
            this.RecordTSB,
            this.TutupTSB});
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
            this.cbTypeID.Size = new System.Drawing.Size(100, 21);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(677, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 104;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtGrid
            // 
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.COSTINGNO,
            this.ID,
            this.CostType,
            this.DESCRIPTION,
            this.Widt,
            this.Usage,
            this.Comsumption,
            this.Uom,
            this.Price,
            this.Amount,
            this.Currency,
            this.Kurs,
            this.Allowance});
            this.dtGrid.Location = new System.Drawing.Point(12, 216);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrid.RowHeadersWidth = 30;
            this.dtGrid.Size = new System.Drawing.Size(946, 244);
            this.dtGrid.TabIndex = 105;
            this.dtGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtGrid_CellBeginEdit);
            this.dtGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 106;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 108;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Check
            // 
            this.Check.HeaderText = "Check";
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            this.Check.Width = 40;
            // 
            // COSTINGNO
            // 
            this.COSTINGNO.HeaderText = "Costing No";
            this.COSTINGNO.Name = "COSTINGNO";
            this.COSTINGNO.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 40;
            // 
            // CostType
            // 
            this.CostType.HeaderText = "Cost Type";
            this.CostType.Name = "CostType";
            this.CostType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CostType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.HeaderText = "Description";
            this.DESCRIPTION.Name = "DESCRIPTION";
            // 
            // Widt
            // 
            this.Widt.HeaderText = "Width";
            this.Widt.Name = "Widt";
            // 
            // Usage
            // 
            this.Usage.HeaderText = "Usage";
            this.Usage.Name = "Usage";
            // 
            // Comsumption
            // 
            this.Comsumption.FillWeight = 50F;
            this.Comsumption.HeaderText = "Consump";
            this.Comsumption.Name = "Comsumption";
            this.Comsumption.Width = 50;
            // 
            // Uom
            // 
            this.Uom.FillWeight = 50F;
            this.Uom.HeaderText = "Uom";
            this.Uom.Name = "Uom";
            this.Uom.Width = 50;
            // 
            // Price
            // 
            this.Price.FillWeight = 50F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 50;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Currency
            // 
            this.Currency.FillWeight = 50F;
            this.Currency.HeaderText = "Currency";
            this.Currency.Name = "Currency";
            this.Currency.Width = 50;
            // 
            // Kurs
            // 
            this.Kurs.FillWeight = 50F;
            this.Kurs.HeaderText = "Kurs";
            this.Kurs.Name = "Kurs";
            this.Kurs.Width = 50;
            // 
            // Allowance
            // 
            this.Allowance.HeaderText = "Allowance";
            this.Allowance.Name = "Allowance";
            this.Allowance.Width = 50;
            // 
            // frmcosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.button3);
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

        internal System.Windows.Forms.ToolStripButton BatalTSB;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTINGNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn CostType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn Widt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comsumption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Allowance;
    }
}