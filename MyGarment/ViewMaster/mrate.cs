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
    public partial class frmmrate : Form
    {
        public frmmrate()
        {
            InitializeComponent();
        }
        private void Binding()
        {
            DataSet data = new mrateCRUD().getData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmrate";
        }
        private void frmmrate_Load(object sender, EventArgs e)
        {
            Binding();
        }

 
        //tambahan
        private void SetValueCallBack(string CurrencyID, string CurrencyDesc)
        {
            txtCurrencyID.Text = CurrencyID;
            txtCurrencyDesc.Text = CurrencyDesc;

        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            mrate K = new mrate();
            K.DATE = txtDate.Value;
            K.CURRENCYID = txtCurrencyID.Text;
            K.KURS = (float)Convert.ToDouble(txtKurs.Text);

            if (new mrateCRUD().insertData(K))
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
            mrate k = new mrate();

            k.ID = Convert.ToInt32(txtID.Text);
            k.DATE = txtDate.Value;
            k.CURRENCYID = txtCurrencyID.Text;
            

            if (new mrateCRUD().updateData(k))
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
            if (new mrateCRUD().deleteData(txtID.Text))
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
            txtID.Text = null;
            txtDate.Text = null;
            txtCurrencyID.Text = null;
            txtKurs.Text = null;
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
          
        }

        private void cmdCurrency_Click(object sender, EventArgs e)
        {
            frmmcurrencySearch f = new frmmcurrencySearch();
            f.AddItemCallback = new frmmcurrencySearch.AddItemDelegate(this.SetValueCallBack);
            f.ShowDialog();
        }

        private void DtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtGrid.Rows[e.RowIndex];

                txtID.Text = row.Cells[0].Value.ToString();
                txtDate.Text = row.Cells[1].Value.ToString();
                txtCurrencyID.Text = row.Cells[2].Value.ToString();
                txtKurs.Text = row.Cells[3].Value.ToString();
            }
        }

  

    }
}
