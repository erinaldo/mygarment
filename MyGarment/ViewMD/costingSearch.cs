using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassMD;

namespace MyGarment.ViewMD
{
    public partial class frmcostingSearch : Form
    {
        public delegate void AddCostingDelegate(string itemID);
        public AddCostingDelegate AddItemCallback;

        public frmcostingSearch()
        {
            InitializeComponent();
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new costingCRUD().getData(txtCostingNo.Text, txtTypeID.Text,txtStatus.Text,txtOfficer.Text,txtCustomer.Text,Convert.ToInt32(cbApprove.Text));
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblcosting";
        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

        private void frmcostingSearch_Load(object sender, EventArgs e)
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

        private void DtGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtGrid_Enter(object sender, EventArgs e)
        {
         
        }

        private void DtGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
     
        }
    }
}
