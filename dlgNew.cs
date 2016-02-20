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
        public String FolderName;
        public String BookName;
        public bool isReverse;

        public dlgNew()
        {
            FolderName = "";
            BookName = "";
            isReverse = false;
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FolderName = ebFolderName.Text;
            BookName = ebBookName.Text;
            isReverse = chkReversePaging.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnFolderBrowse_Click(object sender, EventArgs e)
        {
            if (dlgFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                ebFolderName.Text = dlgFolderBrowser.SelectedPath;
            }
        }

        private void btnFileBrowse_Click(object sender, EventArgs e)
        {
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                ebFolderName.Text = System.IO.Path.GetDirectoryName(dlgSaveFile.FileName);
                ebBookName.Text = System.IO.Path.GetFileName(dlgSaveFile.FileName);
            }

        }
    }
}
