using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.Main.Master;
using MyGarment.ViewForm;
using MyGarment.ViewMD;
using MyGarment.ViewFinance;
using MyGarment.ViewStore;
namespace MyGarment
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void customerSupplieeCMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmcustvend f = new frmmcustvend();
            f.Show();
            f.MdiParent = this;
        }

        private void costingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmmcost f = new frmmcost();
            
            f.Show();
            f.MdiParent = this;
        }

        private void uOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmuom f = new frmmuom();
            f.Show();
            f.MdiParent = this;
        }

        private void KeluarTsb_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmcolor f = new frmmcolor();
            f.Show();
            f.MdiParent = this;
        }

        private void mCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmmcategory f = new frmmcategory();
            f.Show();
            f.MdiParent = this;
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmcurrency f = new frmmcurrency();
            f.Show();
            f.MdiParent = this;

            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void itemsCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmitemscategory f = new frmmitemscategory();
            f.Show();
            f.MdiParent = this;
        }

        private void itemsTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmitemstype f = new frmmitemstype();
            f.Show();
            f.MdiParent = this;
        }

        private void currencyRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmrate f = new frmmrate();
            f.Show();
            f.MdiParent = this;

            
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmstore f = new frmmstore();
            f.Show();
            f.MdiParent = this;


        }

        private void termsOfPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmtermofpayment f = new frmmtermofpayment();
            f.Show();
            f.MdiParent = this;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmitems f = new frmmitems();
            f.Show();
            f.MdiParent = this;
        }

        private void mTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmtype f = new frmmtype();
            f.Show();
            f.MdiParent = this;
        }

        private void costingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcosting f = new frmcosting();
            f.Show();
            f.MdiParent = this;
        }

        private void pOMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchasinfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchase f = new frmPurchase();
            f.Show();
            f.MdiParent = this;
        }

        private void purchasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchase f = new frmPurchase();
            f.Show();
            f.MdiParent = this;
        }

        private void materialReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgrn f = new frmgrn();
            f.Show();
            f.MdiParent = this;
        }

        private void materialIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgin f = new frmgin();
            f.Show();
            f.MdiParent = this;
        }

        private void bOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbom f = new frmbom();
            f.Show();
            f.MdiParent=this;
        }

        private void jobOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmjoborder f = new frmjoborder();
            f.Show();
            f.MdiParent = this;
        }
    }
}
