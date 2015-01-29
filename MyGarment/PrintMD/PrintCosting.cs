using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace MyGarment.PrintMD
{
    public partial class PrintCosting : Form
    {
       
        public PrintCosting()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {


        }

        private void PrintCosting_Load(object sender, EventArgs e)
        {
            /*
            dsSource = new DataSet("tblcosting");
         //   reportDoc = new ReportDocument();
            dsSource.ReadXml(Application.StartupPath+"\\costing.xml");
          //  reportDoc.Load(Application.StartupPath + "\\costing.xml");
           // reportDoc.SetDataSource(dsSource);
           // crystalReportViewer1.ReportSource = reportDoc;
           
            //PrintCostingCr1.SetDataSource(dsSource);
         
            //crystalReportViewer1..ShowGroupTree();
           PrintCostingCr rptXMLReport = new PrintCostingCr();
           rptXMLReport.SetDataSource(dsSource);
           rptXMLReport.Load(PrintCostingCr1.FileName);
            crystalReportViewer1.ReportSource = PrintCostingCr1; 
            */
            
            
        }

        private void PrintCostingCr1_InitReport(object sender, EventArgs e)
        {
            
        }
    }
}
