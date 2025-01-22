using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using Xlfdll.Diagnostics;

using WinTree.Properties;

namespace WinTree
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            copyrightLabel.Text = AssemblyMetadata.EntryAssemblyMetadata.AssemblyCopyright;

            driveComboBox.DataSource = this.GetDrives();
        }

        private void driveComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush textBrush = SystemBrushes.WindowText;

            // Highlight the combobox item when the mouse cursor hovers over the item in the dropdown list.
            if (this.DriveInfos != null)
            {
                if (e.Index == -1)
                {
                    e.Graphics.FillRectangle(SystemBrushes.HotTrack, e.Bounds);

                    textBrush = SystemBrushes.HighlightText;
                }
                else if (e.Index > -1)
                {
                    // Highlight the combobox item when selected in the dropdown list.
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    {
                        e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);

                        textBrush = SystemBrushes.HighlightText;
                    }
                    else
                    {
                        // Restore background colour to deafult when the mouse leaves the item.
                        e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
                    }
                }

                // Draw the string i.e populate the combobox with the list of the text names
                // for the User groups & User Accounts
                e.Graphics.DrawString
                    ($"{this.DriveInfos[e.Index].Name} - {this.DriveInfos[e.Index].VolumeLabel}",
                    e.Font, textBrush, e.Bounds.Left + Resources.Drive.Width + 10, e.Bounds.Top + Resources.Drive.Height / 3);
                e.Graphics.DrawImage(Resources.Drive, e.Bounds.Left, e.Bounds.Top);
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (this.DriveInfos != null)
            {
                generateButton.Enabled = false;
                generateButton.Text = "Generating...";

                sb = new StringBuilder();

                treeProcess.StartInfo.WorkingDirectory = this.DriveInfos[driveComboBox.SelectedIndex].Name;
                treeProcess.Start();
                treeProcess.BeginOutputReadLine();
            }
        }

        private void treeProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (sb != null && !String.IsNullOrEmpty(e.Data))
            {
                sb.AppendLine(e.Data);
            }
        }

        private void treeProcess_Exited(object sender, EventArgs e)
        {
            if (this.DriveInfos != null)
            {
                using (SaveFileDialog dlg = new SaveFileDialog()
                {
                    Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*",
                    FileName = this.DriveInfos[driveComboBox.SelectedIndex].VolumeLabel,
                    RestoreDirectory = true
                })
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(dlg.FileName, sb.ToString());

                        MessageBox.Show
                            (this,
                            "File list has been written into"
                            + Environment.NewLine
                            + dlg.FileName,
                            this.Text,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }

            generateButton.Text = "Generate";
            generateButton.Enabled = true;
        }

        private DriveInfo[] GetDrives()
        {
            List<DriveInfo> drives = new List<DriveInfo>();

            foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
            {
                if (driveInfo.IsReady
                    && (driveInfo.DriveType == DriveType.Fixed
                    || driveInfo.DriveType == DriveType.CDRom
                    || driveInfo.DriveType == DriveType.Removable))
                {
                    drives.Add(driveInfo);
                }
            }

            return drives.ToArray();
        }

        private DriveInfo[] DriveInfos => driveComboBox.DataSource as DriveInfo[];

        private StringBuilder sb;
    }
}