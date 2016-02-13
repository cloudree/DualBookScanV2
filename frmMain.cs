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

        // Components
        private List<AForge.Controls.VideoSourcePlayer> videoPlayers = new List<AForge.Controls.VideoSourcePlayer>();

        // stop watch for measuring fps
        private Stopwatch stopWatch = null;

        // where mouse is clicked;
        enum MouseClicked
        {
            None = -1, 
            Left = 0,       // left scan view
            Right = 1       // right scan view
        };
        private MouseClicked clicked = MouseClicked.None;
        
        public frmMain()
        {
            InitializeComponent();
            book = new BookProject();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            RefreshImageListPages();
            RefreshTitleBar();

            clicked = MouseClicked.None;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            AllCameraStop();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            RefreshSize();
        }

        private new void SuspendLayout()
        {
            videoPlayers.Add(VideoSourcePlayerLeft);
            videoPlayers.Add(VideoSourcePlayerRight);
        }

        // Basic modules =====================
        private void RefreshTitleBar()
        {
            this.Text = "DualBookScan : " + book.BookName;
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
            VideoSourcePlayerRight.Location = new Point(center, VideoSourcePlayerLeft.Location.Y);

            // camera-related
            float aspectRatio = 3 / 4.0f;
            VideoSourcePlayerLeft.Height = grpScan.Size.Height - VideoSourcePlayerLeft.Location.Y - margin;
            VideoSourcePlayerLeft.Width = (int)(VideoSourcePlayerLeft.Height * aspectRatio);
            VideoSourcePlayerRight.Height = grpScan.Size.Height - VideoSourcePlayerRight.Location.Y - margin;
            VideoSourcePlayerRight.Width = (int)(VideoSourcePlayerRight.Height * aspectRatio);
        }

        private void CameraSetup(int idx)
        {
            dlgCameraConfig dlg = new dlgCameraConfig();
            dlg.videoPlayer = videoPlayers[idx];
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK)
            {
                timer.Start();
            }
        }

        private void AllCameraStop()
        {
            timer.Stop();
            VideoSourcePlayerLeft.SignalToStop();
            VideoSourcePlayerLeft.WaitForStop();
            VideoSourcePlayerRight.SignalToStop();
            VideoSourcePlayerRight.WaitForStop();
        }
        
        private int getFrameCount(int idx)
        {
            IVideoSource videoSource = videoPlayers[idx].VideoSource;
            return (videoSource != null) ? videoSource.FramesReceived : 0;
        }

        private void viewerNewFrame(int idx, ref Bitmap image)
        {
            switch (idx)
            {
                case 0:
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 1:
                    image.RotateFlip(RotateFlipType.Rotate90FlipXY);
                    break;
            }
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

        private Bitmap CropImage(Bitmap source, Rectangle rt)
        {
            Bitmap bmp = new Bitmap(rt.Size.Width, rt.Size.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(source, 0, 0, rt, GraphicsUnit.Pixel);
            return bmp;
        }

        private Bitmap FilterImage(Bitmap source)
        {
            if( rbFilterGrayScale.Checked )
                return Grayscale.CommonAlgorithms.BT709.Apply(source);
            return source;
        }

        private void PreviewImage(int idx, Rectangle rt)
        {
            Bitmap bmp = videoPlayers[idx].GetCurrentVideoFrame();
            if (bmp != null)
            {
                Bitmap cropped = CropImage(bmp, rt);
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

                Bitmap bmp = videoPlayers[idx].GetCurrentVideoFrame();
                Bitmap sub = CropImage(bmp, rt);
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
                string pathName = Path.GetDirectoryName(dlg.FileName);
                string fileName = Path.GetFileName(dlg.FileName);
                book.New(pathName, fileName, dlg.isReverse);
                RefreshTitleBar();
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
                string pathName = Path.GetDirectoryName(dlgSaveAsFile.FileName);
                string fileName = Path.GetFileName(dlgSaveAsFile.FileName);
                book.SaveAs(pathName, fileName);
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

        // Component Items ===================
        private void btnLeftCameraSetup_Click(object sender, EventArgs e)
        {
            CameraSetup(0);
        }

        private void btnRightCameraSetup_Click(object sender, EventArgs e)
        {
            CameraSetup(1);
        }

        // right video
        private void VideoSourcePlayerRight_NewFrame(object sender, ref Bitmap image)
        {
            viewerNewFrame(1, ref image);
        }
        
        private void VideoSourcePlayerRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked == MouseClicked.None)
            {
                Rectangle rt = new Rectangle(e.Location, pbPreview.Size);
                PreviewImage(1, rt);
            }
        }

        private void VideoSourcePlayerRight_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    clicked = MouseClicked.Right;       // lock preview position
                    break;
                case MouseButtons.Right:
                    clicked = MouseClicked.None;        // release preview position
                    break;
            }
        }

        // left video
        private void VideoSourcePlayerLeft_NewFrame(object sender, ref Bitmap image)
        {
            viewerNewFrame(0, ref image);
        }

        private void VideoSourcePlayerLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked == MouseClicked.None)
            {
                Rectangle rt = new Rectangle(e.Location, pbPreview.Size);
                PreviewImage(0, rt);
            }
        }

        private void VideoSourcePlayerLeft_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    clicked = MouseClicked.Left;        // lock preview position
                    break;
                case MouseButtons.Right:
                    clicked = MouseClicked.None;        // release preview position
                    break;
            }
        }

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
    }
}
