using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Imaging.Filters;

#pragma warning disable 0414

namespace DualBookScan
{
    public partial class CScanViewer : AForge.Controls.VideoSourcePlayer
    {
        private System.Windows.Forms.AutoScaleMode AutoScaleMode;
        private RotateFlipType rotate;
        private Size frameSize;

        // mouse Drag control
        enum mouseDragType
        {
            mouseDrag_None = 0,
            mouseDrag_LeftButton,
        };
        private mouseDragType mouseDrag = mouseDragType.mouseDrag_None;

        public CScanViewer()
        {
            InitializeComponent();

            this.Location = new Point(10, 10);
            this.Size = new Size(10, 10);
            this.Visible = true;
            rotate = RotateFlipType.Rotate90FlipNone;       // RotateFlipType.Rotate90FlipXY
            frameSize = new Size(0, 0);

            this.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(frameHandler);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownHandler);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpHandler);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMoveHandler);
        }

        public RotateFlipType Rotate
        {
            get { return rotate; }
            set { rotate = Rotate; }
        }

        public void AdjustRatio()
        {
            if (frameSize.IsEmpty)
                return;
            float frameRatio = frameSize.Width * 1.0f / frameSize.Height;
            float thisRatio = this.Width * 1.0f / this.Height;

            if (Math.Abs(frameRatio - thisRatio) < 0.1)
                return;

            if( frameRatio > thisRatio)
            {
                this.Size = new Size(this.Width, (int)(this.Width / frameRatio));
            }
            else
            {
                this.Size = new Size((int)(this.Height * frameRatio), this.Height);
            }
        }

        // events
        protected override void OnResize(EventArgs e)
        {
        }

        // handlers
        private void frameHandler(object sender, ref Bitmap image)
        {
            image.RotateFlip(rotate);
            frameSize = image.Size;
        }

        private void mouseDownHandler(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    mouseDrag = mouseDragType.mouseDrag_LeftButton;
                    break;
                case MouseButtons.Right:
                    break;
            }
        }

        private void mouseUpHandler(object sender, MouseEventArgs e)
        {
            if (mouseDrag == mouseDragType.mouseDrag_LeftButton)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        mouseDrag = mouseDragType.mouseDrag_None;
                        break;
                    case MouseButtons.Right:
                        break;
                }
            }
        }

        private void mouseMoveHandler(object sender, MouseEventArgs e)
        {

        }
    }
}
