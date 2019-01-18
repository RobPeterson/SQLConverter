namespace SQLConverter
{
  partial class FormMain
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
      this.folderBrowserDialogSource = new System.Windows.Forms.FolderBrowserDialog();
      this.textBoxSource = new System.Windows.Forms.TextBox();
      this.labelSource = new System.Windows.Forms.Label();
      this.labelDestination = new System.Windows.Forms.Label();
      this.textBoxDestination = new System.Windows.Forms.TextBox();
      this.listBoxDestinationFiles = new System.Windows.Forms.ListBox();
      this.contextMenuDestination = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemSSMS = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemVSCODE = new System.Windows.Forms.ToolStripMenuItem();
      this.openInNotePadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.listBoxSourceFiles = new System.Windows.Forms.ListBox();
      this.contextMenuSource = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openInSSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openInVSCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openInNotePadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonSource = new System.Windows.Forms.Button();
      this.buttonDestination = new System.Windows.Forms.Button();
      this.buttonConvert = new System.Windows.Forms.Button();
      this.folderBrowserDialogDestination = new System.Windows.Forms.FolderBrowserDialog();
      this.checkBoxOverwriteExistingFiles = new System.Windows.Forms.CheckBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.eTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuDestination.SuspendLayout();
      this.contextMenuSource.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBoxSource
      // 
      this.textBoxSource.Location = new System.Drawing.Point(136, 60);
      this.textBoxSource.Name = "textBoxSource";
      this.textBoxSource.Size = new System.Drawing.Size(625, 22);
      this.textBoxSource.TabIndex = 0;
      // 
      // labelSource
      // 
      this.labelSource.AutoSize = true;
      this.labelSource.Location = new System.Drawing.Point(20, 61);
      this.labelSource.Name = "labelSource";
      this.labelSource.Size = new System.Drawing.Size(53, 17);
      this.labelSource.TabIndex = 1;
      this.labelSource.Text = "Source";
      // 
      // labelDestination
      // 
      this.labelDestination.AutoSize = true;
      this.labelDestination.Location = new System.Drawing.Point(20, 100);
      this.labelDestination.Name = "labelDestination";
      this.labelDestination.Size = new System.Drawing.Size(79, 17);
      this.labelDestination.TabIndex = 2;
      this.labelDestination.Text = "Destination";
      // 
      // textBoxDestination
      // 
      this.textBoxDestination.Location = new System.Drawing.Point(136, 97);
      this.textBoxDestination.Name = "textBoxDestination";
      this.textBoxDestination.Size = new System.Drawing.Size(625, 22);
      this.textBoxDestination.TabIndex = 3;
      // 
      // listBoxDestinationFiles
      // 
      this.listBoxDestinationFiles.ContextMenuStrip = this.contextMenuDestination;
      this.listBoxDestinationFiles.FormattingEnabled = true;
      this.listBoxDestinationFiles.ItemHeight = 16;
      this.listBoxDestinationFiles.Location = new System.Drawing.Point(392, 164);
      this.listBoxDestinationFiles.Name = "listBoxDestinationFiles";
      this.listBoxDestinationFiles.Size = new System.Drawing.Size(369, 228);
      this.listBoxDestinationFiles.TabIndex = 5;
      // 
      // contextMenuDestination
      // 
      this.contextMenuDestination.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuDestination.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemView,
            this.toolStripMenuItemSSMS,
            this.toolStripMenuItemVSCODE,
            this.openInNotePadToolStripMenuItem,
            this.toolStripMenuItemDelete,
            this.refreshToolStripMenuItem1});
      this.contextMenuDestination.Name = "contextMenuDestination";
      this.contextMenuDestination.Size = new System.Drawing.Size(212, 148);
      this.contextMenuDestination.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuDestination_Opening);
      // 
      // toolStripMenuItemView
      // 
      this.toolStripMenuItemView.Name = "toolStripMenuItemView";
      this.toolStripMenuItemView.Size = new System.Drawing.Size(211, 24);
      this.toolStripMenuItemView.Text = "View";
      this.toolStripMenuItemView.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
      // 
      // toolStripMenuItemSSMS
      // 
      this.toolStripMenuItemSSMS.Name = "toolStripMenuItemSSMS";
      this.toolStripMenuItemSSMS.Size = new System.Drawing.Size(211, 24);
      this.toolStripMenuItemSSMS.Text = "Open in SSMS";
      this.toolStripMenuItemSSMS.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
      // 
      // toolStripMenuItemVSCODE
      // 
      this.toolStripMenuItemVSCODE.Name = "toolStripMenuItemVSCODE";
      this.toolStripMenuItemVSCODE.Size = new System.Drawing.Size(211, 24);
      this.toolStripMenuItemVSCODE.Text = "Open in VS Code";
      this.toolStripMenuItemVSCODE.Click += new System.EventHandler(this.toolStripMenuItemVSCODE_Click);
      // 
      // openInNotePadToolStripMenuItem
      // 
      this.openInNotePadToolStripMenuItem.Name = "openInNotePadToolStripMenuItem";
      this.openInNotePadToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
      this.openInNotePadToolStripMenuItem.Text = "Open in NotePad++";
      this.openInNotePadToolStripMenuItem.Click += new System.EventHandler(this.openInNotePadToolStripMenuItem_Click);
      // 
      // toolStripMenuItemDelete
      // 
      this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
      this.toolStripMenuItemDelete.Size = new System.Drawing.Size(211, 24);
      this.toolStripMenuItemDelete.Text = "Delete";
      this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuDelete_Click);
      // 
      // refreshToolStripMenuItem1
      // 
      this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
      this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
      this.refreshToolStripMenuItem1.Text = "Refresh";
      this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
      // 
      // listBoxSourceFiles
      // 
      this.listBoxSourceFiles.ContextMenuStrip = this.contextMenuSource;
      this.listBoxSourceFiles.FormattingEnabled = true;
      this.listBoxSourceFiles.ItemHeight = 16;
      this.listBoxSourceFiles.Location = new System.Drawing.Point(23, 164);
      this.listBoxSourceFiles.Name = "listBoxSourceFiles";
      this.listBoxSourceFiles.Size = new System.Drawing.Size(345, 228);
      this.listBoxSourceFiles.TabIndex = 6;
      // 
      // contextMenuSource
      // 
      this.contextMenuSource.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuSource.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewToolStripMenuItem,
            this.convertToolStripMenuItem,
            this.openInSSMSToolStripMenuItem,
            this.openInVSCodeToolStripMenuItem,
            this.openInNotePadToolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.refreshToolStripMenuItem});
      this.contextMenuSource.Name = "contextMenuStrip1";
      this.contextMenuSource.Size = new System.Drawing.Size(212, 172);
      this.contextMenuSource.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuSource_Opening);
      // 
      // previewToolStripMenuItem
      // 
      this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
      this.previewToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
      this.previewToolStripMenuItem.Text = "Preview";
      this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
      // 
      // convertToolStripMenuItem
      // 
      this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
      this.convertToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
      this.convertToolStripMenuItem.Text = "Convert";
      this.convertToolStripMenuItem.Click += new System.EventHandler(this.convertToolStripMenuItem_Click);
      // 
      // openInSSMSToolStripMenuItem
      // 
      this.openInSSMSToolStripMenuItem.Name = "openInSSMSToolStripMenuItem";
      this.openInSSMSToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
      this.openInSSMSToolStripMenuItem.Text = "Open in SSMS";
      this.openInSSMSToolStripMenuItem.Click += new System.EventHandler(this.openInSSMSToolStripMenuItem_Click);
      // 
      // openInVSCodeToolStripMenuItem
      // 
      this.openInVSCodeToolStripMenuItem.Name = "openInVSCodeToolStripMenuItem";
      this.openInVSCodeToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
      this.openInVSCodeToolStripMenuItem.Text = "Open in VS Code";
      this.openInVSCodeToolStripMenuItem.Click += new System.EventHandler(this.openInVSCodeToolStripMenuItem_Click);
      // 
      // openInNotePadToolStripMenuItem1
      // 
      this.openInNotePadToolStripMenuItem1.Name = "openInNotePadToolStripMenuItem1";
      this.openInNotePadToolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
      this.openInNotePadToolStripMenuItem1.Text = "Open in NotePad++";
      this.openInNotePadToolStripMenuItem1.Click += new System.EventHandler(this.openInNotePadToolStripMenuItem1_Click);
      // 
      // deleteToolStripMenuItem
      // 
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
      this.deleteToolStripMenuItem.Text = "Delete";
      // 
      // refreshToolStripMenuItem
      // 
      this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
      this.refreshToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
      this.refreshToolStripMenuItem.Text = "Refresh";
      this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
      // 
      // buttonSource
      // 
      this.buttonSource.Location = new System.Drawing.Point(766, 60);
      this.buttonSource.Name = "buttonSource";
      this.buttonSource.Size = new System.Drawing.Size(42, 23);
      this.buttonSource.TabIndex = 7;
      this.buttonSource.Text = "...";
      this.buttonSource.UseVisualStyleBackColor = true;
      this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
      // 
      // buttonDestination
      // 
      this.buttonDestination.Location = new System.Drawing.Point(766, 94);
      this.buttonDestination.Name = "buttonDestination";
      this.buttonDestination.Size = new System.Drawing.Size(42, 23);
      this.buttonDestination.TabIndex = 8;
      this.buttonDestination.Text = "...";
      this.buttonDestination.UseVisualStyleBackColor = true;
      this.buttonDestination.Click += new System.EventHandler(this.buttonDestination_Click);
      // 
      // buttonConvert
      // 
      this.buttonConvert.Location = new System.Drawing.Point(309, 398);
      this.buttonConvert.Name = "buttonConvert";
      this.buttonConvert.Size = new System.Drawing.Size(154, 27);
      this.buttonConvert.TabIndex = 9;
      this.buttonConvert.Text = "Convert All";
      this.buttonConvert.UseVisualStyleBackColor = true;
      this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
      // 
      // checkBoxOverwriteExistingFiles
      // 
      this.checkBoxOverwriteExistingFiles.AutoSize = true;
      this.checkBoxOverwriteExistingFiles.Location = new System.Drawing.Point(505, 400);
      this.checkBoxOverwriteExistingFiles.Name = "checkBoxOverwriteExistingFiles";
      this.checkBoxOverwriteExistingFiles.Size = new System.Drawing.Size(175, 21);
      this.checkBoxOverwriteExistingFiles.TabIndex = 11;
      this.checkBoxOverwriteExistingFiles.Text = "Overwrite Existing Files";
      this.checkBoxOverwriteExistingFiles.UseVisualStyleBackColor = true;
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.eTLToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(824, 28);
      this.menuStrip1.TabIndex = 12;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.clearAllToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // closeToolStripMenuItem
      // 
      this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
      this.closeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
      this.closeToolStripMenuItem.Text = "Close";
      this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
      // 
      // clearAllToolStripMenuItem
      // 
      this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
      this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
      this.clearAllToolStripMenuItem.Text = "Clear All";
      this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
      // 
      // eTLToolStripMenuItem
      // 
      this.eTLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractToolStripMenuItem});
      this.eTLToolStripMenuItem.Name = "eTLToolStripMenuItem";
      this.eTLToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
      this.eTLToolStripMenuItem.Text = "ETL";
      // 
      // extractToolStripMenuItem
      // 
      this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
      this.extractToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
      this.extractToolStripMenuItem.Text = "Extract";
      this.extractToolStripMenuItem.Click += new System.EventHandler(this.extractToolStripMenuItem_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(824, 450);
      this.Controls.Add(this.checkBoxOverwriteExistingFiles);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.buttonConvert);
      this.Controls.Add(this.buttonDestination);
      this.Controls.Add(this.buttonSource);
      this.Controls.Add(this.listBoxSourceFiles);
      this.Controls.Add(this.listBoxDestinationFiles);
      this.Controls.Add(this.textBoxDestination);
      this.Controls.Add(this.labelDestination);
      this.Controls.Add(this.labelSource);
      this.Controls.Add(this.textBoxSource);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FormMain";
      this.Text = "SQL Converter";
      this.contextMenuDestination.ResumeLayout(false);
      this.contextMenuSource.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSource;
    private System.Windows.Forms.TextBox textBoxSource;
    private System.Windows.Forms.Label labelSource;
    private System.Windows.Forms.Label labelDestination;
    private System.Windows.Forms.TextBox textBoxDestination;
    private System.Windows.Forms.ListBox listBoxDestinationFiles;
    private System.Windows.Forms.ListBox listBoxSourceFiles;
    private System.Windows.Forms.Button buttonSource;
    private System.Windows.Forms.Button buttonDestination;
    private System.Windows.Forms.Button buttonConvert;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDestination;
    private System.Windows.Forms.ContextMenuStrip contextMenuSource;
    private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextMenuDestination;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemView;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSSMS;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVSCODE;
    private System.Windows.Forms.ToolStripMenuItem openInNotePadToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openInSSMSToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openInVSCodeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openInNotePadToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    private System.Windows.Forms.CheckBox checkBoxOverwriteExistingFiles;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem eTLToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
  }
}

