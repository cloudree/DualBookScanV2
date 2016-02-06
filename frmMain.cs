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
            book = new BookProject();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ImageListPagesRefresh();
            RefreshTitleBar();
        }

        private void RefreshTitleBar()
        {
            this.Text = "DualBookScan : " + book.BookName;
        }

        private void ImageListPagesRefresh()
        {
            int idx = 0;
            foreach (String name in book.ImageFileNames)
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
            int margin = grpScan.Location.X;
            int height = ClientSize.Height - margin * 3;

            // groups
            listViewPages.Size = new Size(listViewPages.Width, height);
            listViewPages.Location = new Point(ClientSize.Width - listViewPages.Width - margin, listViewPages.Location.Y);

            grpFilers.Size = new Size(grpFilers.Width, height);
            grpFilers.Location = new Point(listViewPages.Location.X - grpFilers.Width - margin, grpFilers.Location.Y);

            grpScan.Size = new Size(ClientSize.Width - listViewPages.Width - grpFilers.Width - margin * 4, height);
            //grpScan.Location = new Point(...);

            // grpScan
            int center = grpScan.Size.Width / 2;
            btnRightCameraSetup.Location = new Point(center, btnRightCameraSetup.Location.Y);
            videoSourcePlayer2.Location = new Point(center, videoSourcePlayer1.Location.Y);

            // camera-related
            float aspectRatio = 3 / 4.0f;
            videoSourcePlayer1.Height = grpScan.Size.Height - margin * 2 - videoSourcePlayer1.Location.Y;
            videoSourcePlayer1.Width = (int)(videoSourcePlayer1.Height * aspectRatio);
            videoSourcePlayer2.Height = grpScan.Size.Height - margin * 2 - videoSourcePlayer2.Location.Y;
            videoSourcePlayer2.Width = (int)(videoSourcePlayer2.Height * aspectRatio);
        }
        
        private void CameraSetup(int idx)
        {

        }

        // Windows Events =============
        private void frmMain_Resize(object sender, EventArgs e)
        {
            RefreshSize();
        }

        // Component Items ===================

        // Menu Items ========================
        private void menuNewBook_Click(object sender, EventArgs e)
        {
            if (book.QuerySave() == false)
                return;

            dlgNew dlg = new dlgNew();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                book.New(dlg.FileName, dlg.isReverse);
                RefreshTitleBar();
            }
        }

        private void menuOpenBook_Click(object sender, EventArgs e)
        {
            if (book.QuerySave() == false)
                return;

            if( dlgOpenFile.ShowDialog() == DialogResult.OK )
            {
                book.Load(dlgOpenFile.FileName);
                RefreshTitleBar();
            }
        }

        private void menuSaveBook_Click(object sender, EventArgs e)
        {
            book.Save();
        }

        private void menuSaveAsBook_Click(object sender, EventArgs e)
        {
            if( dlgSaveAsFile.ShowDialog() == DialogResult.OK )
            {
                book.SaveAs( dlgSaveAsFile.FileName);
                RefreshTitleBar();
            }
        }

        private void menuCloseBook_Click(object sender, EventArgs e)
        {
            if (book.QuerySave() == false)
                return;

            book.Close();
            RefreshTitleBar();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            if (book.QuerySave() == false)
                return;

            this.Close();
        }

        private void menuLeftCameraSetup_Click(object sender, EventArgs e)
        {
            CameraSetup(0);
        }

        private void menuRightCameraSetup_Click(object sender, EventArgs e)
        {
            CameraSetup(1);
        }

        private void menuBatch_Click(object sender, EventArgs e)
        {

        }

        private void menuOption_Click(object sender, EventArgs e)
        {

        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            dlgAbout dlg = new dlgAbout();
            dlg.ShowDialog();
        }
    }
}
