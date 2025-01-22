namespace WinTree
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.selectDriveLabel = new System.Windows.Forms.Label();
            this.driveComboBox = new System.Windows.Forms.ComboBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.treeProcess = new System.Diagnostics.Process();
            this.SuspendLayout();
            // 
            // selectDriveLabel
            // 
            this.selectDriveLabel.AutoSize = true;
            this.selectDriveLabel.Location = new System.Drawing.Point(12, 9);
            this.selectDriveLabel.Name = "selectDriveLabel";
            this.selectDriveLabel.Size = new System.Drawing.Size(178, 12);
            this.selectDriveLabel.TabIndex = 0;
            this.selectDriveLabel.Text = "Select a drive to generate file list";
            // 
            // driveComboBox
            // 
            this.driveComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.driveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driveComboBox.FormattingEnabled = true;
            this.driveComboBox.ItemHeight = 35;
            this.driveComboBox.Location = new System.Drawing.Point(12, 24);
            this.driveComboBox.Name = "driveComboBox";
            this.driveComboBox.Size = new System.Drawing.Size(280, 41);
            this.driveComboBox.TabIndex = 1;
            this.driveComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.driveComboBox_DrawItem);
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Location = new System.Drawing.Point(217, 70);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 32);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "&Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(12, 80);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(115, 12);
            this.copyrightLabel.TabIndex = 3;
            this.copyrightLabel.Text = "(C) Xlfdll Workstation";
            // 
            // treeProcess
            // 
            this.treeProcess.EnableRaisingEvents = true;
            this.treeProcess.StartInfo.Arguments = "/f";
            this.treeProcess.StartInfo.CreateNoWindow = true;
            this.treeProcess.StartInfo.Domain = "";
            this.treeProcess.StartInfo.FileName = "C:\\Windows\\System32\\tree.com";
            this.treeProcess.StartInfo.LoadUserProfile = false;
            this.treeProcess.StartInfo.Password = null;
            this.treeProcess.StartInfo.RedirectStandardOutput = true;
            this.treeProcess.StartInfo.StandardErrorEncoding = null;
            this.treeProcess.StartInfo.StandardOutputEncoding = null;
            this.treeProcess.StartInfo.UserName = "";
            this.treeProcess.StartInfo.UseShellExecute = false;
            this.treeProcess.SynchronizingObject = this;
            this.treeProcess.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(this.treeProcess_OutputDataReceived);
            this.treeProcess.Exited += new System.EventHandler(this.treeProcess_Exited);
            // 
            // MainForm
            // 
            this.AcceptButton = this.generateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 111);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.driveComboBox);
            this.Controls.Add(this.selectDriveLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinTree";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectDriveLabel;
        private System.Windows.Forms.ComboBox driveComboBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Diagnostics.Process treeProcess;
    }
}

