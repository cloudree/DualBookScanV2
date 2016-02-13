using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Controls;
using AForge.Video;
using AForge.Video.DirectShow;

namespace DualBookScanV2
{
    public partial class dlgCameraConfig : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCapabilities[] videoCaps;
        public VideoSourcePlayer videoPlayer;

        public dlgCameraConfig()
        {
            InitializeComponent();
        }

        private void dlgCameraConfig_Load(object sender, EventArgs e)
        {
            setupVideoDevices();
        }

        private void cbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDevicesSelectedIndexChanged();
        }
        
        private void cbResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            CameraStop();
            CameraStart();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            CameraStop();
            CameraStart();

            this.DialogResult = DialogResult.OK;
            Close();
        }

        // actions 

        private void setupVideoDevices()
        {
            try
            {
                // enumerate video devices
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                {
                    throw new Exception();
                }

                for (int i = 1, n = videoDevices.Count; i <= n; i++)
                {
                    string cameraName = i + " : " + videoDevices[i - 1].Name;
                    cbDevice.Items.Add(cameraName);
                }
                
                cbDevice.SelectedIndex = 0;
            }
            catch
            {
                cbDevice.Items.Add( "No cameras found" );
                cbDevice.SelectedIndex = 0;
                cbDevice.Enabled = false;
            }
        }

        private void cbDevicesSelectedIndexChanged()
        {
            if (videoDevices.Count != 0)
            {
                VideoCaptureDevice videoDevice = new VideoCaptureDevice(videoDevices[cbDevice.SelectedIndex].MonikerString);

                cbResolution.Items.Clear();
                videoCaps = videoDevice.VideoCapabilities;

                foreach (VideoCapabilities capabilty in videoCaps)
                {
                    cbResolution.Items.Add(string.Format("{0} x {1}", capabilty.FrameSize.Width, capabilty.FrameSize.Height));
                }
                if (videoCaps.Length == 0)
                {
                    cbResolution.Items.Add("Not supported");
                }

                cbResolution.SelectedIndex = cbResolution.Items.Count - 1;
            }
        }

        private void CameraStart()
        {
            VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[cbDevice.SelectedIndex].MonikerString);
            videoSource.VideoResolution = videoCaps[cbResolution.SelectedIndex];
            videoPlayer.VideoSource = videoSource;
            videoPlayer.Start();
        }

        private void CameraStop()
        {
            videoPlayer.SignalToStop();
            videoPlayer.WaitForStop();
        }
    }
}
