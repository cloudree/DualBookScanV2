namespace DualBookScanV2
{
    partial class dlgNew
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ebFileName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.chkReversePaging = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new book Project to scanning...\r\n\r\n ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name && Folder :";
            // 
            // ebFileName
            // 
            this.ebFileName.Location = new System.Drawing.Point(148, 50);
            this.ebFileName.Name = "ebFileName";
            this.ebFileName.Size = new System.Drawing.Size(345, 21);
            this.ebFileName.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(502, 50);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 21);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // chkReversePaging
            // 
            this.chkReversePaging.AutoSize = true;
            this.chkReversePaging.Location = new System.Drawing.Point(14, 87);
            this.chkReversePaging.Name = "chkReversePaging";
            this.chkReversePaging.Size = new System.Drawing.Size(182, 16);
            this.chkReversePaging.TabIndex = 6;
            this.chkReversePaging.Text = "Reverse Paging (Japanese)";
            this.chkReversePaging.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(231, 115);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 35);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.DefaultExt = "Book";
            this.dlgSaveFile.Filter = "Book files|*.Book|All files|*.*";
            // 
            // dlgNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 167);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkReversePaging);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.ebFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgNew";
            this.Text = "New Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.TextBox ebFileName;
        private System.Windows.Forms.CheckBox chkReversePaging;
    }
}