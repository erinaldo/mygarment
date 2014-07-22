namespace MyGarment.ViewForm
{
    partial class frmmitemsSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmitemsSearch));
            this.TutupTSB = new System.Windows.Forms.ToolStripButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.txtItemsTypeDesc = new System.Windows.Forms.TextBox();
            this.cmdCategory = new System.Windows.Forms.Button();
            this.txtItemsTypeID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemsID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RecordTSB = new System.Windows.Forms.ToolStripButton();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TSTombol.SuspendLayout();
            this.SuspendLayout();
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(21, 9);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(50, 50);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 80;
            this.PictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Type";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.pictureBox2);
            this.Panel1.Controls.Add(this.label5);
            this.Panel1.Location = new System.Drawing.Point(0, -4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(487, 78);
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
            this.label5.Text = "Form ini digunakan untuk menyimpan daftar items yang ada pada perusahaan, berikut" +
                " informasi mengenai data yang ada.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtType);
            this.panel2.Controls.Add(this.txtItemsTypeDesc);
            this.panel2.Controls.Add(this.cmdCategory);
            this.panel2.Controls.Add(this.txtItemsTypeID);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtItemsID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Location = new System.Drawing.Point(12, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 154);
            this.panel2.TabIndex = 79;
            // 
            // txtType
            // 
            this.txtType.AutoCompleteCustomSource.AddRange(new string[] {
            "RAW",
            "PRODUCT",
            "SERVICE"});
            this.txtType.FormattingEnabled = true;
            this.txtType.Location = new System.Drawing.Point(87, 94);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(152, 21);
            this.txtType.TabIndex = 82;
            // 
            // txtItemsTypeDesc
            // 
            this.txtItemsTypeDesc.Location = new System.Drawing.Point(211, 67);
            this.txtItemsTypeDesc.Name = "txtItemsTypeDesc";
            this.txtItemsTypeDesc.ReadOnly = true;
            this.txtItemsTypeDesc.Size = new System.Drawing.Size(217, 20);
            this.txtItemsTypeDesc.TabIndex = 80;
            // 
            // cmdCategory
            // 
            this.cmdCategory.Image = ((System.Drawing.Image)(resources.GetObject("cmdCategory.Image")));
            this.cmdCategory.Location = new System.Drawing.Point(177, 65);
            this.cmdCategory.Name = "cmdCategory";
            this.cmdCategory.Size = new System.Drawing.Size(28, 23);
            this.cmdCategory.TabIndex = 79;
            this.cmdCategory.UseVisualStyleBackColor = true;
            // 
            // txtItemsTypeID
            // 
            this.txtItemsTypeID.Location = new System.Drawing.Point(87, 65);
            this.txtItemsTypeID.Name = "txtItemsTypeID";
            this.txtItemsTypeID.ReadOnly = true;
            this.txtItemsTypeID.Size = new System.Drawing.Size(84, 20);
            this.txtItemsTypeID.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Items Type";
            // 
            // txtItemsID
            // 
            this.txtItemsID.BackColor = System.Drawing.SystemColors.Info;
            this.txtItemsID.Location = new System.Drawing.Point(87, 13);
            this.txtItemsID.Name = "txtItemsID";
            this.txtItemsID.Size = new System.Drawing.Size(129, 20);
            this.txtItemsID.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Items ID";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(87, 39);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(341, 20);
            this.txtDescription.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(76, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Items";
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
            // TSTombol
            // 
            this.TSTombol.BackColor = System.Drawing.Color.DarkGray;
            this.TSTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TSTombol.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSTombol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSeparator1,
            this.RecordTSB,
            this.TutupTSB});
            this.TSTombol.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TSTombol.Location = new System.Drawing.Point(0, 270);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(506, 25);
            this.TSTombol.TabIndex = 83;
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // frmmitemsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 295);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TSTombol);
            this.Name = "frmmitemsSearch";
            this.Text = "mitemsSearch";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TSTombol.ResumeLayout(false);
            this.TSTombol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton TutupTSB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.TextBox txtItemsTypeDesc;
        internal System.Windows.Forms.Button cmdCategory;
        private System.Windows.Forms.TextBox txtItemsTypeID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemsID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton RecordTSB;
        private System.Windows.Forms.ToolStrip TSTombol;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
    }
}