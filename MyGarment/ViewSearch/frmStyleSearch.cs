using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyGarment.ClassMaster;

namespace MyGarment.ViewSearch
{
    public partial class frmStyleSearch : Form
    {
        public delegate void AddStyleDelegate(string itemID, string itemDesc);
        public AddStyleDelegate AddItemCallback;

        public frmStyleSearch()
        {
            InitializeComponent();
        }

        private void RecordTSB_Click(object sender, EventArgs e)
        {

        }

        private void TutupTSB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
