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
    public partial class frmmcolorSearch : Form
    {
        //tmabahan fungsi delegate
        public delegate void AddItemDelegate(string itemColorID,string itemDesc,string itemActive);
        public AddItemDelegate AddItemCallback;

        //private frmmcolor formColor;
        public frmmcolorSearch()
        {
            InitializeComponent();
        }

        private void Binding()
        {
            DataSet data = new mcolorCRUD().getData();
            //data.geData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcolor";
        }
        private void frmmcolorSearch_Load(object sender, EventArgs e)
        {
            Binding();
        }



        private void DtGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtGrid.Rows[e.RowIndex];
                AddItemCallback(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString());
                this.Close();
            }

        }

        private void frmmcolorSearch_Shown(object sender, EventArgs e)
        {

        }

        private void DtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SatuanTxt_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
