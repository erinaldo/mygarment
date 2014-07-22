using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyGarment.ViewSearch
{
    public partial class frmCustomerSearch : Form
    {
        public delegate void AddCustomerDelegate(string itemID, string itemDesc);
        public AddCustomerDelegate AddItemCallback;
        public frmCustomerSearch()
        {
            InitializeComponent();
        }

        private void frmCustomerSearch_Load(object sender, EventArgs e)
        {

        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
