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

namespace MyGarment.ViewMD
{
    public partial class frmcosting : Form
    {
        DataSet data = new mcostCRUD().getData();
        public frmcosting()
        {
            InitializeComponent();
        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            // save costing header
            costing K = new costing();
            K.COSTINGNO = txtCostingNo.Text;
            K.TYPEID = cbTypeID.Text;
            K.QTYORDER = Convert.ToInt32(txtQty.Text);
            K.CATEGORYID = txtCategoryID.Text;
            K.CUSTVENDCODE = txtCustomerID.Text;
            K.ITEMSID = txtStyleID.Text;

            if (new costingCRUD().insertData(K))
            {
                MessageBox.Show("Data berhasil di tambahkan");
               // Binding();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan");
            }
        }

        private void frmcosting_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            costingdetail k = new costingdetail();
            for (int i = 0; i < dtGrid.Rows.Count-1; i++)
            {
                k.COSTINGNO = txtCostingNo.Text;
                k.ID = Convert.ToInt32(dtGrid.Rows[i].Cells["ID"].Value);
                if (new costingdetailCRUD().insertData(k))
                {
                   // MessageBox.Show("Data berhasil di tambahkan");
                    // Binding();
                    dtGrid.Rows[i].Cells["Check"].Value = "OK";
                }
                else
                {
                   // MessageBox.Show("Data gagal ditambahkan");
                    dtGrid.Rows[i].Cells["Check"].Value = "ER";
                }
                
            }
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            costingSearch f =new costingSearch();
            f.ShowDialog();
           

        }

        private void cmdCategory_Click(object sender, EventArgs e)
        {
            frmmcategorySearch f= new frmmcategorySearch();
            f.AddItemCallback = new frmmcategorySearch.AddCategoryDelegate(this.SetCategoryCallBack);
            f.ShowDialog();
        }
        private void SetCategoryCallBack(string categoryID, string categoryDesc)
        {
            txtCategoryID.Text = categoryID;
            txtCategoryDesc.Text = categoryDesc;

        }

        private void cmdStyle_Click(object sender, EventArgs e)
        {
            frmStyleSearch f = new frmStyleSearch();
            f.AddItemCallback = new frmStyleSearch.AddStyleDelegate(this.SetStyleCallBack);
            f.ShowDialog();
        }

        private void SetStyleCallBack(string StyleID, string StyleDesc)
        {
            txtStyleID.Text = StyleID;
            txtStyleDesc.Text = StyleDesc;

        }

        private void cmdCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerSearch f = new frmCustomerSearch();
            f.AddItemCallback = new frmCustomerSearch.AddCustomerDelegate(this.SetStyleCallBack);
            f.ShowDialog();

        }
        private void SetCustomerCallBack(string CustID, string CustDesc)
        {
            txtCustomerID.Text = CustID;
            txtCustomerDesc.Text = CustDesc;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet data = new mcostCRUD().getData();
            //data.geData();
            //dtGrid.Rows[].Cells = data;
            //DtGrid.DataMember = "tblmcost";
           // DataGridViewComboBoxCell box = dtGrid.Rows[e.RowIndex].Cells[3] as DataGridViewComboBoxCell;
           // box.DisplayMember="";
           // box.ValueMember="";
           // box.DataSource = data.Tables[0];
        }

        private void dtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewComboBoxCell box = dtGrid.Rows[e.RowIndex].Cells[3] as DataGridViewComboBoxCell;
            box.DisplayMember = "DESCRIPTION";
            box.ValueMember = "COSTID";
            box.DataSource = data.Tables[0];
            /*
            if (dtGrid.Rows[e.RowIndex].IsNewRow)
            {
                dtGrid.Rows[e.RowIndex].HeaderCell.Value = "Test "+ e.RowIndex;
            }
             * */
        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
