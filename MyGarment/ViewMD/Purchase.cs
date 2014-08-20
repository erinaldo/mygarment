using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassMD;
using MyGarment.ViewMaster;
using MyGarment.ViewSearch;
using MyGarment.ClassMaster;
using MyGarment.PrintMD;
using MyGarment.ViewMD;
namespace MyGarment.ViewFinance
{
    public partial class frmPurchase : Form
    {
        private string GStrCode = "";
        DataSet dsCost = new mcostCRUD().getData();
        DataSet dsCurrency = new mcurrencyCRUD().getData();
        DataSet dsUOM = new muomCRUD().getData();
        DataSet dsType = new mtypeCRUD().getData();
        DataSet dsDIV = new mdivCRUD().getData();
        public frmPurchase()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {

        }

        private void cmdCustomer_Click(object sender, EventArgs e)
        {
           // frmCustomerSearch f = new frmCustomerSearch();
           // f.AddItemCallback = new frmCustomerSearch.AddCustomerDelegate(this.SetCustomerCallBack);
           // f.ShowDialog();

        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {

            cbDIV.DataSource = dsDIV.Tables[0];
            cbDIV.DisplayMember = "DESCRIPTION";
            cbDIV.ValueMember = "DIVID";

            cbCurrency.DataSource = dsCurrency.Tables[0];
            cbCurrency.DisplayMember = "CURRENCYID";
            cbCurrency.ValueMember = "CURRENCYID";

            DataGridViewComboBoxColumn Uom = dtGrid.Columns["hUom"] as DataGridViewComboBoxColumn;
            DataGridViewComboBoxColumn Currency = dtGrid.Columns["hCurrency"] as DataGridViewComboBoxColumn;

            Uom.DataSource = dsUOM.Tables[0];
            Uom.DisplayMember = "DESCRIPTION";
            Uom.ValueMember = "UOMID";

            Currency.DataSource = dsCurrency.Tables[0];
            Currency.DisplayMember = "CURRENCYID";
            Currency.ValueMember = "CURRENCYID";
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            frmPurchaseSearch f = new frmPurchaseSearch();
            f.AddItemCallback = new frmPurchaseSearch.AddPurchaseDelegate(this.SetPurchaseCallBack);
            f.ShowDialog();
            //txtCostingNo.Text
            if (GStrCode != "")
            {
            }

        }
        private void SetPurchaseCallBack(string PoNo)
        {
            txtPoNo.Text = PoNo;
            GStrCode = PoNo;
            //txtCategoryDesc.Text = categoryDesc;
        }
    }
}
