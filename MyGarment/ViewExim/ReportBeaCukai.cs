using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.PrintExim;
using MyGarment.ClassExim;

namespace MyGarment.ViewExim
{
    public partial class frmReportBeaCukai : Form
    {
        public frmReportBeaCukai()
        {
            InitializeComponent();
        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            if (checkBeaCukai1.Checked)
            {
                DataSet data = new eximdocCRUD().prBeaCukai1(dateFrom.Value,dateTo.Value);
                Application.DoEvents();
                data.WriteXml("C:\\MyGarmentReport\\BeaCukai1.xml", XmlWriteMode.WriteSchema);
                PrintBeaCukai1 f = new PrintBeaCukai1();
                f.Show();

            }
            if(checkBeaCukai2.Checked)
            {
                DataSet data = new eximdocCRUD().prBeaCukai2(dateFrom.Value, dateTo.Value);
                Application.DoEvents();
                data.WriteXml("C:\\MyGarmentReport\\BeaCukai2.xml", XmlWriteMode.WriteSchema);
                PrintBeaCukai2 f = new PrintBeaCukai2();
                f.Show();
            }
            if (checkBeaCukai3.Checked)
            {
                DataSet data = new eximdocCRUD().prBeaCukai3(dateFrom.Value, dateTo.Value);
                Application.DoEvents();
                data.WriteXml("C:\\MyGarmentReport\\BeaCukai3.xml", XmlWriteMode.WriteSchema);
                PrintBeaCukai3 f = new PrintBeaCukai3();
                f.Show();

            }
            if (checkBeaCukai4.Checked)
            {
                DataSet data = new eximdocCRUD().prBeaCukai4(dateFrom.Value, dateTo.Value);
                Application.DoEvents();
                data.WriteXml("C:\\MyGarmentReport\\BeaCukai4.xml", XmlWriteMode.WriteSchema);
                PrintBeaCukai4 f = new PrintBeaCukai4();
                f.Show();
            }
            if (checkBeaCukai5.Checked)
            {
                DataSet data = new eximdocCRUD().prBeaCukai5(dateFrom.Value, dateTo.Value);
                Application.DoEvents();
                data.WriteXml("C:\\MyGarmentReport\\BeaCukai5.xml", XmlWriteMode.WriteSchema);
                PrintBeaCukai5 f = new PrintBeaCukai5();
                f.Show();
            }
            if (checkBeaCukai6.Checked)
            {
                DataSet data = new eximdocCRUD().prBeaCukai6(dateFrom.Value, dateTo.Value);
                Application.DoEvents();
                data.WriteXml("C:\\MyGarmentReport\\BeaCukai6.xml", XmlWriteMode.WriteSchema);
                PrintBeaCukai6 f = new PrintBeaCukai6();
                f.Show();
            }
            if (checkBeaCukai7.Checked)
            {
                DataSet data = new eximdocCRUD().prBeaCukai7(dateFrom.Value, dateTo.Value);
                Application.DoEvents();
                data.WriteXml("C:\\MyGarmentReport\\BeaCukai7.xml", XmlWriteMode.WriteSchema);
                PrintBeaCukai7 f = new PrintBeaCukai7();
                f.Show();
            }
        }

        private void ReportBeaCukai_Load(object sender, EventArgs e)
        {

        }
    }
}
