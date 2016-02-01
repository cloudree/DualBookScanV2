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
    public partial class frmMain : Form
    {
        private BookProject book;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ImageListPagesRefresh();
        }

        private void ImageListPagesRefresh()
        {
            String[] fileNames = {
                "C:\\MSX\\Labels\\octo_label.png",
                "C:\\MSX\\Labels\\op4 sound card label copy.png",
                "C:\\MSX\\Labels\\octo_label.png",
                "C:\\MSX\\Labels\\op4 sound card label copy.png",
                "C:\\MSX\\Labels\\octo_label.png",
                "C:\\MSX\\Labels\\op4 sound card label copy.png",
                "C:\\MSX\\Labels\\octo_label.png",
                "C:\\MSX\\Labels\\op4 sound card label copy.png"
            };

            int idx = 0;
            foreach (String name in fileNames)
            {
                String item = String.Format("{0,6:000000}",idx);
                Bitmap bmp = new Bitmap(name);
                imageListPages.Images.Add(item, bmp);

                listViewPages.Items.Add(new ListViewItem(item, idx));
                idx++;
            }
        }

        void RefreshSize()
        {
            this.listViewPages.Size = new Size(this.Size.Width - listViewPages.Location.X * 3, this.listViewPages.Size.Height);
        }

        // Menu Items =================
        private void nenuItemNewBook_Click(object sender, EventArgs e)
        {
            dlgNew dlg = new dlgNew();
            DialogResult result = dlg.ShowDialog();
            if( result == DialogResult.OK )
            {
                book = new BookProject();
                book.m_stBookName = dlg.ebBookName.Text;
                book.m_stWorkingFolder = dlg.ebWorkingFolder.Text;
                book.m_bReverse = dlg.chkReversePaging.Checked;
            }
        }

        private void menuItemOpenBook_Click(object sender, EventArgs e)
        {
            this.dlgOpenFile.ShowDialog();
        }

        private void menuItemSaveBook_Click(object sender, EventArgs e)
        {

        }

        private void menuItemCloseBook_Click(object sender, EventArgs e)
        {

        }

        private void menuItemOptions_Click(object sender, EventArgs e)
        {

        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            dlgAbout dlg = new dlgAbout();
            dlg.ShowDialog();
        }

        // Windows Events =============
        private void frmMain_Resize(object sender, EventArgs e)
        {
            RefreshSize();
        }

        private void btnLeftCameraSetup_Click(object sender, EventArgs e)
        {
            CameraSetup(0);
        }

        private void btnRightCameraSetup_Click(object sender, EventArgs e)
        {
            CameraSetup(1);
        }

        private void CameraSetup(int idx)
        {

        }

        private void leftCameraSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CameraSetup(0);
        }

        private void rightCameraSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CameraSetup(1);
        }
    }
}
