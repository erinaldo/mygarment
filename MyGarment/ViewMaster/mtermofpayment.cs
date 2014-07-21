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
    public partial class frmmtermofpayment : Form
    {
        public frmmtermofpayment()
        {
            InitializeComponent();
        }
        private void Binding()
        {
            DataSet data = new mtermofpaymentCRUD().getData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmtermofpayment";
        }

        private void frmmtermofpayment_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            mtermofpayment K = new mtermofpayment();
            K.TermOfPayment = txtTermOfPayment.Text;
            K.TermType = txtTermType.Text;
            K.Days = Convert.ToInt32(txtDays.Text);
            K.Active = Convert.ToInt32(txtActive.Text);

            if (new mtermofpaymentCRUD().insertData(K))
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
            mtermofpayment k = new mtermofpayment();

            k.TermOfPayment = txtTermOfPayment.Text;
            k.TermType= txtTermType.Text;
            k.Days = Convert.ToInt32(txtDays.Text);
            k.Active = Convert.ToInt32(txtActive.Text);

            if (new mtermofpaymentCRUD().updateData(k))
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
            if (new mtermofpaymentCRUD().deleteData(txtTermOfPayment.Text))
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
            txtTermOfPayment.Text = null;
            txtTermType.Text = null;
            txtDays.Text = null;
            txtActive.Text = null;
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new mtermofpaymentCRUD().getData(txtTermOfPayment.Text, txtTermType.Text, Convert.ToInt32(txtDays.Text));
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmtermofpayment";
        }

        private void DtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtGrid.Rows[e.RowIndex];

                txtTermOfPayment.Text = row.Cells[0].Value.ToString();
                txtTermType.Text = row.Cells[1].Value.ToString();
                txtDays.Text = row.Cells[2].Value.ToString();
                txtActive.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
