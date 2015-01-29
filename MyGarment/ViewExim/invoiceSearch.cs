using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassExim;
namespace MyGarment.ViewExim
{
    public partial class frminvoiceSearch : Form
    {
        public delegate void AddPurchaseDelegate(string itemID);
        public AddPurchaseDelegate AddItemCallback;
        public frminvoiceSearch()
        {
            InitializeComponent();
        }

        private void frminvoiceSearch_Load(object sender, EventArgs e)
        {

        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new invoiceCRUD().getData(txtGRNNO.Text, txtPONO.Text, txtOfficer.Text, txtCustomer.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblinvoice";
        }

        private void DtGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtGrid.Rows[e.RowIndex];
                AddItemCallback(row.Cells[0].Value.ToString());
                this.Close();
            }
        }

        private void DtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
