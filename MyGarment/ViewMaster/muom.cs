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
    public partial class frmmuom : Form
    {
        public frmmuom()
        {
            InitializeComponent();
        }

        private void Binding()
        {
            DataSet data = new muomCRUD().getData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmuom";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            muom K = new muom();
            K.UOMID = txtUomID.Text;
            K.Description = txtDescription.Text;
            K.Active = Convert.ToInt32(txtActive.Text);

            if (new muomCRUD().insertData(K))
            {
                MessageBox.Show("Data berhasil di tambahkan");
                Binding();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan");
            }

        }

        private void frmmuom_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void UbahTSB_Click(object sender, EventArgs e)
        {
            muom K = new muom();
            K.UOMID = txtUomID.Text;
            K.Description = txtDescription.Text;
            K.Active = Convert.ToInt32(txtActive.Text);
            if (new muomCRUD().updateData(txtUomID.Text,K))
            {
                MessageBox.Show("Data berhasil di update");
                Binding();
            }
            else
            {
                MessageBox.Show("Gagal update data");
            }

        }

        private void HapusTSB_Click(object sender, EventArgs e)
        {
            if(new muomCRUD().deleteData(txtUomID.Text))
            {
                MessageBox.Show("Data Berhasil di Hapus");
                Binding();
            }
            else
            {
                MessageBox.Show("Data Gagal di hapus");
            }

        }

        private void BatalTSB_Click(object sender, EventArgs e)
        {
            txtUomID.Text = null;
            txtDescription.Text = null;
            txtActive.Text = null;
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new muomCRUD().getData(txtUomID.Text, txtDescription.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmuom";
        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
