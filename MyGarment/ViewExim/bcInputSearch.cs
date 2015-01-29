using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MyGarment.ClassExim;

namespace MyGarment.ViewExim
{
    public partial class frmbcInputSearch : Form
    {
        public delegate void AddPurchaseDelegate(string itemID);
        public AddPurchaseDelegate AddItemCallback;
        public frmbcInputSearch()
        {
            InitializeComponent();
        }

        private void frmbcInputSearch_Load(object sender, EventArgs e)
        {

        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new eximdocCRUD().getData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tbleximdoc";
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
                AddItemCallback(row.Cells[0].Value.ToString());
                this.Close();
            }
        }
    }
}
