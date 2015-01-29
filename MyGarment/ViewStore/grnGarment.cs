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
using MyGarment.ViewMD;
using MyGarment.ViewFinance;
using MyGarment.ClassMaster;
using MyGarment.PrintStore;
using MyGarment._1Global;


namespace MyGarment.ViewStore
{
    public partial class frmgrnCMT : Form
    {
        private string GStrCode = "";
        // private string GitemsDesc = "";
   

        public frmgrnCMT()
        {
            InitializeComponent();
        }

        private void frmgrnCMT_Load(object sender, EventArgs e)
        {
            SimpanTSB.Enabled = true;
            UbahTSB.Enabled = false;
            dtGrid.Enabled = false;


            DataSet dsCost = new mcostCRUD().getData();
            //DataSet dsCurrency = new mcurrencyCRUD().getData();
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

            //cbCurrency.DataSource = dsCurrency.Tables[0];
            //cbCurrency.DisplayMember = "CURRENCYID";
            //cbCurrency.ValueMember = "CURRENCYID";

            DataGridViewComboBoxColumn Uom = dtGrid.Columns["hUom"] as DataGridViewComboBoxColumn;
           // DataGridViewComboBoxColumn CurrencyID = dtGrid.Columns["hCurrencyID"] as DataGridViewComboBoxColumn;
            DataGridViewComboBoxColumn UomPurchase = dtGrid.Columns["hUomPurchase"] as DataGridViewComboBoxColumn;

            Uom.DataSource = dsUOM.Tables[0];
            Uom.DisplayMember = "DESCRIPTION";
            Uom.ValueMember = "UOMID";

            UomPurchase.DataSource = dsUOM.Tables[0];
            UomPurchase.DisplayMember = "DESCRIPTION";
            UomPurchase.ValueMember = "UOMID";

            //CurrencyID.DataSource = dsCurrency.Tables[0];
            //CurrencyID.DisplayMember = "CURRENCYID";
            //CurrencyID.ValueMember = "CURRENCYID";


        }
        private void SetItemsCallBack(string ItemsID, string ItemsDesc)
        {
            //dtGrid.Rows[i].Cells["hPONO"].Value = CostingNo;
            GStrCode = ItemsID;
            //GitemsDesc = ItemsDesc;

            //txtCategoryDesc.Text = categoryDesc;
        }

        private void dtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            GStrCode = "";
            //GitemsDesc = "";
            //untuk items
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex] == dtGrid.Columns["hItemsID"])
            {
                frmItemsSearch f = new frmItemsSearch();
                f.AddItemCallback = new frmItemsSearch.AddItemDelegate(this.SetItemsCallBack);
                f.ShowDialog();
                if (GStrCode != "")
                {
                    dtGrid.Rows[e.RowIndex].Cells["hItemsID"].Value = GStrCode;
                   // dtGrid.Rows[e.RowIndex].Cells["hDescription"].Value = GitemsDesc;
                }
            }
            

        }

        private void cmdCustomer_Click(object sender, EventArgs e)
        {
            frmSupplierSearch f = new frmSupplierSearch();
            f.AddItemCallback = new frmSupplierSearch.AddSupplierDelegate(this.SetSupplierCallBack);
            f.ShowDialog();

        }

        private void SetSupplierCallBack(string CustID, string CustDesc)
        {
            txtCustomerID.Text = CustID;
            txtCustomerDesc.Text = CustDesc;

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
        private void SetCostingCallBack(string CostingNo)
        {
            txtJONO.Text = CostingNo;
            GStrCode = CostingNo;
            //txtCategoryDesc.Text = categoryDesc;
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
            GlobalVariables.GCode = "PRODUCT";
            f.AddItemCallback = new frmgrnSearch.AddPurchaseDelegate(this.SetPurchaseCallBack);
            f.ShowDialog();
           
            //txtCostingNo.Text
            if (GStrCode != "")
            {

                //load header
                //GRNNO,DATE,OFFICER,GDIV,RECEIVEFROM,REMARKS,STOREID,PONO,CUSTVENDCODE,REFFNO,APPROVE,APPROVEDATE,APPROVEBY,
                //CLOSE,STYLEID,COLORID,DOCREGNO,JENIS,
                DataSet dsHeader = new grnCRUD().getData(GStrCode);
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



                //load detail
                DataSet dsDetail = new grndetailCRUD().getData(GStrCode);
                dtGrid.Rows.Clear();
                for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                {
                    GlobalVariables.GID = GlobalVariables.GID + 1;
                    // ID,ITEMSID,DESCRIPTION,JENIS,COLORID,SIZEID,GRADE,COSTINGNO,STYLEID,PONO,QUANTITY,UOM,
                    //PRICE,CURRENCYID,KURS,REMARKS,QTYPURCHASE,PRICEPURCHASE,UOMPURCHASE,
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

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            //simpan header
            grn k = new grn();
            Generate gen = new Generate();
            txtGRNNO.Text = gen.genGRN();
            k.PONO = txtJONO.Text;
            k.GRNNO = txtGRNNO.Text;
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
            k.RECEIVEFROM = 1;// from PO
            k.REFFNO = txtRefer.Text;
            k.REMARKS = txtRemarks.Text;
            k.STOREID = cbStore.Text;
            k.JENIS = cbJENIS.Text;

            //    k.STYLEID="";

            if ((txtGRNNO.Text == ""))
            {
                MessageBox.Show("Isian Belum lengkap untuk PONO");
            }
            else if (new grnCRUD().insertData(k))
            {

                grndetail d = new grndetail();
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {

                    d.PONO = txtJONO.Text;
                    d.GRNNO = txtGRNNO.Text;
                    d.ID = Convert.ToInt32(dtGrid.Rows[i].Cells["hID"].Value); //Convert.ToInt32(dtGrid.Rows[i].Cells["hCostingID"].Value);
                    d.ITEMSID = dtGrid.Rows[i].Cells["hItemsID"].Value == null ? null : dtGrid.Rows[i].Cells["hItemsID"].Value.ToString();
                    d.DESCRIPTION = dtGrid.Rows[i].Cells["hDescription"].Value == null ? null : dtGrid.Rows[i].Cells["hDescription"].Value.ToString().ToString();
                    d.QUANTITY = Convert.ToDecimal(dtGrid.Rows[i].Cells["hQuantity"].Value);
                    d.UOM = dtGrid.Rows[i].Cells["hUOM"].Value == null ? null : dtGrid.Rows[i].Cells["hUOM"].Value.ToString();
                    d.CONVER = Convert.ToDecimal(dtGrid.Rows[i].Cells["hConvert"].Value);
                    d.QTYPURCHASE = Convert.ToDecimal(dtGrid.Rows[i].Cells["hQtyPurchase"].Value);
                    d.UOMPURCHASE = dtGrid.Rows[i].Cells["hUOMPurchase"].Value == null ? null : dtGrid.Rows[i].Cells["hUOMPurchase"].Value.ToString();
                    d.COLORID = dtGrid.Rows[i].Cells["hColorID"].Value == null ? null : dtGrid.Rows[i].Cells["hColorID"].Value.ToString(); 
                    d.GRADE = dtGrid.Rows[i].Cells["hGrade"].Value == null ? null : dtGrid.Rows[i].Cells["hGrade"].Value.ToString(); 
                    d.JENIS = cbJENIS.Text;
                    d.SIZEID = Convert.ToString(dtGrid.Rows[i].Cells["hSizeID"].Value);
                    d.CONVER = Convert.ToDecimal(dtGrid.Rows[i].Cells["hConvert"].Value);
                    d.STYLEID = dtGrid.Rows[i].Cells["hStyleID"].Value == null ? null : dtGrid.Rows[i].Cells["hStyleID"].Value.ToString();
                    if (dtGrid.Rows[i].HeaderCell.Value.ToString() == "#")
                    {

                        if (new grndetailCRUD().insertData(d))
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
            grn k = new grn();
            k.PONO = txtJONO.Text;
            k.GRNNO = txtGRNNO.Text;
            k.DATE = dateCreated.Value;
            DataRow selectedDIV = ((DataRowView)cbDIV.SelectedItem).Row;
            k.GDIV = selectedDIV["DIVID"].ToString();
            k.APPROVE = 0;
            k.APPROVEBY = "";
            k.CLOSE = 0;
            k.COLORID = "";
            k.CUSTVENDCODE = txtCustomerID.Text;
            k.DOCREGNO = "";
            k.OFFICER = "";
            k.RECEIVEFROM = 1;// from PO
            k.REFFNO = txtRefer.Text;
            k.REMARKS = txtRemarks.Text;
            k.STOREID = cbStore.Text;
            k.JENIS = cbJENIS.Text;

            if ((txtGRNNO.Text == "") )
            {
                MessageBox.Show("Isian Belum lengkap untuk PONO");
            }
            else if (new grnCRUD().updateData(k))
            {
                string GRNNO1;
                int ID1;

                grndetail d = new grndetail();
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {
                    //key
                    GRNNO1 = txtGRNNO.Text;
                    ID1 = Convert.ToInt32(dtGrid.Rows[i].Cells["hID1"].Value); //i+1;//Convert.ToInt32(dtGrid.Rows[i].Cells["hCostingID"].Value);
                    //endkey
                    d.PONO = txtJONO.Text;
                    d.GRNNO = txtGRNNO.Text;
                    d.ID = Convert.ToInt32(dtGrid.Rows[i].Cells["hID"].Value); //i+1;//Convert.ToInt32(dtGrid.Rows[i].Cells["hCostingID"].Value);
                    d.ITEMSID = dtGrid.Rows[i].Cells["hItemsID"].Value == null ? null : dtGrid.Rows[i].Cells["hItemsID"].Value.ToString();
                    d.DESCRIPTION = dtGrid.Rows[i].Cells["hDescription"].Value == null ? null : dtGrid.Rows[i].Cells["hDescription"].Value.ToString().ToString();
                    d.QUANTITY = Convert.ToDecimal(dtGrid.Rows[i].Cells["hQuantity"].Value);
                    d.UOM = dtGrid.Rows[i].Cells["hUOM"].Value == null ? null : dtGrid.Rows[i].Cells["hUOM"].Value.ToString();
                    d.CONVER = Convert.ToDecimal(dtGrid.Rows[i].Cells["hConvert"].Value);
                    d.QTYPURCHASE = Convert.ToDecimal(dtGrid.Rows[i].Cells["hQtyPurchase"].Value);
                    d.UOMPURCHASE = dtGrid.Rows[i].Cells["hUOMPurchase"].Value == null ? null : dtGrid.Rows[i].Cells["hUOMPurchase"].Value.ToString();
                    d.COLORID="";
                    d.GRADE = "PRODUCT";
                    d.JENIS = "";
                    d.SIZEID = "";
                    d.STYLEID = "";
                    if (dtGrid.Rows[i].HeaderCell.Value.ToString() == "#")
                    {
                        // ID1 = GlobalVariables.GID;
                        if (new grndetailCRUD().insertData(d))
                        {
                            dtGrid.Rows[i].HeaderCell.Value = "V";
                            ID1 = GlobalVariables.GID + 1;
                        }
                        else
                        {
                            if (new grndetailCRUD().updateData(d, GRNNO1, ID1))
                            {
                                // MessageBox.Show("Data berhasil di tambahkan");
                                // Binding();
                                dtGrid.Rows[i].HeaderCell.Value = "V";
                            }
                            else
                            {
                                MessageBox.Show("gagal");
                            }

                        }
                    }
                }

                MessageBox.Show("Data berhasil di tambahkan");
                SimpanTSB.Enabled = false;
                // Binding();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan");
            }

            //simpang detail
        }

        private void Print_Click(object sender, EventArgs e)
        {
            DataSet data = new grnCRUD().prMatSupplier(txtGRNNO.Text);
            Application.DoEvents();
            data.WriteXml("C:\\MyGarmentReport\\MatSupplier.xml", XmlWriteMode.WriteSchema);
            Form f = new PrintMatSupplier();
            f.Show();
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            
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

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
