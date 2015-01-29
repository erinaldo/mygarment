namespace MyGarment.ViewSearch
{
    partial class frmItemsSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemsSearch));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCurrencyID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.TutupTSB = new System.Windows.Forms.ToolStripButton();
            this.RecordTSB = new System.Windows.Forms.ToolStripButton();
            this.Label3 = new System.Windows.Forms.Label();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtGrid = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.TSTombol.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCurrencyID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Location = new System.Drawing.Point(12, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 100);
            this.panel2.TabIndex = 77;
            // 
            // txtCurrencyID
            // 
            this.txtCurrencyID.BackColor = System.Drawing.SystemColors.Info;
            this.txtCurrencyID.Location = new System.Drawing.Point(87, 13);
            this.txtCurrencyID.Name = "txtCurrencyID";
            this.txtCurrencyID.Size = new System.Drawing.Size(129, 20);
            this.txtCurrencyID.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "ItemsID";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(87, 39);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(341, 20);
            this.txtDescription.TabIndex = 68;
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
            // RecordTSB
            // 
            this.RecordTSB.Image = ((System.Drawing.Image)(resources.GetObject("RecordTSB.Image")));
            this.RecordTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RecordTSB.Name = "RecordTSB";
            this.RecordTSB.Size = new System.Drawing.Size(53, 22);
            this.RecordTSB.Text = "Find";
            this.RecordTSB.Click += new System.EventHandler(this.RecordTSB_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Maroon;
            this.Label3.Location = new System.Drawing.Point(64, 13);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(98, 16);
            this.Label3.TabIndex = 34;
            this.Label3.Text = "Items Search";
            // 
            // TSTombol
            // 
            this.TSTombol.BackColor = System.Drawing.Color.DarkGray;
            this.TSTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TSTombol.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSTombol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RecordTSB,
            this.TutupTSB});
            this.TSTombol.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TSTombol.Location = new System.Drawing.Point(0, 396);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(498, 25);
            this.TSTombol.TabIndex = 78;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Location = new System.Drawing.Point(12, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(475, 78);
            this.Panel1.TabIndex = 76;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(64, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(390, 30);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Form ini digunakan untuk mencari currency";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(9, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(50, 50);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 33;
            this.PictureBox1.TabStop = false;
            // 
            // DtGrid
            // 
            this.DtGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrid.Location = new System.Drawing.Point(12, 89);
            this.DtGrid.Name = "DtGrid";
            this.DtGrid.ReadOnly = true;
            this.DtGrid.Size = new System.Drawing.Size(475, 181);
            this.DtGrid.TabIndex = 75;
            this.DtGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrid_CellDoubleClick);
            // 
            // frmItemsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 421);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TSTombol);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.DtGrid);
            this.Name = "frmItemsSearch";
            this.Text = "frmItemsSearch";
            this.Load += new System.EventHandler(this.frmItemsSearch_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TSTombol.ResumeLayout(false);
            this.TSTombol.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCurrencyID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ToolStripButton TutupTSB;
        private System.Windows.Forms.ToolStripButton RecordTSB;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.ToolStrip TSTombol;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.DataGridView DtGrid;
    }
}