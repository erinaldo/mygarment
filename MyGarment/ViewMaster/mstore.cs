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
    public partial class frmmstore : Form
    {
        public frmmstore()
        {
            InitializeComponent();
        }

        private void Binding()
        {
            DataSet data = new mstoreCRUD().getData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmstore";
        }
        private void frmmstore_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            mstore K = new mstore();
            K.StoreID = txtStoreID.Text;
            K.Name = txtName.Text;
            K.Address = txtAddress.Text;
            K.Active = Convert.ToInt32(txtActive.Text);

            if (new mstoreCRUD().insertData(K))
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
            mstore k = new mstore();

            k.StoreID = txtStoreID.Text;
            k.Name = txtName.Text;
            k.Address = txtAddress.Text;
            k.Active = Convert.ToInt32(txtActive.Text);
            
            if (new mstoreCRUD().updateData(k))
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
            if (new mstoreCRUD().deleteData(txtStoreID.Text))
            {
                MessageBox.Show("Data Berhasil dihapus");
                Binding();
            }
            else
            {
                MessageBox.Show("Data Gagal dihapus");
            }
        }

        private void BatalTSB_Click(object sender, EventArgs e)
        {
            txtActive.Text = null;
            txtStoreID.Text = null;
            txtName.Text = null;
            txtAddress = null;
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new mstoreCRUD().getData(txtStoreID.Text, txtName.Text, txtAddress.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmstore";

        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
