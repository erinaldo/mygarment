using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassMaster;

namespace MyGarment.ViewForm
{
    public partial class frmmcustvend : Form
    {
        public frmmcustvend()
        {
            InitializeComponent();
        }
        private void Binding()
        {
            DataSet data = new mcustvendCRUD().getData();
            //data.geData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcustvend";
        }
        private void frmmcustvend_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            mcustvend K = new mcustvend();
            K.CustVendCode = txtCustVendCode.Text;
            K.Name = txtName.Text;
            K.Type = txtType.Text;
            K.Active = Convert.ToInt32(txtActive.Text);
            //K.Type = null;
            if (new mcustvendCRUD().insertData(K))
            {
                MessageBox.Show("Data berhasil di tambahkan");
                Binding();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan");
            }
        }

        private void UbahTSB_Click(object sender, EventArgs e)
        {
            mcustvend k = new mcustvend();

            k.CustVendCode = txtCustVendCode.Text;
            k.Name = txtName.Text;
            k.Type = txtType.Text;
            k.Active = Convert.ToInt32(txtActive.Text);
          
            if (new mcustvendCRUD().updateData(k))
            {
                MessageBox.Show("Update Sukses");
                Binding();
            }
            else
            {
                MessageBox.Show("Update tidak berhasil");
            }
        }

        private void HapusTSB_Click(object sender, EventArgs e)
        {
            if (new mcustvendCRUD().deleteData(txtCustVendCode.Text))
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
            DataSet data = new mcustvendCRUD().getData(txtCustVendCode.Text, txtName.Text,txtType.Text);
            //data.geData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcustvend";
        }

        private void BatalTSB_Click(object sender, EventArgs e)
        {
            txtCustVendCode = null;
            txtName.Text = null;
            txtType.Text = null;

        }
    }
}
