namespace DualBookScanV2
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewPages = new System.Windows.Forms.ListView();
            this.imageListPages = new System.Windows.Forms.ImageList(this.components);
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCameras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLeftCamera = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRightCamera = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.grpFilers = new System.Windows.Forms.GroupBox();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBatch = new System.Windows.Forms.ToolStripMenuItem();
            this.grpScan = new System.Windows.Forms.GroupBox();
            this.btnRightCameraSetup = new System.Windows.Forms.Button();
            this.btnLeftCameraSetup = new System.Windows.Forms.Button();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            this.menuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgSaveAsFile = new System.Windows.Forms.SaveFileDialog();
            this.menuMain.SuspendLayout();
            this.grpScan.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPages
            // 
            this.listViewPages.LargeImageList = this.imageListPages;
            this.listViewPages.Location = new System.Drawing.Point(667, 29);
            this.listViewPages.Name = "listViewPages";
            this.listViewPages.Size = new System.Drawing.Size(158, 349);
            this.listViewPages.SmallImageList = this.imageListPages;
            this.listViewPages.TabIndex = 0;
            this.listViewPages.UseCompatibleStateImageBehavior = false;
            // 
            // imageListPages
            // 
            this.imageListPages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListPages.ImageSize = new System.Drawing.Size(96, 128);
            this.imageListPages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuCameras,
            this.menuTools,
            this.menuHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(837, 24);
            this.menuMain.TabIndex = 1;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuSave,
            this.menuSaveAs,
            this.menuClose,
            this.toolStripMenuItem1,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(160, 22);
            this.menuNew.Text = "New Book ...";
            this.menuNew.Click += new System.EventHandler(this.menuNewBook_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(160, 22);
            this.menuOpen.Text = "Open Book ...";
            this.menuOpen.Click += new System.EventHandler(this.menuOpenBook_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(160, 22);
            this.menuSave.Text = "Save Book";
            this.menuSave.Click += new System.EventHandler(this.menuSaveBook_Click);
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(160, 22);
            this.menuClose.Text = "Close Book";
            this.menuClose.Click += new System.EventHandler(this.menuCloseBook_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(160, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuCameras
            // 
            this.menuCameras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLeftCamera,
            this.menuRightCamera});
            this.menuCameras.Name = "menuCameras";
            this.menuCameras.Size = new System.Drawing.Size(65, 20);
            this.menuCameras.Text = "Cameras";
            // 
            // menuLeftCamera
            // 
            this.menuLeftCamera.Name = "menuLeftCamera";
            this.menuLeftCamera.Size = new System.Drawing.Size(195, 22);
            this.menuLeftCamera.Text = "Left Camera Setup ...";
            this.menuLeftCamera.Click += new System.EventHandler(this.menuLeftCameraSetup_Click);
            // 
            // menuRightCamera
            // 
            this.menuRightCamera.Name = "menuRightCamera";
            this.menuRightCamera.Size = new System.Drawing.Size(195, 22);
            this.menuRightCamera.Text = "Right Camera Setup ...";
            this.menuRightCamera.Click += new System.EventHandler(this.menuRightCameraSetup_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(152, 22);
            this.menuAbout.Text = "About ...";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "dlgOpenFile";
            // 
            // grpFilers
            // 
            this.grpFilers.Location = new System.Drawing.Point(460, 29);
            this.grpFilers.Name = "grpFilers";
            this.grpFilers.Size = new System.Drawing.Size(200, 349);
            this.grpFilers.TabIndex = 2;
            this.grpFilers.TabStop = false;
            this.grpFilers.Text = "Filters";
            // 
            // menuTools
            // 
            this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBatch,
            this.menuOption});
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(47, 20);
            this.menuTools.Text = "Tools";
            // 
            // menuBatch
            // 
            this.menuBatch.Name = "menuBatch";
            this.menuBatch.Size = new System.Drawing.Size(152, 22);
            this.menuBatch.Text = "Batch...";
            this.menuBatch.Click += new System.EventHandler(this.menuBatch_Click);
            // 
            // grpScan
            // 
            this.grpScan.Controls.Add(this.btnRightCameraSetup);
            this.grpScan.Controls.Add(this.btnLeftCameraSetup);
            this.grpScan.Controls.Add(this.videoSourcePlayer1);
            this.grpScan.Controls.Add(this.videoSourcePlayer2);
            this.grpScan.Location = new System.Drawing.Point(12, 29);
            this.grpScan.Name = "grpScan";
            this.grpScan.Size = new System.Drawing.Size(442, 349);
            this.grpScan.TabIndex = 9;
            this.grpScan.TabStop = false;
            this.grpScan.Text = "Scan";
            // 
            // btnRightCameraSetup
            // 
            this.btnRightCameraSetup.Location = new System.Drawing.Point(265, 20);
            this.btnRightCameraSetup.Name = "btnRightCameraSetup";
            this.btnRightCameraSetup.Size = new System.Drawing.Size(171, 23);
            this.btnRightCameraSetup.TabIndex = 12;
            this.btnRightCameraSetup.Text = "Right Camera Setup...";
            this.btnRightCameraSetup.UseVisualStyleBackColor = true;
            // 
            // btnLeftCameraSetup
            // 
            this.btnLeftCameraSetup.Location = new System.Drawing.Point(6, 20);
            this.btnLeftCameraSetup.Name = "btnLeftCameraSetup";
            this.btnLeftCameraSetup.Size = new System.Drawing.Size(171, 23);
            this.btnLeftCameraSetup.TabIndex = 11;
            this.btnLeftCameraSetup.Text = "Left Camera Setup...";
            this.btnLeftCameraSetup.UseVisualStyleBackColor = true;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.videoSourcePlayer1.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(6, 49);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(100, 100);
            this.videoSourcePlayer1.TabIndex = 9;
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // videoSourcePlayer2
            // 
            this.videoSourcePlayer2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.videoSourcePlayer2.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer2.Location = new System.Drawing.Point(336, 49);
            this.videoSourcePlayer2.Name = "videoSourcePlayer2";
            this.videoSourcePlayer2.Size = new System.Drawing.Size(100, 100);
            this.videoSourcePlayer2.TabIndex = 10;
            this.videoSourcePlayer2.VideoSource = null;
            // 
            // menuOption
            // 
            this.menuOption.Name = "menuOption";
            this.menuOption.Size = new System.Drawing.Size(152, 22);
            this.menuOption.Text = "Options...";
            this.menuOption.Click += new System.EventHandler(this.menuOption_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(160, 22);
            this.menuSaveAs.Text = "Save As Book ...";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAsBook_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 390);
            this.Controls.Add(this.grpScan);
            this.Controls.Add(this.grpFilers);
            this.Controls.Add(this.listViewPages);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = "DualBookScan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.grpScan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPages;
        private System.Windows.Forms.ImageList imageListPages;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuCameras;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.GroupBox grpFilers;
        private System.Windows.Forms.ToolStripMenuItem menuLeftCamera;
        private System.Windows.Forms.ToolStripMenuItem menuRightCamera;
        private System.Windows.Forms.ToolStripMenuItem menuTools;
        private System.Windows.Forms.ToolStripMenuItem menuBatch;
        private System.Windows.Forms.GroupBox grpScan;
        private System.Windows.Forms.Button btnRightCameraSetup;
        private System.Windows.Forms.Button btnLeftCameraSetup;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
        private System.Windows.Forms.ToolStripMenuItem menuOption;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.SaveFileDialog dlgSaveAsFile;
    }
}

