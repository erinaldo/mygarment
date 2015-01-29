namespace MyGarment.ViewMD
{
    partial class frmPurchaseCekBudget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseCekBudget));
            this.DtGrid = new System.Windows.Forms.DataGridView();
            this.TutupTSB = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrid)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TSTombol.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtGrid
            // 
            this.DtGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrid.Location = new System.Drawing.Point(0, 49);
            this.DtGrid.Name = "DtGrid";
            this.DtGrid.ReadOnly = true;
            this.DtGrid.Size = new System.Drawing.Size(618, 216);
            this.DtGrid.TabIndex = 79;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(59, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = "Cek Budget Purchase";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.pictureBox2);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(618, 43);
            this.Panel1.TabIndex = 77;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // TSTombol
            // 
            this.TSTombol.BackColor = System.Drawing.Color.DarkGray;
            this.TSTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TSTombol.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSTombol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TutupTSB});
            this.TSTombol.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TSTombol.Location = new System.Drawing.Point(0, 278);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(626, 25);
            this.TSTombol.TabIndex = 78;
            // 
            // frmPurchaseCekBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 303);
            this.Controls.Add(this.DtGrid);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TSTombol);
            this.Name = "frmPurchaseCekBudget";
            this.Text = "PurchaseCekBudget";
            this.Load += new System.EventHandler(this.frmPurchaseCekBudget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGrid)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TSTombol.ResumeLayout(false);
            this.TSTombol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtGrid;
        internal System.Windows.Forms.ToolStripButton TutupTSB;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.ToolStrip TSTombol;
    }
}