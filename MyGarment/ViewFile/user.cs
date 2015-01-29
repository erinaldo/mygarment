using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassMaster;
using MyGarment.ClassFile;
using System.IO;

namespace MyGarment.ViewFile
{
    public partial class frmuser : Form
    {
        
        public frmuser()
        {
            InitializeComponent();
        }
        public void Binding()
        {
            DataSet data = new muserCRUD().getData();
            //data.geData();
            dtGrid.DataSource = data;
            dtGrid.DataMember = "tblmuser";
        }
        private void cmdImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = openFileDialog1.FileName;
                    picItems.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmuser_Load(object sender, EventArgs e)
        {

            SimpanTSB.Enabled = true;
            UbahTSB.Enabled = false;
            dtGrid.Enabled = false;

            DataSet dsDIV = new mdivCRUD().getData();
            cbDIV.DataSource = dsDIV.Tables[0];
            cbDIV.DisplayMember = "DESCRIPTION";
            cbDIV.ValueMember = "DIVID";

        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            muser K = new muser();
            if (txtPath.Text !="")
            {
            FileStream fs;
            BinaryReader br;
            fs = new FileStream(txtPath.Text, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            K.TTD = br.ReadBytes((int)fs.Length);
            }
            K.USERID = txtUserID.Text;
            //K.GDIV = cbDIV.ValueMember;
            DataRow selectedDIV = ((DataRowView)cbDIV.SelectedItem).Row;
            K.GDIV = selectedDIV["DIVID"].ToString();
           // K.LOCATIONID = cbLocation.Text;
            K.NAME = txtName.Text;
            K.PASSWORD = txtPassword.Text;
            K.PHONE = txtPhone.Text;
            K.ACTIVE = Convert.ToInt32(txtActive.Text);
            K.ADDRESS = txtAddress.Text;
            K.EMAIL = txtEmail.Text;
            K.PATH = txtPath.Text;
            if (new muserCRUD().insertData(K))
            {
                MessageBox.Show("Data berhasil di tambahkan");
                Binding();
                SimpanTSB.Enabled = false;
                UbahTSB.Enabled = true;
                dtGrid.Enabled = true;
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan");
            }

        }

        private void UbahTSB_Click(object sender, EventArgs e)
        {
            muser K = new muser();
            if (txtPath.Text != "")
            {
                FileStream fs;
                BinaryReader br;
                fs = new FileStream(txtPath.Text, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                K.TTD = br.ReadBytes((int)fs.Length);
            }
            K.USERID = txtUserID.Text;
            DataRow selectedDIV = ((DataRowView)cbDIV.SelectedItem).Row;
            K.GDIV = selectedDIV["DIVID"].ToString();
           // K.LOCATIONID = cbLocation.Text;

            K.NAME = txtName.Text;
            K.PASSWORD = txtPassword.Text;
            K.PHONE = txtPhone.Text;
            K.ACTIVE = Convert.ToInt32(txtActive.Text);
            K.PATH = txtPath.Text;
            if (new muserCRUD().updateData(K))
            {
                MessageBox.Show("Data berhasil di tambahkan");
                Binding();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan");
            }
        }

        private void HapusTSB_Click(object sender, EventArgs e)
        {
            if (new muserCRUD().deleteData(txtUserID.Text))
            {
                MessageBox.Show("Data Berhasil dihapus");
                Binding();
            }
            else
            {
                MessageBox.Show("Data Gagal dihapus");
            }
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new muserCRUD().getData(txtUserID.Text, txtName.Text);
            dtGrid.DataSource = data;
            dtGrid.DataMember = "tblmuser";
            SimpanTSB.Enabled = false;
            UbahTSB.Enabled = true;
            dtGrid.Enabled = true;
        }

        private void dtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGrid.Rows[e.RowIndex];

                /*
                 USERID,
NAME,
PASSWORD,
DIV,
LOCATIONID,
EMAIL,
PHONE,
TTD,
PATH,
ADDRESS,
ACTIVE,

                 */
                txtUserID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtPassword.Text = row.Cells[2].Value.ToString();
                cbDIV.Text = row.Cells[3].Value.ToString();
               // cbLocation.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
                txtPhone.Text = row.Cells[6].Value.ToString();
                
                txtActive.Text = row.Cells[10].Value.ToString();
                if (row.Cells[7].Value.ToString() != string.Empty)
                {
                    var data = (Byte[])(row.Cells[7].Value);
                    var stream = new MemoryStream(data);
                    picItems.Image = Image.FromStream(stream);
                }
                else
                {
                    picItems.Image = null;
                }
                txtAddress.Text = row.Cells[9].Value.ToString();
                
                //picItems.Image = GetDataToImage((byte[])(row.Cells[5].Value));

                txtPath.Text = row.Cells[8].Value.ToString();



            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BatalTSB_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtPath.Text = "";
            txtPhone.Text = "";
            txtUserID.Text = "";
            
            SimpanTSB.Enabled = true;
            UbahTSB.Enabled = false;
            dtGrid.Enabled = false;
        }
    }
}
