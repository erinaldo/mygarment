using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassMD;

namespace MyGarment.ViewMD
{
    public partial class costingSearch : Form
    {
        public costingSearch()
        {
            InitializeComponent();
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new costingCRUD().getData(txtCostingNo.Text, txtTypeID.Text,txtStatus.Text,txtOfficer.Text,txtCustomer.Text,Convert.ToInt32(cbApprove.Text));
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblcosting";
        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
