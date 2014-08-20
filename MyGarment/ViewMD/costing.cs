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
//using MyGarment.

namespace MyGarment.ViewMD
{
    public partial class frmcosting : Form
    {
        private string GStrCode="";
        DataSet dsCost = new mcostCRUD().getData();
        DataSet dsCurrency = new mcurrencyCRUD().getData();
        DataSet dsUOM = new muomCRUD().getData();
        DataSet dsType = new mtypeCRUD().getData();
        DataSet dsDIV = new mdivCRUD().getData();
        //DataSet dsDIV=new 
 
        
        public frmcosting()
        {
            InitializeComponent();
        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            // save costing header
            //txtCostingNo=genCos
            Generate gen = new Generate();
            txtCostingNo.Text = gen.genCosting();
            costing K = new costing();
            K.COSTINGNO = txtCostingNo.Text;
            DataRow selectedDataRow = ((DataRowView)cbTypeID.SelectedItem).Row;
            K.TYPEID = selectedDataRow["TYPEID"].ToString();
            DataRow selectedDIV = ((DataRowView)cbDIV.SelectedItem).Row;
            K.GDIV = selectedDIV["DIVID"].ToString();
            K.QTYORDER = Convert.ToInt32(txtQty.Text);
            K.CATEGORYID = txtCategoryID.Text;
            K.CUSTVENDCODE = txtCustomerID.Text;
            K.ITEMSID = txtStyleID.Text;
            K.DATE = dateCreated.Value;
            K.VALUEIN = cbValueIn.Text;
            if ((txtCategoryID.Text=="") || (txtCustomerID.Text=="")) 
            {
                MessageBox.Show("Isian Belum lengkap untuk category, style atau customer");
            }else  if (new costingCRUD().insertData(K))
            {
                MessageBox.Show("Data berhasil di tambahkan");
                SimpanTSB.Enabled = false; 
               // Binding();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan");
            }
        }

        private void frmcosting_Load(object sender, EventArgs e)
        {


            cbTypeID.DataSource=dsType.Tables[0];
            cbTypeID.DisplayMember = "DESCRIPTION";
            cbTypeID.ValueMember="TYPEID";

            cbDIV.DataSource = dsDIV.Tables[0];
            cbDIV.DisplayMember = "DESCRIPTION";
            cbDIV.ValueMember = "DIVID";

            cbValueIn.DataSource = dsCurrency.Tables[0];
            cbValueIn.DisplayMember = "CURRENCYID";
            cbValueIn.ValueMember = "CURRENCYID";

            DataGridViewComboBoxColumn CostType = dtGrid.Columns["hCostType"] as DataGridViewComboBoxColumn;//new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn Uom = dtGrid.Columns["hUom"] as DataGridViewComboBoxColumn;
            DataGridViewComboBoxColumn Currency = dtGrid.Columns["hCurrency"] as DataGridViewComboBoxColumn;
            CostType.DataSource = dsCost.Tables[0];
            CostType.DisplayMember = "DESCRIPTION";
            CostType.ValueMember = "COSTID";

            Uom.DataSource = dsUOM.Tables[0];
            Uom.DisplayMember = "DESCRIPTION";
            Uom.ValueMember = "UOMID";

            Currency.DataSource = dsCurrency.Tables[0];
            Currency.DisplayMember = "CURRENCYID";
            Currency.ValueMember = "CURRENCYID";
            
        }

   

        private void RecordTSB_Click(object sender, EventArgs e)
        {
           // frmcostingSearch f =new frmcostingSearch();
           // f.ShowDialog();
           // txtCostingNo.Text = "test";
            //txtCategoryDesc.Text = "test";
            frmcostingSearch f = new frmcostingSearch();
            f.AddItemCallback = new frmcostingSearch.AddCostingDelegate(this.SetCostingCallBack);
            f.ShowDialog();
            //txtCostingNo.Text
            if (GStrCode != "")
            {
                //isi costing header
                //txtCostingNo.Text = GStrCode;
                DataSet dsHeader = new costingCRUD().getData(GStrCode);
                //DtGrid.DataSource = data;
                //DtGrid.DataMember = "tblmcustvend";
                txtCostingNo.Text = GStrCode;
                cbDIV.SelectedValue = dsHeader.Tables[0].Rows[0]["GDIV"].ToString();
                cbTypeID.SelectedValue = dsHeader.Tables[0].Rows[0]["TYPEID"].ToString();
                txtQty.Text = dsHeader.Tables[0].Rows[0]["QTYORDER"].ToString();
                txtCustomerID.Text = dsHeader.Tables[0].Rows[0]["CUSTVENDCODE"].ToString();
                txtStyleID.Text = dsHeader.Tables[0].Rows[0]["ITEMSID"].ToString();
                txtCategoryID.Text = dsHeader.Tables[0].Rows[0]["CATEGORYID"].ToString();
                txtKurs.Text=dsHeader.Tables[0].Rows[0]["KURS"].ToString();
                cbValueIn.Text = dsHeader.Tables[0].Rows[0]["VALUEIN"].ToString();
                //dateCreated.Value = dsHeader.Tables[0].Columns["QTYORDER"]
                //txtQty
                //isi detail
                DataSet dsDetail = new costingdetailCRUD().getData(GStrCode);
               // var index = dtGrid.Rows.Add();
                dtGrid.Rows.Clear();
                for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                {
                    dtGrid.Rows.Add();
                    dtGrid.Rows[i].HeaderCell.Value = "V";
                    dtGrid.Rows[i].Cells["hCostingNo"].Value = dsDetail.Tables[0].Rows[i]["COSTINGNO"].ToString();
                    dtGrid.Rows[i].Cells["hID"].Value=dsDetail.Tables[0].Rows[i]["ID"].ToString();
                    dtGrid.Rows[i].Cells["hAllowance"].Value=dsDetail.Tables[0].Rows[i]["ALLOWANCE"].ToString();
                    dtGrid.Rows[i].Cells["hAmount"].Value=dsDetail.Tables[0].Rows[i]["AMOUNT"].ToString();
                    dtGrid.Rows[i].Cells["hConsumption"].Value=dsDetail.Tables[0].Rows[i]["CONSUMPTION"].ToString();
                    dtGrid.Rows[i].Cells["hCostType"].Value=dsDetail.Tables[0].Rows[i]["COSTID"].ToString();
                    
                    dtGrid.Rows[i].Cells["hCurrency"].Value=dsDetail.Tables[0].Rows[i]["CURRENCY"].ToString();
                    dtGrid.Rows[i].Cells["hDescription"].Value=dsDetail.Tables[0].Rows[i]["DESCRIPTION"].ToString();
                    dtGrid.Rows[i].Cells["hKurs"].Value=dsDetail.Tables[0].Rows[i]["KURS"].ToString();
                    dtGrid.Rows[i].Cells["hPrice"].Value=dsDetail.Tables[0].Rows[i]["PRICE"].ToString();
                    dtGrid.Rows[i].Cells["hUOM"].Value=dsDetail.Tables[0].Rows[i]["UOMID"].ToString();
                    dtGrid.Rows[i].Cells["hUsage"].Value=dsDetail.Tables[0].Rows[i]["USAG"].ToString();
                    dtGrid.Rows[i].Cells["hWidth"].Value = dsDetail.Tables[0].Rows[i]["WIDTH"].ToString(); 
  
                }
                //dtGrid.DataSource = dsDetail;
                //dtGrid.DataMember = "tblcostingdetail";
            }



            



        }
        private void SetCostingCallBack(string CostingNo)
        {
            txtCostingNo.Text = CostingNo;
            GStrCode = CostingNo;
            //txtCategoryDesc.Text = categoryDesc;
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
            f.AddItemCallback = new frmCustomerSearch.AddCustomerDelegate(this.SetCustomerCallBack);
            f.ShowDialog();

        }
        private void SetCustomerCallBack(string CustID, string CustDesc)
        {
            txtCustomerID.Text = CustID;
            txtCustomerDesc.Text = CustDesc;

        }

     

        private void dtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
                    
            if (dtGrid.Rows[e.RowIndex].IsNewRow)
            {
                dtGrid.Rows[e.RowIndex].HeaderCell.Value = "#";
            } else if(dtGrid.Rows[e.RowIndex].HeaderCell.Value.ToString() == "V")
            {
                dtGrid.Rows[e.RowIndex].HeaderCell.Value = "E";
            }

            
        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {  /*
            if (dtGrid.Columns[e.ColumnIndex].Name == "Description")
            {
                if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dtGrid.Rows[e.RowIndex].ErrorText =
                        "Price must not be empty";
                    e.Cancel = true;
                }
            }
            */ 
             
            /*
            dtGrid.Rows[e.RowIndex].ErrorText= "";
            if (dtGrid.Columns[e.ColumnIndex].Name == "ID")
            {
                int newInteger;
                if (!int.TryParse(e.FormattedValue.ToString(), out newInteger) || newInteger < 0)
                {
                    e.Cancel = true;
                    dtGrid.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
                }
            }
           */
        }

        private void UbahTSB_Click(object sender, EventArgs e)
        {
            costing K = new costing();
            K.COSTINGNO = txtCostingNo.Text;
            DataRow selectedDataRow = ((DataRowView)cbTypeID.SelectedItem).Row;
            K.TYPEID = selectedDataRow["TYPEID"].ToString();
            DataRow selectedDIV = ((DataRowView)cbDIV.SelectedItem).Row;
            K.GDIV = selectedDIV["DIVID"].ToString();
            K.QTYORDER = Convert.ToInt32(txtQty.Text);
            K.CATEGORYID = txtCategoryID.Text;
            K.CUSTVENDCODE = txtCustomerID.Text;
            K.ITEMSID = txtStyleID.Text;
            K.DATE = dateCreated.Value;
            K.KURS = (float)Convert.ToDouble(txtKurs.Text);
            K.VALUEIN = cbValueIn.Text;

            if (new costingCRUD().updateData(K))
            {
               // MessageBox.Show("Update sukses");
                //SimpanTSB.Enabled = false;
                // Binding();
                costingdetail k = new costingdetail();
                //dtGrid.BeginEdit(true);
                //dtGrid.Refresh();
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {
                    k.COSTINGNO = txtCostingNo.Text;
                    k.ID = Convert.ToInt32(dtGrid.Rows[i].Cells["hID"].Value);
                    k.ALLOWANCE = Convert.ToSingle(dtGrid.Rows[i].Cells["hAllowance"].Value);
                    k.AMOUNT = Convert.ToSingle(dtGrid.Rows[i].Cells["hAmount"].Value);
                    //k.APPROVE = "";
                    //k.APPROVEBY = "";
                    k.CONSUMPTION = Convert.ToSingle(dtGrid.Rows[i].Cells["hConsumption"].Value);
                    k.COSTID = Convert.ToString(dtGrid.Rows[i].Cells["hCostType"].Value); 
                    //k.COSTINGNO = Convert.ToString(dtGrid.Rows[i].Cells["ALLOWANCE"].Value);
                    k.CURRENCY = Convert.ToString(dtGrid.Rows[i].Cells["hCurrency"].Value);
                    k.DESCRIPTION = Convert.ToString(dtGrid.Rows[i].Cells["hDescription"].Value);
                   // k.ID = i+1;
                    k.KURS = Convert.ToSingle(dtGrid.Rows[i].Cells["hKurs"].Value);
                    k.PRICE = Convert.ToSingle(dtGrid.Rows[i].Cells["hPrice"].Value);
                    k.UOMID = Convert.ToString(dtGrid.Rows[i].Cells["hUOM"].Value);
                    k.USAG = Convert.ToString(dtGrid.Rows[i].Cells["hUsage"].Value);
                    k.WIDTH = Convert.ToString(dtGrid.Rows[i].Cells["hWidth"].Value); 
                    
                    if (dtGrid.Rows[i].HeaderCell.Value.ToString()=="#") {
                        k.ID = i+1;
                        if (new costingdetailCRUD().insertData(k))
                        {
                         
                            // MessageBox.Show("Data berhasil di tambahkan");
                            // Binding();
                            dtGrid.Rows[i].HeaderCell.Value = "V";
                        }
                        else
                        {
                            // MessageBox.Show("Data gagal ditambahkan");
                            //dtGrid.Rows[i].Cells["Check"].Value = "ER";
                           // dtGrid.Rows[i].HeaderCell.Value = "X";
                        }
                    }
                    else if (dtGrid.Rows[i].HeaderCell.Value.ToString() == "E")// udapte
                    {
                        if (new costingdetailCRUD().updateData(k))
                        {
                            // MessageBox.Show("Data berhasil di tambahkan");
                            // Binding();
                            dtGrid.Rows[i].HeaderCell.Value = "V";
                        }
                        else
                        {
                            // MessageBox.Show("Data gagal ditambahkan");
                            //dtGrid.Rows[i].Cells["Check"].Value = "ER";
                            // dtGrid.Rows[i].HeaderCell.Value = "X";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Update gagal");
            }

        }

        private void dtGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGrid.Rows[e.RowIndex];
                //txtCategoryID.Text = row.Cells[0].Value.ToString();
                dtGrid.Rows[e.RowIndex].Cells["hAmount"].Value = Convert.ToSingle(dtGrid.Rows[e.RowIndex].Cells["hConsumption"].Value) * Convert.ToSingle(dtGrid.Rows[e.RowIndex].Cells["hPrice"].Value);

            }
            
           // int i = dtGrid.CurrentRow.Index;
            //dtGrid.Rows[i].Cells["hAmount"].Value = Convert.ToSingle(dtGrid.Rows[i].Cells["hConsumption"].Value) * Convert.ToSingle(dtGrid.Rows[i].Cells["hConsumption"].Value);

            //'to
        }

        private void dtGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            if (e.ColumnIndex == 1)
            {
                bool validation = true;
                if (dtGrid.Rows[RowIndex].Cells[columnIndex].Value != null && dtGrid.Rows[RowIndex].Cells[columnIndex].Value.ToString().Trim() != "")
                {
                    string DataToValidate = dtGrid.Rows[RowIndex].Cells[columnIndex].Value.ToString();
                    foreach (char c in DataToValidate)
                    {
                        if (!char.IsDigit(c))
                        {
                            validation = false;
                            break;
                        }
                    }

                    if (validation == false)
                    {

                        dtGrid.Rows[RowIndex].Cells[columnIndex].ErrorText = "You Can Only Enter Number here ";
                        dtGrid.Rows[RowIndex].Cells[columnIndex].Value = "";

                    }
                }

            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            DataSet data = new costingCRUD().prCosting(txtCostingNo.Text);
            //Application.DoEvents();
            data.WriteXml(Application.StartupPath + "\\costing.xml",XmlWriteMode.WriteSchema);
            //data.WriteXmlSchema(Application.StartupPath + "\\costing.xsd");
            //data.WriteXmlSchema(Application.StartupPath + "\\costing1.xml");
            Form f = new PrintCosting();
            //f.MdiParent = MainMenu.ActiveForm;
            f.Show();
        }

    }
}
