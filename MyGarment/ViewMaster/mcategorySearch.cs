using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyGarment.ViewMaster
{
    public partial class frmmcategorySearch : Form
    {
        public delegate void AddCategoryDelegate(string itemID, string itemDesc);
        public AddCategoryDelegate AddItemCallback;

        public frmmcategorySearch()
        {
            InitializeComponent();
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new mcategoryCRUD().getData(txtCategoryID.Text, txtDescription.Text, txtActive.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcategory";
        }

        private void mcategorySearch_Load(object sender, EventArgs e)
        {

        }
    }
}
