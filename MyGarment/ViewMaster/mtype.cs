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
    public partial class frmmtype : Form
    {
        public frmmtype()
        {
            InitializeComponent();
        }
        private void Binding()
        {
            DataSet data = new mtypeCRUD().getData();
            //data.geData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmtype";
        }

        private void DtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            mtype K = new mtype();
            K.TypeID = txtTypeID.Text;
            K.Description = txtDescription.Text;
            K.Active = Convert.ToInt32(txtActive.Text);
            //K.Type = null;
            if (new mtypeCRUD().insertData(K))
            {
                MessageBox.Show("Data berhasil di tambahkan");
                Binding();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan");
            }
        }

        private void frmmtype_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void UbahTSB_Click(object sender, EventArgs e)
        {
            mtype k = new mtype();

            k.TypeID = txtTypeID.Text;
            k.Description = txtDescription.Text;
            k.Active = Convert.ToInt32(txtActive.Text);
            //string costID = k.CostID;
            if (new mtypeCRUD().updateData(k))
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
            if (new mtypeCRUD().deleteData(txtTypeID.Text))
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
            txtTypeID.Text = null;
            txtDescription.Text = null;
            txtActive.Text = null;
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new mtypeCRUD().getData(txtTypeID.Text, txtDescription.Text);
            //data.geData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmtype";
        }
    }
}
