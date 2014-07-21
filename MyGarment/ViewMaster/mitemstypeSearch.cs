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
    public partial class frmmitemstypeSearch : Form
    {
        public delegate void AddItemDelegate(string ItemsTypeID, string ItemsTypeDesc);
        public AddItemDelegate AddItemCallback;

        public frmmitemstypeSearch()
        {
            InitializeComponent();
        }
        private void Binding()
        {
            DataSet data = new mitemstypeCRUD().getData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmitemstype";
        }
        private void mitemstypeSearch_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new mitemstypeCRUD().getData(txtTypeID.Text, txtDescription.Text, txtitemID.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmitemstype";
        }

        private void DtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdCategory_Click(object sender, EventArgs e)
        {
            frmmitemscategorySearch f = new frmmitemscategorySearch();
            f.AddItemCallback = new frmmitemscategorySearch.AddItemDelegate(this.SetValueCallBack);
            f.ShowDialog();
        }

        private void SetValueCallBack(string itemID, string itemDesc)
        {
            txtTypeID.Text = itemID;
            txtDescription.Text = itemDesc;

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
