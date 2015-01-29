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
using MyGarment._1Global;
using MyGarment.ClassFile;

namespace MyGarment.ViewMD
{
    
    public partial class frmbom : Form
    {


        private string GStrCode = "";
        private string GitemsDesc = "";

        private string GCostingNo = "";
        private int GID = 0;
        private float Allowance = 0;
        private float Consumption = 0;

        public frmbom()
        {
            InitializeComponent();
        }
        private void load_data(string CostingNo)
        {
            DataSet dsHeader = new costingCRUD().getData(CostingNo);
            txtCostingNo.Text = CostingNo;
            txtCustomerID.Text = dsHeader.Tables[0].Rows[0]["CUSTVENDCODE"].ToString();
            txtStyleID.Text = dsHeader.Tables[0].Rows[0]["ITEMSID"].ToString();
            txtCategoryID.Text = dsHeader.Tables[0].Rows[0]["CATEGORYID"].ToString();
            txtJO.Text = dsHeader.Tables[0].Rows[0]["JONO"].ToString();
            dateCreated.Value = (DateTime)dsHeader.Tables[0].Rows[0]["DATE"];
            DataSet dsDetail = new costingdetailCRUD().getData(CostingNo);
            dtGrid.Rows.Clear();
            dtGridBOM.Rows.Clear();
                for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                {
                    dtGrid.Rows.Add();
                    dtGrid.Rows[i].HeaderCell.Value = "V";
                    dtGrid.Rows[i].Cells["hCostingNo"].Value = dsDetail.Tables[0].Rows[i]["COSTINGNO"].ToString();
                    dtGrid.Rows[i].Cells["hID"].Value = dsDetail.Tables[0].Rows[i]["ID"].ToString();
                    dtGrid.Rows[i].Cells["hAllowance"].Value = dsDetail.Tables[0].Rows[i]["ALLOWANCE"].ToString();
                    dtGrid.Rows[i].Cells["hAmount"].Value = dsDetail.Tables[0].Rows[i]["AMOUNT"].ToString();
                    dtGrid.Rows[i].Cells["hConsumption"].Value = dsDetail.Tables[0].Rows[i]["CONSUMPTION"].ToString();
                    dtGrid.Rows[i].Cells["hCostType"].Value = dsDetail.Tables[0].Rows[i]["COSTID"].ToString();
                    dtGrid.Rows[i].Cells["hCurrency"].Value = dsDetail.Tables[0].Rows[i]["CURRENCY"].ToString();
                    dtGrid.Rows[i].Cells["hDescription"].Value = dsDetail.Tables[0].Rows[i]["DESCRIPTION"].ToString();
                    dtGrid.Rows[i].Cells["hKurs"].Value = dsDetail.Tables[0].Rows[i]["KURS"].ToString();
                    dtGrid.Rows[i].Cells["hPrice"].Value = dsDetail.Tables[0].Rows[i]["PRICE"].ToString();
                    dtGrid.Rows[i].Cells["hUOM"].Value = dsDetail.Tables[0].Rows[i]["UOMID"].ToString();
                    dtGrid.Rows[i].Cells["hUsage"].Value = dsDetail.Tables[0].Rows[i]["USAG"].ToString();
                    dtGrid.Rows[i].Cells["hWidth"].Value = dsDetail.Tables[0].Rows[i]["WIDTH"].ToString();

                }

        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            frmcostingSearch f = new frmcostingSearch();
            f.AddItemCallback = new frmcostingSearch.AddCostingDelegate(this.SetCostingCallBack);
            f.ShowDialog();
            if (GStrCode != "")
            {
                load_data(GStrCode);
            }
            /*
            if (GStrCode != "")
            {
                DataSet dsHeader = new costingCRUD().getData(GStrCode);
                txtCostingNo.Text = GStrCode;
                txtCustomerID.Text = dsHeader.Tables[0].Rows[0]["CUSTVENDCODE"].ToString();
                txtStyleID.Text = dsHeader.Tables[0].Rows[0]["ITEMSID"].ToString();
                txtCategoryID.Text = dsHeader.Tables[0].Rows[0]["CATEGORYID"].ToString();
                txtJO.Text = dsHeader.Tables[0].Rows[0]["JONO"].ToString();
                dateCreated.Value = (DateTime)dsHeader.Tables[0].Rows[0]["DATE"];
                DataSet dsDetail = new costingdetailCRUD().getData(GStrCode);
                dtGrid.Rows.Clear();
                dtGridBOM.Rows.Clear();
                for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                {
                    dtGrid.Rows.Add();
                    dtGrid.Rows[i].HeaderCell.Value = "V";
                    dtGrid.Rows[i].Cells["hCostingNo"].Value = dsDetail.Tables[0].Rows[i]["COSTINGNO"].ToString();
                    dtGrid.Rows[i].Cells["hID"].Value = dsDetail.Tables[0].Rows[i]["ID"].ToString();
                    dtGrid.Rows[i].Cells["hAllowance"].Value = dsDetail.Tables[0].Rows[i]["ALLOWANCE"].ToString();
                    dtGrid.Rows[i].Cells["hAmount"].Value = dsDetail.Tables[0].Rows[i]["AMOUNT"].ToString();
                    dtGrid.Rows[i].Cells["hConsumption"].Value = dsDetail.Tables[0].Rows[i]["CONSUMPTION"].ToString();
                    dtGrid.Rows[i].Cells["hCostType"].Value = dsDetail.Tables[0].Rows[i]["COSTID"].ToString();

                    dtGrid.Rows[i].Cells["hCurrency"].Value = dsDetail.Tables[0].Rows[i]["CURRENCY"].ToString();
                    dtGrid.Rows[i].Cells["hDescription"].Value = dsDetail.Tables[0].Rows[i]["DESCRIPTION"].ToString();
                    dtGrid.Rows[i].Cells["hKurs"].Value = dsDetail.Tables[0].Rows[i]["KURS"].ToString();
                    dtGrid.Rows[i].Cells["hPrice"].Value = dsDetail.Tables[0].Rows[i]["PRICE"].ToString();
                    dtGrid.Rows[i].Cells["hUOM"].Value = dsDetail.Tables[0].Rows[i]["UOMID"].ToString();
                    dtGrid.Rows[i].Cells["hUsage"].Value = dsDetail.Tables[0].Rows[i]["USAG"].ToString();
                    dtGrid.Rows[i].Cells["hWidth"].Value = dsDetail.Tables[0].Rows[i]["WIDTH"].ToString();

                }
            }

            */
        }
        private void SetCostingCallBack(string CostingNo)
        {
            txtCostingNo.Text = CostingNo;
            GStrCode = CostingNo;
            //txtCategoryDesc.Text = categoryDesc;
        }


        private void frmbom_Load(object sender, EventArgs e)
        {
            DataSet dsCost = new mcostCRUD().getData();
            DataSet dsUOM = new muomCRUD().getData();
            DataSet dsColor = new mcolorCRUD().getData();
            DataSet dsSize = new msizeCRUD().getData();


            DataGridViewComboBoxColumn CostType = dtGrid.Columns["hCostType"] as DataGridViewComboBoxColumn;//new DataGridViewComboBoxColumn();
            CostType.DataSource = dsCost.Tables[0];
            CostType.DisplayMember = "DESCRIPTION";
            CostType.ValueMember = "COSTID";


            DataGridViewComboBoxColumn ColorID = dtGridBOM.Columns["bColorID"] as DataGridViewComboBoxColumn;
            DataGridViewComboBoxColumn Uom = dtGridBOM.Columns["bUom"] as DataGridViewComboBoxColumn;
            DataGridViewComboBoxColumn SizeID = dtGridBOM.Columns["bSizeID"] as DataGridViewComboBoxColumn;
            ColorID.DataSource = dsColor.Tables[0];
            ColorID.DisplayMember = "DESCRIPTION";
            ColorID.ValueMember = "COLORID";

            Uom.DataSource = dsUOM.Tables[0];
            Uom.DisplayMember = "DESCRIPTION";
            Uom.ValueMember = "UOMID";

            SizeID.DataSource = dsSize.Tables[0];
            SizeID.DisplayMember = "DESCRIPTION";
            SizeID.ValueMember = "SIZEID";


        }

        private void dtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
            //MessageBox.Show ("test"+e.RowIndex);
        }

        private void dtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //MessageBox.Show("test" + this.dtGrid.Rows[e.RowIndex] + " ");
                //MessageBox.Show(dtGrid.Rows[e.RowIndex].Cells["hCostingNo"].Value.ToString());
                //MessageBox.Show(dtGrid.Rows[e.RowIndex].Cells["hID"].Value.ToString());
                GCostingNo = dtGrid.Rows[e.RowIndex].Cells["hCostingNo"].Value.ToString();
                GID = Convert.ToInt32(dtGrid.Rows[e.RowIndex].Cells["hID"].Value);
                Allowance=(float)Convert.ToDouble(dtGrid.Rows[e.RowIndex].Cells["hAllowance"].Value);
                Consumption=(float)Convert.ToDouble(dtGrid.Rows[e.RowIndex].Cells["hConsumption"].Value);
                DataSet dsBOM = new bomCRUD().getData(dtGrid.Rows[e.RowIndex].Cells["hCostingNo"].Value.ToString(), Convert.ToInt32(dtGrid.Rows[e.RowIndex].Cells["hID"].Value));
                dtGridBOM.Rows.Clear();
                for (int i = 0; i < dsBOM.Tables[0].Rows.Count; i++)
                {
                    dtGridBOM.Rows.Add();
                    dtGridBOM.Rows[i].HeaderCell.Value = "V";
                    //key
                    dtGridBOM.Rows[i].Cells["bCostingNo1"].Value = GCostingNo;
                    dtGridBOM.Rows[i].Cells["bID1"].Value = GID;
                    dtGridBOM.Rows[i].Cells["bColorID1"].Value = dsBOM.Tables[0].Rows[i]["COLORID"].ToString();
                    dtGridBOM.Rows[i].Cells["bSizeID1"].Value = dsBOM.Tables[0].Rows[i]["SIZEID"].ToString();

                    //end key
                    dtGridBOM.Rows[i].Cells["bCostingNo"].Value = GCostingNo;
                    dtGridBOM.Rows[i].Cells["bID"].Value = GID;
                    dtGridBOM.Rows[i].Cells["bColorID"].Value = dsBOM.Tables[0].Rows[i]["COLORID"].ToString();
                    dtGridBOM.Rows[i].Cells["bSizeID"].Value = dsBOM.Tables[0].Rows[i]["SIZEID"].ToString();
                    dtGridBOM.Rows[i].Cells["bItemsID"].Value = dsBOM.Tables[0].Rows[i]["ITEMSID"].ToString();
                    dtGridBOM.Rows[i].Cells["bRemarks"].Value = dsBOM.Tables[0].Rows[i]["REMARKS"].ToString();
                    dtGridBOM.Rows[i].Cells["bConsumption"].Value = dsBOM.Tables[0].Rows[i]["CONSUMPTION"].ToString();
                    dtGridBOM.Rows[i].Cells["bAllowance"].Value = dsBOM.Tables[0].Rows[i]["ALLOWANCE"].ToString();
                    dtGridBOM.Rows[i].Cells["bQtyOrder"].Value = dsBOM.Tables[0].Rows[i]["QTYORDER"].ToString();
                    dtGridBOM.Rows[i].Cells["bTotConsumption"].Value = dsBOM.Tables[0].Rows[i]["TOTCONSUMPTION"].ToString();
                    dtGridBOM.Rows[i].Cells["bUOM"].Value =  dsBOM.Tables[0].Rows[i]["UOM"].ToString();
                    dtGridBOM.Rows[i].Cells["bSupplier"].Value = dsBOM.Tables[0].Rows[i]["SUPPLIER"].ToString();
                    dtGridBOM.Rows[i].Cells["bPONO"].Value = dsBOM.Tables[0].Rows[i]["PONO"].ToString();
                    //dtGridBOM.Rows[i].Cells["bQtyPO"].Value = dsBOM.Tables[0].Rows[i]["QTYPO"].ToString();
                    //dtGridBOM.Rows[i].Cells["bQtyStore"].Value = dsBOM.Tables[0].Rows[i]["QTYSTORE"].ToString();
                }
            }

        }

        private void SetItemsCallBack(string ItemsID, string ItemsDesc)
        {
            //dtGrid.Rows[i].Cells["hPONO"].Value = CostingNo;
            GStrCode = ItemsID;
            GitemsDesc = ItemsDesc;

            //txtCategoryDesc.Text = categoryDesc;
        }

        private void dtGridBOM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            GStrCode = "";
            GitemsDesc = "";
            //untuk items
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex] == dtGridBOM.Columns["bItemsID"])
            {
                frmItemsSearch f = new frmItemsSearch();
                f.AddItemCallback = new frmItemsSearch.AddItemDelegate(this.SetItemsCallBack);
                f.ShowDialog();
                if (GStrCode != "")
                {
                    // MessageBox.Show("keren bok");
                    dtGridBOM.Rows[e.RowIndex].Cells["bItemsID"].Value = GStrCode;
                    //dtGridBOM.Rows[e.RowIndex].Cells["bDescription"].Value = GitemsDesc;
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

        }

        private void dtGridBOM_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dtGridBOM.Rows[e.RowIndex].IsNewRow)
            {
                dtGridBOM.Rows[e.RowIndex].HeaderCell.Value = "#";
                dtGridBOM.Rows[e.RowIndex].Cells["bAllowance"].Value = Allowance;
                dtGridBOM.Rows[e.RowIndex].Cells["bConsumption"].Value = Consumption;

            }
            else if (dtGridBOM.Rows[e.RowIndex].HeaderCell.Value.ToString() == "V")
            {
                dtGridBOM.Rows[e.RowIndex].HeaderCell.Value = "E";
            }
        }

        private void cmdCustomer_Click(object sender, EventArgs e)
        {

        }

        private void UbahTSB_Click(object sender, EventArgs e)
        {
            string StrUpdate = "UPDATE tblcosting SET JONO='"+txtJO.Text+"' WHERE COSTINGNO='"+txtCostingNo.Text+"'" ;
            if (new costingCRUD().exec_query(StrUpdate))
            {
                MessageBox.Show("berhasil");
            }
            //insert or update costing BOM
                bom b = new bom();
                string CostingNo1;
                int ID1;
                string ColorID1;string SizeID1;
                dtGridBOM.EndEdit();
                for (int i = 0; i < dtGridBOM.Rows.Count - 1; i++)
                {
                    //key
                    CostingNo1=GCostingNo;
                    ID1=GID;
                    ColorID1=Convert.ToString(dtGridBOM.Rows[i].Cells["bColorID1"].Value);
                    SizeID1=Convert.ToString(dtGridBOM.Rows[i].Cells["bSizeID1"].Value);;
                    //end key
                    b.ID = GID;
                    b.COSTINGNO = GCostingNo;
                    b.ALLOWANCE=(float)Convert.ToDouble(dtGridBOM.Rows[i].Cells["bAllowance"].Value);
                    b.COLORID=Convert.ToString(dtGridBOM.Rows[i].Cells["bColorID"].Value);
                    b.CONSUMPTION=(float)Convert.ToDouble(dtGridBOM.Rows[i].Cells["bConsumption"].Value);
                    b.ITEMSID=Convert.ToString(dtGridBOM.Rows[i].Cells["bItemsID"].Value);
                    //b.ORDERNO=dtGridBOM.Rows[i].Cells["bID"].Value;
                    b.PONO=Convert.ToString(dtGridBOM.Rows[i].Cells["bPONO"].Value);
                    b.QTYORDER = (float)Convert.ToDouble(dtGridBOM.Rows[i].Cells["bQtyOrder"].Value);
                    //b.QTYPO=
                    //b.QTYSTORE=
                    b.REMARKS=Convert.ToString(dtGridBOM.Rows[i].Cells["bRemarks"].Value);
                    b.SIZEID=Convert.ToString(dtGridBOM.Rows[i].Cells["bSizeID"].Value);
                    b.SUPPLIER=Convert.ToString(dtGridBOM.Rows[i].Cells["bSupplier"].Value);
                    b.TOTCONSUMPTION=(float)Convert.ToDouble(dtGridBOM.Rows[i].Cells["bTotConsumption"].Value);
                    b.UOM = Convert.ToString(dtGridBOM.Rows[i].Cells["bUOM"].Value);
                    if (dtGridBOM.Rows[i].HeaderCell.Value.ToString() == "#")
                    {
                       
                        if (new bomCRUD().insertData(b))
                        {

                            // MessageBox.Show("Data berhasil di tambahkan");
                            // Binding();
                            dtGridBOM.Rows[i].HeaderCell.Value = "V";
                        }
                        else
                        {
                            // MessageBox.Show("Data gagal ditambahkan");
                            // dtGrid.Rows[i].Cells["Check"].Value = "ER";
                            // dtGrid.Rows[i].HeaderCell.Value = "X";
                        }
                    }
                    else //if (dtGridBOM.Rows[i].HeaderCell.Value.ToString() == "E")// udapte
                    {
                        if (new bomCRUD().updateData(b,CostingNo1,ID1,ColorID1,SizeID1))
                        {
                            dtGridBOM.Rows[i].HeaderCell.Value = "V";
                            
                        }
                        else
                        {
                            MessageBox.Show("gagal update");
                            

                        }
                    }

                }

        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {
            DataSet data = new bomCRUD().prBOM(txtCostingNo.Text);
            //Application.DoEvents();
            //data.WriteXml(Application.StartupPath + "\\bom.xml", XmlWriteMode.WriteSchema);
            data.WriteXml("C:\\MyGarmentReport\\bom.xml", XmlWriteMode.WriteSchema);
            Form f = new PrintBOM();
            f.Show();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            DataSet dsSupplier = new mcustvendCRUD().getData(txtCustomerID.Text, "", "");
            txtCustomerDesc.Text = dsSupplier.Tables[0].Rows[0]["NAME"].ToString();
        }

        private void txtCustomerDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdCategory_Click(object sender, EventArgs e)
        {

        }

        private void cmdJO_Click(object sender, EventArgs e)
        {
            frmjoborderSearch f = new frmjoborderSearch();
            f.AddItemCallback = new frmjoborderSearch.AddCostingDelegate(this.SetJOCallBack);
            f.ShowDialog();

        }
        private void SetJOCallBack(string JONO)
        {
            txtJO.Text = JONO;
            //txtCategoryDesc.Text = categoryDesc;
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

        private void dtGridBOM_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGridBOM.Rows[e.RowIndex];
                //txtCategoryID.Text = row.Cells[0].Value.ToString();
                //dtGridBOM.Rows[e.RowIndex].Cells["hAmount"].Value = Convert.ToSingle(dtGridBOM.Rows[e.RowIndex].Cells["hConsumption"].Value) * Convert.ToSingle(dtGridBOM.Rows[e.RowIndex].Cells["hPrice"].Value);
                dtGridBOM.Rows[e.RowIndex].Cells["bTotConsumption"].Value = (Convert.ToSingle(dtGridBOM.Rows[e.RowIndex].Cells["bQtyOrder"].Value) + (Convert.ToSingle(dtGridBOM.Rows[e.RowIndex].Cells["bQtyOrder"].Value) * Convert.ToSingle(dtGridBOM.Rows[e.RowIndex].Cells["bAllowance"].Value) / 100));

            }
        }

        private void frmbom_Shown(object sender, EventArgs e)
        {
              DataSet dsModulUser = new moduluserCRUD().findData(GlobalVariables.GUserID,"BOM");
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
