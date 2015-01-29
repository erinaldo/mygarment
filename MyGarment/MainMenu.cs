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
using MyGarment.ViewFile;
using MyGarment.ViewMaster;
using MyGarment.ViewExim;
using MyGarment.ViewProduction;
namespace MyGarment
{
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void SetItemCallBack(string User,string Name,string GDIV)
        {
            tsUser.Text = User;
            tsName.Text = Name;
            tsDIV.Text = GDIV;
            //txtCategoryDesc.Text = categoryDesc;
        }
        private void customerSupplieeCMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmcustvend f = new frmmcustvend();
            f.MdiParent = this;
            f.Show();
            
        }

        private void costingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmmcost f = new frmmcost();
            f.MdiParent = this;
            f.Show();
            
        }

        private void uOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmuom f = new frmmuom();
            f.MdiParent = this;
            f.Show();
            
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
            this.Dispose();
            
        }

        private void mColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmcolor f = new frmmcolor();
            f.MdiParent = this;
            f.Show();
            
        }

        private void mCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmmcategory f = new frmmcategory();
            f.MdiParent = this;
            f.Show();
            
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmcurrency f = new frmmcurrency();
            f.MdiParent = this;
            f.Show();
            

            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
            frmLogin f = new frmLogin();
            f.AddItemCallback = new frmLogin.AddItemDelegate(this.SetItemCallBack);
            f.ShowDialog();
            
        }

        private void itemsCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmitemscategory f = new frmmitemscategory();
            f.MdiParent = this;
            f.Show();
            
        }

        private void itemsTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmitemstype f = new frmmitemstype();
            f.MdiParent = this;
            f.Show();
            
        }

        private void currencyRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmrate f = new frmmrate();
            f.MdiParent = this;
            f.Show();
                        
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmstore f = new frmmstore();
            f.MdiParent = this;
            f.Show();
            


        }

        private void termsOfPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmtermofpayment f = new frmmtermofpayment();
            f.MdiParent = this;
            f.Show();
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmitems f = new frmmitems();
            f.MdiParent = this;
            f.Show();
            
        }

        private void mTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmtype f = new frmmtype();
            f.MdiParent = this;
            f.Show();
            
        }

        private void costingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmcosting f = new frmcosting();
            f.MdiParent = this;
            f.Show();
            

        }

        private void pOMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchasinfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchase f = new frmPurchase();
            f.MdiParent = this;
            f.Show();
            
        }

        private void purchasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchase f = new frmPurchase();
            f.MdiParent = this;
            f.Show();
            
        }

        private void materialReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgrn f = new frmgrn();
            f.MdiParent = this;
            f.Show();
          
        }

        private void materialIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmginMat f = new frmginMat();
            f.MdiParent = this;
            f.Show();
            
        }

        private void bOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbom f = new frmbom();
            f.MdiParent = this;
            f.Show();
            
        }

        private void jobOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmjoborder f = new frmjoborder();
            f.MdiParent = this;
            f.Show();
           
        }

        private void manageModulUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmoduluser f = new frmmoduluser();
            f.MdiParent = this;
            f.Show();
            

        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmuser f = new frmuser();
            f.MdiParent = this;
            f.Show();
            

        }

        private void garmentReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgrnCMT f = new frmgrnCMT();
            f.MdiParent = this;
            f.Show();
            
            
        }

        private void garmentReceiveFromOtherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgrnOther f = new frmgrnOther();
            f.MdiParent = this;
            f.Show();
            

        }

        private void itemsReceiveFromOtherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgrnOtherMat f = new frmgrnOtherMat();
            f.MdiParent = this;
            f.Show();
            

        }

        private void garmentIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgin f = new frmgin();
            f.MdiParent = this;
            f.Show();
            
        }

        private void itemsReceiveFromCMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgrnOtherMat f = new frmgrnOtherMat();
            f.MdiParent = this;
            f.Show();
            
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmsize f = new frmmsize();
            f.MdiParent = this;
            f.Show();
            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.AddItemCallback = new frmLogin.AddItemDelegate(this.SetItemCallBack);
            f.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

       
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Shown(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmuserchange f = new frmuserchange();
            f.MdiParent = this;
            f.Show();
            
        }

        private void garmentIssueOtherToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoice f = new frmInvoice();
            f.MdiParent = this;
            f.Show();
            
        }

        private void storeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void componentReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgrntComponent f = new frmgrntComponent();
            f.MdiParent = this;
            f.Show();
            
        }

        private void componentIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmginComponent f = new frmginComponent();
            f.MdiParent = this;
            f.Show();
            
        }

        private void eximReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbcInput f = new frmbcInput();
            f.MdiParent = this;
            f.Show();
            

        }

        private void reportBeaCukaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportBeaCukai f = new frmReportBeaCukai();
            f.MdiParent = this;
            f.Show();
            

        }

        private void materialReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuttingmatreturn f = new cuttingmatreturn();
            f.MdiParent = this;
            f.Show();
        }

        private void initialProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInitProduction f = new frmInitProduction();
            f.MdiParent = this;
            f.Show();
        }

        private void materialReceiveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cuttingmatreceive f = new cuttingmatreceive();
            f.MdiParent=this;
            f.Show();
        }

        private void processCuttingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutting f = new cutting();
            f.MdiParent = this;
            f.Show();
        }

        private void componentReceiveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cuttingcompreceive f = new cuttingcompreceive();
            f.MdiParent = this;
            f.Show();
        }

        private void sewingProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sewing f = new sewing();
            f.MdiParent = this;
            f.Show();
        }

        private void itemsReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sewingmatreceive f = new sewingmatreceive();
            f.MdiParent = this;
            f.Show();

        }

        private void itemsReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sewingmatreturn f = new sewingmatreturn();
            f.MdiParent = this;
            f.Show();
        }

        private void componentReceiveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            sewingcompreceive f = new sewingcompreceive();
            f.MdiParent = this;
            f.Show();
        }

        private void componentDeliveryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sewingcompreturn f = new sewingcompreturn();
            f.MdiParent = this;
            f.Show();
        }

        private void finishingProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            finishing f = new finishing();
            f.MdiParent = this;
            f.Show();
        }

        private void itemsReceiveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            finishingmatreceive f = new finishingmatreceive();
            f.MdiParent = this;
            f.Show();
        }

        private void itemsReturnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            finishingmatreturn f = new finishingmatreturn();
            f.MdiParent = this;
            f.Show();
        }

        private void componentReceiveToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            finishingcompreceive f = new finishingcompreceive();
            f.MdiParent = this;
            f.Show();
        }

        private void componentDeliveryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            finishingcompreturn f = new finishingcompreturn();
            f.MdiParent = this;
            f.Show();
        }
    }
}
