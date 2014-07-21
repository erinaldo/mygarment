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
    public partial class frmmitemstype : Form
    {
        public frmmitemstype()
        {
            InitializeComponent();
        }
        private void Binding()
        {
            DataSet data = new mitemstypeCRUD().getData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmitemstype";
        }

        private void frmmitemstype_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new mitemstypeCRUD().getData(txtTypeID.Text, txtDescription.Text, txtitemID.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmitemstype";
        }

        private void cmdCategory_Click(object sender, EventArgs e)
        {
            //frmmcolorSearch f = new frmmcolorSearch();
            //f.AddItemCallback = new frmmcolorSearch.AddItemDelegate(this.SetValueCallBack);
            //f.ShowDialog();
            frmmitemscategorySearch f = new frmmitemscategorySearch();
            f.AddItemCallback = new frmmitemscategorySearch.AddItemDelegate(this.SetValueCallBack);
            f.ShowDialog();
        }
        //tambahan
        private void SetValueCallBack(string itemID, string itemDesc)
        {
            txtitemID.Text = itemID;
            txtItemDesc.Text = itemDesc;
            
        }

        private void DtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtGrid.Rows[e.RowIndex];

                txtTypeID.Text = row.Cells[0].Value.ToString();
                txtDescription.Text = row.Cells[1].Value.ToString();
                txtActive.Text = row.Cells[2].Value.ToString();
                txtitemID.Text = row.Cells[3].Value.ToString();

            }

        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            mitemstype K = new mitemstype();
            K.ItemsTypeID = txtTypeID.Text;
            K.Description = txtDescription.Text;
            K.Active = Convert.ToInt32(txtActive.Text);
            K.CategoryID = txtitemID.Text;
            if (new mitemstypeCRUD().insertData(K))
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
            mitemstype k = new mitemstype();

            k.ItemsTypeID = txtTypeID.Text;
            k.Description = txtDescription.Text;
            k.Active = Convert.ToInt32(txtActive.Text);
            k.CategoryID = txtitemID.Text;

           // string categoryID = k.ItemsTypeID;
            if (new mitemstypeCRUD().updateData(k.ItemsTypeID, k))
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
            if (new mitemstypeCRUD().deleteData(txtTypeID.Text))
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
            txtTypeID.Text = null;
            txtDescription.Text = null;
            txtitemID.Text = null;
            txtItemDesc = null;
        }
    }
}
