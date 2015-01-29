using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using MyGarment.ViewMD;
using MyGarment.ClassMD;
using MyGarment.ClassProduction;
using MyGarment._1Global;

namespace MyGarment.ViewProduction
{
    public partial class frmInitProduction : Form
    {
        private string GStrCode = "";
        CekType cek = new CekType();
        public frmInitProduction()
        {
            InitializeComponent();
        }
        private void SetCostingCallBack(string CostingNo)
        {
            txtJONO.Text = CostingNo;
            GStrCode = CostingNo;
            //txtCategoryDesc.Text = categoryDesc;
        }
        private void load_color(string JONO)
        {
            DataSet dsColor = new joborderCRUD().getColor(JONO);
            dtColor.Rows.Clear();
            for (int i = 0; i < dsColor.Tables[0].Rows.Count; i++)
            {
                dtColor.Rows.Add();
                
                dtColor.Rows[i].Cells["hJONO"].Value = Convert.ToString(dsColor.Tables[0].Rows[i]["JONO"]);
                dtColor.Rows[i].Cells["hStyleID"].Value = Convert.ToString(dsColor.Tables[0].Rows[i]["STYLEID"]);
                txtJONO.Text = Convert.ToString(dsColor.Tables[0].Rows[i]["ORDERNO"]);
                txtStyleID.Text = Convert.ToString(dsColor.Tables[0].Rows[i]["ITEMSID"]);
                dtColor.Rows[i].Cells["hColorID"].Value = Convert.ToString(dsColor.Tables[0].Rows[i]["COLORID"]);
                if (!DBNull.Value.Equals(dsColor.Tables[0].Rows[i]["STARTDATE"]))
                {
                dtColor.Rows[i].Cells["hStart"].Value = Convert.ToDateTime(dsColor.Tables[0].Rows[i]["STARTDATE"]).ToString(GlobalVariables.GFormat);
                }
                if (!DBNull.Value.Equals(dsColor.Tables[0].Rows[i]["CLOSEDATE"]))
                {
                    dtColor.Rows[i].Cells["hClose"].Value = Convert.ToDateTime(dsColor.Tables[0].Rows[i]["CLOSEDATE"]).ToString(GlobalVariables.GFormat);
                }
                if (!DBNull.Value.Equals(dsColor.Tables[0].Rows[i]["DELIVERYDATE"]))
                {
                    dtColor.Rows[i].Cells["hDelivery"].Value = Convert.ToDateTime(dsColor.Tables[0].Rows[i]["DELIVERYDATE"]).ToString(GlobalVariables.GFormat);
                }

            }


            

        }
        private void load_size(string JONO)
        {
            
            
            DataSet dsSize = new joborderCRUD().getSize(JONO);
            dtSize.Rows.Clear();
            for (int i = 0; i < dsSize.Tables[0].Rows.Count; i++)
            {
                dtSize.Rows.Add();
                dtSize.Rows[i].Cells["dStyleID"].Value = Convert.ToString(dsSize.Tables[0].Rows[i]["STYLEID"]);
                dtSize.Rows[i].Cells["dSizeID"].Value = Convert.ToString(dsSize.Tables[0].Rows[i]["SIZEID"]);
                //dtSize.Rows[i].Cells["dNoUrut"].Value = Convert.ToString(dsSize.Tables[0].Rows[i]["NOURUT"]);
                dtSize.Rows[i].Cells["dNoUrut"].Value = i;
                dtSize.Rows[i].Cells["dQtyPlan"].Value = Convert.ToString(dsSize.Tables[0].Rows[i]["CUTTINGQTY"]);
                dtSize.Rows[i].Cells["dRatio"].Value = Convert.ToString(dsSize.Tables[0].Rows[i]["RATIO"]);
                
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmjoborderSearch f = new frmjoborderSearch();
            f.AddItemCallback = new frmjoborderSearch.AddCostingDelegate(this.SetCostingCallBack);
            f.ShowDialog();

            if (GStrCode != "")
            {
                txtJONO.Text = GStrCode;
                load_color(GStrCode);
                load_size(GStrCode);

            }
        }

        private void simpan_color()
        {
             //simpan color
            production k = new production();
            
            dtColor.EndEdit();
            for (int i = 0; i < dtColor.Rows.Count - 1; i++)
            {
                if (Convert.ToString(dtColor.Rows[i].Cells["hJONO"].Value) == "")
                {  //insert
                    k.JONO = txtJONO.Text;
                    k.STYLEID = txtStyleID.Text;
                    k.COLORID = Convert.ToString(dtColor.Rows[i].Cells["hColorID"].Value);
                    if (cek.date(dtColor.Rows[i].Cells["hDelivery"].Value))
                    {
                        k.DELIVERYDATE = Convert.ToDateTime(dtColor.Rows[i].Cells["hDelivery"].Value, new CultureInfo(GlobalVariables.GCulture));
                    }else
                    {
                        k.DELIVERYDATE = null;
                    }
                    if (cek.date(dtColor.Rows[i].Cells["hStart"].Value))
                    {
                        k.STARTDATE = Convert.ToDateTime(dtColor.Rows[i].Cells["hStart"].Value, new CultureInfo(GlobalVariables.GCulture));
                    }
                    else { k.STARTDATE = null; }
                    if (cek.date(dtColor.Rows[i].Cells["hClose"].Value))
                    {
                        k.CLOSEDATE = Convert.ToDateTime(dtColor.Rows[i].Cells["hClose"].Value, new CultureInfo(GlobalVariables.GCulture));
                    }
                    else { k.CLOSEDATE = null; }
                    //k.WASHING = "";
                    if (new productionCRUD().insertData(k))
                    {
                    }
                    else
                    {
                        MessageBox.Show("gagal bro");
                    }
                }
                else //update
                {
                    k.JONO = Convert.ToString(dtColor.Rows[i].Cells["hJONO"].Value); ;
                    k.STYLEID = Convert.ToString(dtColor.Rows[i].Cells["hStyleID"].Value);
                    k.COLORID = Convert.ToString(dtColor.Rows[i].Cells["hColorID"].Value);
                    if (cek.date(dtColor.Rows[i].Cells["hDelivery"].Value))
                    {
                        k.DELIVERYDATE = Convert.ToDateTime(dtColor.Rows[i].Cells["hDelivery"].Value, new CultureInfo(GlobalVariables.GCulture));
                    }
                    else { k.DELIVERYDATE=null;}
                    
                    if (cek.date(dtColor.Rows[i].Cells["hStart"].Value))
                    {
                        k.STARTDATE = Convert.ToDateTime(dtColor.Rows[i].Cells["hStart"].Value, new CultureInfo(GlobalVariables.GCulture));
                    }else {k.STARTDATE=null;}
                    if (cek.date(dtColor.Rows[i].Cells["hClose"].Value))
                    {
                        k.CLOSEDATE = Convert.ToDateTime(dtColor.Rows[i].Cells["hClose"].Value, new CultureInfo(GlobalVariables.GCulture));
                    }
                    else { k.CLOSEDATE = null; }


                    if (new productionCRUD().updateData(k, k.JONO, k.STYLEID, k.COLORID))
                    {
                    }
                    else
                    {
                        MessageBox.Show("gagal bro");
                    }


                }
            }
        }
        private void simpan_size()
        {
          //simpan color
          productionsize k = new productionsize();
            
          dtSize.EndEdit();
          for (int i = 0; i < dtSize.Rows.Count - 1; i++)
            {
                if (Convert.ToString(dtSize.Rows[i].Cells["dStyleID"].Value) == "")
                {  //insert
                    if (cek.strdouble(txtConsumption.Text))
                    {
                        k.COSUMPTION = Convert.ToDouble(txtConsumption.Text);
                    }
                    else { k.COSUMPTION = 0; }
                    k.NOURUT = Convert.ToInt32(dtSize.Rows[i].Cells["dNoUrut"].Value);
                    k.QTYPLAN = Convert.ToDouble(dtSize.Rows[i].Cells["dQtyPlan"].Value);
                    if (cek.strint(dtSize.Rows[i].Cells["dRatio"].Value))
                        k.RATIO = Convert.ToInt32(dtSize.Rows[i].Cells["dRatio"].Value);
                    else
                        k.RATIO = 0;
                    k.SIZEID = Convert.ToString(dtSize.Rows[i].Cells["dSizeID"].Value);
                    k.STYLEID = txtStyleID.Text;//Convert.ToString(dtSize.Rows[i].Cells["hStyleID"].Value);

                    if (new productionsizeCRUD().insertData(k))
                    {
                    }
                    else { MessageBox.Show("gagal"); }
                }
                else //update
                {
                    if (cek.strdouble(txtConsumption.Text))
                    {
                        k.COSUMPTION = Convert.ToDouble(txtConsumption.Text);
                    }
                    else { k.COSUMPTION = 0; }

                    k.NOURUT = Convert.ToInt32(dtSize.Rows[i].Cells["dNoUrut"].Value);
                    k.QTYPLAN = Convert.ToDouble(dtSize.Rows[i].Cells["dQtyPlan"].Value);
                    k.RATIO = Convert.ToInt32(dtSize.Rows[i].Cells["dRatio"].Value);
                    k.SIZEID = Convert.ToString(dtSize.Rows[i].Cells["dSizeID"].Value);
                    k.STYLEID = Convert.ToString(dtSize.Rows[i].Cells["dStyleID"].Value);

                    if (new productionsizeCRUD().updateData(k,k.STYLEID,k.SIZEID))
                    {
                    }
                    else { MessageBox.Show("gagal"); }

                }
            }
            

        }
        private void SimpanTSB_Click(object sender, EventArgs e)
        {

          simpan_color();
          simpan_size();

          load_color(txtJONO.Text);
          load_size(txtJONO.Text);

        }
    }
}
