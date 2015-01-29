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
    public partial class frmmcolor : Form
    {
        public frmmcolor()
        {
            InitializeComponent();
        }
        private void Binding()
        {
            DataSet data = new mcolorCRUD().getData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcolor";
        }

        //tmabahan untuk set

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmmcolor_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            mcolor K = new mcolor();
            K.ColorID = txtColorID.Text;
            K.Description = txtDescription.Text;
            K.Active = Convert.ToInt32(txtActive.Text);
            //K.Type = null;
            if (new mcolorCRUD().insertData(K))
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
            mcolor k = new mcolor();

            k.ColorID = txtColorID.Text;
            k.Description = txtDescription.Text;
            k.Active = Convert.ToInt32(txtActive.Text);
            string costID = k.ColorID;
            if (new mcolorCRUD().updateData(costID, k))
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
            if (new mcolorCRUD().deleteData(txtColorID.Text))
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

            DataSet data = new mcolorCRUD().getData(txtColorID.Text, txtDescription.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcolor";

           // frmmcolorSearch f = new frmmcolorSearch();
           // f.AddItemCallback = new frmmcolorSearch.AddItemDelegate(this.SetValueCallBack);
           // f.ShowDialog();
            
        }
        private void SetValueCallBack(string itemColorID,string itemDesc,string itemActive)
        {
            txtColorID.Text = itemColorID;
            txtDescription.Text = itemDesc;
            txtActive.Text = itemActive;
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

                txtColorID.Text = row.Cells[0].Value.ToString();
                txtDescription.Text = row.Cells[1].Value.ToString();
                txtActive.Text = row.Cells[2].Value.ToString();



            }
        }

        private void DtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
