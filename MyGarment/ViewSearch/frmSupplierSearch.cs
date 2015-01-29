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
    public partial class frmSupplierSearch : Form
    {
        public delegate void AddSupplierDelegate(string itemID, string itemDesc);
        public AddSupplierDelegate AddItemCallback;

        public frmSupplierSearch()
        {
            InitializeComponent();
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new mcustvendCRUD().getData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcustvend";
        }

        private void SupplierSearch_Load(object sender, EventArgs e)
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
                AddItemCallback(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                this.Close();
            }
        }
    }
}
