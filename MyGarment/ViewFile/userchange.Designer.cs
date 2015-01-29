namespace MyGarment.ViewFile
{
    partial class frmuserchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmuserchange));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.BatalTSB = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            this.UbahTSB = new System.Windows.Forms.ToolStripButton();
            this.TutupTSB = new System.Windows.Forms.ToolStripButton();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.TSTombol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUserID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 95);
            this.panel2.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(87, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(197, 20);
            this.txtPassword.TabIndex = 88;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtUserID.Location = new System.Drawing.Point(87, 13);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(129, 20);
            this.txtUserID.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "User ID";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtName.Location = new System.Drawing.Point(87, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 20);
            this.txtName.TabIndex = 68;
            // 
            // BatalTSB
            // 
            this.BatalTSB.Image = ((System.Drawing.Image)(resources.GetObject("BatalTSB.Image")));
            this.BatalTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BatalTSB.Name = "BatalTSB";
            this.BatalTSB.Size = new System.Drawing.Size(56, 22);
            this.BatalTSB.Text = "Batal";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TSTombol
            // 
            this.TSTombol.BackColor = System.Drawing.Color.DarkGray;
            this.TSTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TSTombol.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSTombol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UbahTSB,
            this.BatalTSB,
            this.ToolStripSeparator1,
            this.TutupTSB});
            this.TSTombol.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TSTombol.Location = new System.Drawing.Point(0, 204);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(341, 25);
            this.TSTombol.TabIndex = 90;
            // 
            // UbahTSB
            // 
            this.UbahTSB.Image = ((System.Drawing.Image)(resources.GetObject("UbahTSB.Image")));
            this.UbahTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UbahTSB.Name = "UbahTSB";
            this.UbahTSB.Size = new System.Drawing.Size(56, 22);
            this.UbahTSB.Text = "Ubah";
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
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(21, 13);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(50, 50);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 87;
            this.PictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(76, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 88;
            this.label4.Text = "User Change";
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
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.pictureBox2);
            this.Panel1.Controls.Add(this.label5);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(326, 78);
            this.Panel1.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(74, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Form ini digunakan untuk menyimpan daftar items yang ada pada perusahaan, berikut" +
                " informasi mengenai data yang ada.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmuserchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 229);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TSTombol);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Panel1);
            this.Name = "frmuserchange";
            this.Text = "userchange";
            this.Load += new System.EventHandler(this.frmuserchange_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TSTombol.ResumeLayout(false);
            this.TSTombol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolStripButton BatalTSB;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStrip TSTombol;
        private System.Windows.Forms.ToolStripButton UbahTSB;
        private System.Windows.Forms.ToolStripButton TutupTSB;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}