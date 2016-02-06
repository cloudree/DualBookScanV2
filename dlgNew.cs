using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualBookScanV2
{
    public partial class dlgNew : Form
    {
        public String FileName;
        public bool isReverse;

        public dlgNew()
        {
            FileName = "";
            isReverse = false;
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if( dlgSaveFile.ShowDialog() == DialogResult.OK )
            {
                ebFileName.Text = dlgSaveFile.FileName;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FileName = ebFileName.Text;
            isReverse = chkReversePaging.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
