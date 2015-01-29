using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using MyGarment.ClassMD;
using MyGarment.ViewMaster;
using MyGarment.ViewSearch;
using MyGarment.ClassMaster;
using MyGarment.PrintMD;
using MyGarment.ClassFile;

namespace MyGarment.ViewMD
{
    public partial class frmjoborder : Form
    {
        DateTimePicker dtp = new DateTimePicker();  //DateTimePicker  
        //Rectangle _Rectangle;  

        private string GStrCode = "";

        public frmjoborder()
        {
            InitializeComponent();
            /*
            dtGrid.Controls.Add(dtp);  //DataGridView  
            dtp.Visible = false;  //  
            dtp.Format = DateTimePickerFormat.Custom;  //2010-08-05  
            dtp.TextChanged += new EventHandler(dtp_TextChange); //dtp_TextChange  
             */
        }

        /*****************************/
        private void dtp_TextChange(object sender, EventArgs e)
        {
            //dtGrid.CurrentCell.Value = dtp.Text.ToString();  //?  
        }

        /****************?*******************/  
        private void cmdCategory_Click(object sender, EventArgs e)
        {
            frmmcategorySearch f = new frmmcategorySearch();
            f.AddItemCallback = new frmmcategorySearch.AddCategoryDelegate(this.SetCategoryCallBack);
            f.ShowDialog();
        }
        private void SetCategoryCallBack(string categoryID, string categoryDesc)
        {
            txtCategoryID.Text = categoryID;
            txtCategoryDesc.Text = categoryDesc;

        }

        private void frmjoborder_Load(object sender, EventArgs e)
        {
            DataSet dsType = new mtypeCRUD().getData();
            DataSet dsDIV = new mdivCRUD().getData();
            DataSet dsColor = new mcolorCRUD().getData();
            DataSet dsSize = new msizeCRUD().getData();
            //teat
            // dtGrid.HeaderCell.Columns["hSizeID"].HeaderCell = datagridViewCheckBoxHeaderCell;
            SimpanTSB.Enabled = true;
            UbahTSB.Enabled = false;
            dtGrid.Enabled = true;

            cbTypeID.DataSource = dsType.Tables[0];
            cbTypeID.DisplayMember = "DESCRIPTION";
            cbTypeID.ValueMember = "TYPEID";

            cbDIV.DataSource = dsDIV.Tables[0];
            cbDIV.DisplayMember = "DESCRIPTION";
            cbDIV.ValueMember = "DIVID";
            DataGridViewComboBoxColumn SizeID = dtGrid.Columns["hSizeID"] as DataGridViewComboBoxColumn;
            DataGridViewComboBoxColumn ColorID = dtGrid.Columns["hColorID"] as DataGridViewComboBoxColumn;

            SizeID.DataSource = dsSize.Tables[0];
            SizeID.DisplayMember = "DESCRIPTION";
            SizeID.ValueMember = "SIZEID";

            ColorID.DataSource = dsColor.Tables[0];
            ColorID.DisplayMember = "DESCRIPTION";
            ColorID.ValueMember = "COLORID";


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
        private void load_data(string JONO)
        {
            DataSet dsHeader = new joborderCRUD().getData(JONO);
            
            txtCostingNo.Text = JONO;
            cbDIV.SelectedValue = dsHeader.Tables[0].Rows[0]["GDIV"].ToString();
            cbTypeID.SelectedValue = dsHeader.Tables[0].Rows[0]["TYPEID"].ToString();
            txtQty.Text = dsHeader.Tables[0].Rows[0]["QUANTITY"].ToString();
            txtCustomerID.Text = dsHeader.Tables[0].Rows[0]["CUSTVENDCODE"].ToString();
            txtStyleID.Text = dsHeader.Tables[0].Rows[0]["ITEMSID"].ToString();
            txtCategoryID.Text = dsHeader.Tables[0].Rows[0]["CATEGORYID"].ToString();
            dateCreated.Value = (DateTime)dsHeader.Tables[0].Rows[0]["DATE"];
            txtPOCustomer.Text = dsHeader.Tables[0].Rows[0]["POCUSTOMER"].ToString();
            txtRemarks.Text = dsHeader.Tables[0].Rows[0]["REMARKS"].ToString();
            txtWash.Text = dsHeader.Tables[0].Rows[0]["WASH"].ToString();
            DataSet dsDetail = new joborderdetailCRUD().getData(JONO);
            dtGrid.Rows.Clear();
            for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                {
                    dtGrid.Rows.Add();
                    dtGrid.Rows[i].HeaderCell.Value = "V";
                    dtGrid.Rows[i].Cells["hOrderNo"].Value = dsDetail.Tables[0].Rows[i]["ORDERNO"].ToString();
                    dtGrid.Rows[i].Cells["hPOCustomer"].Value = dsDetail.Tables[0].Rows[i]["POCUSTOMER"].ToString();
                    dtGrid.Rows[i].Cells["hColorID"].Value = dsDetail.Tables[0].Rows[i]["COLORID"].ToString();
                    dtGrid.Rows[i].Cells["hSizeID"].Value = dsDetail.Tables[0].Rows[i]["SIZEID"].ToString();
                    dtGrid.Rows[i].Cells["hNoUrut"].Value = dsDetail.Tables[0].Rows[i]["NOURUT"].ToString();
                    dtGrid.Rows[i].Cells["hAllowance"].Value = dsDetail.Tables[0].Rows[i]["ALLOWANCE"].ToString();
                    dtGrid.Rows[i].Cells["hQuantity"].Value = dsDetail.Tables[0].Rows[i]["QUANTITY"].ToString();
                    dtGrid.Rows[i].Cells["hCuttingQty"].Value = dsDetail.Tables[0].Rows[i]["CUTTINGQTY"].ToString();
                    dtGrid.Rows[i].Cells["hDestination"].Value = dsDetail.Tables[0].Rows[i]["DESTINATION"].ToString();
                    //dt = dsDetail.Tables[0].Rows[i]["DELIVERY"].;
                    dtGrid.Rows[i].Cells["hDelivery"].Value = Convert.ToDateTime(dsDetail.Tables[0].Rows[i]["DELIVERY"]).ToString("dd/MM/yyyy");

                }
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            frmjoborderSearch f = new frmjoborderSearch();
            f.AddItemCallback = new frmjoborderSearch.AddCostingDelegate(this.SetCostingCallBack);
            f.ShowDialog();
            if (GStrCode != "")
            {
                load_data(GStrCode);

                SimpanTSB.Enabled = false;
                UbahTSB.Enabled = true;
                dtGrid.Enabled = true;
            }
            /*
            if (GStrCode != "")
            {
                DataSet dsHeader = new joborderCRUD().getData(GStrCode);
                txtCostingNo.Text = GStrCode;
                cbDIV.SelectedValue = dsHeader.Tables[0].Rows[0]["GDIV"].ToString();
                cbTypeID.SelectedValue = dsHeader.Tables[0].Rows[0]["TYPEID"].ToString();
                txtQty.Text = dsHeader.Tables[0].Rows[0]["QUANTITY"].ToString();
                txtCustomerID.Text = dsHeader.Tables[0].Rows[0]["CUSTVENDCODE"].ToString();
                txtStyleID.Text = dsHeader.Tables[0].Rows[0]["ITEMSID"].ToString();
                txtCategoryID.Text = dsHeader.Tables[0].Rows[0]["CATEGORYID"].ToString();
                dateCreated.Value = (DateTime)dsHeader.Tables[0].Rows[0]["DATE"];
                txtPOCustomer.Text = dsHeader.Tables[0].Rows[0]["POCUSTOMER"].ToString();
                txtRemarks.Text = dsHeader.Tables[0].Rows[0]["REMARKS"].ToString();
                txtWash.Text = dsHeader.Tables[0].Rows[0]["WASH"].ToString();

                //isi detail
                DataSet dsDetail = new joborderdetailCRUD().getData(GStrCode);
                // var index = dtGrid.Rows.Add();
                dtGrid.Rows.Clear();
                for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                {
                    dtGrid.Rows.Add();
                    dtGrid.Rows[i].HeaderCell.Value = "V";
                    dtGrid.Rows[i].Cells["hOrderNo"].Value = dsDetail.Tables[0].Rows[i]["ORDERNO"].ToString();
                    //dtGrid.Rows[i].Cells["hOrderNo1"].Value = dsDetail.Tables[0].Rows[i]["ORDERNO"].ToString();
                    dtGrid.Rows[i].Cells["hPOCustomer"].Value = dsDetail.Tables[0].Rows[i]["POCUSTOMER"].ToString();
                   // dtGrid.Rows[i].Cells["hPOCustomer1"].Value = dsDetail.Tables[0].Rows[i]["POCUSTOMER"].ToString();
                    dtGrid.Rows[i].Cells["hColorID"].Value = dsDetail.Tables[0].Rows[i]["COLORID"].ToString();
                   // dtGrid.Rows[i].Cells["hColorID1"].Value = dsDetail.Tables[0].Rows[i]["COLORID"].ToString();
                    dtGrid.Rows[i].Cells["hSizeID"].Value = dsDetail.Tables[0].Rows[i]["SIZEID"].ToString();
                   // dtGrid.Rows[i].Cells["hSizeID1"].Value = dsDetail.Tables[0].Rows[i]["SIZEID"].ToString();
                    dtGrid.Rows[i].Cells["hNoUrut"].Value = dsDetail.Tables[0].Rows[i]["NOURUT"].ToString();
                    dtGrid.Rows[i].Cells["hAllowance"].Value = dsDetail.Tables[0].Rows[i]["ALLOWANCE"].ToString();
                    dtGrid.Rows[i].Cells["hQuantity"].Value = dsDetail.Tables[0].Rows[i]["QUANTITY"].ToString();
                    dtGrid.Rows[i].Cells["hCuttingQty"].Value = dsDetail.Tables[0].Rows[i]["CUTTINGQTY"].ToString();

                    dtGrid.Rows[i].Cells["hDestination"].Value = dsDetail.Tables[0].Rows[i]["DESTINATION"].ToString();
                    dtGrid.Rows[i].Cells["hDelivery"].Value = dsDetail.Tables[0].Rows[i]["DELIVERY"].ToString();

                }
                SimpanTSB.Enabled = false;
                UbahTSB.Enabled = true;
                dtGrid.Enabled = true;
            }
             */
        }
        private void SetCostingCallBack(string CostingNo)
        {
            txtCostingNo.Text = CostingNo;
            GStrCode = CostingNo;
            //txtCategoryDesc.Text = categoryDesc;
        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            Generate gen = new Generate();
            txtCostingNo.Text = gen.genJO();
            joborder K = new joborder();
            K.ORDERNO = gen.genJO();
            DataRow selectedDataRow = ((DataRowView)cbTypeID.SelectedItem).Row;
            K.TYPEID = selectedDataRow["TYPEID"].ToString();
            DataRow selectedDIV = ((DataRowView)cbDIV.SelectedItem).Row;
            K.GDIV = selectedDIV["DIVID"].ToString();
            K.QUANTITY = Convert.ToInt32(txtQty.Text);
            K.CATEGORYID = txtCategoryID.Text;
            K.CUSTVENDCODE = txtCustomerID.Text;
            K.ITEMSID = txtStyleID.Text;
            K.DATE = dateCreated.Value;
            K.OFFICER = GlobalVariables.GUserID;
            K.POCUSTOMER = txtPOCustomer.Text;
            K.REMARKS = txtRemarks.Text;
            K.WASH = txtWash.Text;
            if ((txtCategoryID.Text == "") || (txtCustomerID.Text == ""))
            {
                MessageBox.Show("Isian Belum lengkap untuk category, style atau customer");
            }
            else if (new joborderCRUD().insertData(K))
            {
                joborderdetail k = new joborderdetail();
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {
                    k.ORDERNO = txtCostingNo.Text;
                    k.POCUSTOMER = Convert.ToString(dtGrid.Rows[i].Cells["hPOCustomer"].Value);
                    k.COLORID = Convert.ToString(dtGrid.Rows[i].Cells["hColorID"].Value);
                    k.SIZEID = Convert.ToString(dtGrid.Rows[i].Cells["hSizeID"].Value);
                    k.NOURUT = Convert.ToInt16(dtGrid.Rows[i].Cells["hNoUrut"].Value);
                    //dtGrid.Rows[i].Cells["hUOMPurchase"].Value == null ? null : dtGrid.Rows[i].Cells["hUOMPurchase"].Value.ToString();
                    //if (!dtGrid.Rows[i].Cells["hDelivery"].Value..HasValue)
                    k.DELIVERY = DateTime.Parse(dtGrid.Rows[i].Cells["hDelivery"].Value.ToString(), null);
                    k.QUANTITY = (float)Convert.ToDouble(dtGrid.Rows[i].Cells["hQuantity"].Value);
                    k.CUTTINGQTY = (float)Convert.ToDouble(dtGrid.Rows[i].Cells["hCuttingQty"].Value);
                    k.ALLOWANCE = (float)Convert.ToDouble(dtGrid.Rows[i].Cells["hAllowance"].Value);
                    k.DESTINATION = Convert.ToString(dtGrid.Rows[i].Cells["hDestination"].Value);

                    if (dtGrid.Rows[i].HeaderCell.Value.ToString() == "#")
                    { //insert
                        if (new joborderdetailCRUD().insertData(k))
                        {
                            dtGrid.Rows[i].HeaderCell.Value = "V";
                        }

                    }
                    else
                    {// update

                        if (new joborderdetailCRUD().updateData(k))
                        {
                            dtGrid.Rows[i].HeaderCell.Value = "V";
                        }
                        else
                        {
                            MessageBox.Show("gagal");
                        }
                    }

                }
                MessageBox.Show("Data berhasil di tambahkan");

                load_data(txtCostingNo.Text);
                SimpanTSB.Enabled = false;
                UbahTSB.Enabled = true;
                dtGrid.Enabled = true;

            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan");
            }
        }

        private void dtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dtGrid.Rows[e.RowIndex].IsNewRow)
            {
                dtGrid.Rows[e.RowIndex].HeaderCell.Value = "#";
            }
            else if (dtGrid.Rows[e.RowIndex].HeaderCell.Value.ToString() == "V")
            {
                dtGrid.Rows[e.RowIndex].HeaderCell.Value = "E";
            }


        }

        private void UbahTSB_Click(object sender, EventArgs e)
        {
            joborder K = new joborder();
            K.ORDERNO = txtCostingNo.Text;
            DataRow selectedDataRow = ((DataRowView)cbTypeID.SelectedItem).Row;
            K.TYPEID = selectedDataRow["TYPEID"].ToString();
            DataRow selectedDIV = ((DataRowView)cbDIV.SelectedItem).Row;
            K.GDIV = selectedDIV["DIVID"].ToString();
            K.QUANTITY = Convert.ToInt32(txtQty.Text);
            K.CATEGORYID = txtCategoryID.Text;
            K.CUSTVENDCODE = txtCustomerID.Text;
            K.ITEMSID = txtStyleID.Text;
            K.DATE = dateCreated.Value;
            //K.OFFICER = "";
            K.POCUSTOMER = txtPOCustomer.Text;
            K.REMARKS = txtRemarks.Text;
            K.WASH = txtWash.Text;
            if (new joborderCRUD().updateData(K))
            {
                joborderdetail k = new joborderdetail();
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {
                    k.ORDERNO = txtCostingNo.Text;
                    k.POCUSTOMER = Convert.ToString(dtGrid.Rows[i].Cells["hPOCustomer"].Value);
                    k.COLORID = Convert.ToString(dtGrid.Rows[i].Cells["hColorID"].Value);
                    k.SIZEID = Convert.ToString(dtGrid.Rows[i].Cells["hSizeID"].Value);
                    k.NOURUT = Convert.ToInt16(dtGrid.Rows[i].Cells["hNoUrut"].Value);
                    //dtGrid.Rows[i].Cells["hUOMPurchase"].Value == null ? null : dtGrid.Rows[i].Cells["hUOMPurchase"].Value.ToString();
                    //if (!dtGrid.Rows[i].Cells["hDelivery"].Value..HasValue)
                    k.DELIVERY = Convert.ToDateTime(dtGrid.Rows[i].Cells["hDelivery"].Value, new CultureInfo("id"));
                    k.QUANTITY = (float)Convert.ToDouble(dtGrid.Rows[i].Cells["hQuantity"].Value);
                    k.CUTTINGQTY = (float)Convert.ToDouble(dtGrid.Rows[i].Cells["hCuttingQty"].Value);
                    k.ALLOWANCE = (float)Convert.ToDouble(dtGrid.Rows[i].Cells["hAllowance"].Value);
                    k.DESTINATION = Convert.ToString(dtGrid.Rows[i].Cells["hDestination"].Value);

                    if (dtGrid.Rows[i].HeaderCell.Value.ToString() == "#")
                    { //insert
                        if (new joborderdetailCRUD().insertData(k))
                        {
                            dtGrid.Rows[i].HeaderCell.Value = "V";
                        }

                    }
                    else
                    {// update

                        if (new joborderdetailCRUD().updateData(k))
                        {
                            dtGrid.Rows[i].HeaderCell.Value = "V";
                        }
                        else
                        {
                            MessageBox.Show("gagal");
                        }
                    }

                }
                MessageBox.Show("Update Sukses");
                load_data(txtCostingNo.Text);
            }
            else
            {
                MessageBox.Show("Data gagal update");
            }

        }

        private void Print_Click(object sender, EventArgs e)
        {
            DataSet data = new joborderCRUD().prJobOrder(txtCostingNo.Text);
            Application.DoEvents();
            data.WriteXml("C:\\MyGarmentReport\\joborder.xml", XmlWriteMode.WriteSchema);
            Form f = new PrintJO();
            f.Show();
        }

        private void txtCategoryID_TextChanged(object sender, EventArgs e)
        {
            DataSet dsCatergory = new mcategoryCRUD().getData(txtCategoryID.Text);
            if (dsCatergory.Tables[0].Rows.Count > 0)
            {
                txtCategoryDesc.Text = dsCatergory.Tables[0].Rows[0]["DESCRIPTION"].ToString();
            }
        }

        private void txtStyleID_TextChanged(object sender, EventArgs e)
        {
            DataSet dsStyle = new mitemsCRUD().getData(txtStyleID.Text);
            if (dsStyle.Tables[0].Rows.Count > 0)
            {
                txtStyleDesc.Text = dsStyle.Tables[0].Rows[0]["DESCRIPTION"].ToString();
            }
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            DataSet dsSupplier = new mcustvendCRUD().getData(txtCustomerID.Text, "", "");
            txtCustomerDesc.Text = dsSupplier.Tables[0].Rows[0]["NAME"].ToString();
        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGrid.Rows[e.RowIndex];
                dtGrid.Rows[e.RowIndex].Cells["hCuttingQty"].Value = (Convert.ToSingle(dtGrid.Rows[e.RowIndex].Cells["hQuantity"].Value) + (Convert.ToSingle(dtGrid.Rows[e.RowIndex].Cells["hQuantity"].Value) * Convert.ToSingle(dtGrid.Rows[e.RowIndex].Cells["hAllowance"].Value) / 100));

            }
        }

        private void HapusTSB_Click(object sender, EventArgs e)
        {
            if (dtGrid.RowCount < 0)
            {
                if (new joborderCRUD().deleteData(txtCostingNo.Text))
                {
                    MessageBox.Show(" Job oder telah di hapus ");
                    load_data(txtCostingNo.Text);
                }

            }
            else //delete detail
            {
                joborderdetail k = new joborderdetail();
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {
                    k.ORDERNO = txtCostingNo.Text;
                    k.POCUSTOMER = Convert.ToString(dtGrid.Rows[i].Cells["hPOCustomer"].Value);
                    k.COLORID = Convert.ToString(dtGrid.Rows[i].Cells["hColorID"].Value);
                    k.SIZEID = Convert.ToString(dtGrid.Rows[i].Cells["hSizeID"].Value);
                    k.NOURUT = Convert.ToInt16(dtGrid.Rows[i].Cells["hNoUrut"].Value);
                    k.DELIVERY = Convert.ToDateTime(dtGrid.Rows[i].Cells["hDelivery"].Value);
                    k.QUANTITY = (float)Convert.ToDouble(dtGrid.Rows[i].Cells["hQuantity"].Value);
                    k.CUTTINGQTY = (float)Convert.ToDouble(dtGrid.Rows[i].Cells["hCuttingQty"].Value);
                    k.ALLOWANCE = (float)Convert.ToDouble(dtGrid.Rows[i].Cells["hAllowance"].Value);
                    k.DESTINATION = Convert.ToString(dtGrid.Rows[i].Cells["hDestination"].Value);
                    
                    if (Convert.ToInt32(dtGrid.Rows[i].Cells["hDelRow"].Value)==1)
                    {
                        if (new joborderdetailCRUD().deleteData(k.ORDERNO, k.POCUSTOMER, k.COLORID, k.SIZEID))
                        {
                            dtGrid.Rows.RemoveAt(i);
                        }
                    }

                }
                load_data(txtCostingNo.Text);
            }
            
        }

        private void dtGrid_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            //dtp.Visible = false;  
        }

        private void dtGrid_Scroll(object sender, ScrollEventArgs e)
        {
           // dtp.Visible = true;  
        }

        private void dtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {/*
            if (e.ColumnIndex == 6)
            {
                _Rectangle = dtGrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                dtp.Visible = true;  //  
            }
            else
                dtp.Visible = false;  
          */ 
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmjoborder_Shown(object sender, EventArgs e)
        {
            DataSet dsModulUser = new moduluserCRUD().findData(GlobalVariables.GUserID, "Job Order");
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
