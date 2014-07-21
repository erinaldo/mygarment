using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassMaster;

namespace MyGarment
{
    public partial class frmmcurrency : Form
    {
        public frmmcurrency()
        {
            InitializeComponent();
        }
        private void Binding()
        {
            DataSet data = new mcurrencyCRUD().getData();
            //data.geData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcurrency";
        }
        private void frmmcurrency_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            mcurrency K = new mcurrency();
            K.CurrencyID = txtCurrencyID.Text;
            K.Description = txtDescription.Text;
            K.Active = Convert.ToInt32(txtActive.Text);

            if (new mcurrencyCRUD().insertData(K))
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
            mcurrency k = new mcurrency();

            k.CurrencyID = txtCurrencyID.Text;
            k.Description = txtDescription.Text;
            k.Active = Convert.ToInt32(txtActive.Text);
            string categoryID = k.CurrencyID;
            if (new mcurrencyCRUD().updateData(categoryID, k))
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
            if (new mcurrencyCRUD().deleteData(txtCurrencyID.Text))
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
            DataSet data = new mcurrencyCRUD().getData(txtCurrencyID.Text, txtDescription.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcurrency";

        }

        private void DtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtGrid.Rows[e.RowIndex];

                txtCurrencyID.Text = row.Cells[0].Value.ToString();
                txtDescription.Text = row.Cells[1].Value.ToString();
                txtActive.Text = row.Cells[2].Value.ToString();



            }

        }
    }
}
