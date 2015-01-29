namespace MyGarment.ViewProduction
{
    partial class cutting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cutting));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.detailsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtColorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStyleID = new System.Windows.Forms.TextBox();
            this.cmdStyle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.masterDataGridView = new System.Windows.Forms.DataGridView();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Location = new System.Drawing.Point(1, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(927, 38);
            this.Panel1.TabIndex = 107;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(19, 8);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(16, 17);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 122;
            this.PictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(41, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Cutting Process Production";
            // 
            // detailsDataGridView
            // 
            this.detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsDataGridView.Location = new System.Drawing.Point(627, 137);
            this.detailsDataGridView.Name = "detailsDataGridView";
            this.detailsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.detailsDataGridView.RowHeadersWidth = 50;
            this.detailsDataGridView.Size = new System.Drawing.Size(301, 199);
            this.detailsDataGridView.TabIndex = 108;
            this.detailsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtColorID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtStyleID);
            this.panel2.Controls.Add(this.cmdStyle);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 54);
            this.panel2.TabIndex = 286;
            // 
            // txtColorID
            // 
            this.txtColorID.Location = new System.Drawing.Point(297, 13);
            this.txtColorID.Name = "txtColorID";
            this.txtColorID.Size = new System.Drawing.Size(150, 20);
            this.txtColorID.TabIndex = 290;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 289;
            this.label1.Text = "Color";
            // 
            // txtStyleID
            // 
            this.txtStyleID.BackColor = System.Drawing.SystemColors.Info;
            this.txtStyleID.Location = new System.Drawing.Point(58, 13);
            this.txtStyleID.Name = "txtStyleID";
            this.txtStyleID.Size = new System.Drawing.Size(150, 20);
            this.txtStyleID.TabIndex = 285;
            this.txtStyleID.TextChanged += new System.EventHandler(this.txtStyleID_TextChanged);
            // 
            // cmdStyle
            // 
            this.cmdStyle.Image = ((System.Drawing.Image)(resources.GetObject("cmdStyle.Image")));
            this.cmdStyle.Location = new System.Drawing.Point(214, 11);
            this.cmdStyle.Name = "cmdStyle";
            this.cmdStyle.Size = new System.Drawing.Size(28, 23);
            this.cmdStyle.TabIndex = 287;
            this.cmdStyle.UseVisualStyleBackColor = true;
            this.cmdStyle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 286;
            this.label8.Text = "StyleID";
            // 
            // masterDataGridView
            // 
            this.masterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masterDataGridView.Location = new System.Drawing.Point(12, 137);
            this.masterDataGridView.Name = "masterDataGridView";
            this.masterDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.masterDataGridView.RowHeadersWidth = 50;
            this.masterDataGridView.Size = new System.Drawing.Size(600, 199);
            this.masterDataGridView.TabIndex = 288;
            this.masterDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.masterDataGridView_CellBeginEdit);
            this.masterDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.masterDataGridView_CellContentClick);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(12, 358);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 290;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click_1);
            // 
            // cmdDel
            // 
            this.cmdDel.Location = new System.Drawing.Point(93, 358);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(75, 23);
            this.cmdDel.TabIndex = 291;
            this.cmdDel.Text = "Delete";
            this.cmdDel.UseVisualStyleBackColor = true;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Location = new System.Drawing.Point(174, 358);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(75, 23);
            this.cmdPrint.TabIndex = 292;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // cutting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 407);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.masterDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.detailsDataGridView);
            this.Controls.Add(this.Panel1);
            this.Name = "cutting";
            this.Text = "cutting";
            this.Load += new System.EventHandler(this.cutting_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView detailsDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStyleID;
        internal System.Windows.Forms.Button cmdStyle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtColorID;
        private System.Windows.Forms.DataGridView masterDataGridView;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Button cmdPrint;

    }
}