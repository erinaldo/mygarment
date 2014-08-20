using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyGarment.ViewFinance
{
    public partial class frmPurchaseSearch : Form
    {
        public delegate void AddPurchaseDelegate(string itemID);
        public AddPurchaseDelegate AddItemCallback;

        public frmPurchaseSearch()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPurchaseSearch_Load(object sender, EventArgs e)
        {

        }

        private void DtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            //DataSet data = new purchaseCRUD().getData(txtCostingNo.Text, txtTypeID.Text, txtStatus.Text, txtOfficer.Text, txtCustomer.Text, Convert.ToInt32(cbApprove.Text));
            //DtGrid.DataSource = data;
            //DtGrid.DataMember = "tblcosting";
        }
    }
}
