using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassMD;
using MyGarment.ClassStore;
using MyGarment.ViewMaster;
using MyGarment.ViewSearch;
using MyGarment.ViewFinance;
using MyGarment.ClassMaster;
using MyGarment.PrintStore;
using MyGarment._1Global;
namespace MyGarment.ViewStore
{
    public partial class frmgrntComponent : Form
    {
        private string GStrCode;
        public frmgrntComponent()
        {
            InitializeComponent();
        }
        private void SetCustomerCallBack(string CustID, string CustDesc)
        {
            txtCustomerID.Text = CustID;
            txtCustomerDesc.Text = CustDesc;
            //GStrCode = CustID;

        }
        private void cmdCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerSearch f = new frmCustomerSearch();
            f.AddItemCallback = new frmCustomerSearch.AddCustomerDelegate(this.SetCustomerCallBack);
            f.ShowDialog();
        }

        private void frmgrntComponent_Load(object sender, EventArgs e)
        {

        }
        private void SetStyleCallBack(string StyleID, string StyleDesc)
        {
            txtItemsID.Text = StyleID;
            txtStyleDesc.Text = StyleDesc;
            GStrCode = StyleID;
        }

        private void cmdStyle_Click(object sender, EventArgs e)
        {
            
            frmginSearch f = new frmginSearch();
            GlobalVariables.GCode = "PROCESS";
            f.AddItemCallback = new frmginSearch.AddPurchaseDelegate(this.SetPurchaseCallBack);
            f.ShowDialog();
            //txtCostingNo.Text

            if (GStrCode != "")
            {
                //load detail
                DataSet dsDetail = new gindetailCRUD().getData(GStrCode);
                dtGrid.Rows.Clear();
                for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                {
                    GlobalVariables.GID = GlobalVariables.GID + 1;
                    dtGrid.Rows.Add();
                    dtGrid.Rows[i].HeaderCell.Value = "V";
                    //key
                    dtGrid.Rows[i].Cells["hGINNo1"].Value = dsDetail.Tables[0].Rows[i]["GINNO"].ToString();
                    dtGrid.Rows[i].Cells["hID1"].Value = dsDetail.Tables[0].Rows[i]["ID"].ToString();
                    //end key
                    dtGrid.Rows[i].Cells["hGINNo"].Value = dsDetail.Tables[0].Rows[i]["GINNO"].ToString();
                    dtGrid.Rows[i].Cells["hID"].Value = dsDetail.Tables[0].Rows[i]["ID"].ToString();
                    dtGrid.Rows[i].Cells["hItemsID"].Value = dsDetail.Tables[0].Rows[i]["ITEMSID"].ToString();
                    dtGrid.Rows[i].Cells["hDescription"].Value = dsDetail.Tables[0].Rows[i]["DESCRIPTION"].ToString();
                    dtGrid.Rows[i].Cells["hJenis"].Value = dsDetail.Tables[0].Rows[i]["JENIS"].ToString();
                    dtGrid.Rows[i].Cells["hColorID"].Value = dsDetail.Tables[0].Rows[i]["COLORID"].ToString();
                    dtGrid.Rows[i].Cells["hSizeID"].Value = dsDetail.Tables[0].Rows[i]["SIZEID"].ToString();

                    dtGrid.Rows[i].Cells["hGrade"].Value = DBNull.Value.Equals(dsDetail.Tables[0].Rows[i]["GRADE"]) ? null : dsDetail.Tables[0].Rows[i]["GRADE"].ToString();

                    dtGrid.Rows[i].Cells["hStyleID"].Value = dsDetail.Tables[0].Rows[i]["STYLEID"].ToString();
                    dtGrid.Rows[i].Cells["hPONO"].Value = dsDetail.Tables[0].Rows[i]["PONO"].ToString();
                    dtGrid.Rows[i].Cells["hQuantity"].Value = dsDetail.Tables[0].Rows[i]["QUANTITY"].ToString();
                    dtGrid.Rows[i].Cells["hUOM"].Value = dsDetail.Tables[0].Rows[i]["UOM"].ToString();

                }
            }
            SimpanTSB.Enabled = true;
            UbahTSB.Enabled = true;
            dtGrid.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmginGarmentSearchStyle f = new frmginGarmentSearchStyle();
            f.AddItemCallback = new frmginGarmentSearchStyle.AddStyleDelegate(this.SetStyleCallBack);
            GlobalVariables.GCode = "PROCESS";
            f.ShowDialog();

            if (GStrCode != "")
            {
                DataSet dsDetail = new grndetailCRUD().getItemsByStyle(GStrCode);
                cbJENIS.Text = "PROCESS";
                //dtGrid.Rows.Clear();
                Int32 index = dtGrid.Rows.Count - 1;
                for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                {
                    dtGrid.Rows.Add();
                    dtGrid.Rows[index].HeaderCell.Value = "#";
                    dtGrid.Rows[index].Cells["hID"].Value = index;//dsDetail.Tables[0].Rows[i]["ID"].ToString();
                    dtGrid.Rows[index].Cells["hItemsID"].Value = Convert.ToString(dsDetail.Tables[0].Rows[0]["ITEMSID"]);
                    dtGrid.Rows[index].Cells["hDescription"].Value = Convert.ToString(dsDetail.Tables[0].Rows[0]["ITEMSID"]);
                    dtGrid.Rows[index].Cells["hJenis"].Value = dsDetail.Tables[0].Rows[i]["JENIS"].ToString();
                    dtGrid.Rows[index].Cells["hColorID"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["COLORID"]);
                    dtGrid.Rows[index].Cells["hSizeID"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["SIZEID"]);
                    dtGrid.Rows[index].Cells["hGrade"].Value = DBNull.Value.Equals(dsDetail.Tables[0].Rows[i]["GRADE"]) ? null : dsDetail.Tables[0].Rows[i]["GRADE"].ToString();
                    dtGrid.Rows[index].Cells["hPONO"].Value = Convert.ToString(dsDetail.Tables[0].Rows[0]["PONO"]);
                    dtGrid.Rows[index].Cells["hStyleID"].Value = Convert.ToString(dsDetail.Tables[0].Rows[0]["STYLEID"]);
                    dtGrid.Rows[index].Cells["hStyleIDto"].Value = Convert.ToString(dsDetail.Tables[0].Rows[0]["STYLEID"]);
                    dtGrid.Rows[index].Cells["hQuantity"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["QTYOH"]);
                    dtGrid.Rows[index].Cells["hUOM"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["UOM"]);
                    dtGrid.Rows[index].Cells["hGRNNO"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["GRNNO"]);
                    index++;

                }
            }
            SimpanTSB.Enabled = true;
            UbahTSB.Enabled = true;
            dtGrid.Enabled = true;
        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            //simpan header
            gin k = new gin();
            Generate gen = new Generate();
            txtGRNNO.Text = gen.genMIN();
            k.GINNO = txtGRNNO.Text;
            k.DATE = dateCreated.Value;
            DataRow selectedDIV = ((DataRowView)cbDIV.SelectedItem).Row;
            k.GDIV = selectedDIV["DIVID"].ToString();
            k.APPROVE = 0;
            k.APPROVEBY = "";
            k.CLOSE = 0;
            k.CUSTVENDCODE = txtCustomerID.Text;
            k.DOCREGNO = "";
            k.OFFICER = GlobalVariables.GUserID;
            k.DELIVERYTO = txtRefer.Text;  // untuk refer to
            k.REMARKS = txtRemarks.Text;
            k.STOREID = cbStore.Text;
            k.TYPE = cbJENIS.Text;
            k.DELIVERYTOADDRESS = txtAddress.Text;
            k.DELIVERYTONAME = txtCustomerDesc.Text;
            //k.OFFICER = GlobalVariables.GUserID;
            //k.CLOSE = 0;
            //  k.STYLEID="";
            if ((txtGRNNO.Text == "") || (txtCustomerID.Text == ""))
            {
                MessageBox.Show("Isian Belum lengkap untuk PONO");
            }
            else if (new ginCRUD().insertData(k))
            {

                gindetail d = new gindetail();
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {
                    //d.PONO = txtJONO.Text;
                    d.GINNO = txtGRNNO.Text;
                    d.ID = Convert.ToInt32(dtGrid.Rows[i].Cells["hID"].Value); //Convert.ToInt32(dtGrid.Rows[i].Cells["hCostingID"].Value);
                    d.GRNNO = Convert.ToString(dtGrid.Rows[i].Cells["hGRNNO"].Value);
                    d.ITEMSID = dtGrid.Rows[i].Cells["hItemsID"].Value == null ? null : dtGrid.Rows[i].Cells["hItemsID"].Value.ToString();
                    d.DESCRIPTION = dtGrid.Rows[i].Cells["hDescription"].Value == null ? null : dtGrid.Rows[i].Cells["hDescription"].Value.ToString().ToString();
                    d.QUANTITY = Convert.ToDecimal(dtGrid.Rows[i].Cells["hQuantity"].Value);
                    d.UOM = dtGrid.Rows[i].Cells["hUOM"].Value == null ? null : dtGrid.Rows[i].Cells["hUOM"].Value.ToString();
                    d.COLORID = dtGrid.Rows[i].Cells["hColorID"].Value == null ? null : dtGrid.Rows[i].Cells["hColorID"].Value.ToString();
                    d.GRADE = dtGrid.Rows[i].Cells["hGrade"].Value == null ? null : dtGrid.Rows[i].Cells["hGrade"].Value.ToString();
                    d.JENIS = cbJENIS.Text;
                    d.PONO = Convert.ToString(dtGrid.Rows[i].Cells["hPONO"].Value);
                    d.SIZEID = Convert.ToString(dtGrid.Rows[i].Cells["hSizeID"].Value);
                    d.STYLEID = dtGrid.Rows[i].Cells["hStyleID"].Value == null ? null : dtGrid.Rows[i].Cells["hStyleID"].Value.ToString();
                    d.STYLEIDTO = dtGrid.Rows[i].Cells["hStyleID"].Value == null ? null : dtGrid.Rows[i].Cells["hStyleID"].Value.ToString();
                    if (dtGrid.Rows[i].HeaderCell.Value.ToString() == "#")
                    {
                        if (new gindetailCRUD().insertData(d))
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
        }

        private void UbahTSB_Click(object sender, EventArgs e)
        {
            //simpan header
            gin k = new gin();
            k.GINNO = txtGRNNO.Text;
            k.DATE = dateCreated.Value;
            DataRow selectedDIV = ((DataRowView)cbDIV.SelectedItem).Row;
            k.GDIV = selectedDIV["DIVID"].ToString();
            k.APPROVE = 0;
            k.APPROVEBY = "";
            k.CLOSE = 0;
            k.CUSTVENDCODE = txtCustomerID.Text;
            k.DOCREGNO = "";
            k.OFFICER = GlobalVariables.GUserID;
            k.DELIVERYTO = txtRefer.Text;  // untuk refer to
            k.REMARKS = txtRemarks.Text;
            k.STOREID = cbStore.Text;
            k.TYPE = cbJENIS.Text;
            k.DELIVERYTOADDRESS = txtAddress.Text;
            k.DELIVERYTONAME = txtCustomerDesc.Text;
            //k.OFFICER = GlobalVariables.GUserID;
            //k.CLOSE = 0;
            //  k.STYLEID="";
            if ((txtGRNNO.Text == "") || (txtCustomerID.Text == ""))
            {
                MessageBox.Show("Isian Belum lengkap untuk PONO");
            }
            else if (new ginCRUD().insertData(k))
            {

                gindetail d = new gindetail();
                string GINNO1;
                int ID1;
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {
                    //d.PONO = txtJONO.Text;
                    //key
                    GINNO1 = Convert.ToString(dtGrid.Rows[i].Cells["hGINNO"].Value);
                    ID1 = Convert.ToInt32(dtGrid.Rows[i].Cells["hID1"].Value); ;
                    d.GINNO = txtGRNNO.Text;
                    d.ID = Convert.ToInt32(dtGrid.Rows[i].Cells["hID"].Value); //Convert.ToInt32(dtGrid.Rows[i].Cells["hCostingID"].Value);
                    d.GRNNO = Convert.ToString(dtGrid.Rows[i].Cells["hGRNNO"].Value);
                    d.ITEMSID = dtGrid.Rows[i].Cells["hItemsID"].Value == null ? null : dtGrid.Rows[i].Cells["hItemsID"].Value.ToString();
                    d.DESCRIPTION = dtGrid.Rows[i].Cells["hDescription"].Value == null ? null : dtGrid.Rows[i].Cells["hDescription"].Value.ToString().ToString();
                    d.QUANTITY = Convert.ToDecimal(dtGrid.Rows[i].Cells["hQuantity"].Value);
                    d.UOM = dtGrid.Rows[i].Cells["hUOM"].Value == null ? null : dtGrid.Rows[i].Cells["hUOM"].Value.ToString();
                    d.COLORID = dtGrid.Rows[i].Cells["hColorID"].Value == null ? null : dtGrid.Rows[i].Cells["hColorID"].Value.ToString();
                    d.GRADE = dtGrid.Rows[i].Cells["hGrade"].Value == null ? null : dtGrid.Rows[i].Cells["hGrade"].Value.ToString();
                    d.JENIS = cbJENIS.Text;
                    //d.PONO = Convert.ToString(dtGrid.Rows[i].Cells["hPONO"].Value);
                    d.SIZEID = Convert.ToString(dtGrid.Rows[i].Cells["hSizeID"].Value);
                    d.STYLEID = dtGrid.Rows[i].Cells["hStyleID"].Value == null ? null : dtGrid.Rows[i].Cells["hStyleID"].Value.ToString();
                    d.STYLEIDTO = dtGrid.Rows[i].Cells["hStyleID"].Value == null ? null : dtGrid.Rows[i].Cells["hStyleID"].Value.ToString();
                    if (dtGrid.Rows[i].HeaderCell.Value.ToString() != "#")
                    {
                        if (new gindetailCRUD().updateData(d, GINNO1, ID1))
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
        }

        private void HapusTSB_Click(object sender, EventArgs e)
        {
            if (dtGrid.RowCount < 0)
            {
                if (new grnCRUD().deleteData(txtGRNNO.Text))
                {
                    MessageBox.Show(" Items Receive telah di hapus ");
                }

            }
            else //delete detail
            {
                gindetail k = new gindetail();
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {
                    k.GRNNO = txtGRNNO.Text;
                    k.ID = Convert.ToInt32(dtGrid.Rows[i].Cells["hID1"].Value);
                    if ((Convert.ToInt32(dtGrid.Rows[i].Cells["hDel"].Value) == 1) && (dtGrid.Rows[i].Cells["hID1"].Value != null))
                    {
                        if (new gindetailCRUD().deleteData(k.GRNNO, k.ID))
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
            }// end bro
        }
        private void SetPurchaseCallBack(string PoNo)
        {
            txtGRNNO.Text = PoNo;
            GStrCode = PoNo;
            //txtCategoryDesc.Text = categoryDesc;
        }
        private void RecordTSB_Click(object sender, EventArgs e)
        {
            GStrCode = "";
            frmgrnSearch f = new frmgrnSearch();
            GlobalVariables.GCode = "PROCESS";
            f.AddItemCallback = new frmgrnSearch.AddPurchaseDelegate(this.SetPurchaseCallBack);
            
            f.ShowDialog();
            if (GStrCode != "")
            {
                DataSet dsHeader = new ginCRUD().getData(GStrCode);
                txtGRNNO.Text = GStrCode;
                dateCreated.Value = (DateTime)dsHeader.Tables[0].Rows[0]["DATE"];
                cbDIV.SelectedValue = dsHeader.Tables[0].Rows[0]["GDIV"];

                txtCustomerID.Text = dsHeader.Tables[0].Rows[0]["CUSTVENDCODE"].ToString();
                txtAddress.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["DELIVERYTOADDRESS"]);
                txtRefer.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["DELIVERYTONAME"]);
                //txtStyleID.Text = dsHeader.Tables[0].Rows[0]["STYLEID"].ToString();
                txtRemarks.Text = dsHeader.Tables[0].Rows[0]["REMARKS"].ToString();
                cbJENIS.Text = dsHeader.Tables[0].Rows[0]["TYPE"].ToString();
                cbStore.Text = dsHeader.Tables[0].Rows[0]["STOREID"].ToString();
                //load detail
                DataSet dsDetail = new gindetailCRUD().getData(GStrCode);
                dtGrid.Rows.Clear();
                for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                {
                    GlobalVariables.GID = GlobalVariables.GID + 1;
                    dtGrid.Rows.Add();
                    dtGrid.Rows[i].HeaderCell.Value = "V";
                    //key
                    dtGrid.Rows[i].Cells["hGINNO1"].Value = dsDetail.Tables[0].Rows[i]["GINNO"].ToString();
                    dtGrid.Rows[i].Cells["hID1"].Value = dsDetail.Tables[0].Rows[i]["ID"].ToString();
                    //end key
                    dtGrid.Rows[i].Cells["hGINNO"].Value = dsDetail.Tables[0].Rows[i]["GINNO"].ToString();
                    dtGrid.Rows[i].Cells["hID"].Value = dsDetail.Tables[0].Rows[i]["ID"].ToString();
                    dtGrid.Rows[i].Cells["hItemsID"].Value = dsDetail.Tables[0].Rows[i]["ITEMSID"].ToString();
                    dtGrid.Rows[i].Cells["hDescription"].Value = dsDetail.Tables[0].Rows[i]["DESCRIPTION"].ToString();
                    dtGrid.Rows[i].Cells["hJenis"].Value = dsDetail.Tables[0].Rows[i]["JENIS"].ToString();
                    dtGrid.Rows[i].Cells["hColorID"].Value = dsDetail.Tables[0].Rows[i]["COLORID"].ToString();
                    dtGrid.Rows[i].Cells["hSizeID"].Value = dsDetail.Tables[0].Rows[i]["SIZEID"].ToString();
                    dtGrid.Rows[i].Cells["hGrade"].Value = DBNull.Value.Equals(dsDetail.Tables[0].Rows[i]["GRADE"]) ? null : dsDetail.Tables[0].Rows[i]["GRADE"].ToString();
                    dtGrid.Rows[i].Cells["hStyleID"].Value = dsDetail.Tables[0].Rows[i]["STYLEID"].ToString();
                    // dtGrid.Rows[i].Cells["hPONO"].Value = dsDetail.Tables[0].Rows[i]["PONO"].ToString();
                    dtGrid.Rows[i].Cells["hQuantity"].Value = dsDetail.Tables[0].Rows[i]["QUANTITY"].ToString();
                    dtGrid.Rows[i].Cells["hUOM"].Value = dsDetail.Tables[0].Rows[i]["UOM"].ToString();
                    dtGrid.Rows[i].Cells["hGRNNO"].Value = dsDetail.Tables[0].Rows[i]["GRNNO"].ToString();

                }
                SimpanTSB.Enabled = false;
                UbahTSB.Enabled = true;
                dtGrid.Enabled = true;
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            DataSet data = new grnCRUD().prMatSupplier(txtGRNNO.Text);
            Application.DoEvents();
            data.WriteXml("C:\\MyGarmentReport\\MatSupplier.xml", XmlWriteMode.WriteSchema);
            Form f = new PrintMatSupplier();
            f.Show();
        }
    }
}
