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
            this.imageListPages = new System.Windows.Forms.ImageList(this.components);
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCameras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLeftCamera = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRightCamera = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBatch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.grpFilers = new System.Windows.Forms.GroupBox();
            this.btnScanRight = new System.Windows.Forms.Button();
            this.btnScanBoth = new System.Windows.Forms.Button();
            this.btnScanLeft = new System.Windows.Forms.Button();
            this.rbFilterGrayScale = new System.Windows.Forms.RadioButton();
            this.rbFilterColor = new System.Windows.Forms.RadioButton();
            this.grpScan = new System.Windows.Forms.GroupBox();
            this.txtRightFPS = new System.Windows.Forms.Label();
            this.txtLeftFPS = new System.Windows.Forms.Label();
            this.btnRightCameraSetup = new System.Windows.Forms.Button();
            this.btnLeftCameraSetup = new System.Windows.Forms.Button();
            this.VideoSourcePlayerLeft = new AForge.Controls.VideoSourcePlayer();
            this.VideoSourcePlayerRight = new AForge.Controls.VideoSourcePlayer();
            this.dlgSaveAsFile = new System.Windows.Forms.SaveFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNextPage = new System.Windows.Forms.NumericUpDown();
            this.listViewPages = new System.Windows.Forms.ListView();
            this.menuMain.SuspendLayout();
            this.grpFilers.SuspendLayout();
            this.grpScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.grpBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNextPage)).BeginInit();
            this.SuspendLayout();
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
            this.menuMain.Size = new System.Drawing.Size(973, 24);
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
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(160, 22);
            this.menuSaveAs.Text = "Save As Book ...";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAsBook_Click);
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
            this.menuBatch.Size = new System.Drawing.Size(125, 22);
            this.menuBatch.Text = "Batch...";
            this.menuBatch.Click += new System.EventHandler(this.menuBatch_Click);
            // 
            // menuOption
            // 
            this.menuOption.Name = "menuOption";
            this.menuOption.Size = new System.Drawing.Size(125, 22);
            this.menuOption.Text = "Options...";
            this.menuOption.Click += new System.EventHandler(this.menuOption_Click);
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
            this.menuAbout.Size = new System.Drawing.Size(120, 22);
            this.menuAbout.Text = "About ...";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "dlgOpenFile";
            // 
            // grpFilers
            // 
            this.grpFilers.Controls.Add(this.btnScanRight);
            this.grpFilers.Controls.Add(this.btnScanBoth);
            this.grpFilers.Controls.Add(this.btnScanLeft);
            this.grpFilers.Controls.Add(this.rbFilterGrayScale);
            this.grpFilers.Controls.Add(this.rbFilterColor);
            this.grpFilers.Location = new System.Drawing.Point(460, 29);
            this.grpFilers.Name = "grpFilers";
            this.grpFilers.Size = new System.Drawing.Size(200, 259);
            this.grpFilers.TabIndex = 2;
            this.grpFilers.TabStop = false;
            this.grpFilers.Text = "Filters";
            // 
            // btnScanRight
            // 
            this.btnScanRight.Location = new System.Drawing.Point(141, 175);
            this.btnScanRight.Name = "btnScanRight";
            this.btnScanRight.Size = new System.Drawing.Size(53, 75);
            this.btnScanRight.TabIndex = 5;
            this.btnScanRight.Text = "Scan Right";
            this.btnScanRight.UseVisualStyleBackColor = true;
            this.btnScanRight.Click += new System.EventHandler(this.btnScanRight_Click);
            // 
            // btnScanBoth
            // 
            this.btnScanBoth.Location = new System.Drawing.Point(65, 175);
            this.btnScanBoth.Name = "btnScanBoth";
            this.btnScanBoth.Size = new System.Drawing.Size(70, 75);
            this.btnScanBoth.TabIndex = 4;
            this.btnScanBoth.Text = "Scan Both";
            this.btnScanBoth.UseVisualStyleBackColor = true;
            this.btnScanBoth.Click += new System.EventHandler(this.btnScanBoth_Click);
            // 
            // btnScanLeft
            // 
            this.btnScanLeft.Location = new System.Drawing.Point(6, 175);
            this.btnScanLeft.Name = "btnScanLeft";
            this.btnScanLeft.Size = new System.Drawing.Size(53, 75);
            this.btnScanLeft.TabIndex = 3;
            this.btnScanLeft.Text = "Scan Left";
            this.btnScanLeft.UseVisualStyleBackColor = true;
            this.btnScanLeft.Click += new System.EventHandler(this.btnScanLeft_Click);
            // 
            // rbFilterGrayScale
            // 
            this.rbFilterGrayScale.AutoSize = true;
            this.rbFilterGrayScale.Location = new System.Drawing.Point(6, 42);
            this.rbFilterGrayScale.Name = "rbFilterGrayScale";
            this.rbFilterGrayScale.Size = new System.Drawing.Size(86, 16);
            this.rbFilterGrayScale.TabIndex = 1;
            this.rbFilterGrayScale.Text = "Gray Scale";
            this.rbFilterGrayScale.UseVisualStyleBackColor = true;
            // 
            // rbFilterColor
            // 
            this.rbFilterColor.AutoSize = true;
            this.rbFilterColor.Checked = true;
            this.rbFilterColor.Location = new System.Drawing.Point(6, 20);
            this.rbFilterColor.Name = "rbFilterColor";
            this.rbFilterColor.Size = new System.Drawing.Size(53, 16);
            this.rbFilterColor.TabIndex = 0;
            this.rbFilterColor.TabStop = true;
            this.rbFilterColor.Text = "Color";
            this.rbFilterColor.UseVisualStyleBackColor = true;
            // 
            // grpScan
            // 
            this.grpScan.Controls.Add(this.txtRightFPS);
            this.grpScan.Controls.Add(this.txtLeftFPS);
            this.grpScan.Controls.Add(this.btnRightCameraSetup);
            this.grpScan.Controls.Add(this.btnLeftCameraSetup);
            this.grpScan.Controls.Add(this.VideoSourcePlayerLeft);
            this.grpScan.Controls.Add(this.VideoSourcePlayerRight);
            this.grpScan.Location = new System.Drawing.Point(12, 29);
            this.grpScan.Name = "grpScan";
            this.grpScan.Size = new System.Drawing.Size(442, 349);
            this.grpScan.TabIndex = 9;
            this.grpScan.TabStop = false;
            this.grpScan.Text = "Scan";
            // 
            // txtRightFPS
            // 
            this.txtRightFPS.AutoSize = true;
            this.txtRightFPS.Location = new System.Drawing.Point(401, 25);
            this.txtRightFPS.Name = "txtRightFPS";
            this.txtRightFPS.Size = new System.Drawing.Size(46, 12);
            this.txtRightFPS.TabIndex = 14;
            this.txtRightFPS.Text = "0.0 Fps";
            // 
            // txtLeftFPS
            // 
            this.txtLeftFPS.AutoSize = true;
            this.txtLeftFPS.Location = new System.Drawing.Point(183, 25);
            this.txtLeftFPS.Name = "txtLeftFPS";
            this.txtLeftFPS.Size = new System.Drawing.Size(46, 12);
            this.txtLeftFPS.TabIndex = 13;
            this.txtLeftFPS.Text = "0.0 Fps";
            // 
            // btnRightCameraSetup
            // 
            this.btnRightCameraSetup.Location = new System.Drawing.Point(224, 20);
            this.btnRightCameraSetup.Name = "btnRightCameraSetup";
            this.btnRightCameraSetup.Size = new System.Drawing.Size(171, 23);
            this.btnRightCameraSetup.TabIndex = 12;
            this.btnRightCameraSetup.Text = "Right Camera Setup...";
            this.btnRightCameraSetup.UseVisualStyleBackColor = true;
            this.btnRightCameraSetup.Click += new System.EventHandler(this.btnRightCameraSetup_Click);
            // 
            // btnLeftCameraSetup
            // 
            this.btnLeftCameraSetup.Location = new System.Drawing.Point(6, 20);
            this.btnLeftCameraSetup.Name = "btnLeftCameraSetup";
            this.btnLeftCameraSetup.Size = new System.Drawing.Size(171, 23);
            this.btnLeftCameraSetup.TabIndex = 11;
            this.btnLeftCameraSetup.Text = "Left Camera Setup...";
            this.btnLeftCameraSetup.UseVisualStyleBackColor = true;
            this.btnLeftCameraSetup.Click += new System.EventHandler(this.btnLeftCameraSetup_Click);
            // 
            // VideoSourcePlayerLeft
            // 
            this.VideoSourcePlayerLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.VideoSourcePlayerLeft.ForeColor = System.Drawing.Color.White;
            this.VideoSourcePlayerLeft.Location = new System.Drawing.Point(6, 49);
            this.VideoSourcePlayerLeft.Name = "VideoSourcePlayerLeft";
            this.VideoSourcePlayerLeft.Size = new System.Drawing.Size(100, 100);
            this.VideoSourcePlayerLeft.TabIndex = 9;
            this.VideoSourcePlayerLeft.VideoSource = null;
            this.VideoSourcePlayerLeft.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.VideoSourcePlayerLeft_NewFrame);
            this.VideoSourcePlayerLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayerLeft_MouseClick);
            this.VideoSourcePlayerLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayerLeft_MouseMove);
            // 
            // VideoSourcePlayerRight
            // 
            this.VideoSourcePlayerRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.VideoSourcePlayerRight.ForeColor = System.Drawing.Color.White;
            this.VideoSourcePlayerRight.Location = new System.Drawing.Point(224, 49);
            this.VideoSourcePlayerRight.Name = "VideoSourcePlayerRight";
            this.VideoSourcePlayerRight.Size = new System.Drawing.Size(100, 100);
            this.VideoSourcePlayerRight.TabIndex = 10;
            this.VideoSourcePlayerRight.VideoSource = null;
            this.VideoSourcePlayerRight.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.VideoSourcePlayerRight_NewFrame);
            this.VideoSourcePlayerRight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayerRight_MouseClick);
            this.VideoSourcePlayerRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayerRight_MouseMove);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pbPreview
            // 
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreview.ErrorImage = null;
            this.pbPreview.Location = new System.Drawing.Point(460, 294);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(200, 84);
            this.pbPreview.TabIndex = 10;
            this.pbPreview.TabStop = false;
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.label1);
            this.grpBook.Controls.Add(this.nudNextPage);
            this.grpBook.Controls.Add(this.listViewPages);
            this.grpBook.Location = new System.Drawing.Point(667, 27);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(200, 351);
            this.grpBook.TabIndex = 11;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Next Page :";
            // 
            // nudNextPage
            // 
            this.nudNextPage.Location = new System.Drawing.Point(86, 17);
            this.nudNextPage.Name = "nudNextPage";
            this.nudNextPage.Size = new System.Drawing.Size(108, 21);
            this.nudNextPage.TabIndex = 2;
            // 
            // listViewPages
            // 
            this.listViewPages.LargeImageList = this.imageListPages;
            this.listViewPages.Location = new System.Drawing.Point(6, 44);
            this.listViewPages.Name = "listViewPages";
            this.listViewPages.Size = new System.Drawing.Size(188, 301);
            this.listViewPages.SmallImageList = this.imageListPages;
            this.listViewPages.TabIndex = 1;
            this.listViewPages.UseCompatibleStateImageBehavior = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 427);
            this.Controls.Add(this.grpBook);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.grpScan);
            this.Controls.Add(this.grpFilers);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = "DualBookScan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.grpFilers.ResumeLayout(false);
            this.grpFilers.PerformLayout();
            this.grpScan.ResumeLayout(false);
            this.grpScan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNextPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ToolStripMenuItem menuOption;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.SaveFileDialog dlgSaveAsFile;
        public AForge.Controls.VideoSourcePlayer VideoSourcePlayerLeft;
        public AForge.Controls.VideoSourcePlayer VideoSourcePlayerRight;
        private System.Windows.Forms.Label txtRightFPS;
        private System.Windows.Forms.Label txtLeftFPS;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RadioButton rbFilterColor;
        private System.Windows.Forms.RadioButton rbFilterGrayScale;
        private System.Windows.Forms.Button btnScanRight;
        private System.Windows.Forms.Button btnScanBoth;
        private System.Windows.Forms.Button btnScanLeft;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.ListView listViewPages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNextPage;
    }
}

