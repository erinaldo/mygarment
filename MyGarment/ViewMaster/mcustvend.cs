using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassMaster;

namespace MyGarment.ViewForm
{
    public partial class frmmcustvend : Form
    {
        public frmmcustvend()
        {
            InitializeComponent();
        }
        private void Binding()
        {
            DataSet data = new mcustvendCRUD().getData();
            //data.geData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcustvend";
        }
        private void frmmcustvend_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            mcustvend K = new mcustvend();
           

            K.CUSTVENDCODE=txtCustVendCode.Text;
            K.NAME=txtName.Text;
            K.TYPE=txtType.Text;
            K.ACTIVE=Convert.ToInt32(txtActive.Text);
            //K.DATE=
            K.CONTACTPERSON=txtContactPerson.Text;
            K.CONTACTTITLE=txtContactTitle.Text;
            K.ADDRESS=txtAddress.Text;
            K.CITY=txtCity.Text;
            K.ZIPCODE=txtZipCode.Text;
            K.COUNTRY=txtCountry.Text;
            K.HP=txtHP.Text;
            K.PHONE=txtPhone.Text;
            K.FAX=txtFax.Text;
            //K.REMARKS=txtre
            //K.TAX=
            //K.CURRENCYID=
            //K.NPWP=
            //K.NPKP=
        
            
            if (new mcustvendCRUD().insertData(K))
            {
                MessageBox.Show("Data berhasil di tambahkan");
                Binding();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan");
            }
        }

        private void UbahTSB_Click(object sender, EventArgs e)
        {
            mcustvend K = new mcustvend();

            K.CUSTVENDCODE = txtCustVendCode.Text;
            K.NAME = txtName.Text;
            K.TYPE = txtType.Text;
            K.ACTIVE = Convert.ToInt32(txtActive.Text);
            //K.DATE=
            K.CONTACTPERSON = txtContactPerson.Text;
            K.CONTACTTITLE = txtContactTitle.Text;
            K.ADDRESS = txtAddress.Text;
            K.CITY = txtCity.Text;
            K.ZIPCODE = txtZipCode.Text;
            K.COUNTRY = txtCountry.Text;
            K.HP = txtHP.Text;
            K.PHONE = txtPhone.Text;
            K.FAX = txtFax.Text;
          
            if (new mcustvendCRUD().updateData(K))
            {
                MessageBox.Show("Update Sukses");
                Binding();
            }
            else
            {
                MessageBox.Show("Update tidak berhasil");
            }
        }

        private void HapusTSB_Click(object sender, EventArgs e)
        {
            if (new mcustvendCRUD().deleteData(txtCustVendCode.Text))
            {
                MessageBox.Show("Data Berhasil dihapus");
                Binding();
            }
            else
            {
                MessageBox.Show("Data Gagal dihapus");
            }
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new mcustvendCRUD().getData(txtCustVendCode.Text, txtName.Text,txtType.Text);
            //data.geData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmcustvend";
        }

        private void BatalTSB_Click(object sender, EventArgs e)
        {
            txtCustVendCode = null;
            txtName.Text = null;
            txtType.Text = null;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void DtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtGrid.Rows[e.RowIndex];
                /*
                txtCostID.Text = row.Cells[0].Value.ToString();
                txtDescription.Text = row.Cells[1].Value.ToString();
                txtActive.Text = row.Cells[2].Value.ToString();
                */
                txtCustVendCode.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtType.Text = row.Cells[2].Value.ToString(); 
                txtActive.Text=row.Cells[3].Value.ToString();
                //K.DATE=4
                txtContactPerson.Text = row.Cells[5].Value.ToString();
                txtContactTitle.Text = row.Cells[6].Value.ToString();
                txtAddress.Text = row.Cells[7].Value.ToString();
                txtCity.Text = row.Cells[8].Value.ToString();
                txtZipCode.Text = row.Cells[9].Value.ToString();
                txtCountry.Text = row.Cells[10].Value.ToString();
                txtHP.Text = row.Cells[11].Value.ToString();
                txtPhone.Text = row.Cells[12].Value.ToString();
                txtFax.Text = row.Cells[13].Value.ToString(); 
                //K.REMARKS=txtre
                //K.TAX=
                //K.CURRENCYID=
                //K.NPWP=
                //K.NPKP=


            }
        }
    }
}
