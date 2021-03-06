﻿namespace StarBank
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bankFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBankFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBankAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGalaxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGalaxyToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMapFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMapAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMapName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.cbxHideBlizzard = new System.Windows.Forms.CheckBox();
            this.cbxHideMapsWithoutBank = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnprotectMapFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResignExternalBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblMultipleBankFiles = new System.Windows.Forms.Label();
            this.cmbBankFile = new System.Windows.Forms.ComboBox();
            this.panelMultipleBankFiles = new System.Windows.Forms.Panel();
            this.bankEditor1 = new StarBank.BankEditor();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelMultipleBankFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 356);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBox1_Format);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankFileToolStripMenuItem,
            this.triggerToolStripMenuItem,
            this.mapFileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // bankFileToolStripMenuItem
            // 
            this.bankFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBankToolStripMenuItem,
            this.openBankFolderToolStripMenuItem,
            this.saveBankAsToolStripMenuItem});
            this.bankFileToolStripMenuItem.Name = "bankFileToolStripMenuItem";
            this.bankFileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.bankFileToolStripMenuItem.Text = "&Bank File";
            // 
            // openBankToolStripMenuItem
            // 
            this.openBankToolStripMenuItem.Name = "openBankToolStripMenuItem";
            this.openBankToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openBankToolStripMenuItem.Text = "Open";
            this.openBankToolStripMenuItem.Click += new System.EventHandler(this.openBankToolStripMenuItem_Click);
            // 
            // openBankFolderToolStripMenuItem
            // 
            this.openBankFolderToolStripMenuItem.Name = "openBankFolderToolStripMenuItem";
            this.openBankFolderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openBankFolderToolStripMenuItem.Text = "Open Folder";
            this.openBankFolderToolStripMenuItem.Click += new System.EventHandler(this.openBankFolderToolStripMenuItem_Click);
            // 
            // saveBankAsToolStripMenuItem
            // 
            this.saveBankAsToolStripMenuItem.Name = "saveBankAsToolStripMenuItem";
            this.saveBankAsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveBankAsToolStripMenuItem.Text = "Save As...";
            this.saveBankAsToolStripMenuItem.Click += new System.EventHandler(this.saveBankToToolStripMenuItem_Click);
            // 
            // triggerToolStripMenuItem
            // 
            this.triggerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openGalaxyToolStripMenuItem,
            this.saveGalaxyToToolStripMenuItem});
            this.triggerToolStripMenuItem.Name = "triggerToolStripMenuItem";
            this.triggerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.triggerToolStripMenuItem.Text = "&Galaxyscript Code";
            // 
            // openGalaxyToolStripMenuItem
            // 
            this.openGalaxyToolStripMenuItem.Name = "openGalaxyToolStripMenuItem";
            this.openGalaxyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openGalaxyToolStripMenuItem.Text = "&Open";
            this.openGalaxyToolStripMenuItem.Click += new System.EventHandler(this.openGalaxyToolStripMenuItem_Click);
            // 
            // saveGalaxyToToolStripMenuItem
            // 
            this.saveGalaxyToToolStripMenuItem.Name = "saveGalaxyToToolStripMenuItem";
            this.saveGalaxyToToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveGalaxyToToolStripMenuItem.Text = "&Save To...";
            this.saveGalaxyToToolStripMenuItem.Click += new System.EventHandler(this.saveGalaxyToToolStripMenuItem_Click);
            // 
            // mapFileToolStripMenuItem
            // 
            this.mapFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMapToolStripMenuItem,
            this.openMapFolderToolStripMenuItem,
            this.saveMapAsToolStripMenuItem});
            this.mapFileToolStripMenuItem.Name = "mapFileToolStripMenuItem";
            this.mapFileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.mapFileToolStripMenuItem.Text = "&Map File";
            // 
            // openMapToolStripMenuItem
            // 
            this.openMapToolStripMenuItem.Name = "openMapToolStripMenuItem";
            this.openMapToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openMapToolStripMenuItem.Text = "&Open";
            this.openMapToolStripMenuItem.Click += new System.EventHandler(this.openMapToolStripMenuItem_Click);
            // 
            // openMapFolderToolStripMenuItem
            // 
            this.openMapFolderToolStripMenuItem.Name = "openMapFolderToolStripMenuItem";
            this.openMapFolderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openMapFolderToolStripMenuItem.Text = "Open &Folder";
            this.openMapFolderToolStripMenuItem.Click += new System.EventHandler(this.openMapFolderToolStripMenuItem_Click);
            // 
            // saveMapAsToolStripMenuItem
            // 
            this.saveMapAsToolStripMenuItem.Name = "saveMapAsToolStripMenuItem";
            this.saveMapAsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveMapAsToolStripMenuItem.Text = "&Save As...";
            this.saveMapAsToolStripMenuItem.Click += new System.EventHandler(this.saveMapToToolStripMenuItem_Click);
            // 
            // lblMapName
            // 
            this.lblMapName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMapName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapName.Location = new System.Drawing.Point(14, 13);
            this.lblMapName.Name = "lblMapName";
            this.lblMapName.Size = new System.Drawing.Size(545, 45);
            this.lblMapName.TabIndex = 1;
            this.lblMapName.Text = "Map name";
            this.lblMapName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(14, 62);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(64, 13);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Created by: ";
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastUpdate.Location = new System.Drawing.Point(246, 62);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(313, 23);
            this.lblLastUpdate.TabIndex = 3;
            this.lblLastUpdate.Text = "Last update downloaded on...";
            this.lblLastUpdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbxHideBlizzard
            // 
            this.cbxHideBlizzard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxHideBlizzard.AutoSize = true;
            this.cbxHideBlizzard.Checked = true;
            this.cbxHideBlizzard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxHideBlizzard.Location = new System.Drawing.Point(12, 395);
            this.cbxHideBlizzard.Name = "cbxHideBlizzard";
            this.cbxHideBlizzard.Size = new System.Drawing.Size(116, 17);
            this.cbxHideBlizzard.TabIndex = 5;
            this.cbxHideBlizzard.Text = "Hide Blizzard Maps";
            this.cbxHideBlizzard.UseVisualStyleBackColor = true;
            this.cbxHideBlizzard.CheckedChanged += new System.EventHandler(this.cbxCheckedChanged);
            // 
            // cbxHideMapsWithoutBank
            // 
            this.cbxHideMapsWithoutBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxHideMapsWithoutBank.AutoSize = true;
            this.cbxHideMapsWithoutBank.Checked = true;
            this.cbxHideMapsWithoutBank.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxHideMapsWithoutBank.Location = new System.Drawing.Point(12, 418);
            this.cbxHideMapsWithoutBank.Name = "cbxHideMapsWithoutBank";
            this.cbxHideMapsWithoutBank.Size = new System.Drawing.Size(161, 17);
            this.cbxHideMapsWithoutBank.TabIndex = 6;
            this.cbxHideMapsWithoutBank.Text = "Hide maps without bank files";
            this.cbxHideMapsWithoutBank.UseVisualStyleBackColor = true;
            this.cbxHideMapsWithoutBank.CheckedChanged += new System.EventHandler(this.cbxCheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.accountsToolStripMenuItem.Text = "Accounts";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UnprotectMapFileToolStripMenuItem,
            this.ResignExternalBankToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // UnprotectMapFileToolStripMenuItem
            // 
            this.UnprotectMapFileToolStripMenuItem.Name = "UnprotectMapFileToolStripMenuItem";
            this.UnprotectMapFileToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.UnprotectMapFileToolStripMenuItem.Text = "&Unprotect external map file";
            this.UnprotectMapFileToolStripMenuItem.Click += new System.EventHandler(this.UnprotectMapFileToolStripMenuItem_Click);
            // 
            // ResignExternalBankToolStripMenuItem
            // 
            this.ResignExternalBankToolStripMenuItem.Name = "ResignExternalBankToolStripMenuItem";
            this.ResignExternalBankToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.ResignExternalBankToolStripMenuItem.Text = "&Re-sign external bank";
            this.ResignExternalBankToolStripMenuItem.Click += new System.EventHandler(this.ResignExternalBankToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblMultipleBankFiles
            // 
            this.lblMultipleBankFiles.AutoSize = true;
            this.lblMultipleBankFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultipleBankFiles.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMultipleBankFiles.Location = new System.Drawing.Point(43, 6);
            this.lblMultipleBankFiles.Name = "lblMultipleBankFiles";
            this.lblMultipleBankFiles.Size = new System.Drawing.Size(276, 15);
            this.lblMultipleBankFiles.TabIndex = 9;
            this.lblMultipleBankFiles.Text = "Multiple bank files detected.  Choose one:";
            // 
            // cmbBankFile
            // 
            this.cmbBankFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBankFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbBankFile.FormattingEnabled = true;
            this.cmbBankFile.Location = new System.Drawing.Point(325, 2);
            this.cmbBankFile.Name = "cmbBankFile";
            this.cmbBankFile.Size = new System.Drawing.Size(207, 23);
            this.cmbBankFile.TabIndex = 10;
            this.cmbBankFile.SelectedIndexChanged += new System.EventHandler(this.cmbBankFile_SelectedIndexChanged);
            this.cmbBankFile.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbBankFile_Format);
            // 
            // panelMultipleBankFiles
            // 
            this.panelMultipleBankFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMultipleBankFiles.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelMultipleBankFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMultipleBankFiles.Controls.Add(this.lblMultipleBankFiles);
            this.panelMultipleBankFiles.Controls.Add(this.cmbBankFile);
            this.panelMultipleBankFiles.Location = new System.Drawing.Point(17, 78);
            this.panelMultipleBankFiles.Name = "panelMultipleBankFiles";
            this.panelMultipleBankFiles.Size = new System.Drawing.Size(553, 30);
            this.panelMultipleBankFiles.TabIndex = 11;
            this.panelMultipleBankFiles.Visible = false;
            // 
            // bankEditor1
            // 
            this.bankEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bankEditor1.Location = new System.Drawing.Point(17, 112);
            this.bankEditor1.Name = "bankEditor1";
            this.bankEditor1.Size = new System.Drawing.Size(553, 323);
            this.bankEditor1.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.cbxHideMapsWithoutBank);
            this.splitContainer1.Panel1.Controls.Add(this.cbxHideBlizzard);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblMapName);
            this.splitContainer1.Panel2.Controls.Add(this.panelMultipleBankFiles);
            this.splitContainer1.Panel2.Controls.Add(this.lblLastUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.bankEditor1);
            this.splitContainer1.Panel2.Controls.Add(this.lblAuthor);
            this.splitContainer1.Size = new System.Drawing.Size(828, 446);
            this.splitContainer1.SplitterDistance = 231;
            this.splitContainer1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Map List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 473);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(836, 500);
            this.Name = "MainForm";
            this.Text = "StarBank - The Starcraft II Bank File Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMultipleBankFiles.ResumeLayout(false);
            this.panelMultipleBankFiles.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblMapName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mapFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMapFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMapAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBankFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBankAsToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbxHideBlizzard;
        private System.Windows.Forms.CheckBox cbxHideMapsWithoutBank;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnprotectMapFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResignExternalBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private BankEditor bankEditor1;
        private System.Windows.Forms.Label lblMultipleBankFiles;
        private System.Windows.Forms.ComboBox cmbBankFile;
        private System.Windows.Forms.Panel panelMultipleBankFiles;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGalaxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGalaxyToToolStripMenuItem;

    }
}

