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
    public partial class frmmcurrencySearch : Form
    {
        public delegate void AddItemDelegate(string itemID, string itemDesc);
        public AddItemDelegate AddItemCallback;

        public frmmcurrencySearch()
        {
            InitializeComponent();
        }
        private void Binding()
        {
           DataSet data = new  mcurrencyCRUD().getData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcurrency";
        }
        private void mcurrencySearch_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new mcurrencyCRUD().getData(txtCurrencyID.Text, txtDescription.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcurrency";

        }

        private void DtGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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
