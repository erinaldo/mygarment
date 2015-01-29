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
    public partial class frmginComponent : Form
    {
        private string GStrCode = "";
        //private string GitemsDesc = "";

        public frmginComponent()
        {
            InitializeComponent();
        }
        private void SetPurchaseCallBack(string PoNo)
        {
            txtPONO.Text = PoNo;
            GStrCode = PoNo;
            //txtCategoryDesc.Text = categoryDesc;
        }

        private void cmdPONO_Click(object sender, EventArgs e)
        {
            GStrCode = "";
            frmPurchaseSearch f = new frmPurchaseSearch();
            f.AddItemCallback = new frmPurchaseSearch.AddPurchaseDelegate(this.SetPurchaseCallBack);
            f.ShowDialog();
            if (GStrCode != "")
            {

                DataSet dsHeader = new purchaseCRUD().getData(GStrCode);
                txtPONO.Text = GStrCode;
                cbDIV.SelectedValue = dsHeader.Tables[0].Rows[0]["GDIV"];
                dateCreated.Value = (DateTime)dsHeader.Tables[0].Rows[0]["DATE"];
                txtRemarks.Text = dsHeader.Tables[0].Rows[0]["REMARKS"].ToString();
                txtCustomerID.Text = dsHeader.Tables[0].Rows[0]["CUSTVENDID"].ToString();
                DataSet dsSupplier = new mcustvendCRUD().getData(txtCustomerID.Text, "", "");
                if (dsSupplier.Tables[0].Rows.Count > 0)
                {
                    txtCustomerDesc.Text = dsSupplier.Tables[0].Rows[0]["NAME"].ToString();
                    txtAddress.Text = dsSupplier.Tables[0].Rows[0]["ADDRESS"].ToString();

                }
                txtAddress.Text = dsHeader.Tables[0].Rows[0]["DELIVERYTOADDRESS"].ToString();
                //txtRefer.Text = dsHeader.Tables[0].Rows[0]["REFERTO"].ToString();
                cbStore.Text = dsHeader.Tables[0].Rows[0]["COURIER"].ToString();
                DataSet dsDetail = new purchasedetailCRUD().getDataGrn(GStrCode);
                cbJENIS.Text = "PROCESS";
                dtGrid.Rows.Clear();
                for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                {
                    dtGrid.Rows.Add();
                    dtGrid.Rows[i].HeaderCell.Value = "#";
                    dtGrid.Rows[i].Cells["hStyleID"].Value = dsDetail.Tables[0].Rows[i]["STYLEID"].ToString();
                    GStrCode = dsDetail.Tables[0].Rows[i]["COSTINGNO"].ToString();
                    dtGrid.Rows[i].Cells["hItemsID"].Value = dsDetail.Tables[0].Rows[i]["ITEMSID"];
                    dtGrid.Rows[i].Cells["hPONO"].Value = dsDetail.Tables[0].Rows[i]["PONO"].ToString();
                    dtGrid.Rows[i].Cells["hID"].Value = dsDetail.Tables[0].Rows[i]["ID"].ToString();
                    dtGrid.Rows[i].Cells["hQuantity"].Value = dsDetail.Tables[0].Rows[i]["QUANTITY"].ToString();
                    dtGrid.Rows[i].Cells["hUOM"].Value = dsDetail.Tables[0].Rows[i]["UOM"].ToString();
                    dtGrid.Rows[i].Cells["hDescription"].Value = dsDetail.Tables[0].Rows[i]["DESCRIPTION"].ToString();
                    //dtGrid.Rows[i].Cells["hQtyPurchase"].Value = dsDetail.Tables[0].Rows[i]["QTYPURCHASE"].ToString();
                    //dtGrid.Rows[i].Cells["hUOMPurchase"].Value = dsDetail.Tables[0].Rows[i]["UOMPURCHASE"].ToString();
                    //dtGrid.Rows[i].Cells["hConvert"].Value = dsDetail.Tables[0].Rows[i]["CONVER"];
                    dtGrid.Rows[i].Cells["hStyleID"].Value = dsDetail.Tables[0].Rows[i]["STYLEID"].ToString();

                }
                SimpanTSB.Enabled = true;
                UbahTSB.Enabled = false;
                dtGrid.Enabled = true;

            }
        }

        private void frmginComponent_Load(object sender, EventArgs e)
        {
            SimpanTSB.Enabled = true;
            UbahTSB.Enabled = false;
            dtGrid.Enabled = false;


            DataSet dsCost = new mcostCRUD().getData();
            DataSet dsCurrency = new mcurrencyCRUD().getData();
            DataSet dsUOM = new muomCRUD().getData();
            DataSet dsType = new mtypeCRUD().getData();
            DataSet dsDIV = new mdivCRUD().getData();
            DataSet dsCourier = new mcourierCRUD().getData();
            DataSet dsStore = new mstoreCRUD().getData();

            cbStore.DataSource = dsStore.Tables[0];
            cbStore.DisplayMember = "NAME";
            cbStore.ValueMember = "STOREID";


            cbDIV.DataSource = dsDIV.Tables[0];
            cbDIV.DisplayMember = "DESCRIPTION";
            cbDIV.ValueMember = "DIVID";

            DataGridViewComboBoxColumn Uom = dtGrid.Columns["hUom"] as DataGridViewComboBoxColumn;
            //DataGridViewComboBoxColumn UomPurchase = dtGrid.Columns["hUomPurchase"] as DataGridViewComboBoxColumn;

            Uom.DataSource = dsUOM.Tables[0];
            Uom.DisplayMember = "DESCRIPTION";
            Uom.ValueMember = "UOMID";

          //  UomPurchase.DataSource = dsUOM.Tables[0];
          //  UomPurchase.DisplayMember = "DESCRIPTION";
         //   UomPurchase.ValueMember = "UOMID";

        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            //simpan header
            gin k = new gin();
            Generate gen = new Generate();
            txtGRNNO.Text = gen.genPIN();
            //k.PONO = txtPONO.Text;
            k.GINNO = txtGRNNO.Text;
            k.DATE = dateCreated.Value;
            DataRow selectedDIV = ((DataRowView)cbDIV.SelectedItem).Row;
            k.GDIV = selectedDIV["DIVID"].ToString();
            k.APPROVE = 0;
            k.APPROVEBY = "";
            k.CLOSE = 0;
           // k.COLORID = "";
            k.CUSTVENDCODE = txtCustomerID.Text;
            k.DOCREGNO = "";
            k.OFFICER = GlobalVariables.GUserID;
            //k.RECEIVEFROM = 3;// from po process
            //k.REMARKS=txte txtRefer.Text;
            k.REMARKS = txtRemarks.Text;
            k.STOREID = cbStore.Text;
            k.TYPE = cbJENIS.Text;
            if ((txtGRNNO.Text == "") || (txtPONO.Text == ""))
            {
                MessageBox.Show("Isian Belum lengkap untuk PONO");
            }
            else if (new ginCRUD().insertData(k))
            {

                gindetail d = new gindetail();
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {

                    d.PONO = txtPONO.Text;
                    d.GINNO = txtGRNNO.Text;
                    d.GRNNO = txtGRNNO.Text;
                    d.ID = i + 1;
                    d.ITEMSID = dtGrid.Rows[i].Cells["hItemsID"].Value == null ? null : dtGrid.Rows[i].Cells["hItemsID"].Value.ToString();
                    d.DESCRIPTION = dtGrid.Rows[i].Cells["hDescription"].Value == null ? null : dtGrid.Rows[i].Cells["hDescription"].Value.ToString().ToString();
                    d.QUANTITY = Convert.ToDecimal(dtGrid.Rows[i].Cells["hQuantity"].Value);
                    d.UOM = dtGrid.Rows[i].Cells["hUOM"].Value == null ? null : dtGrid.Rows[i].Cells["hUOM"].Value.ToString();
                    d.COLORID = "";
                    d.GRADE = "";
                    d.JENIS = cbJENIS.Text;
                    d.SIZEID = "";
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

            //simpang detail
        }

        private void UbahTSB_Click(object sender, EventArgs e)
        {
            //simpan header
            gin k = new gin();
            //Generate gen = new Generate();
           // txtGRNNO.Text = gen.genPIN();
            //k.PONO = txtPONO.Text;
            k.GINNO = txtGRNNO.Text;
            k.DATE = dateCreated.Value;
            DataRow selectedDIV = ((DataRowView)cbDIV.SelectedItem).Row;
            k.GDIV = selectedDIV["DIVID"].ToString();
            k.APPROVE = 0;
            k.APPROVEBY = "";
            k.CLOSE = 0;
            // k.COLORID = "";
            k.CUSTVENDCODE = txtCustomerID.Text;
            k.DOCREGNO = "";
            k.OFFICER = GlobalVariables.GUserID;
            //k.RECEIVEFROM = 3;// from po process
            //k.REMARKS=txte txtRefer.Text;
            k.REMARKS = txtRemarks.Text;
            k.STOREID = cbStore.Text;
            k.TYPE = cbJENIS.Text;
            if ((txtGRNNO.Text == "") || (txtPONO.Text == ""))
            {
                MessageBox.Show("Isian Belum lengkap untuk PONO");
            }
            else if (new ginCRUD().updateData(k))
            {

                gindetail d = new gindetail();
                dtGrid.EndEdit();
                string GINNO1;
                int ID1;
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {

                    //d.PONO = txtPONO.Text;
                    //d.GINNO = txtGRNNO.Text;
                    GINNO1=Convert.ToString(dtGrid.Rows[i].Cells["hItemsID"].Value);
                    ID1=Convert.ToInt32(dtGrid.Rows[i].Cells["hItemsID"].Value);
                    d.GRNNO = Convert.ToString(dtGrid.Rows[i].Cells["hItemsID"].Value);
                    d.GINNO=Convert.ToString(dtGrid.Rows[i].Cells["hItemsID"].Value);
                    d.ID = Convert.ToInt32(dtGrid.Rows[i].Cells["hItemsID"].Value);
                    d.ITEMSID = dtGrid.Rows[i].Cells["hItemsID"].Value == null ? null : dtGrid.Rows[i].Cells["hItemsID"].Value.ToString();
                    d.DESCRIPTION = dtGrid.Rows[i].Cells["hDescription"].Value == null ? null : dtGrid.Rows[i].Cells["hDescription"].Value.ToString().ToString();
                    d.QUANTITY = Convert.ToDecimal(dtGrid.Rows[i].Cells["hQuantity"].Value);
                    d.UOM = dtGrid.Rows[i].Cells["hUOM"].Value == null ? null : dtGrid.Rows[i].Cells["hUOM"].Value.ToString();
                    d.COLORID = "";
                    d.GRADE = "";
                    d.JENIS = cbJENIS.Text;
                    d.SIZEID = "";
                    d.STYLEID = dtGrid.Rows[i].Cells["hStyleID"].Value == null ? null : dtGrid.Rows[i].Cells["hStyleID"].Value.ToString();
                    d.STYLEIDTO = dtGrid.Rows[i].Cells["hStyleID"].Value == null ? null : dtGrid.Rows[i].Cells["hStyleID"].Value.ToString();
                    if (dtGrid.Rows[i].HeaderCell.Value.ToString() != "#")
                    {

                        if (new gindetailCRUD().updateData(d,GINNO1,ID1))
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

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            frmginSearch f = new frmginSearch();
            GlobalVariables.GCode = "PROCESS";
            f.AddItemCallback = new frmginSearch.AddPurchaseDelegate(this.SetPurchaseCallBack);
            f.ShowDialog();
            //txtCostingNo.Text
            if (GStrCode != "")
            {
                DataSet dsHeader = new ginCRUD().getData(GStrCode);
                txtGRNNO.Text = GStrCode;
                dateCreated.Value = (DateTime)dsHeader.Tables[0].Rows[0]["DATE"];
                cbDIV.SelectedValue = dsHeader.Tables[0].Rows[0]["GDIV"];
                //RECEIVEFROM  di hilangkan
                //
                txtRemarks.Text = dsHeader.Tables[0].Rows[0]["REMARKS"].ToString();
                txtCustomerID.Text = dsHeader.Tables[0].Rows[0]["CUSTVENDCODE"].ToString();
                txtRefer.Text = dsHeader.Tables[0].Rows[0]["DELIVERYTO"].ToString();
               // txtPONO.Text = dsHeader.Tables[0].Rows[0]["PONO"].ToString();
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
                   // dtGrid.Rows[i].Cells["hConvert"].Value = dsDetail.Tables[0].Rows[i]["CONVER"].ToString();
                  //  dtGrid.Rows[i].Cells["hQtyPurchase"].Value = dsDetail.Tables[0].Rows[i]["QTYPURCHASE"].ToString();
                   // dtGrid.Rows[i].Cells["hUOMPurchase"].Value = dsDetail.Tables[0].Rows[i]["UOMPURCHASE"].ToString();

                }
                SimpanTSB.Enabled = false;
                UbahTSB.Enabled = true;
                dtGrid.Enabled = true;
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
                grndetail k = new grndetail();
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {
                    k.GRNNO = txtGRNNO.Text;
                    k.ID = Convert.ToInt32(dtGrid.Rows[i].Cells["hID1"].Value);
                    if ((Convert.ToInt32(dtGrid.Rows[i].Cells["hDel"].Value) == 1) && (dtGrid.Rows[i].Cells["hID1"].Value != null))
                    {
                        if (new grndetailCRUD().deleteData(k.GRNNO, k.ID))
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

        private void cbJENIS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {
            DataSet data = new ginCRUD().prMatIssue(txtGRNNO.Text);
            Application.DoEvents();
            data.WriteXml("C:\\MyGarmentReport\\MatIssue.xml", XmlWriteMode.WriteSchema);
            Form f = new PrintMatIssue();
            f.Show();
        }
    }
}
