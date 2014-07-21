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
    public partial class frmmcategory : Form
    {
       

        public frmmcategory()
        {
            InitializeComponent();
        }
        // fungsi binding
        private void Binding()
        {
            DataSet data = new mcategoryCRUD().getData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcategory";
        }
        private void frmmcategory_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new mcategoryCRUD().getData(txtCategoryID.Text,txtDescription.Text,txtActive.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcategory";
        }
        private void AddItemCallbackFn(string item)
        {
            txtCategoryID.Text=item;
        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            mcategory K = new mcategory();
            K.CategoryID = txtCategoryID.Text;
            K.Description = txtDescription.Text;
            K.Active = Convert.ToInt32(txtActive.Text);
 
            if (new mcategoryCRUD().insertData(K))
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
            mcategory k = new mcategory();

            k.CategoryID = txtCategoryID.Text;
            k.Description = txtDescription.Text;
            k.Active = Convert.ToInt32(txtActive.Text);
            string categoryID = k.CategoryID;
            if (new mcategoryCRUD().updateData(categoryID, k))
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
            if (new mcategoryCRUD().deleteData(txtCategoryID.Text))
            {
                MessageBox.Show("Data Berhasil dihapus");
                Binding();
            }
            else
            {
                MessageBox.Show("Data Gagal dihapus");
            }
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

        private void DtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BatalTSB_Click(object sender, EventArgs e)
        {
            txtActive.Text = null;
            txtCategoryID.Text = null;
            txtDescription.Text = null;
        }

    }
}