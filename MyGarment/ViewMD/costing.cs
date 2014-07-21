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
    public partial class frmcosting : Form
    {
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
            K.ITEMSID = txtItemsID.Text;

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
    }
}
