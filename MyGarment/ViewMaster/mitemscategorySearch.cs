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
    public partial class frmmitemscategorySearch : Form
    {
        public delegate void AddItemDelegate(string itemID, string itemDesc);
        public AddItemDelegate AddItemCallback;

        public frmmitemscategorySearch()
        {
            InitializeComponent();
        }

        private void Binding()
        {
            DataSet data = new mitemscategoryCRUD().getData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmitemscategory";
        }
        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new mitemscategoryCRUD().getData(txtCategoryID.Text, txtDescription.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmitemscategory";
        }

        private void frmmitemstypeSearch_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void DtGrid_DoubleClick(object sender, EventArgs e)
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

        private void DtGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
