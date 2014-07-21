using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ViewForm;

namespace MyGarment.Main.Master
{
    public partial class frmmcost : Form
    {
        public frmmcost()
        {
            InitializeComponent();
        }
        private void Binding()
        {
            DataSet data = new mcostCRUD().getData();
            //data.geData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcost";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            mcost K = new mcost();
            K.CostID = txtCostID.Text;
            K.Description = txtDescription.Text;
            K.Active = Convert.ToInt32(txtActive.Text);
            //K.Type = null;
            if (new mcostCRUD().insertData(K))
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
            mcost k = new mcost();

            k.CostID = txtCostID.Text;
            k.Description = txtDescription.Text;
            k.Active = Convert.ToInt32( txtActive.Text);
            string costID = k.CostID;
            if (new mcostCRUD().updateData(costID, k))
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
            if (new mcostCRUD().deleteData(txtCostID.Text))
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
            txtCostID.Text = null;
            txtDescription.Text=null;
            txtActive.Text = null;
        }

        private void mcostFRM_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new mcostCRUD().getData(txtCostID.Text, txtDescription.Text);
            //data.geData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcost";
        }

        private void DtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtGrid.Rows[e.RowIndex];

                txtCostID.Text = row.Cells[0].Value.ToString();
                txtDescription.Text = row.Cells[1].Value.ToString();
                txtActive.Text = row.Cells[2].Value.ToString();



            }

        }
    }
}
