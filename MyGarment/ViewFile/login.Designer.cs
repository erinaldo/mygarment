namespace MyGarment.ViewFile
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.BatalTSB = new System.Windows.Forms.ToolStripButton();
            this.Label5 = new System.Windows.Forms.Label();
            this.TSTombol = new System.Windows.Forms.ToolStrip();
            this.OkTSB = new System.Windows.Forms.ToolStripButton();
            this.Option = new System.Windows.Forms.ToolStripButton();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TSTombol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BatalTSB
            // 
            this.BatalTSB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BatalTSB.Image = ((System.Drawing.Image)(resources.GetObject("BatalTSB.Image")));
            this.BatalTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BatalTSB.Name = "BatalTSB";
            this.BatalTSB.Size = new System.Drawing.Size(58, 22);
            this.BatalTSB.Text = "Close";
            this.BatalTSB.Click += new System.EventHandler(this.BatalTSB_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Maroon;
            this.Label5.Location = new System.Drawing.Point(117, 135);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(118, 13);
            this.Label5.TabIndex = 46;
            this.Label5.Text = "*Password case sensitif";
            // 
            // TSTombol
            // 
            this.TSTombol.BackColor = System.Drawing.Color.DarkGray;
            this.TSTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TSTombol.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSTombol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BatalTSB,
            this.OkTSB,
            this.Option});
            this.TSTombol.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TSTombol.Location = new System.Drawing.Point(0, 270);
            this.TSTombol.Name = "TSTombol";
            this.TSTombol.Size = new System.Drawing.Size(295, 25);
            this.TSTombol.TabIndex = 45;
            this.TSTombol.Text = "ToolStrip1";
            // 
            // OkTSB
            // 
            this.OkTSB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.OkTSB.Image = ((System.Drawing.Image)(resources.GetObject("OkTSB.Image")));
            this.OkTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OkTSB.Name = "OkTSB";
            this.OkTSB.Size = new System.Drawing.Size(43, 22);
            this.OkTSB.Text = "Ok";
            this.OkTSB.Click += new System.EventHandler(this.OkTSB_Click);
            // 
            // Option
            // 
            this.Option.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Option.Image = ((System.Drawing.Image)(resources.GetObject("Option.Image")));
            this.Option.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(23, 22);
            this.Option.Text = "Option";
            this.Option.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(10, 10);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(50, 55);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 43;
            this.PictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(122, 20);
            this.txtPassword.TabIndex = 42;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(120, 84);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(122, 20);
            this.txtUser.TabIndex = 39;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 114);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 13);
            this.Label2.TabIndex = 41;
            this.Label2.Text = "Password :";
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(64, 34);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(219, 30);
            this.Label4.TabIndex = 36;
            this.Label4.Text = "Form untuk sistem login pengguna ke dalam aplikasi.";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 88);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 13);
            this.Label1.TabIndex = 40;
            this.Label1.Text = "Nama Login :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Maroon;
            this.Label3.Location = new System.Drawing.Point(63, 13);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(97, 16);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "Sistem Login";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Location = new System.Drawing.Point(-1, -2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(292, 78);
            this.Panel1.TabIndex = 44;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(120, 214);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(122, 20);
            this.txtServer.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Server :";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(120, 240);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(122, 20);
            this.txtDatabase.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Database :";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 295);
            this.ControlBox = false;
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TSTombol);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Enter += new System.EventHandler(this.frmLogin_Enter);
            this.TSTombol.ResumeLayout(false);
            this.TSTombol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton BatalTSB;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ToolStrip TSTombol;
        internal System.Windows.Forms.ToolStripButton OkTSB;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUser;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.ToolStripButton Option;
        internal System.Windows.Forms.TextBox txtServer;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtDatabase;
        internal System.Windows.Forms.Label label7;
    }
}