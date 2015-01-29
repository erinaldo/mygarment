using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassStore;

namespace MyGarment.ViewStore
{
    public partial class frmginSearch : Form
    {
        public delegate void AddPurchaseDelegate(string itemID);
        public AddPurchaseDelegate AddItemCallback;
        public frmginSearch()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new ginCRUD().searchData(txtGINNO.Text, txtOfficer.Text, txtCustomer.Text, txtStyleID.Text, GlobalVariables.GCode);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblginsearch";
        }

        private void frmginSearch_Load(object sender, EventArgs e)
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
    }
}
