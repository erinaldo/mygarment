using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassProduction;
using System.Globalization;
using MyGarment._1Global;
using MySql.Data.MySqlClient;

namespace MyGarment.ViewProduction
{
    public partial class cutting : Form
    {
        private DataSet data = null;

        private BindingSource masterBindingSource = new BindingSource();
        private BindingSource detailsBindingSource = new BindingSource();

        private MySqlDataAdapter masterDataAdapter = null;
        private MySqlDataAdapter detailsDataAdapter = null;

        private MySqlCommandBuilder sqlCommandBuilder = null;

        private string GStrCode;
        Generate gen = new Generate();
        public cutting()
        {
            InitializeComponent();
        }

        private void SetCostingCallBack(string itemID, string itemDesc)
        {
            txtStyleID.Text = itemID;
            GStrCode = itemID;
            txtColorID.Text = itemDesc;

        }

        private void GetData()
        {
            try
            {
                //string connectionString = "Data Source='IT-PC\\SQLEXPRESS';Initial Catalog=Personalia;User ID=itmis;Password=itmis"; //ConfigurationManager.AppSettings["connectionString"];
                MySqlConnection connection = new MySqlConnection(GlobalVariables.strCon);

                // Create a DataSet.
                data = new DataSet();

                // Add data from the Customers table to the DataSet.
                masterDataAdapter = new
                MySqlDataAdapter("select * from tblcutt where STYLEID='" + txtStyleID.Text + "' AND COLORID='"+txtColorID.Text+"'", connection);

                // masterDataAdapter.TableMappings.Add("Orders", "tblcutt");
                masterDataAdapter.Fill(data, "tblcutt");
                sqlCommandBuilder = new MySqlCommandBuilder(masterDataAdapter);

                // detail
                
                if (data.Tables[0].Rows.Count == 0)
                {
                    string cutno;
                    cutno = "";
                    detailsDataAdapter = new
                        MySqlDataAdapter("select * from tblcuttdetail where CUTNO='" + cutno + "'", connection);
                    detailsDataAdapter.Fill(data, "tblcuttdetail");


                }
               
                
                for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                {
                    string cutno;
                    cutno = Convert.ToString(data.Tables[0].Rows[i]["CUTNO"]);
                    detailsDataAdapter = new
                        MySqlDataAdapter("select * from tblcuttdetail where CUTNO='" + cutno + "'", connection);
                    detailsDataAdapter.Fill(data, "tblcuttdetail");
                }

                sqlCommandBuilder = new MySqlCommandBuilder(detailsDataAdapter);

                // Establish a relationship between the two tables.
                DataRelation relation = new DataRelation("tblcuttdetail",
                    data.Tables["tblcutt"].Columns["CUTNO"],
                    data.Tables["tblcuttdetail"].Columns["CUTNO"]);
                data.Relations.Add(relation);

                // Bind the master data connector to the Customers table.
                masterBindingSource.DataSource = data;
                masterBindingSource.DataMember = "tblcutt";

                // Nav.BindingSource = masterBindingSource;

                // Bind the details data connector to the master data connector,
                // using the DataRelation name to filter the information in the 
                // details table based on the current row in the master table. 
                detailsBindingSource.DataSource = masterBindingSource;
                detailsBindingSource.DataMember = "tblcuttdetail";


                //combo size

                //Month Data Source

                string selectQueryStringSize = "SELECT SIZEID FROM tblproductionsize";

                MySqlDataAdapter sqlDataAdapterSize = new MySqlDataAdapter(selectQueryStringSize, connection);
                MySqlCommandBuilder sqlCommandBuilderSize = new MySqlCommandBuilder(sqlDataAdapterSize);

                DataTable dataTableMonth = new DataTable();
                sqlDataAdapterSize.Fill(dataTableMonth);
                BindingSource bindingSourceSize = new BindingSource();
                bindingSourceSize.DataSource = dataTableMonth;

                // end combo size
                detailsDataGridView.Columns.Clear();

                DataGridViewComboBoxColumn Columnsize = new DataGridViewComboBoxColumn();
                Columnsize.DataPropertyName = "SIZEID";
                Columnsize.HeaderText = "SIZEID";
                Columnsize.Width = 120;

                Columnsize.DataSource = bindingSourceSize;
                Columnsize.ValueMember = "SIZEID";
                Columnsize.DisplayMember = "SIZEID";
                detailsDataGridView.Columns.Add(Columnsize);
                // combo
                //Adding  Year TextBox

                DataGridViewTextBoxColumn ColumnYear = new DataGridViewTextBoxColumn();
                ColumnYear.HeaderText = "QTY";
                ColumnYear.Width = 80;
                ColumnYear.DataPropertyName = "QTY";

                detailsDataGridView.Columns.Add(ColumnYear);

                //


                //tambahan
                /*
                txtOrder.DataBindings.Clear();
                txtDate.DataBindings.Clear();
                txtRemarks.DataBindings.Clear();
                txtSupplierID.DataBindings.Clear();

                txtOrder.DataBindings.Add(new Binding("Text", masterBindingSource, "OrderID", true, DataSourceUpdateMode.OnPropertyChanged));
                txtDate.DataBindings.Add(new Binding("Text", masterBindingSource, "Date", true, DataSourceUpdateMode.OnPropertyChanged));
                txtRemarks.DataBindings.Add(new Binding("Text", masterBindingSource, "Remarks", true, DataSourceUpdateMode.OnPropertyChanged));
                txtSupplierID.DataBindings.Add(new Binding("Text", masterBindingSource, "SupplierID", true, DataSourceUpdateMode.OnPropertyChanged));
                 */ 
                //txtOrder.DataBindings.Add(new Binding("Text", masterBindingSource, "OrderID", true));


            }
            catch (MySqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            findProductionStyle f = new findProductionStyle();
            f.AddItemCallback = new findProductionStyle.AddStyleDelegate(this.SetCostingCallBack);
            f.ShowDialog();

            if (GStrCode != "")
            {
                // DataSet dsDetail = new productionCRUD().getStyleColor(txtStyleID.Text, txtColorID.Text);
                // dtGrid.Rows.Clear();
                // dtGrid.Columns.Clear();
                masterDataGridView.DataSource = masterBindingSource;
                detailsDataGridView.DataSource = detailsBindingSource;

                GetData();



            }
        }

        private void txtStyleID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
        }

        private void cmdSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                masterBindingSource.EndEdit();
                detailsBindingSource.EndEdit();
                masterDataAdapter.Update(data, "tblcutt");
                detailsDataAdapter.Update(data, "tblcuttdetail");
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }
        }

        private void cutting_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            try
            {
                //remove data grid detail
                foreach (DataGridViewRow item in this.detailsDataGridView.SelectedRows)
                {
                    detailsDataGridView.Rows.RemoveAt(item.Index);
                }
                //
                //remove master
                foreach (DataGridViewRow item in this.masterDataGridView.SelectedRows)
                {
                    masterDataGridView.Rows.RemoveAt(item.Index);
                }


                //
                masterBindingSource.EndEdit();
                detailsBindingSource.EndEdit();
                masterDataAdapter.Update(data, "tblcutt");
                detailsDataAdapter.Update(data, "tblcuttdetail");
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }
        }

        private void masterDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void masterDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (masterDataGridView.Rows[e.RowIndex].IsNewRow)
            {
                //masterDataGridView.Rows[e.RowIndex].HeaderCell.Value = "#";
                masterDataGridView.Rows[e.RowIndex].Cells["STYLEID"].Value = txtStyleID.Text;
                masterDataGridView.Rows[e.RowIndex].Cells["COLORID"].Value = txtColorID.Text;
                masterDataGridView.Rows[e.RowIndex].Cells["CUTNO"].Value = gen.genPIN();
                masterDataGridView.Rows[e.RowIndex].Cells["OFFICER"].Value = GlobalVariables.GUserID;

            }

        }
    }
}
