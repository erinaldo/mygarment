using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassFile;

namespace MyGarment.ViewFile
{
    public partial class frmmoduluser : Form
    {
        DataSet dsMuser = new muserCRUD().getData();
        DataSet dsModul = new modulCRUD().getData();

        public frmmoduluser()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
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

        private void RecordTSB_Click(object sender, EventArgs e)
        {   /*
            DataSet data = new moduluserCRUD().getData(txtUserID.Text, txtModul.Text);
            dtGrid.DataSource = data;
            dtGrid.DataMember = "tblmoduluser";
             * */
                       
            DataSet dsDetail = new moduluserCRUD().getData(txtUserID.Text, txtModul.Text);
               
            dtGrid.Rows.Clear();
            for (int i = 0; i < dsDetail.Tables[0].Rows.Count; i++)
            {
              dtGrid.Rows.Add();
              dtGrid.Rows[i].HeaderCell.Value = "V";
              dtGrid.Rows[i].Cells["hUserID"].Value = dsDetail.Tables[0].Rows[i]["USERID"].ToString();
              dtGrid.Rows[i].Cells["hModul"].Value = dsDetail.Tables[0].Rows[i]["MODUL"].ToString();
              dtGrid.Rows[i].Cells["hSave"].Value = Convert.ToInt32(dsDetail.Tables[0].Rows[i]["SAVE"]);
              dtGrid.Rows[i].Cells["hUpdate"].Value = Convert.ToInt32(dsDetail.Tables[0].Rows[i]["UPDAT"]);
              dtGrid.Rows[i].Cells["hDelete"].Value = Convert.ToInt32(dsDetail.Tables[0].Rows[i]["DEL"]);
              dtGrid.Rows[i].Cells["hPrint"].Value = Convert.ToInt32(dsDetail.Tables[0].Rows[i]["PRINT"]);
              dtGrid.Rows[i].Cells["hApprove"].Value = Convert.ToInt32(dsDetail.Tables[0].Rows[i]["APPROVE"]);
              dtGrid.Rows[i].Cells["hUnApprove"].Value = Convert.ToInt32(dsDetail.Tables[0].Rows[i]["UNAPPROVE"]);
              dtGrid.Rows[i].Cells["hCheck"].Value = Convert.ToInt32(dsDetail.Tables[0].Rows[i]["CEK"]);
              dtGrid.Rows[i].Cells["hAck"].Value = Convert.ToInt32(dsDetail.Tables[0].Rows[i]["ACKNOWLEGMENT"]);
              dtGrid.Rows[i].Cells["hSee"].Value = Convert.ToInt32(dsDetail.Tables[0].Rows[i]["SEE"]);
            }

        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            moduluser k = new moduluser();
            dtGrid.EndEdit();
            for (int i = 0; i < dtGrid.Rows.Count - 1; i++)
            {
                k.USERID = Convert.ToString(dtGrid.Rows[i].Cells["hUserID"].Value); 
                k.MODUL=Convert.ToString(dtGrid.Rows[i].Cells["hModul"].Value);
                k.SAVE=Convert.ToInt32(dtGrid.Rows[i].Cells["hSave"].Value);
 
                k.UPDAT=Convert.ToInt32(dtGrid.Rows[i].Cells["hUpdate"].Value);
                k.DEL=Convert.ToInt32(dtGrid.Rows[i].Cells["hDelete"].Value);
                k.PRINT=Convert.ToInt32(dtGrid.Rows[i].Cells["hPrint"].Value);
                k.APPROVE=Convert.ToInt32(dtGrid.Rows[i].Cells["hApprove"].Value);
                k.UNAPPROVE=Convert.ToInt32(dtGrid.Rows[i].Cells["hUnApprove"].Value); 
                k.CEK=Convert.ToInt32(dtGrid.Rows[i].Cells["hCheck"].Value);
                k.ACKNOWLEGMENT = Convert.ToInt32(dtGrid.Rows[i].Cells["hAck"].Value);
                k.SEE = Convert.ToInt32(dtGrid.Rows[i].Cells["hSee"].Value);
                

                if (dtGrid.Rows[i].HeaderCell.Value.ToString() == "#")
                {
                    if (new moduluserCRUD().insertData(k))
                    {

                        dtGrid.Rows[i].HeaderCell.Value = "V";
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                else if (dtGrid.Rows[i].HeaderCell.Value.ToString() == "E")// udapte
                {
                    if (new moduluserCRUD().updateData(k))
                    {
                        dtGrid.Rows[i].HeaderCell.Value = "V";
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
            }

        }

        private void UbahTSB_Click(object sender, EventArgs e)
        {
            
        }

        private void frmmoduluser_Load(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn User = dtGrid.Columns["hUserID"] as DataGridViewComboBoxColumn;//new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn Modul = dtGrid.Columns["hModul"] as DataGridViewComboBoxColumn;

            User.DataSource = dsMuser.Tables[0];
            User.DisplayMember = "USERID";
            User.ValueMember = "USERID";

            Modul.DataSource = dsModul.Tables[0];
            Modul.DisplayMember = "MODUL";
            Modul.ValueMember = "MODUL";


        }
    }
}
