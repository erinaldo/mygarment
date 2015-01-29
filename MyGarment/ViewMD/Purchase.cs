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
using MyGarment.ClassFile;
namespace MyGarment.ViewFinance
{
    public partial class frmPurchase : Form
    {
        private string GStrCode = "";
        private string GitemsDesc = "";
        DataSet dsCost = new mcostCRUD().getData();
        DataSet dsCurrency = new mcurrencyCRUD().getData();
        DataSet dsUOM = new muomCRUD().getData();
        DataSet dsType = new mtypeCRUD().getData();
        DataSet dsDIV = new mdivCRUD().getData();
        DataSet dsCourier = new mcourierCRUD().getData();
        DataSet dsTerms = new mtermofpaymentCRUD().getData();

        //DataSet dtCostingID=new mcos
        public frmPurchase()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            // save purchase Header
            purchase k = new purchase();
            Generate gen = new Generate();
            txtPONO.Text = gen.genPONO();
            k.PONO = txtPONO.Text;
            k.DATE = dateCreated.Value;
            k.CURRENCYID = cbCurrency.Text;
            k.KURS = (float)Convert.ToDouble(txtKurs.Text);
           // k.PPN = (float)Convert.ToDouble(txtPPN.Text);
            //k.pp
           // DataRow selectedDataRow = ((DataRowView)cbTypeID.SelectedItem).Row;
           // k.TYPEID = selectedDataRow["TYPEID"].ToString();
            DataRow selectedDIV = ((DataRowView)cbDIV.SelectedItem).Row;
            k.GDIV = selectedDIV["DIVID"].ToString();
            k.CUSTVENDID = txtCustomerID.Text;
            k.DELIVERYTO = txtDeliveryTo.Text;
            k.DELIVERYTOADDRESS = txtAddress.Text;
            
            //k.ACKNOWLEDGEMENT = 
            //k.ACKNOWLEDGEMENTBY=
            //k.ACKNOWLEDGEMENTDATE=
            //  k.APPROVE=
            // k.APPROVEBY=
            //  k.APPROVEDATE=
            // k.CHECKBY=
            //k.CHECKDATE=
            //k.CHECKED=
            //k.CLOSE=
             k.CURRENCYID=cbCurrency.Text;
             k.CUSTVENDID=txtCustomerID.Text;
             k.DATE=dateCreated.Value;
             k.DELIVERYTOADDRESS=txtAddress.Text;
             k.DELIVERYTONAME=txtRefer.Text;
             k.DUEDATE=dateDue.Value;
             k.ETA=dateETA.Value;
             k.ETD=dateETD.Value;
             k.GDIV=cbDIV.SelectedValue.ToString();
             //k.NONREQ=
             k.NOTE=txtRemarks.Text;
             //k.OFFICER=GOFFIC
             //k.PONO=
             k.REFERTO=txtRefer.Text;
             k.REMARKS=txtRemarks.Text;
             //k.REVISE=
             //k.REVISEBY=
             //k.REVISEDATE=
             //k.REVISEDUEDATE=
             k.SHIPMODA=cbCourier.Text;
            //k.TERMOFPAYMENT=cbt
            //k.TOTALAMOUNT=
            //k.TOTALDISCOUNT=
            //k.TOTALPAID=
            //k.TOTALPPN=
            //k.TOTALUPCHARGES=
            //k.DELIVERYTOADDRESS=txta
             k.OFFICER = GlobalVariables.GUserID;

            if ((cbDIV.Text == "") || (txtCustomerID.Text == ""))
            {
                MessageBox.Show("Isian Belum lengkap,silahkan di lengkapi");
            }
            else if (new purchaseCRUD().insertData(k))
            {
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

        private void cmdCustomer_Click(object sender, EventArgs e)
        {
           // frmCustomerSearch f = new frmCustomerSearch();
           // f.AddItemCallback = new frmCustomerSearch.AddCustomerDelegate(this.SetCustomerCallBack);
           // f.ShowDialog();

            frmSupplierSearch f = new frmSupplierSearch();
            f.AddItemCallback = new frmSupplierSearch.AddSupplierDelegate(this.SetSupplierCallBack);
            f.ShowDialog();

        }

        private void SetSupplierCallBack(string CustID, string CustDesc)
        {
            txtCustomerID.Text = CustID;
            txtCustomerDesc.Text = CustDesc;

        }
        private void frmPurchase_Load(object sender, EventArgs e)
        {
            SimpanTSB.Enabled = true;
            UbahTSB.Enabled = false;
            dtGrid.Enabled = false;


            cbCourier.DataSource = dsCourier.Tables[0];
            cbCourier.DisplayMember = "DESCRIPTION";
            cbCourier.ValueMember = "COURIERID";


            cbDIV.DataSource = dsDIV.Tables[0];
            cbDIV.DisplayMember = "DESCRIPTION";
            cbDIV.ValueMember = "DIVID";

            cbCurrency.DataSource = dsCurrency.Tables[0];
            cbCurrency.DisplayMember = "CURRENCYID";
            cbCurrency.ValueMember = "CURRENCYID";

            cbTerms.DataSource = dsTerms.Tables[0];
            cbTerms.DisplayMember = "TERMOFPAYMENT";
            cbTerms.ValueMember = "TERMOFPAYMENT";

            DataGridViewComboBoxColumn Uom = dtGrid.Columns["hUom"] as DataGridViewComboBoxColumn;
            DataGridViewComboBoxColumn Currency = dtGrid.Columns["hCurrency"] as DataGridViewComboBoxColumn;
            DataGridViewComboBoxColumn UomPurchase = dtGrid.Columns["hUomPurchase"] as DataGridViewComboBoxColumn;

            Uom.DataSource = dsUOM.Tables[0];
            Uom.DisplayMember = "DESCRIPTION";
            Uom.ValueMember = "UOMID";

            UomPurchase.DataSource = dsUOM.Tables[0];
            UomPurchase.DisplayMember = "DESCRIPTION";
            UomPurchase.ValueMember = "UOMID";

            Currency.DataSource = dsCurrency.Tables[0];
            Currency.DisplayMember = "CURRENCYID";
            Currency.ValueMember = "CURRENCYID";

            cbCurrency.Text = "USD";
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            frmPurchaseSearch f = new frmPurchaseSearch();
            f.AddItemCallback = new frmPurchaseSearch.AddPurchaseDelegate(this.SetPurchaseCallBack);
            f.ShowDialog();
            //txtCostingNo.Text
            if (GStrCode != "")
            {

                DataSet dsHeader = new purchaseCRUD().getData(GStrCode);
                txtPONO.Text = GStrCode;
                cbDIV.SelectedValue = dsHeader.Tables[0].Rows[0]["GDIV"];
                dateCreated.Value = (DateTime)dsHeader.Tables[0].Rows[0]["DATE"];
                txtRemarks.Text=dsHeader.Tables[0].Rows[0]["REMARKS"].ToString();
                cbCurrency.Text=dsHeader.Tables[0].Rows[0]["CURRENCYID"].ToString();
                txtKurs.Text=dsHeader.Tables[0].Rows[0]["KURS"].ToString();
                //txtPPN.Text=dsHeader.Tables[0].Rows[0]["PPN"].ToString();
                txtCustomerID.Text=dsHeader.Tables[0].Rows[0]["CUSTVENDID"].ToString();
                txtDeliveryTo.Text = dsHeader.Tables[0].Rows[0]["DELIVERYTO"].ToString();
               // txtAddress.Text = dsHeader.Tables[0].Rows[0]["DELIVERYTOADDRESS"].ToString();
                txtRefer.Text=dsHeader.Tables[0].Rows[0]["REFERTO"].ToString();
                cbCourier.Text=dsHeader.Tables[0].Rows[0]["SHIPMODA"].ToString();
                txtAddresTo.Text = dsHeader.Tables[0].Rows[0]["DELIVERYTOADDRESS"].ToString();
                dateDue.Value=(DateTime)dsHeader.Tables[0].Rows[0]["DUEDATE"];
                dateETA.Value=(DateTime)dsHeader.Tables[0].Rows[0]["ETA"];
                dateETD.Value=(DateTime)dsHeader.Tables[0].Rows[0]["ETD"];
                cbTerms.Text = dsHeader.Tables[0].Rows[0]["TERMOFPAYMENT"].ToString();
                //txtDiscount.Text = dsHeader.Tables[0].Rows[0]["DISCOUNT"].ToString();
                //MessageBox.Show("testttt");
                DataSet dsDetail = new purchasedetailCRUD().getData(GStrCode);
                dtGrid.Rows.Clear();
                for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                {
                    dtGrid.Rows.Add();
                    dtGrid.Rows[i].HeaderCell.Value = "V";
                    dtGrid.Rows[i].Cells["hCostingNo"].Value = dsDetail.Tables[0].Rows[i]["COSTINGNO"].ToString();
                    // cari items costing
                    GStrCode = dsDetail.Tables[0].Rows[i]["COSTINGNO"].ToString();
                    DataSet dsDetailtemp = new costingdetailCRUD().getData(GStrCode);
                    if (dsDetailtemp.Tables[0].Rows.Count > 0)
                    {
                        DataGridViewComboBoxCell dtgCol = dtGrid.Rows[i].Cells["hCostingID"] as DataGridViewComboBoxCell;
                        dtgCol.DataSource = dsDetailtemp.Tables[0];
                        dtgCol.DisplayMember = "DESCRIPTION";
                        dtgCol.ValueMember = "ID";
                    }

                    dtGrid.Rows[i].Cells["hItemsID"].Value = dsDetail.Tables[0].Rows[i]["ITEMSID"];

                    dtGrid.Rows[i].Cells["hCostingID"].Value = dsDetail.Tables[0].Rows[i]["COSTINGID"];
                    dtGrid.Rows[i].Cells["hPONO"].Value = dsDetail.Tables[0].Rows[i]["PONO"].ToString();
                    dtGrid.Rows[i].Cells["hID"].Value = dsDetail.Tables[0].Rows[i]["ID"].ToString();
                    dtGrid.Rows[i].Cells["hQuantity"].Value = dsDetail.Tables[0].Rows[i]["QUANTITY"].ToString();
                    dtGrid.Rows[i].Cells["hUOM"].Value = dsDetail.Tables[0].Rows[i]["UOM"].ToString();
                    dtGrid.Rows[i].Cells["hPrice"].Value = dsDetail.Tables[0].Rows[i]["PRICE"].ToString();
                    dtGrid.Rows[i].Cells["hDescription"].Value = dsDetail.Tables[0].Rows[i]["DESCRIPTION"].ToString();

                    dtGrid.Rows[i].Cells["hQtyPurchase"].Value = dsDetail.Tables[0].Rows[i]["QTYPURCHASE"].ToString();
                    dtGrid.Rows[i].Cells["hUOMPurchase"].Value = dsDetail.Tables[0].Rows[i]["UOMPURCHASE"].ToString();
                    dtGrid.Rows[i].Cells["hPricePurchase"].Value = dsDetail.Tables[0].Rows[i]["PRICEPURCHASE"].ToString();
                   // dtGrid.Rows[i].Cells["hPPN"].Value = dsDetail.Tables[0].Rows[i]["PPN"];
                   //dtGrid.Rows[i].Cells["hDiscount"].Value = dsDetail.Tables[0].Rows[i]["DISCOUNT"];
                    dtGrid.Rows[i].Cells["hConvert"].Value = dsDetail.Tables[0].Rows[i]["CONVER"];
                    dtGrid.Rows[i].Cells["hCurrency"].Value = dsDetail.Tables[0].Rows[i]["CURRENCYID"].ToString();
                    dtGrid.Rows[i].Cells["hKurs"].Value = dsDetail.Tables[0].Rows[i]["KURS"].ToString();
                    
                }

                SimpanTSB.Enabled = false;
                UbahTSB.Enabled = true;
                dtGrid.Enabled = true;

            }

        }
        private void SetPurchaseCallBack(string PoNo)
        {
            txtPONO.Text = PoNo;
            GStrCode = PoNo;
            //txtCategoryDesc.Text = categoryDesc;
        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UbahTSB_Click(object sender, EventArgs e)
        {
            // save purchase Header
            purchase k = new purchase();
            k.PONO = txtPONO.Text;
            k.CURRENCYID = cbCurrency.Text;
            k.DELIVERYTO = txtDeliveryTo.Text;
            // DataRow selectedDataRow = ((DataRowView)cbTypeID.SelectedItem).Row;
            // k.TYPEID = selectedDataRow["TYPEID"].ToString();
            DataRow selectedDIV = ((DataRowView)cbDIV.SelectedItem).Row;
            k.GDIV = selectedDIV["DIVID"].ToString();
            k.CUSTVENDID = txtCustomerID.Text;
            k.DELIVERYTO = txtDeliveryTo.Text;
            k.DELIVERYTOADDRESS = txtAddress.Text;

            //k.ACKNOWLEDGEMENT = 
            //k.ACKNOWLEDGEMENTBY=
            //k.ACKNOWLEDGEMENTDATE=
            //k.APPROVE=
            //k.APPROVEBY=
            //k.APPROVEDATE=
            //k.CHECKBY=
            //k.CHECKDATE=
            //k.CHECKED=
            //k.CLOSE=
            k.CURRENCYID = cbCurrency.Text;
            k.CUSTVENDID = txtCustomerID.Text;
            k.DATE = dateCreated.Value;
            k.DELIVERYTO = txtDeliveryTo.Text;
            k.DELIVERYTOADDRESS = txtAddress.Text;
            k.DELIVERYTONAME = txtRefer.Text;
            k.DUEDATE = dateDue.Value;
            k.ETA = dateETA.Value;
            k.ETD = dateETD.Value;
           // k.PPN = (float)Convert.ToDouble(txtPPN.Text);
            k.KURS = (float)Convert.ToDouble(txtKurs.Text);
            //k.GDIV=cbDIV.Text;
            //k.NONREQ=
            k.NOTE = txtRemarks.Text;
            //k.OFFICER=GOFFICER
            //k.PONO=
            k.REFERTO = txtRefer.Text;
            k.REMARKS = txtRemarks.Text;
            //k.REVISE=
            //k.REVISEBY=
            //k.REVISEDATE=
            //k.REVISEDUEDATE=
            k.SHIPMODA = cbCourier.Text;
            k.TERMOFPAYMENT = cbTerms.Text;
            //k.TOTALAMOUNT=
            //k.TOTALDISCOUNT=
            //k.TOTALPAID=
            //k.TOTALPPN=
            //k.TOTALUPCHARGES=
            //k.DELIVERYTOADDRESS=txta

            if ((cbDIV.Text == "") || (txtCustomerID.Text == ""))
            {
                MessageBox.Show("Isian Belum lengkap,silahkan di lengkapi");
            }
            else if (new purchaseCRUD().updateData(k))
            {
                purchasedetail d = new purchasedetail();
                //dtGrid.BeginEdit(true);
                //dtGrid.Refresh();
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {
                    d.PONO = txtPONO.Text;

                    d.ID = Convert.ToInt32(dtGrid.Rows[i].Cells["hID"].Value); //i+1;//Convert.ToInt32(dtGrid.Rows[i].Cells["hCostingID"].Value);
                    d.COSTINGNO = dtGrid.Rows[i].Cells["hCostingNo"].Value.ToString();
                    d.COSTINGID = Convert.ToInt32(dtGrid.Rows[i].Cells["hCostingID"].Value);
                    
                   // d.COSTINGDESC=dtGrid.Rows[i].Cells["hCostingID"].tr
                    //d.COSTINGDESC=
                    //d.MATERIALTYPEID=
                    d.ITEMSID = dtGrid.Rows[i].Cells["hItemsID"].Value == null ? null : dtGrid.Rows[i].Cells["hItemsID"].Value.ToString();
                    d.DESCRIPTION=dtGrid.Rows[i].Cells["hDescription"].Value==null?null:dtGrid.Rows[i].Cells["hDescription"].Value.ToString().ToString();
                    d.QUANTITY = (float)Convert.ToDouble(dtGrid.Rows[i].Cells["hQuantity"].Value);
                    d.UOM = dtGrid.Rows[i].Cells["hUOM"].Value == null ? null : dtGrid.Rows[i].Cells["hUOM"].Value.ToString();
                    d.PRICE = (float)Convert.ToDouble(dtGrid.Rows[i].Cells["hPrice"].Value);
                    d.CONVER = (float)Convert.ToDouble(dtGrid.Rows[i].Cells["hConvert"].Value);
                    d.QTYPURCHASE = (float)Convert.ToDouble(dtGrid.Rows[i].Cells["hQtyPurchase"].Value);
                    d.UOMPURCHASE = dtGrid.Rows[i].Cells["hUOMPurchase"].Value==null?null:dtGrid.Rows[i].Cells["hUOMPurchase"].Value.ToString();
                    d.PRICEPURCHASE = (float)Convert.ToDouble(dtGrid.Rows[i].Cells["hPricePurchase"].Value);
                    //d.TOTAL = (float)Convert.ToDouble(dtGrid.Rows[i].Cells["hTotal"].Value);
                    d.CURRENCYID = dtGrid.Rows[i].Cells["hCurrency"].Value == null ? null : dtGrid.Rows[i].Cells["hCurrency"].Value.ToString();
                   // d.DISCOUNT = (float)Convert.ToDouble(txtDiscount.Text);
                   // d.PPN = (float)Convert.ToDouble(txtPPN.Text);
                    d.KURS = (float)Convert.ToDouble(txtKurs.Text);
                    d.CURRENCYID = cbCurrency.SelectedValue.ToString();

                    //d.ITEMSID=
                    //d.COSTINGDESC=txtPONO.Text;
                    //d.COSTINGNO=txtPONO.Text;
                    //d.CURRENCYID=txtPONO.Text;
                    if (dtGrid.Rows[i].HeaderCell.Value.ToString() == "#")
                    {
                        d.ID = i + 1;
                        if (new purchasedetailCRUD().insertData(d))
                        {
                            // MessageBox.Show("Data berhasil di tambahkan");
                            // Binding();
                            dtGrid.Rows[i].HeaderCell.Value = "V";
                        }
                        else
                        { //insert
 
                        }
                        
                    }
                    else //if (dtGrid.Rows[i].HeaderCell.Value.ToString() == "E")
                    {

                        //update
                        if (new purchasedetailCRUD().updateData(d))
                        {
                            // MessageBox.Show("Data berhasil di tambahkan");
                            dtGrid.Rows[i].HeaderCell.Value = "V";
                        }
                        else
                        {
                             MessageBox.Show("Data gagal update");
                            //dtGrid.Rows[i].Cells["Check"].Value = "ER";
                            // dtGrid.Rows[i].HeaderCell.Value = "X";
                        }


                    }
                }
                MessageBox.Show("Data berhasil di update");
                SimpanTSB.Enabled = false;
            }
            else
            {
                MessageBox.Show("Data gagal update");
            }

        }

        private void dtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            GStrCode = "";
            GitemsDesc = "";
            //untuk items
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex] == dtGrid.Columns["hItemsID"])
                {
                    frmItemsSearch f = new frmItemsSearch();
                    f.AddItemCallback = new frmItemsSearch.AddItemDelegate(this.SetItemsCallBack);
                    f.ShowDialog();
                    if (GStrCode != "")
                    {
                       // MessageBox.Show("keren bok");
                        dtGrid.Rows[e.RowIndex].Cells["hItemsID"].Value = GStrCode;
                        dtGrid.Rows[e.RowIndex].Cells["hDescription"].Value = GitemsDesc;
                        /*
                        DataSet dsDetail = new mitemsCRUD().getData(GStrCode);
                        if (dsDetail.Tables[0].Rows.Count > 0)
                        {
                            DataGridViewComboBoxCell dtgCol = dtGrid.Rows[e.RowIndex].Cells["hItemsID"] as DataGridViewComboBoxCell;
                            dtgCol.DataSource = dsDetail.Tables[0];
                            dtgCol.DisplayMember = "DESCRIPTION";
                            dtgCol.ValueMember = "ITEMSID";

                        }
                         * */


                    }
                }
            
            
            //untuk costing
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex] == dtGrid.Columns["hCostingNo"])
            {
                    GStrCode = "";
                    frmcostingSearch f = new frmcostingSearch();
                    f.AddItemCallback = new frmcostingSearch.AddCostingDelegate(this.SetCostingCallBack);
                    f.ShowDialog();
                    if (GStrCode != "")
                    {

                        dtGrid.Rows[e.RowIndex].Cells["hCostingNo"].Value = GStrCode;
                        DataSet dsDetail = new costingdetailCRUD().getData(GStrCode);
                        if (dsDetail.Tables[0].Rows.Count > 0)
                        {
                            //DataGridViewComboBoxColumn CostingID = dtGrid.Columns["hCostingID"] as DataGridViewComboBoxColumn;//new DataGridViewComboBoxColumn();
                            //CostingID.DataSource = dsDetail.Tables[0];
                            //CostingID.DisplayMember = "DESCRIPTION";
                            //CostingID.ValueMember = "ID";
                            DataGridViewComboBoxCell dtgCol=dtGrid.Rows[e.RowIndex].Cells["hCostingID"] as DataGridViewComboBoxCell;
                           // dtgCol.Items.Add("comboitem1");
                            //dtgCol.Items.Add("comboitem2");
                            dtgCol.DataSource = dsDetail.Tables[0];
                            dtgCol.DisplayMember = "DESCRIPTION";
                            dtgCol.ValueMember = "ID";
                            //dtGrid.Rows[e.RowIndex].Cells["hCostingID"].Value
                        }
                       // else { dtGrid.Rows[e.RowIndex].Cells["hCostingID"].Value = ""; }
                        //MessageBox.Show("wowowowwowow");
                    }

            }
        }


        private void SetItemsCallBack(string ItemsID,string ItemsDesc)
        {
            //dtGrid.Rows[i].Cells["hPONO"].Value = CostingNo;
            GStrCode = ItemsID;
            GitemsDesc = ItemsDesc;
            
            //txtCategoryDesc.Text = categoryDesc;
        }
        private void SetCostingCallBack(string CostingNo)
        {
            //dtGrid.Rows[i].Cells["hPONO"].Value = CostingNo;
            GStrCode = CostingNo;
            //txtCategoryDesc.Text = categoryDesc;
        }

        private void dtGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dtGrid.Rows[e.RowIndex].IsNewRow)
            {
                dtGrid.Rows[e.RowIndex].HeaderCell.Value = "#";

                //
            }
            else if (dtGrid.Rows[e.RowIndex].HeaderCell.Value.ToString() == "V")
            {
                dtGrid.Rows[e.RowIndex].HeaderCell.Value = "E";
            }
        }

        private void dtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show("klik");
        }

        private void dtGrid_Click(object sender, EventArgs e)
        {

        }

        private void dtGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private void HapusTSB_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSupplierSearch f = new frmSupplierSearch();
            f.AddItemCallback = new frmSupplierSearch.AddSupplierDelegate(this.SetDeliverCallBack);
            f.ShowDialog();

        }
        private void SetDeliverCallBack(string CustID, string CustDesc)
        {
            txtDeliveryTo.Text = CustID;
            txtDeliveryToDesc.Text = CustDesc;

        }

        private void Print_Click(object sender, EventArgs e)
        {
            DataSet data = new purchaseCRUD().prPONO(txtPONO.Text);
            Application.DoEvents();
            data.WriteXml("C:\\MyGarmentReport\\pono.xml", XmlWriteMode.WriteSchema);
            //data.WriteXmlSchema(Application.StartupPath + "\\costing.xsd");
            //data.WriteXmlSchema(Application.StartupPath + "\\costing1.xml");
            Form f = new PrintPO();
            //f.MdiParent = MainMenu.ActiveForm;
            f.Show();
        }

        private void dateDue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dtGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if ( e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex] == dtGrid.Columns["hConvert"])
            {
                float Conver= 0 ;
                float QtyPurchse = 0;
                float PricePurchase = 0;
                float Quantity = 0;
                float Price = 0;
                //MessageBox.Show("okey bero" + dtGrid.Rows[e.ColumnIndex].Cells["hConvert"].Value);
                Conver = (float)Convert.ToDouble(dtGrid.Rows[e.RowIndex].Cells["hConvert"].Value);
                QtyPurchse = (float)Convert.ToDouble(dtGrid.Rows[e.RowIndex].Cells["hQtyPurchase"].Value);
                PricePurchase = (float)Convert.ToDouble(dtGrid.Rows[e.RowIndex].Cells["hPricePurchase"].Value);

                Quantity = Conver * QtyPurchse;
                Price = (PricePurchase*QtyPurchse) / (Conver * QtyPurchse);
                dtGrid.Rows[e.RowIndex].Cells["hQuantity"].Value = Quantity;
                dtGrid.Rows[e.RowIndex].Cells["hPrice"].Value = Price;
                //dtGrid.Rows[e.ColumnIndex].Cells["hQuantity"].Value = Convert.ToSingle(dtGrid.Rows[e.ColumnIndex].Cells["hConvert"].Value) * Convert.ToSingle(dtGrid.Rows[e.ColumnIndex].Cells["hQtyPurchase"].Value);


            }

            if (e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex] == dtGrid.Columns["hUOM"])
            {
                float Conver = 0;
                float QtyPurchse = 0;
                float PricePurchase = 0;
                float Quantity = 0;
                float Price = 0;
                string UOM,UOMPurchase = "";
                UOM = dtGrid.Rows[e.RowIndex].Cells["hUOM"].Value.ToString();
                UOMPurchase = dtGrid.Rows[e.RowIndex].Cells["hUOMPurchase"].Value.ToString();

                DataSet dsConvert = new mconvertCRUD().getData(UOM, UOMPurchase);
                if (dsConvert.Tables[0].Rows.Count > 0)
                {
                    Conver = (float)Convert.ToDouble(dsConvert.Tables[0].Rows[0]["CONVER"]);
                    // MessageBox.Show("test");
                    //Conver = (float)Convert.ToDouble(dtGrid.Rows[e.RowIndex].Cells["hConvert"].Value);
                    QtyPurchse = (float)Convert.ToDouble(dtGrid.Rows[e.RowIndex].Cells["hQtyPurchase"].Value);
                    PricePurchase = (float)Convert.ToDouble(dtGrid.Rows[e.RowIndex].Cells["hPricePurchase"].Value);

                    Quantity = Conver * QtyPurchse;
                    Price = (PricePurchase * QtyPurchse) / (Conver * QtyPurchse);
                    dtGrid.Rows[e.RowIndex].Cells["hQuantity"].Value = Quantity;
                    dtGrid.Rows[e.RowIndex].Cells["hPrice"].Value = Price;
                    dtGrid.Rows[e.RowIndex].Cells["hConvert"].Value = Conver;
                }

            }

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

            DataSet dsSupplier = new mcustvendCRUD().getData(txtCustomerID.Text, "", "");
            if (dsSupplier.Tables[0].Rows.Count > 0)
            {
                txtCustomerDesc.Text = dsSupplier.Tables[0].Rows[0]["NAME"].ToString();
                txtAddress.Text = dsSupplier.Tables[0].Rows[0]["ADDRESS"].ToString();

            }
        }

        private void txtDeliveryTo_TextChanged(object sender, EventArgs e)
        {
            DataSet dsSupplier = new mcustvendCRUD().getData(txtDeliveryTo.Text, "", "");
            if (dsSupplier.Tables[0].Rows.Count > 0)
            {
                txtDeliveryToDesc.Text = dsSupplier.Tables[0].Rows[0]["NAME"].ToString();
                txtAddresTo.Text = dsSupplier.Tables[0].Rows[0]["ADDRESS"].ToString();

            }
        }

        private void cbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsKurs = new mrateCRUD().getData(cbCurrency.Text);

            if (dsKurs.Tables[0].Rows.Count > 0)
            {
                txtKurs.Text = dsKurs.Tables[0].Rows[0]["KURS"].ToString();

            }
        }

        private void cmdCekbudget_Click(object sender, EventArgs e)
        {
            frmPurchaseCekBudget f = new frmPurchaseCekBudget();
            //f.AddItemCallback = new frmPurchaseCekBudget.PONO=;
            f.PONO = txtPONO.Text;
            f.ShowDialog();
            
            if (GStrCode != "")
            {
                //MessageBox.Show(GStrCode);
            }

        }

        private void frmPurchase_Shown(object sender, EventArgs e)
        {
            DataSet dsModulUser = new moduluserCRUD().findData(GlobalVariables.GUserID, "Purchasing");
            if (dsModulUser.Tables[0].Rows.Count > 0)
            {
                if (Convert.ToInt32(dsModulUser.Tables[0].Rows[0]["SEE"]) == 0)
                {
                    MessageBox.Show("You Not Allowed this Modul");
                    this.Dispose();

                }
                else
                {

                }

            }
            else
            {
                MessageBox.Show("You Not Allowed this Modul");
                this.Dispose();
            }
        }

       


    }
}
