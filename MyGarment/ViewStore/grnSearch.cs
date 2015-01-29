using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassMD;
using MyGarment.ClassStore;
using MyGarment.ViewMaster;
using MyGarment.ViewSearch;
using MyGarment.ViewMD;
using MyGarment.ViewFinance;
using MyGarment.ClassMaster;
using MyGarment.PrintMD;
using MyGarment._1Global;

namespace MyGarment.ViewStore
{
    public partial class frmgrnSearch : Form
    {
        public delegate void AddPurchaseDelegate(string itemID);
        public AddPurchaseDelegate AddItemCallback;

        public frmgrnSearch()
        {
            InitializeComponent();
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new grnCRUD().SearchData(txtGRNNO.Text, txtPONO.Text, txtOfficer.Text, txtCustomer.Text,GlobalVariables.GCode);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblgrn";
        }

        private void frmgrnSearch_Load(object sender, EventArgs e)
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
    }
}
