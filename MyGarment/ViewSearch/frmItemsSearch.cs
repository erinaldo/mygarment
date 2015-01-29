using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassMaster;

namespace MyGarment.ViewSearch
{
    public partial class frmItemsSearch : Form
    {
        public delegate void AddItemDelegate(string itemID, string itemDesc);
        public AddItemDelegate AddItemCallback;

        public frmItemsSearch()
        {
            InitializeComponent();
        }

        private void frmItemsSearch_Load(object sender, EventArgs e)
        {

        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new mitemsCRUD().getType("RAW");
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmitems";
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
