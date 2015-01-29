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
using MyGarment.ViewFinance;
using MyGarment.ClassMaster;
using MyGarment.PrintStore;
using MyGarment._1Global;

namespace MyGarment.ViewStore
{
    public partial class frmginGarmentSearchStyle : Form
    {
        public delegate void AddStyleDelegate(string itemID,string itemDesc);
        public AddStyleDelegate AddItemCallback;

        public frmginGarmentSearchStyle()
        {
            InitializeComponent();
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new grndetailCRUD().SearchDataGrn(txtStyleID.Text, txtStyleDesc.Text, GlobalVariables.GCode);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblgrndetail";

        }

        private void ginGarmentSearchStyle_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.GCode == "PRODUCT")
            {
                lblItemsID.Text = "Style ID";

            }else{lblItemsID.Text="Items ID";}
        }

       

        private void DtGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtGrid.Rows[e.RowIndex];
                AddItemCallback(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                this.Close();
            }
        }
    }
}
