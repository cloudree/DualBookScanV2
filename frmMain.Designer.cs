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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.grpFilers = new System.Windows.Forms.GroupBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            this.leftCameraSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightCameraSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLeftCameraSetup = new System.Windows.Forms.Button();
            this.btnRightCameraSetup = new System.Windows.Forms.Button();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPages
            // 
            this.listViewPages.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewPages.LargeImageList = this.imageListPages;
            this.listViewPages.Location = new System.Drawing.Point(12, 29);
            this.listViewPages.Name = "listViewPages";
            this.listViewPages.Size = new System.Drawing.Size(648, 119);
            this.listViewPages.SmallImageList = this.imageListPages;
            this.listViewPages.TabIndex = 0;
            this.listViewPages.UseCompatibleStateImageBehavior = false;
            // 
            // imageListPages
            // 
            this.imageListPages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListPages.ImageSize = new System.Drawing.Size(48, 64);
            this.imageListPages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(938, 24);
            this.menuMain.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeBookToolStripMenuItem,
            this.toolStripMenuItem1,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newProjectToolStripMenuItem.Text = "New Book ...";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.nenuItemNewBook_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openProjectToolStripMenuItem.Text = "Open Book ...";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.menuItemOpenBook_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save Book";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.menuItemSaveBook_Click);
            // 
            // closeBookToolStripMenuItem
            // 
            this.closeBookToolStripMenuItem.Name = "closeBookToolStripMenuItem";
            this.closeBookToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeBookToolStripMenuItem.Text = "Close Book";
            this.closeBookToolStripMenuItem.Click += new System.EventHandler(this.menuItemCloseBook_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "Options ...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.menuItemOptions_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftCameraSetupToolStripMenuItem,
            this.rightCameraSetupToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.editToolStripMenuItem.Text = "Cameras";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.aboutToolStripMenuItem.Text = "About ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "dlgOpenFile";
            // 
            // grpFilers
            // 
            this.grpFilers.Location = new System.Drawing.Point(12, 154);
            this.grpFilers.Name = "grpFilers";
            this.grpFilers.Size = new System.Drawing.Size(200, 225);
            this.grpFilers.TabIndex = 2;
            this.grpFilers.TabStop = false;
            this.grpFilers.Text = "Filters";
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.videoSourcePlayer1.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(218, 205);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(100, 100);
            this.videoSourcePlayer1.TabIndex = 6;
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // videoSourcePlayer2
            // 
            this.videoSourcePlayer2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.videoSourcePlayer2.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer2.Location = new System.Drawing.Point(324, 205);
            this.videoSourcePlayer2.Name = "videoSourcePlayer2";
            this.videoSourcePlayer2.Size = new System.Drawing.Size(100, 100);
            this.videoSourcePlayer2.TabIndex = 6;
            this.videoSourcePlayer2.VideoSource = null;
            // 
            // leftCameraSetupToolStripMenuItem
            // 
            this.leftCameraSetupToolStripMenuItem.Name = "leftCameraSetupToolStripMenuItem";
            this.leftCameraSetupToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.leftCameraSetupToolStripMenuItem.Text = "Left Camera Setup ...";
            this.leftCameraSetupToolStripMenuItem.Click += new System.EventHandler(this.leftCameraSetupToolStripMenuItem_Click);
            // 
            // rightCameraSetupToolStripMenuItem
            // 
            this.rightCameraSetupToolStripMenuItem.Name = "rightCameraSetupToolStripMenuItem";
            this.rightCameraSetupToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.rightCameraSetupToolStripMenuItem.Text = "Right Camera Setup ...";
            this.rightCameraSetupToolStripMenuItem.Click += new System.EventHandler(this.rightCameraSetupToolStripMenuItem_Click);
            // 
            // btnLeftCameraSetup
            // 
            this.btnLeftCameraSetup.Location = new System.Drawing.Point(218, 154);
            this.btnLeftCameraSetup.Name = "btnLeftCameraSetup";
            this.btnLeftCameraSetup.Size = new System.Drawing.Size(115, 23);
            this.btnLeftCameraSetup.TabIndex = 7;
            this.btnLeftCameraSetup.Text = "Left Camera ...";
            this.btnLeftCameraSetup.UseVisualStyleBackColor = true;
            this.btnLeftCameraSetup.Click += new System.EventHandler(this.btnLeftCameraSetup_Click);
            // 
            // btnRightCameraSetup
            // 
            this.btnRightCameraSetup.Location = new System.Drawing.Point(339, 154);
            this.btnRightCameraSetup.Name = "btnRightCameraSetup";
            this.btnRightCameraSetup.Size = new System.Drawing.Size(115, 23);
            this.btnRightCameraSetup.TabIndex = 8;
            this.btnRightCameraSetup.Text = "Right Camera ...";
            this.btnRightCameraSetup.UseVisualStyleBackColor = true;
            this.btnRightCameraSetup.Click += new System.EventHandler(this.btnRightCameraSetup_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 461);
            this.Controls.Add(this.btnRightCameraSetup);
            this.Controls.Add(this.btnLeftCameraSetup);
            this.Controls.Add(this.grpFilers);
            this.Controls.Add(this.listViewPages);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.videoSourcePlayer2);
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = "DualBookScan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPages;
        private System.Windows.Forms.ImageList imageListPages;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.GroupBox grpFilers;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
        private System.Windows.Forms.ToolStripMenuItem leftCameraSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightCameraSetupToolStripMenuItem;
        private System.Windows.Forms.Button btnLeftCameraSetup;
        private System.Windows.Forms.Button btnRightCameraSetup;
    }
}

