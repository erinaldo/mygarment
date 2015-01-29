namespace MyGarment.ViewFile
{
    partial class frmmoduluser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmoduluser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BatalTSB = new System.Windows.Forms.ToolStripButton();
            this.HapusTSB = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RecordTSB = new System.Windows.Forms.ToolStripButton();
            this.SimpanTSB = new System.Windows.Forms.ToolStripButton();
            this.TutupTSB = new System.Windows.Forms.ToolStripButton();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModul = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.hUserID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hModul = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hSave = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hUpdate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hPrint = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hApprove = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hUnApprove = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hAck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hSee = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            // 
            // TSTombol
            // 
            this.TSTombol.BackColor = System.Drawing.Color.DarkGray;
            this.TSTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TSTombol.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSTombol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SimpanTSB,
            this.HapusTSB,
            this.BatalTSB,
            this.ToolStripSeparator1,
            this.RecordTSB,
            this.TutupTSB});
            this.TSTombol.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TSTombol.Location = new System.Drawing.Point(0, 420);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(985, 25);
            this.TSTombol.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(75, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Modul Application";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(20, 11);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(50, 50);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 80;
            this.PictureBox1.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.label5);
            this.Panel1.Location = new System.Drawing.Point(-1, -2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(956, 78);
            this.Panel1.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(74, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Form ini digunakan untuk menyimpan daftar costing yang ada pada perusahaan, berik" +
                "ut informasi mengenai data yang ada.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtGrid
            // 
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hUserID,
            this.hModul,
            this.hSave,
            this.hUpdate,
            this.hDelete,
            this.hPrint,
            this.hApprove,
            this.hUnApprove,
            this.hAck,
            this.hCheck,
            this.hSee});
            this.dtGrid.Location = new System.Drawing.Point(20, 96);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrid.RowHeadersWidth = 50;
            this.dtGrid.Size = new System.Drawing.Size(953, 250);
            this.dtGrid.TabIndex = 106;
            this.dtGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtGrid_CellBeginEdit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 110;
            this.label2.Text = "Modul";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 109;
            this.label1.Text = "UserID";
            // 
            // txtModul
            // 
            this.txtModul.Location = new System.Drawing.Point(103, 389);
            this.txtModul.Name = "txtModul";
            this.txtModul.Size = new System.Drawing.Size(190, 20);
            this.txtModul.TabIndex = 108;
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.SystemColors.Info;
            this.txtUserID.Location = new System.Drawing.Point(103, 363);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(129, 20);
            this.txtUserID.TabIndex = 107;
            // 
            // hUserID
            // 
            this.hUserID.HeaderText = "UserID";
            this.hUserID.Name = "hUserID";
            this.hUserID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hUserID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // hModul
            // 
            this.hModul.HeaderText = "Modul";
            this.hModul.Name = "hModul";
            this.hModul.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hModul.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hModul.Width = 200;
            // 
            // hSave
            // 
            this.hSave.HeaderText = "SAVE";
            this.hSave.Name = "hSave";
            this.hSave.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hSave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hSave.Width = 50;
            // 
            // hUpdate
            // 
            this.hUpdate.HeaderText = "UPDATE";
            this.hUpdate.Name = "hUpdate";
            this.hUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hUpdate.Width = 60;
            // 
            // hDelete
            // 
            this.hDelete.HeaderText = "DELETE";
            this.hDelete.Name = "hDelete";
            this.hDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hDelete.Width = 60;
            // 
            // hPrint
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = false;
            this.hPrint.DefaultCellStyle = dataGridViewCellStyle1;
            this.hPrint.FillWeight = 50F;
            this.hPrint.HeaderText = "PRINT";
            this.hPrint.Name = "hPrint";
            this.hPrint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hPrint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hPrint.Width = 50;
            // 
            // hApprove
            // 
            this.hApprove.FillWeight = 50F;
            this.hApprove.HeaderText = "APPROVE";
            this.hApprove.Name = "hApprove";
            this.hApprove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hApprove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hApprove.Width = 70;
            // 
            // hUnApprove
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = false;
            this.hUnApprove.DefaultCellStyle = dataGridViewCellStyle2;
            this.hUnApprove.FillWeight = 50F;
            this.hUnApprove.HeaderText = "UNAPPROVE";
            this.hUnApprove.Name = "hUnApprove";
            this.hUnApprove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hUnApprove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hUnApprove.Width = 80;
            // 
            // hAck
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = false;
            this.hAck.DefaultCellStyle = dataGridViewCellStyle3;
            this.hAck.HeaderText = "ACKNOWLEDGMENT";
            this.hAck.Name = "hAck";
            this.hAck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hAck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hAck.Width = 120;
            // 
            // hCheck
            // 
            this.hCheck.FillWeight = 50F;
            this.hCheck.HeaderText = "CHECK";
            this.hCheck.Name = "hCheck";
            this.hCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hCheck.Width = 50;
            // 
            // hSee
            // 
            this.hSee.HeaderText = "READ";
            this.hSee.Name = "hSee";
            this.hSee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hSee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hSee.Width = 40;
            // 
            // frmmoduluser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModul);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.TSTombol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Panel1);
            this.Name = "frmmoduluser";
            this.Text = "Modul User";
            this.Load += new System.EventHandler(this.frmmoduluser_Load);
            this.TSTombol.ResumeLayout(false);
            this.TSTombol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton BatalTSB;
        internal System.Windows.Forms.ToolStripButton HapusTSB;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton RecordTSB;
        internal System.Windows.Forms.ToolStripButton SimpanTSB;
        internal System.Windows.Forms.ToolStripButton TutupTSB;
        internal System.Windows.Forms.ToolStrip TSTombol;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModul;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.DataGridViewComboBoxColumn hUserID;
        private System.Windows.Forms.DataGridViewComboBoxColumn hModul;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hUpdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hPrint;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hApprove;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hUnApprove;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hAck;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hCheck;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hSee;
    }
}