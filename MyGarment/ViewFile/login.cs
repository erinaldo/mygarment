using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassFile;
using MyGarment;
namespace MyGarment.ViewFile
{
    public partial class frmLogin : Form
    {
        public delegate void AddItemDelegate(string User,string Name,string GDIV);
        public AddItemDelegate AddItemCallback;
        bool option;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void login()
        {
            //simpan properties
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;
            Properties.Settings.Default.UserID = txtUser.Text;
            Properties.Settings.Default.Save();

            DataSet data = new muserCRUD().getLogin(txtUser.Text, txtPassword.Text);
            if (data.Tables[0].Rows.Count > 0)
            {
                GlobalVariables.GUserID = data.Tables[0].Rows[0]["USERID"].ToString();
                GlobalVariables.GName = data.Tables[0].Rows[0]["NAME"].ToString();
                GlobalVariables.GDIV = data.Tables[0].Rows[0]["GDIV"].ToString();
                GlobalVariables.GPassword = txtPassword.Text;
                AddItemCallback(data.Tables[0].Rows[0]["USERID"].ToString(), data.Tables[0].Rows[0]["NAME"].ToString(), data.Tables[0].Rows[0]["GDIV"].ToString());
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Login gagal, silahkan di cek lagi user dan paswword");
            }
        }

      
        private void OkTSB_Click(object sender, EventArgs e)
        {
            login();
           // this.Dispose();
            /*
            DataSet data = new muserCRUD().getLogin(txtUser.Text,txtPassword.Text);
            if (data.Tables[0].Rows.Count > 0 )
            {
                GlobalVariables.GUserID=data.Tables[0].Rows[0]["USERID"].ToString();
                GlobalVariables.GName = data.Tables[0].Rows[0]["NAME"].ToString();
                GlobalVariables.GDIV= data.Tables[0].Rows[0]["GDIV"].ToString();
                AddItemCallback(data.Tables[0].Rows[0]["USERID"].ToString(), data.Tables[0].Rows[0]["NAME"].ToString(), data.Tables[0].Rows[0]["GDIV"].ToString());
                
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Login gagal, silahkan di cek lagi user dan paswword");
            }
            */
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Size= new Size(311, 238);
            option = true;
            txtServer.Text= Properties.Settings.Default.Server;
            txtDatabase.Text = Properties.Settings.Default.Database;
            txtUser.Text = Properties.Settings.Default.UserID;
        }

        private void BatalTSB_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void frmLogin_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
                /*
                DataSet data = new muserCRUD().getLogin(txtUser.Text, txtPassword.Text);
                if (data.Tables[0].Rows.Count > 0)
                {
                    AddItemCallback(data.Tables[0].Rows[0]["USERID"].ToString(), data.Tables[0].Rows[0]["NAME"].ToString(), data.Tables[0].Rows[0]["GDIV"].ToString());

                    //simpan properties
                    Properties.Settings.Default.Server=txtServer.Text;
                    Properties.Settings.Default.Database = txtDatabase.Text;
                    Properties.Settings.Default.UserID=txtUser.Text;
                    Properties.Settings.Default.Save();
                    
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Login gagal, silahkan di cek lagi user dan paswword");
                }
                */
                //enter key is down
                //MessageBox.Show("");
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (option == true)
            {
                this.Size = new Size(311, 333);
                option = false;
            }
            else { this.Size = new Size(311, 238); option = true; }
        }
    }
}
