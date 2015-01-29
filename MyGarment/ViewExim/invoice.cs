using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassMD;
using MyGarment.ClassExim;
using MyGarment.ViewMaster;
using MyGarment.ViewSearch;
using MyGarment.ViewMD;
using MyGarment.ViewFinance;
using MyGarment.ClassMaster;
using MyGarment.PrintStore;
using MyGarment._1Global;

namespace MyGarment.ViewExim
{
    public partial class frmInvoice : Form
    {
        private string GStrCode = "";
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {

        }
        private void SetCostingCallBack(string CostingNo)
        {
            txtJONO.Text = CostingNo;
            GStrCode = CostingNo;
            //txtCategoryDesc.Text = categoryDesc;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            frmjoborderSearch f = new frmjoborderSearch();
            f.AddItemCallback = new frmjoborderSearch.AddCostingDelegate(this.SetCostingCallBack);
            f.ShowDialog();

            if (GStrCode != "")
            {
                DataSet dsHeader = new joborderCRUD().getGarment(GStrCode);
                cbDIV.SelectedValue = dsHeader.Tables[0].Rows[0]["GDIV"].ToString();
                txtCustomerID.Text = dsHeader.Tables[0].Rows[0]["CUSTVENDCODE"].ToString();

                DataSet dsSupplier = new mcustvendCRUD().getData(txtCustomerID.Text, "", "");
                if (dsSupplier.Tables[0].Rows.Count > 0)
                {
                    txtCustomerDesc.Text = dsSupplier.Tables[0].Rows[0]["NAME"].ToString();
                    txtAddress.Text = dsSupplier.Tables[0].Rows[0]["ADDRESS"].ToString();

                }
                //isi detail
                DataSet dsDetail = new joborderdetailCRUD().getData(GStrCode);
                // var index = dtGrid.Rows.Add();
                dtGrid.Rows.Clear();
                for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                {
                    dtGrid.Rows.Add();
                    dtGrid.Rows[i].HeaderCell.Value = "#";
                    dtGrid.Rows[i].Cells["hID"].Value = i;//dsDetail.Tables[0].Rows[i]["ID"].ToString();
                    dtGrid.Rows[i].Cells["hItemsID"].Value = Convert.ToString(dsHeader.Tables[0].Rows[0]["ITEMSID"]);
                    dtGrid.Rows[i].Cells["hDescription"].Value = Convert.ToString(dsHeader.Tables[0].Rows[0]["ITEMSID"]);
                    // dtGrid.Rows[i].Cells["hJenis"].Value = dsDetail.Tables[0].Rows[i]["JENIS"].ToString();
                    dtGrid.Rows[i].Cells["hColorID"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["COLORID"]);
                    dtGrid.Rows[i].Cells["hSizeID"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["SIZEID"]);
                    dtGrid.Rows[i].Cells["hGrade"].Value = "A";
                    dtGrid.Rows[i].Cells["hStyleID"].Value = Convert.ToString(dsHeader.Tables[0].Rows[0]["ITEMSID"]);
                    dtGrid.Rows[i].Cells["hQuantity"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["QUANTITY"]);
                    dtGrid.Rows[i].Cells["hUOM"].Value = "PCS";
                    dtGrid.Rows[i].Cells["hConvert"].Value = 1;
                    dtGrid.Rows[i].Cells["hQtyPurchase"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["QUANTITY"]);
                    dtGrid.Rows[i].Cells["hUOMPurchase"].Value = "PCS";


                }
                SimpanTSB.Enabled = true;
                UbahTSB.Enabled = false;
                dtGrid.Enabled = true;

            }
        }

        private void cmdCustomer_Click(object sender, EventArgs e)
        {

        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            //simpan header
            invoice k = new invoice();
            Generate gen = new Generate();
            txtGRNNO.Text = gen.genGRN();
            k.PONO = txtJONO.Text;
            k.INVNO = txtGRNNO.Text;
            k.DATE = dateCreated.Value;
            DataRow selectedDIV = ((DataRowView)cbDIV.SelectedItem).Row;
            k.GDIV = selectedDIV["DIVID"].ToString();
            k.APPROVE = 0;
            k.APPROVEBY = "";
            k.CLOSE = 0;
            k.COLORID = "";
            k.CUSTVENDCODE = txtCustomerID.Text;
            k.DOCREGNO = "";

            k.OFFICER = GlobalVariables.GUserID;
            k.RECEIVEFROM ="CMT";// from PO
            k.REFFNO = txtRefer.Text;
            k.REMARKS = txtRemarks.Text;
            k.STOREID = cbStore.Text;
            k.JENIS = cbJENIS.Text;

            //    k.STYLEID="";

            if ((txtGRNNO.Text == ""))
            {
                MessageBox.Show("Isian Belum lengkap untuk PONO");
            }
            else if (new invoiceCRUD().insertData(k))
            {

                invoicedetail d = new invoicedetail();
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {

                    d.PONO = txtJONO.Text;
                    d.INVNO = txtGRNNO.Text;
                    d.ID = Convert.ToInt32(dtGrid.Rows[i].Cells["hID"].Value); //Convert.ToInt32(dtGrid.Rows[i].Cells["hCostingID"].Value);
                    d.ITEMSID = dtGrid.Rows[i].Cells["hItemsID"].Value == null ? null : dtGrid.Rows[i].Cells["hItemsID"].Value.ToString();
                    d.DESCRIPTION = dtGrid.Rows[i].Cells["hDescription"].Value == null ? null : dtGrid.Rows[i].Cells["hDescription"].Value.ToString().ToString();
                    d.QUANTITY = Convert.ToDecimal(dtGrid.Rows[i].Cells["hQuantity"].Value);
                    d.UOM = dtGrid.Rows[i].Cells["hUOM"].Value == null ? null : dtGrid.Rows[i].Cells["hUOM"].Value.ToString();
                    d.COLORID = dtGrid.Rows[i].Cells["hColorID"].Value == null ? null : dtGrid.Rows[i].Cells["hColorID"].Value.ToString();
                    d.GRADE = dtGrid.Rows[i].Cells["hGrade"].Value == null ? null : dtGrid.Rows[i].Cells["hGrade"].Value.ToString();
                    d.JENIS = cbJENIS.Text;
                    d.SIZEID = Convert.ToString(dtGrid.Rows[i].Cells["hSizeID"].Value);
                    d.STYLEID = dtGrid.Rows[i].Cells["hStyleID"].Value == null ? null : dtGrid.Rows[i].Cells["hStyleID"].Value.ToString();
                    if (dtGrid.Rows[i].HeaderCell.Value.ToString() == "#")
                    {

                        if (new invoicedetailCRUD().insertData(d))
                        {
                            dtGrid.Rows[i].HeaderCell.Value = "V";
                        }
                        else
                        {
                        }
                    }
                }

                MessageBox.Show("Data berhasil di tambahkan");
                SimpanTSB.Enabled = false;
                UbahTSB.Enabled = true;
                dtGrid.Enabled = true;

                // Binding();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan");
            }

            //simpang detail
        }

        private void HapusTSB_Click(object sender, EventArgs e)
        {
            if (dtGrid.RowCount < 0)
            {
                if (new invoiceCRUD().deleteData(txtGRNNO.Text))
                {
                    MessageBox.Show(" Items Receive telah di hapus ");
                }

            }
            else //delete detail
            {
                invoicedetail k = new invoicedetail();
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {
                    k.INVNO = txtGRNNO.Text;
                    k.ID = Convert.ToInt32(dtGrid.Rows[i].Cells["hID1"].Value);
                    if ((Convert.ToInt32(dtGrid.Rows[i].Cells["hDel"].Value) == 1) && (dtGrid.Rows[i].Cells["hID1"].Value != null))
                    {
                        if (new invoicedetailCRUD().deleteData(k.INVNO, k.ID))
                        {
                            dtGrid.Rows.RemoveAt(i);
                        }
                        else if ((dtGrid.Rows[i].Cells["hID1"].Value.ToString() == null))
                        {
                            dtGrid.Rows.RemoveAt(i);
                        }
                        else
                        {
                            MessageBox.Show("gagal delete");
                        }

                    }
                }
            }
        }

        private void UbahTSB_Click(object sender, EventArgs e)
        {
            //simpan header
            invoice k = new invoice();
            k.PONO = txtJONO.Text;
            k.INVNO = txtGRNNO.Text;
            k.DATE = dateCreated.Value;
            DataRow selectedDIV = ((DataRowView)cbDIV.SelectedItem).Row;
            k.GDIV = selectedDIV["DIVID"].ToString();
            k.APPROVE = 0;
            k.APPROVEBY = "";
            k.CLOSE = 0;
            k.COLORID = "";
            k.CUSTVENDCODE = txtCustomerID.Text;
            k.DOCREGNO = "";

            k.OFFICER = GlobalVariables.GUserID;
            k.RECEIVEFROM = "CMT";// from PO
            k.REFFNO = txtRefer.Text;
            k.REMARKS = txtRemarks.Text;
            k.STOREID = cbStore.Text;
            k.JENIS = cbJENIS.Text;

            //    k.STYLEID="";

            if ((txtGRNNO.Text == ""))
            {
                MessageBox.Show("Isian Belum lengkap untuk PONO");
            }
            else if (new invoiceCRUD().updateData(k))
            {
                string INVNO1;
                int ID1;
                invoicedetail d = new invoicedetail();
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {
                    INVNO1=Convert.ToString(dtGrid.Rows[i].Cells["INVNO1"].Value); 
                    ID1=Convert.ToInt32(dtGrid.Rows[i].Cells["ID1"].Value); 
                    d.PONO = txtJONO.Text;
                    d.INVNO = txtGRNNO.Text;
                    d.ID = Convert.ToInt32(dtGrid.Rows[i].Cells["hID"].Value); //Convert.ToInt32(dtGrid.Rows[i].Cells["hCostingID"].Value);
                    d.ITEMSID = dtGrid.Rows[i].Cells["hItemsID"].Value == null ? null : dtGrid.Rows[i].Cells["hItemsID"].Value.ToString();
                    d.DESCRIPTION = dtGrid.Rows[i].Cells["hDescription"].Value == null ? null : dtGrid.Rows[i].Cells["hDescription"].Value.ToString().ToString();
                    d.QUANTITY = Convert.ToDecimal(dtGrid.Rows[i].Cells["hQuantity"].Value);
                    d.UOM = dtGrid.Rows[i].Cells["hUOM"].Value == null ? null : dtGrid.Rows[i].Cells["hUOM"].Value.ToString();
                    d.COLORID = dtGrid.Rows[i].Cells["hColorID"].Value == null ? null : dtGrid.Rows[i].Cells["hColorID"].Value.ToString();
                    d.GRADE = dtGrid.Rows[i].Cells["hGrade"].Value == null ? null : dtGrid.Rows[i].Cells["hGrade"].Value.ToString();
                    d.JENIS = cbJENIS.Text;
                    d.SIZEID = Convert.ToString(dtGrid.Rows[i].Cells["hSizeID"].Value);
                    d.STYLEID = dtGrid.Rows[i].Cells["hStyleID"].Value == null ? null : dtGrid.Rows[i].Cells["hStyleID"].Value.ToString();
                    if (dtGrid.Rows[i].HeaderCell.Value.ToString() != "#")
                    {

                        if (new invoicedetailCRUD().updateData(d,INVNO1,ID1))
                        {
                            dtGrid.Rows[i].HeaderCell.Value = "V";
                        }
                        else
                        {
                        }
                    }
                }

                MessageBox.Show("Data berhasil di tambahkan");
                SimpanTSB.Enabled = false;
                UbahTSB.Enabled = true;
                dtGrid.Enabled = true;

                // Binding();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan");
            }

            //simpang detail
        }
        private void SetPurchaseCallBack(string PoNo)
        {
            txtGRNNO.Text = PoNo;
            GStrCode = PoNo;
            //txtCategoryDesc.Text = categoryDesc;
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            frminvoiceSearch f = new frminvoiceSearch();
            f.AddItemCallback = new frminvoiceSearch.AddPurchaseDelegate(this.SetPurchaseCallBack);
            f.ShowDialog();
            
            if (GStrCode != "")
            {

                DataSet dsHeader = new invoiceCRUD().getData(GStrCode);
                txtGRNNO.Text = GStrCode;
                dateCreated.Value = (DateTime)dsHeader.Tables[0].Rows[0]["DATE"];
                cbDIV.SelectedValue = dsHeader.Tables[0].Rows[0]["GDIV"];
                //RECEIVEFROM  di hilangkan
                txtRemarks.Text = dsHeader.Tables[0].Rows[0]["REMARKS"].ToString();
                txtCustomerID.Text = dsHeader.Tables[0].Rows[0]["CUSTVENDCODE"].ToString();
                txtRefer.Text = dsHeader.Tables[0].Rows[0]["REFFNO"].ToString();
                txtJONO.Text = dsHeader.Tables[0].Rows[0]["PONO"].ToString();
                cbJENIS.Text = dsHeader.Tables[0].Rows[0]["JENIS"].ToString();
                cbStore.Text = dsHeader.Tables[0].Rows[0]["STOREID"].ToString();
                DataSet dsDetail = new invoicedetailCRUD().getData(GStrCode);
                dtGrid.Rows.Clear();
                for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                {
                    GlobalVariables.GID = GlobalVariables.GID + 1;
                    dtGrid.Rows.Add();
                    dtGrid.Rows[i].HeaderCell.Value = "V";
                    //key
                    dtGrid.Rows[i].Cells["hGRNNo1"].Value = dsDetail.Tables[0].Rows[i]["GRNNO"].ToString();
                    dtGrid.Rows[i].Cells["hID1"].Value = dsDetail.Tables[0].Rows[i]["ID"].ToString();
                    //end key
                    dtGrid.Rows[i].Cells["hGRNNo"].Value = dsDetail.Tables[0].Rows[i]["GRNNO"].ToString();
                    dtGrid.Rows[i].Cells["hID"].Value = dsDetail.Tables[0].Rows[i]["ID"].ToString();
                    dtGrid.Rows[i].Cells["hItemsID"].Value = dsDetail.Tables[0].Rows[i]["ITEMSID"].ToString();
                    dtGrid.Rows[i].Cells["hDescription"].Value = dsDetail.Tables[0].Rows[i]["DESCRIPTION"].ToString();
                    dtGrid.Rows[i].Cells["hJenis"].Value = dsDetail.Tables[0].Rows[i]["JENIS"].ToString();
                    dtGrid.Rows[i].Cells["hColorID"].Value = dsDetail.Tables[0].Rows[i]["COLORID"].ToString();
                    dtGrid.Rows[i].Cells["hSizeID"].Value = dsDetail.Tables[0].Rows[i]["SIZEID"].ToString();
                    //if (row[col] == DBNull.Value)
                    dtGrid.Rows[i].Cells["hGrade"].Value = DBNull.Value.Equals(dsDetail.Tables[0].Rows[i]["GRADE"]) ? null : dsDetail.Tables[0].Rows[i]["GRADE"].ToString();
                    //dtGrid.Rows[i].Cells["hCostingNo"].Value = dsDetail.Tables[0].Rows[i]["COSTINGNO"].ToString();
                    dtGrid.Rows[i].Cells["hStyleID"].Value = dsDetail.Tables[0].Rows[i]["STYLEID"].ToString();
                    dtGrid.Rows[i].Cells["hPONO"].Value = dsDetail.Tables[0].Rows[i]["PONO"].ToString();
                    dtGrid.Rows[i].Cells["hQuantity"].Value = dsDetail.Tables[0].Rows[i]["QUANTITY"].ToString();
                    dtGrid.Rows[i].Cells["hUOM"].Value = dsDetail.Tables[0].Rows[i]["UOM"].ToString();
                    // dtGrid.Rows[i].Cells["hPrice"].Value = dsDetail.Tables[0].Rows[i]["PRICE"].ToString();
                    //dtGrid.Rows[i].Cells["hCurrencyID"].Value = dsDetail.Tables[0].Rows[i]["CURRENCYID"].ToString();
                    //dtGrid.Rows[i].Cells["hKurs"].Value = dsDetail.Tables[0].Rows[i]["KURS"].ToString();
                    dtGrid.Rows[i].Cells["hConvert"].Value = dsDetail.Tables[0].Rows[i]["CONVER"].ToString();
                    //dtGrid.Rows[i].Cells["hRemarks"].Value = dsDetail.Tables[0].Rows[i]["REMARKS"].ToString();
                    dtGrid.Rows[i].Cells["hQtyPurchase"].Value = dsDetail.Tables[0].Rows[i]["QTYPURCHASE"].ToString();
                    //dtGrid.Rows[i].Cells["hPricePurchase"].Value = dsDetail.Tables[0].Rows[i]["PRICEPURCHASE"].ToString();
                    dtGrid.Rows[i].Cells["hUOMPurchase"].Value = dsDetail.Tables[0].Rows[i]["UOMPURCHASE"].ToString();

                }
                SimpanTSB.Enabled = false;
                UbahTSB.Enabled = true;
                dtGrid.Enabled = true;
            }
        }
    }
}
