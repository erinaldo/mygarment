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
    public partial class frmjoborderSearch : Form
    {
        public delegate void AddCostingDelegate(string itemID);
        public AddCostingDelegate AddItemCallback;

        public frmjoborderSearch()
        {
            InitializeComponent();
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            //k.ORDERNO=txtCostingNo.Text;
           // k.TYPEID=txtTypeID.Text;
            //k.APPROVE= txtStatus.Text;
            //k.OFFICER=txtOfficer.Text;
            //k.CUSTVENDCODE=txtCustomer.Text;
            //k.APPROVE= Convert.ToInt32(cbApprove.Text);
            DataSet data = new joborderCRUD().getData(txtCostingNo.Text,txtStyleID.Text,txtPOCustomer.Text,txtOfficer.Text,txtCustomer.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tbljoborder";
        }

        private void frmjoborderSearch_Load(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
