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
      this.listBoxSourceFiles = new System.Windows.Forms.ListBox();
      this.buttonSource = new System.Windows.Forms.Button();
      this.buttonDestination = new System.Windows.Forms.Button();
      this.buttonConvert = new System.Windows.Forms.Button();
      this.folderBrowserDialogDestination = new System.Windows.Forms.FolderBrowserDialog();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip1.SuspendLayout();
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
      this.listBoxDestinationFiles.FormattingEnabled = true;
      this.listBoxDestinationFiles.ItemHeight = 16;
      this.listBoxDestinationFiles.Location = new System.Drawing.Point(392, 164);
      this.listBoxDestinationFiles.Name = "listBoxDestinationFiles";
      this.listBoxDestinationFiles.Size = new System.Drawing.Size(369, 228);
      this.listBoxDestinationFiles.TabIndex = 5;
      // 
      // listBoxSourceFiles
      // 
      this.listBoxSourceFiles.ContextMenuStrip = this.contextMenuStrip1;
      this.listBoxSourceFiles.FormattingEnabled = true;
      this.listBoxSourceFiles.ItemHeight = 16;
      this.listBoxSourceFiles.Location = new System.Drawing.Point(23, 164);
      this.listBoxSourceFiles.Name = "listBoxSourceFiles";
      this.listBoxSourceFiles.Size = new System.Drawing.Size(345, 228);
      this.listBoxSourceFiles.TabIndex = 6;
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
      this.buttonConvert.Text = "Convert";
      this.buttonConvert.UseVisualStyleBackColor = true;
      this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(130, 28);
      // 
      // previewToolStripMenuItem
      // 
      this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
      this.previewToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.previewToolStripMenuItem.Text = "Preview";
      this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(824, 450);
      this.Controls.Add(this.buttonConvert);
      this.Controls.Add(this.buttonDestination);
      this.Controls.Add(this.buttonSource);
      this.Controls.Add(this.listBoxSourceFiles);
      this.Controls.Add(this.listBoxDestinationFiles);
      this.Controls.Add(this.textBoxDestination);
      this.Controls.Add(this.labelDestination);
      this.Controls.Add(this.labelSource);
      this.Controls.Add(this.textBoxSource);
      this.Name = "FormMain";
      this.Text = "SQL Converter";
      this.contextMenuStrip1.ResumeLayout(false);
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
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
  }
}

