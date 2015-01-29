using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassMaster;

namespace MyGarment.ViewMaster
{
    public partial class frmmsize : Form
    {
        public frmmsize()
        {
            InitializeComponent();
        }
        private void Binding()
        {
            DataSet data = new msizeCRUD().getData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmsize";
        }

        private void msize_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            msize K = new msize();
            K.SIZEID = txtSizeID.Text;
            K.Description = txtDescription.Text;
            K.Active = Convert.ToInt32(txtActive.Text);

            if (new msizeCRUD().insertData(K))
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
            msize K = new msize();
            K.SIZEID = txtSizeID.Text;
            K.Description = txtDescription.Text;
            K.Active = Convert.ToInt32(txtActive.Text);

            if (new msizeCRUD().updateData(K))
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
            if (new msizeCRUD().deleteData(txtSizeID.Text))
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
            txtSizeID.Text = null;
            txtDescription.Text = null;
            
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new msizeCRUD().getData(txtSizeID.Text, txtDescription.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmsize";
        }

        private void DtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtGrid.Rows[e.RowIndex];

                txtSizeID.Text = row.Cells[0].Value.ToString();
                txtDescription.Text = row.Cells[1].Value.ToString();
                txtActive.Text = row.Cells[2].Value.ToString();



            }
        }

    }
}
