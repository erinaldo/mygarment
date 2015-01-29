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
    public partial class frmPurchaseCekBudget : Form
    {
        //public delegate void AddPurchaseDelegate(string itemID);
        //public AddPurchaseDelegate AddItemCallback;
        public string PONO;
        public frmPurchaseCekBudget()
        {
            InitializeComponent();
        }
        private void Binding()
        {
            DataSet data = new purchaseCRUD().cekBudget(PONO);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblpurchase";
        }
        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPurchaseCekBudget_Load(object sender, EventArgs e)
        {
            Binding();

        }
    }
}
