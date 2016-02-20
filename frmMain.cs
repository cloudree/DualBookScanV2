using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using AForge.Video;
using AForge.Imaging.Filters;

namespace DualBookScanV2
{
    public partial class frmMain : Form
    {
        private BookProject book;

        // Scan Viewer Controls
        private List<DualBookScan.CScanViewer> scanViewers = new List<DualBookScan.CScanViewer>();

        // stop watch for measuring fps
        private Stopwatch stopWatch = null;

        public frmMain()
        {
            InitializeComponent();

            scanViewers.Add(new DualBookScan.CScanViewer());
            this.grpScan.Controls.Add(this.scanViewers[0]);
            scanViewers[0].Rotate = RotateFlipType.Rotate90FlipNone;
            scanViewers[0].MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScanViewerLeft_MouseDown);
            
            scanViewers.Add(new DualBookScan.CScanViewer());
            this.grpScan.Controls.Add(this.scanViewers[1]);
            scanViewers[1].Rotate = RotateFlipType.Rotate90FlipXY;

            book = new BookProject();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            RefreshImageListPages();
            RefreshTitleBar();
            RefreshMenuItems();
            RefreshScanButtons();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            AllCameraStop();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            RefreshSize();
        }
        
        // Basic modules =====================
        private void RefreshTitleBar()
        {
            this.Text = "DualBookScan : " + book.BookName;
        }
        
        private void RefreshMenuItems()
        {
            menuSave.Enabled = book.HasBook();
            menuSaveAs.Enabled = book.HasBook();
            menuClose.Enabled = book.HasBook();
        }

        private void RefreshScanButtons()
        {
            btnScanLeft.Enabled = (scanViewers[0].VideoSource != null);
            btnScanRight.Enabled = (scanViewers[1].VideoSource != null);
            btnScanBoth.Enabled = btnScanLeft.Enabled & btnScanRight.Enabled;
        }
        
        private void RefreshImageListPages()
        {
            int idx = 0;
            foreach (String filename in book.ImageFileNames)
            {
                String item = String.Format("{0,6:000000}", idx);
                Bitmap bmp = new Bitmap(filename);
                imageListPages.Images.Add(item, bmp);

                listViewPages.Items.Add(new ListViewItem(item, idx));
                idx++;
            }
        }

        public void RefreshScanViewRatio()
        {
            int margin = grpScan.Location.X;
            float defaultRatio = 3 / 4.0f;

            scanViewers[0].Height = grpScan.Size.Height - scanViewers[0].Top - margin * 3;
            scanViewers[0].Width = (int)(scanViewers[0].Height * defaultRatio);
            scanViewers[1].Height = grpScan.Size.Height - scanViewers[1].Top - margin * 3;
            scanViewers[1].Width = (int)(scanViewers[1].Height * defaultRatio);

            scanViewers[0].AdjustRatio();
            scanViewers[1].AdjustRatio();
        }

        private void RefreshSize()
        {
            int margin = grpScan.Location.X;
            int height = ClientSize.Height - margin * 3;

            // groups
            grpBook.Size = new Size(grpBook.Width, height);
            grpBook.Location = new Point(ClientSize.Width - grpBook.Width - margin, grpBook.Location.Y);
            listViewPages.Size = new Size(listViewPages.Width, grpBook.Height - listViewPages.Top - margin);

            grpFilers.Size = new Size(grpFilers.Width, grpFilers.Height);
            grpFilers.Location = new Point(grpBook.Location.X - grpFilers.Width - margin, grpFilers.Location.Y);

            pbPreview.Size = new Size(pbPreview.Width, height - grpFilers.Height - margin);
            pbPreview.Location = new Point(grpFilers.Location.X, pbPreview.Location.Y);

            grpScan.Size = new Size(ClientSize.Width - grpBook.Width - grpFilers.Width - margin * 4, height);

            // grpScan
            int center = grpScan.Size.Width / 2;
            int interBtn = txtLeftFPS.Location.X - btnLeftCameraSetup.Location.X;
            btnRightCameraSetup.Location = new Point(center, btnRightCameraSetup.Location.Y);
            txtRightFPS.Location = new Point(center + interBtn, txtRightFPS.Location.Y);

            // scanViewers-related
            scanViewers[0].Location = new Point(btnLeftCameraSetup.Left, btnLeftCameraSetup.Bottom + margin);
            scanViewers[1].Location = new Point(center, btnRightCameraSetup.Bottom + margin);
            RefreshScanViewRatio();
        }

        private void CameraSetup(int idx)
        {
            dlgCameraConfig dlg = new dlgCameraConfig();
            dlg.videoPlayer = scanViewers[idx];
            dlg.ParentWindow = this;

            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK)
            {
                timer.Start();
            }
            RefreshScanButtons();
            RefreshScanViewRatio();
        }

        private void AllCameraStop()
        {
            timer.Stop();

            scanViewers[0].Stop();
            scanViewers[1].Stop();
        }
        
        private int getFrameCount(int idx)
        {
            IVideoSource videoSource = scanViewers[idx].VideoSource;
            return (videoSource != null) ? videoSource.FramesReceived : 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (stopWatch == null)
            {
                stopWatch = new Stopwatch();
                stopWatch.Start();
            }
            else
            {
                stopWatch.Stop();

                float fps1 = 1.0f * timer.Interval * getFrameCount(0) / stopWatch.ElapsedMilliseconds;
                float fps2 = 1.0f * timer.Interval * getFrameCount(1) / stopWatch.ElapsedMilliseconds;

                txtLeftFPS.Text = fps1.ToString("F2") + " fps";
                txtRightFPS.Text = fps2.ToString("F2") + " fps";

                stopWatch.Reset();
                stopWatch.Start();
            }
        }

        private Bitmap CropImage(Bitmap source, Rectangle rtSrc, Rectangle rtDest)
        {
            Bitmap bmp = new Bitmap(rtDest.Size.Width, rtDest.Size.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(source, rtDest, rtSrc, GraphicsUnit.Pixel);
            return bmp;
        }

        private Bitmap FilterImage(Bitmap source)
        {
            if( rbFilterGrayScale.Checked )
                return Grayscale.CommonAlgorithms.BT709.Apply(source);
            return source;
        }

        private void PreviewImage(int idx, Point pt)
        {
            Bitmap bmp = scanViewers[idx].GetCurrentVideoFrame();
            if (bmp != null)
            {
                Point rpt = new Point(pt.X * bmp.Width / scanViewers[idx].Width, pt.Y * bmp.Height / scanViewers[idx].Height);
                Rectangle rtSrc = new Rectangle(rpt, pbPreview.Size);
                Rectangle rtDest = new Rectangle(0, 0, pbPreview.Width, pbPreview.Height);
                Bitmap cropped = CropImage(bmp, rtSrc, rtDest);
                Bitmap filtered = FilterImage(cropped);
                pbPreview.Image = filtered;
            }
        }
        
        private void Scan(int idx)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                
                String fileName = String.Format("{0}\\{1,6:000000}.png", book.WorkingFolderName, nudNextPage.Value);

                Rectangle rt = new Rectangle(0, 0, 100, 100);   // RectResize(rect[idx], ratios[idx]);
                
                Bitmap bmp = scanViewers[idx].GetCurrentVideoFrame();
                Bitmap sub = CropImage(bmp, rt, rt);
                sub.Save(fileName, ImageFormat.Png);
                sub.Dispose();
                bmp.Dispose();
                
                nudNextPage.Value++;
            }
            catch
            {
                MessageBox.Show((idx == 0) ? "Left Save Error" : "Right Save Error");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        // Menu Items ========================
        private void menuNewBook_Click(object sender, EventArgs e)
        {
            if (book.QuerySave() == false)
                return;

            dlgNew dlg = new dlgNew();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                book.New(dlg.FolderName, dlg.BookName, dlg.isReverse);
                RefreshTitleBar();
                RefreshMenuItems();
            }
        }

        private void menuOpenBook_Click(object sender, EventArgs e)
        {
            if (book.QuerySave() == false)
                return;

            if( dlgOpenFile.ShowDialog() == DialogResult.OK )
            {
                string pathName = Path.GetDirectoryName(dlgOpenFile.FileName);
                string fileName = Path.GetFileName(dlgOpenFile.FileName);
                book.Load(pathName, fileName);
                RefreshTitleBar();
                RefreshMenuItems();
            }
        }

        private void menuSaveBook_Click(object sender, EventArgs e)
        {
            if (!book.HasBook())
                return;
            book.Save();
        }

        private void menuSaveAsBook_Click(object sender, EventArgs e)
        {
            if (!book.HasBook())
                return;
            if ( dlgSaveAsFile.ShowDialog() == DialogResult.OK )
            {
                string pathName = Path.GetDirectoryName(dlgSaveAsFile.FileName);
                string fileName = Path.GetFileName(dlgSaveAsFile.FileName);
                book.SaveAs(pathName, fileName);
                RefreshTitleBar();
                RefreshMenuItems();
            }
        }

        private void menuCloseBook_Click(object sender, EventArgs e)
        {
            if (book.QuerySave() == false)
                return;

            book.Close();
            RefreshTitleBar();
            RefreshMenuItems();
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

        // Component Items ===================
        private void btnLeftCameraSetup_Click(object sender, EventArgs e)
        {
            CameraSetup(0);
        }

        private void btnRightCameraSetup_Click(object sender, EventArgs e)
        {
            CameraSetup(1);
        }

        // scan buttons
        private void btnScanLeft_Click(object sender, EventArgs e)
        {
            Scan(0);
        }

        private void btnScanRight_Click(object sender, EventArgs e)
        {
            Scan(1);
        }

        private void btnScanBoth_Click(object sender, EventArgs e)
        {
            Scan(0);
            Scan(1);
        }
        
        // scanViewe external Handlers
        private void ScanViewerLeft_MouseDown(object sender, MouseEventArgs e)
        {
            PreviewImage(0, e.Location);
        }
    }
}
