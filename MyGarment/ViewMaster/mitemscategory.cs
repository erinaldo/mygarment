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
    public partial class frmmitemscategory : Form
    {
        public frmmitemscategory()
        {
            InitializeComponent();
        }
        private void Binding()
        {
            DataSet data = new mitemscategoryCRUD().getData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmitemscategory";
        }
        private void frmmitemscategory_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            mitemscategory K = new mitemscategory();
            K.CategoryID = txtCategoryID.Text;
            K.Description = txtDescription.Text;
            K.Active = Convert.ToInt32(txtActive.Text);

            if (new mitemscategoryCRUD().insertData(K))
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
            mitemscategory K = new mitemscategory();
            K.CategoryID = txtCategoryID.Text;
            K.Description = txtDescription.Text;
            K.Active =Convert.ToInt32(txtActive.Text);
            string categoryID = K.CategoryID;
            if (new mitemscategoryCRUD().updateData(categoryID,K))
            {
                MessageBox.Show("Data Berhasil di update");
                Binding();
            }
            else{
                MessageBox.Show("Data gagal di update");
            }

        }

        private void HapusTSB_Click(object sender, EventArgs e)
        {
            if (new mitemscategoryCRUD().deleteData(txtCategoryID.Text))
            {
                MessageBox.Show("Data telah berhasil di hapus");
                Binding();
            }
            else
            {
                MessageBox.Show("Gagal di hapus");
            }
        }

        private void BatalTSB_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = null;
            txtActive.Text = null;
            txtDescription.Text = null;
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new mitemscategoryCRUD().getData(txtCategoryID.Text, txtDescription.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmitemscategory";
          

        }

        private void DtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtGrid.Rows[e.RowIndex];

                txtCategoryID.Text = row.Cells[0].Value.ToString();
                txtDescription.Text = row.Cells[1].Value.ToString();
                txtActive.Text = row.Cells[2].Value.ToString();

            }

        }
    }
}
