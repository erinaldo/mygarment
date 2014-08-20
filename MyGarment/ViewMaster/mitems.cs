using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassMaster;
using System.IO;
//using System.Drawing;

namespace MyGarment.ViewForm
{
    public partial class frmmitems : Form
    {
        public frmmitems()
        {
            InitializeComponent();
        }
        private void Binding()
        {
            DataSet data = new mitemsCRUD().getData();
            //data.geData();
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmitems";
        }

        private void cmdItemsType_Click(object sender, EventArgs e)
        {
            frmmitemstypeSearch f = new frmmitemstypeSearch();
            f.AddItemCallback = new frmmitemstypeSearch.AddItemDelegate(this.SetValueCallBack);
            f.ShowDialog();
        }

        private void SetValueCallBack(string ItemsTypeID, string ItemsTypeDesc)
        {
            //txtItemsID.Text = ItemsID;
            txtItemsTypeDesc.Text = ItemsTypeDesc;
            txtItemsTypeID.Text = ItemsTypeID;
            //txtType.Text = Type;


        }
        private void SimpanTSB_Click(object sender, EventArgs e)
        {
            mitems K = new mitems();
            
            FileStream fs;
            BinaryReader br;
            fs = new FileStream(txtPath.Text, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);

            K.ItemsID = txtItemsID.Text;
            K.Description = txtDescription.Text;
            K.ItemsTypeID = txtItemsTypeID.Text;
            K.Type = txtType.Text;
            K.Active = Convert.ToInt32(txtActive.Text);
            K.Active = Convert.ToInt32(txtActive.Text);
            K.Path = txtPath.Text;
            K.Image = br.ReadBytes((int)fs.Length);

            if (new mitemsCRUD().insertData(K))
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
            mitems k = new mitems();
            FileStream fs;
            BinaryReader br;
            fs = new FileStream(txtPath.Text, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            k.ItemsID = txtItemsID.Text;
            k.Description = txtDescription.Text;
            k.ItemsTypeID = txtItemsTypeDesc.Text;
            k.Type = txtType.Text;
            k.Active = Convert.ToInt32(txtActive.Text);
            k.Path = txtPath.Text;
            k.Image = br.ReadBytes((int)fs.Length);

            if (new mitemsCRUD().updateData(k))
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
            if (new mitemsCRUD().deleteData(txtItemsID.Text))
            {
                MessageBox.Show("Data Berhasil dihapus");
                Binding();
            }
            else
            {
                MessageBox.Show("Data Gagal dihapus");
            }
        }

        private void BatalTSB_Click(object sender, EventArgs e)
        {
            txtItemsID.Text = null;
            txtDescription.Text = null;
            txtItemsTypeID.Text = null;
            txtType.Text = null;
            txtActive.Text = null;
            txtItemsTypeDesc = null;
        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmmitems_Load(object sender, EventArgs e)
        {
            Binding();
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {
            DataSet data = new mitemsCRUD().getData(txtItemsID.Text,txtDescription.Text,txtItemsTypeID.Text,txtType.Text);
            DtGrid.DataSource = data;
            DtGrid.DataMember = "tblmitems";
        }

        private void DtGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DtGrid.Rows[e.RowIndex];

                txtItemsID.Text = row.Cells[0].Value.ToString();
                txtDescription.Text = row.Cells[1].Value.ToString();
                txtItemsTypeID.Text = row.Cells[2].Value.ToString();
                txtType.Text = row.Cells[3].Value.ToString();
                txtActive.Text= row.Cells[4].Value.ToString();
                if (row.Cells[5].Value.ToString() != string.Empty)
                {
                    var data = (Byte[])(row.Cells[5].Value);
                    var stream = new MemoryStream(data);
                    picItems.Image = Image.FromStream(stream);
                }
                else
                {
                    picItems.Image = null;
                }
                //picItems.Image = GetDataToImage((byte[])(row.Cells[5].Value));

                txtPath.Text = row.Cells[6].Value.ToString();



            }
        }


        public Image GetDataToImage(byte[] pData)
        {
            try
            {
                ImageConverter imgConverter = new ImageConverter();
                return imgConverter.ConvertFrom(pData) as Image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void cmdImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = openFileDialog1.FileName;
                    picItems.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   
    }
}
