using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MyGarment.ClassExim;
using MyGarment.ClassMaster;
using MyGarment.ViewStore;
using MyGarment.ClassStore;
namespace MyGarment.ViewExim
{
    public partial class frmbcInput : Form
    {
        private string GStrCode;
        public frmbcInput()
        {
            InitializeComponent();
        }

        private void cbTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsJenis = new eximbcCRUD().getData(cbTypeID.Text);
            cbJenis.Items.Clear();
            for (int i = 0; i < dsJenis.Tables[0].Rows.Count-1; i++)
            {
                cbJenis.Items.Add(dsJenis.Tables[0].Rows[i]["DOCTYPE"]);
                
            }
        }

        private void cbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsAlasan = new eximbcdetailCRUD().getData(cbJenis.Text,cbTypeID.Text);
            cbAlasan.Items.Clear();
            for (int i = 0; i < dsAlasan.Tables[0].Rows.Count - 1; i++)
            {
                cbAlasan.Items.Add(dsAlasan.Tables[0].Rows[i]["IDDetail"]);

            }

        }

        // serah
        private void load_data(string DataNo)
        {
            DataSet dsHeader = new eximdocCRUD().findData(DataNo);
            txtNoAju.Text = DataNo;
            AjuDate.Value = (DateTime)dsHeader.Tables[0].Rows[0]["AJUDATE"];
            txtBLNO.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["BLNO"]);
            txtDocNo.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["DOCNO"]);
            txtInvoice.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["INVNO"]);
            txtRemarks.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["REMARKS"]);
            txtTransNo.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["TRANSNO"]);
            BLDate.Value = (DateTime)dsHeader.Tables[0].Rows[0]["BLDATE"];
            dateCreated.Value = (DateTime)dsHeader.Tables[0].Rows[0]["DATE"];
            InvoiceDate.Value = (DateTime)dsHeader.Tables[0].Rows[0]["INVDATE"];
            DocDate.Value = (DateTime)dsHeader.Tables[0].Rows[0]["DOCDATE"];
            cbAlasan.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["DOCREASON"]);
            cbJenis.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["DOCTYPE"]);
            cbTypeID.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["TYPE"]);

            //detail
            DataSet dsDetail = new eximdocdetailCRUD().findData(DataNo);
            dtGrid.Rows.Clear();
            for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
            {
                dtGrid.Rows.Add();
                dtGrid.Rows[i].HeaderCell.Value = "V";
                dtGrid.Rows[i].Cells["hTransNo1"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["TRANSNO"]);
                dtGrid.Rows[i].Cells["hID1"].Value = Convert.ToInt32(dsDetail.Tables[0].Rows[i]["ID"]);
                dtGrid.Rows[i].Cells["hTransNo"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["TRANSNO"]);
                dtGrid.Rows[i].Cells["hID"].Value = Convert.ToInt32(dsDetail.Tables[0].Rows[i]["ID"]);
                dtGrid.Rows[i].Cells["hItemsID"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["ITEMSID"]);
                dtGrid.Rows[i].Cells["hStyleID"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["STYLEID"]);
                dtGrid.Rows[i].Cells["hDescription"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["DESCRIPTION"]);
                dtGrid.Rows[i].Cells["hQuantity"].Value = Convert.ToDecimal(dsDetail.Tables[0].Rows[i]["QUANTITY"]);
                dtGrid.Rows[i].Cells["hUOM"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["UOM"]);
                dtGrid.Rows[i].Cells["hCurrency"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["CURRENCY"]);
                dtGrid.Rows[i].Cells["hPrice"].Value = Convert.ToDecimal(dsDetail.Tables[0].Rows[i]["PRICE"]);
                dtGrid.Rows[i].Cells["hTotal"].Value = Convert.ToDecimal(dsDetail.Tables[0].Rows[i]["TOTAL"]);
                dtGrid.Rows[i].Cells["hKurs"].Value = Convert.ToDecimal(dsDetail.Tables[0].Rows[i]["KURS"]);



            }

        }
        private void frmbcInput_Load(object sender, EventArgs e)
        {
            SimpanTSB.Enabled = true;
            UbahTSB.Enabled = false;
            //dtGrid.Enabled = false;
            
            DataSet dsDIV = new mdivCRUD().getData();
            cbDIV.DataSource = dsDIV.Tables[0];
            cbDIV.DisplayMember = "DESCRIPTION";
            cbDIV.ValueMember = "DIVID";
            
            DataSet dsCurrency = new mcurrencyCRUD().getData();
            DataGridViewComboBoxColumn Currency = dtGrid.Columns["hCurrency"] as DataGridViewComboBoxColumn;

            Currency.DataSource = dsCurrency.Tables[0];
            Currency.DisplayMember = "CURRENCYID";
            Currency.ValueMember = "CURRENCYID";
        }

        private void SetPurchaseCallBack(string PoNo)
        {
           GStrCode = PoNo;
           txtTransNo.Text = PoNo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GStrCode = "";
            if (cbTypeID.Text == "PENGELUARAN")
            {
                frmginSearch f = new frmginSearch();
                f.AddItemCallback = new frmginSearch.AddPurchaseDelegate(this.SetPurchaseCallBack);
                f.ShowDialog();
                if (GStrCode != "")
                {
                    DataSet dsDetail = new gindetailCRUD().getData(GStrCode);
                    dtGrid.Rows.Clear();
                    for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                    {
                        
                        dtGrid.Rows.Add();
                        dtGrid.Rows[i].HeaderCell.Value = "#";
                        dtGrid.Rows[i].Cells["hTransNo"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["GINNO"]);
                        dtGrid.Rows[i].Cells["hID"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["ID"]);
                        dtGrid.Rows[i].Cells["hItemsID"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["ITEMSID"]);
                        dtGrid.Rows[i].Cells["hDescription"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["DESCRIPTION"]);
                       // dtGrid.Rows[i].Cells["hJenis"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["JENIS"]);
                       // dtGrid.Rows[i].Cells["hColorID"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["COLORID"]);
                       // dtGrid.Rows[i].Cells["hSizeID"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["SIZEID"]);
                       // dtGrid.Rows[i].Cells["hGrade"].Value = DBNull.Value.Equals(dsDetail.Tables[0].Rows[i]["GRADE"]) ? null : dsDetail.Tables[0].Rows[i]["GRADE"].ToString();
                        dtGrid.Rows[i].Cells["hStyleID"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["STYLEID"]);
                       // dtGrid.Rows[i].Cells["hPONO"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["PONO"]);
                        dtGrid.Rows[i].Cells["hQuantity"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["QUANTITY"]);
                        dtGrid.Rows[i].Cells["hUOM"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["UOM"]);
                        //dtGrid.Rows[i].Cells["hPrice"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["PRICE"]);
                        //dtGrid.Rows[i].Cells["hKurs"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["KURS"]);

                    }

                }
            }
            else if (cbTypeID.Text == "PEMASUKAN")
            {
                frmgrnSearch f = new frmgrnSearch();
                f.AddItemCallback = new frmgrnSearch.AddPurchaseDelegate(this.SetPurchaseCallBack);
                f.ShowDialog();

                if (GStrCode != "")
                {
                    DataSet dsDetail = new grndetailCRUD().getData(GStrCode);
                    dtGrid.Rows.Clear();
                    for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                    {
                        dtGrid.Rows.Add();
                        dtGrid.Rows[i].HeaderCell.Value = "#";
                        //key
                      //  dtGrid.Rows[i].Cells["hGRNNo1"].Value = dsDetail.Tables[0].Rows[i]["GRNNO"].ToString();
                      //  dtGrid.Rows[i].Cells["hID1"].Value = dsDetail.Tables[0].Rows[i]["ID"].ToString();
                        //end key
                        dtGrid.Rows[i].Cells["hTransNo"].Value = dsDetail.Tables[0].Rows[i]["GRNNO"].ToString();
                        dtGrid.Rows[i].Cells["hID"].Value = dsDetail.Tables[0].Rows[i]["ID"].ToString();
                        dtGrid.Rows[i].Cells["hItemsID"].Value = dsDetail.Tables[0].Rows[i]["ITEMSID"].ToString();
                        dtGrid.Rows[i].Cells["hDescription"].Value = dsDetail.Tables[0].Rows[i]["DESCRIPTION"].ToString();
                        //dtGrid.Rows[i].Cells["hJenis"].Value = dsDetail.Tables[0].Rows[i]["JENIS"].ToString();

                        dtGrid.Rows[i].Cells["hStyleID"].Value = dsDetail.Tables[0].Rows[i]["STYLEID"].ToString();

                        dtGrid.Rows[i].Cells["hQuantity"].Value = dsDetail.Tables[0].Rows[i]["QUANTITY"].ToString();
                        dtGrid.Rows[i].Cells["hUOM"].Value = dsDetail.Tables[0].Rows[i]["UOM"].ToString();

                    }
                }

            }
            else { MessageBox.Show("You must select type"); }


        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            //simpan header
            eximdoc k = new eximdoc();
            //Generate gen = new Generate();
            //txtGRNNO.Text = gen.genGRN();
            k.AJUDATE = AjuDate.Value;
            k.AJUNO = txtNoAju.Text;
            k.BLDATE = BLDate.Value;
            
            k.BLNO=txtBLNO.Text;
            k.DATE = DateTime.Now;
            k.DOCDATE = DocDate.Value;
            k.DOCNO = txtDocNo.Text;
            k.DOCREASON = cbAlasan.Text;
            k.DOCTYPE = cbJenis.Text;
            k.INVDATE = InvoiceDate.Value;
            k.INVNO = txtInvoice.Text;
            k.OFFICER = GlobalVariables.GUserID;
            k.REMARKS = txtRemarks.Text;
            k.TRANSNO = txtTransNo.Text;
            k.TYPE = cbTypeID.Text;
            if ((txtNoAju.Text == ""))
            {
                MessageBox.Show("Isian Belum lengkap untuk No AJu");
            }
            else if (new eximdocCRUD().insertData(k))
            {

                eximdocdetail d = new eximdocdetail();
                dtGrid.EndEdit();
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {

                    d.CURRENCY = "";
                    d.ID = Convert.ToInt32(dtGrid.Rows[i].Cells["hID"].Value); //Convert.ToInt32(dtGrid.Rows[i].Cells["hCostingID"].Value);
                    
                    d.ITEMSID = dtGrid.Rows[i].Cells["hItemsID"].Value == null ? null : dtGrid.Rows[i].Cells["hItemsID"].Value.ToString();
                    d.KURS = Convert.ToDecimal(dtGrid.Rows[i].Cells["hKurs"].Value);
                    d.NOAJU = txtNoAju.Text;
                    d.PRICE = Convert.ToDecimal(dtGrid.Rows[i].Cells["hPrice"].Value);
                    d.STYLEID = Convert.ToString(dtGrid.Rows[i].Cells["hStyleID"].Value);
                    d.TOTAL = Convert.ToDecimal(dtGrid.Rows[i].Cells["hTotal"].Value);
                    d.CURRENCY = Convert.ToString(dtGrid.Rows[i].Cells["hCurrency"].Value);
                    //d.TRANSNO = Convert.ToString(dtGrid.Rows[i].Cells["hItemsID"].Value);
                    d.TRANSNO = Convert.ToString(dtGrid.Rows[i].Cells["hTransNo"].Value);
                    
                    if (dtGrid.Rows[i].HeaderCell.Value.ToString() == "#")
                    {

                        if (new eximdocdetailCRUD().insertData(d))
                        {
                            dtGrid.Rows[i].HeaderCell.Value = "V";
                        }
                        else
                        {
                        }
                    }
                }

                MessageBox.Show("Data berhasil di tambahkan");
                load_data(txtNoAju.Text);
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

        private void dtGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == -1)
                return;
            else
            {
                if (senderGrid.Columns[e.ColumnIndex] == dtGrid.Columns["hCurrency"])
                {
                    DataSet dsKurs = new mrateCRUD().getData(Convert.ToString(dtGrid.Rows[e.RowIndex].Cells["hCurrency"].Value));

                    if (dsKurs.Tables[0].Rows.Count > 0)
                    {
                        dtGrid.Rows[e.RowIndex].Cells["hKurs"].Value = Convert.ToString(dsKurs.Tables[0].Rows[0]["KURS"]);

                    }
                }
            }

        }

        private void SetBCCallBack(string PoNo)
        {
            GStrCode = PoNo;
            txtNoAju.Text = PoNo;
        }
        private void RecordTSB_Click(object sender, EventArgs e)
        {
            GStrCode = "";
            frmbcInputSearch f = new frmbcInputSearch();
            f.AddItemCallback = new frmbcInputSearch.AddPurchaseDelegate(this.SetBCCallBack);
            f.ShowDialog();

            if (GStrCode != "")
            {
                load_data(GStrCode);
             /*
                DataSet dsHeader = new eximdocCRUD().findData(GStrCode);
                txtNoAju.Text = GStrCode;
                AjuDate.Value = (DateTime)dsHeader.Tables[0].Rows[0]["DATE"];
                txtBLNO.Text= Convert.ToString(dsHeader.Tables[0].Rows[0]["BLNO"]);
                txtDocNo.Text= Convert.ToString(dsHeader.Tables[0].Rows[0]["DOCNO"]);
                txtInvoice.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["INVNO"]);
                txtRemarks.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["REMARKS"]);
                txtTransNo.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["TRANSNO"]);
                BLDate.Value = (DateTime)dsHeader.Tables[0].Rows[0]["BLDATE"];
                cbAlasan.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["DOCREASON"]) ;
                dateCreated.Value = (DateTime)dsHeader.Tables[0].Rows[0]["DATE"];
                //cbDIV.Text=
                cbJenis.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["DOCTYPE"]);
                cbTypeID.Text = Convert.ToString(dsHeader.Tables[0].Rows[0]["TYPE"]);
               

                        
                //cbDIV.SelectedValue = dsHeader.Tables[0].Rows[0]["GDIV"];

                //detail
                 DataSet dsDetail = new eximdocdetailCRUD().findData(GStrCode);
                 dtGrid.Rows.Clear();
                 for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
                 {
                      dtGrid.Rows.Add();
                      dtGrid.Rows[i].HeaderCell.Value = "V";
                      dtGrid.Rows[i].Cells["hTransNo1"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["TRANSNO"]);
                      dtGrid.Rows[i].Cells["hID1"].Value = Convert.ToInt32(dsDetail.Tables[0].Rows[i]["ID"]);
                      dtGrid.Rows[i].Cells["hTransNo"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["TRANSNO"]);
                      dtGrid.Rows[i].Cells["hID"].Value = Convert.ToInt32(dsDetail.Tables[0].Rows[i]["ID"]);
                      dtGrid.Rows[i].Cells["hItemsID"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["ITEMSID"]);
                      dtGrid.Rows[i].Cells["hStyleID"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["STYLEID"]);
                      dtGrid.Rows[i].Cells["hDescription"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["DESCRIPTION"]);
                      dtGrid.Rows[i].Cells["hQuantity"].Value = Convert.ToDecimal(dsDetail.Tables[0].Rows[i]["QUANTITY"]);
                      dtGrid.Rows[i].Cells["hUOM"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["UOM"]);
                      dtGrid.Rows[i].Cells["hCurrency"].Value = Convert.ToString(dsDetail.Tables[0].Rows[i]["CURRENCY"]);
                      dtGrid.Rows[i].Cells["hPrice"].Value = Convert.ToDecimal(dsDetail.Tables[0].Rows[i]["PRICE"]);
                      dtGrid.Rows[i].Cells["hTotal"].Value = Convert.ToDecimal(dsDetail.Tables[0].Rows[i]["TOTAL"]);
                      dtGrid.Rows[i].Cells["hKurs"].Value = Convert.ToDecimal(dsDetail.Tables[0].Rows[i]["KURS"]);



                 }
              */ 
                 SimpanTSB.Enabled = false;
                 UbahTSB.Enabled = true;
                 dtGrid.Enabled = true;
            }

        }

        private void HapusTSB_Click(object sender, EventArgs e)
        {
          if (new eximdocCRUD().deleteData(txtNoAju.Text))
           {
             MessageBox.Show(" Items Receive telah di hapus ");
           }
           
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

   

     
        private void New_Click(object sender, EventArgs e)
        {
            SimpanTSB.Enabled = true;
            UbahTSB.Enabled = false;
            dtGrid.RowCount = 1;
        }

        private void dtGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGrid.Rows[e.RowIndex];
                //txtCategoryID.Text = row.Cells[0].Value.ToString();
                dtGrid.Rows[e.RowIndex].Cells["hTotal"].Value = Convert.ToDecimal(dtGrid.Rows[e.RowIndex].Cells["hQuantity"].Value) * Convert.ToDecimal(dtGrid.Rows[e.RowIndex].Cells["hPrice"].Value);

            }

        }

        private void UbahTSB_Click(object sender, EventArgs e)
        {
            //simpan header
            eximdoc k = new eximdoc();
            //Generate gen = new Generate();
            //txtGRNNO.Text = gen.genGRN();
            k.AJUDATE = AjuDate.Value;
            k.AJUNO = txtNoAju.Text;
            k.BLDATE = BLDate.Value;
            k.BLNO = txtBLNO.Text;
            k.DATE = DateTime.Now;
            k.DOCDATE = DocDate.Value;
            k.DOCNO = txtDocNo.Text;
            k.DOCREASON = cbAlasan.Text;
            k.DOCTYPE = cbJenis.Text;
            k.INVDATE = InvoiceDate.Value;
            k.INVNO = txtInvoice.Text;
            k.OFFICER = GlobalVariables.GUserID;
            k.REMARKS = txtRemarks.Text;
            k.TRANSNO = txtTransNo.Text;
            k.TYPE = cbTypeID.Text;
            if ((txtNoAju.Text == ""))
            {
                MessageBox.Show("Isian Belum lengkap untuk No AJu");
            }
            else if (new eximdocCRUD().updateData(k,txtNoAju.Text))
            {

                eximdocdetail d = new eximdocdetail();
                dtGrid.EndEdit();
                string TransNo1;
                int ID1;
                for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
                {

                    d.CURRENCY = "";
                    d.ID = Convert.ToInt32(dtGrid.Rows[i].Cells["hID"].Value); //Convert.ToInt32(dtGrid.Rows[i].Cells["hCostingID"].Value);

                    d.ITEMSID = dtGrid.Rows[i].Cells["hItemsID"].Value == null ? null : dtGrid.Rows[i].Cells["hItemsID"].Value.ToString();
                    d.KURS = Convert.ToDecimal(dtGrid.Rows[i].Cells["hKurs"].Value);
                    d.NOAJU = txtNoAju.Text;
                    d.PRICE = Convert.ToDecimal(dtGrid.Rows[i].Cells["hPrice"].Value);
                    d.STYLEID = Convert.ToString(dtGrid.Rows[i].Cells["hStyleID"].Value);
                    d.TOTAL = Convert.ToDecimal(dtGrid.Rows[i].Cells["hTotal"].Value);
                    d.CURRENCY = Convert.ToString(dtGrid.Rows[i].Cells["hCurrency"].Value);
                    d.TRANSNO = Convert.ToString(dtGrid.Rows[i].Cells["hTransNo"].Value);
                    //d.TRANSNO = txtTransNo.Text;
                    TransNo1 = Convert.ToString(dtGrid.Rows[i].Cells["hTransNo1"].Value);
                    ID1 = Convert.ToInt32(dtGrid.Rows[i].Cells["hID1"].Value);

                    if (dtGrid.Rows[i].HeaderCell.Value.ToString() == "#")
                    {

                        if (new eximdocdetailCRUD().insertData(d))
                        {
                            dtGrid.Rows[i].HeaderCell.Value = "V";
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        if (new eximdocdetailCRUD().updateData(d, TransNo1, ID1))
                        {
                        }
                    }
                }

                MessageBox.Show("Data berhasil di update");
                load_data(txtNoAju.Text);
                SimpanTSB.Enabled = false;
                UbahTSB.Enabled = true;
                dtGrid.Enabled = true;
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan");
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
