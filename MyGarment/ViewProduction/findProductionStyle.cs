using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassProduction;
namespace MyGarment.ViewProduction
{
    public partial class findProductionStyle : Form
    {
        public delegate void AddStyleDelegate(string itemID, string colorID);
        public AddStyleDelegate AddItemCallback;

        public findProductionStyle()
        {
            InitializeComponent();
        }

        private void findProductionStyle_Load(object sender, EventArgs e)
        {
        

        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new productionCRUD().findStyle(txtStyleID.Text,txtDescription.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblproduction";
        }

        private void DtGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtGrid.Rows[e.RowIndex];
                AddItemCallback(row.Cells["STYLEID"].Value.ToString(), row.Cells["COLORID"].Value.ToString());
                this.Close();
            }
        }
    }
}
