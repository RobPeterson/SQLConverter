namespace SQLConverter
{
  partial class FormViewer
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
      this.textBoxContent = new System.Windows.Forms.TextBox();
      this.buttonOK = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBoxContent
      // 
      this.textBoxContent.Location = new System.Drawing.Point(25, 21);
      this.textBoxContent.Multiline = true;
      this.textBoxContent.Name = "textBoxContent";
      this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxContent.Size = new System.Drawing.Size(754, 369);
      this.textBoxContent.TabIndex = 0;
      // 
      // buttonOK
      // 
      this.buttonOK.Location = new System.Drawing.Point(339, 396);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.Size = new System.Drawing.Size(75, 23);
      this.buttonOK.TabIndex = 1;
      this.buttonOK.Text = "OK";
      this.buttonOK.UseVisualStyleBackColor = true;
      // 
      // FormViewer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.buttonOK);
      this.Controls.Add(this.textBoxContent);
      this.Name = "FormViewer";
      this.Text = "Viewer";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxContent;
    private System.Windows.Forms.Button buttonOK;
  }
}