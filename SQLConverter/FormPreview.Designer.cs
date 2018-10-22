namespace SQLConverter
{
  partial class FormPreview
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
      this.textBoxOriginal = new System.Windows.Forms.TextBox();
      this.textBoxResult = new System.Windows.Forms.TextBox();
      this.labelBefore = new System.Windows.Forms.Label();
      this.labelAfter = new System.Windows.Forms.Label();
      this.buttonPreviewOK = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBoxOriginal
      // 
      this.textBoxOriginal.Location = new System.Drawing.Point(49, 49);
      this.textBoxOriginal.Multiline = true;
      this.textBoxOriginal.Name = "textBoxOriginal";
      this.textBoxOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxOriginal.Size = new System.Drawing.Size(1109, 275);
      this.textBoxOriginal.TabIndex = 0;
      this.textBoxOriginal.TextChanged += new System.EventHandler(this.textBoxOriginal_TextChanged);
      // 
      // textBoxResult
      // 
      this.textBoxResult.Location = new System.Drawing.Point(49, 370);
      this.textBoxResult.Multiline = true;
      this.textBoxResult.Name = "textBoxResult";
      this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxResult.Size = new System.Drawing.Size(1109, 275);
      this.textBoxResult.TabIndex = 1;
      // 
      // labelBefore
      // 
      this.labelBefore.AutoSize = true;
      this.labelBefore.Location = new System.Drawing.Point(46, 29);
      this.labelBefore.Name = "labelBefore";
      this.labelBefore.Size = new System.Drawing.Size(50, 17);
      this.labelBefore.TabIndex = 2;
      this.labelBefore.Text = "Before";
      // 
      // labelAfter
      // 
      this.labelAfter.AutoSize = true;
      this.labelAfter.Location = new System.Drawing.Point(51, 350);
      this.labelAfter.Name = "labelAfter";
      this.labelAfter.Size = new System.Drawing.Size(38, 17);
      this.labelAfter.TabIndex = 3;
      this.labelAfter.Text = "After";
      // 
      // buttonPreviewOK
      // 
      this.buttonPreviewOK.Location = new System.Drawing.Point(478, 651);
      this.buttonPreviewOK.Name = "buttonPreviewOK";
      this.buttonPreviewOK.Size = new System.Drawing.Size(123, 40);
      this.buttonPreviewOK.TabIndex = 4;
      this.buttonPreviewOK.Text = "OK";
      this.buttonPreviewOK.UseVisualStyleBackColor = true;
      this.buttonPreviewOK.Click += new System.EventHandler(this.buttonPreviewOK_Click);
      // 
      // FormPreview
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1210, 846);
      this.Controls.Add(this.buttonPreviewOK);
      this.Controls.Add(this.labelAfter);
      this.Controls.Add(this.labelBefore);
      this.Controls.Add(this.textBoxResult);
      this.Controls.Add(this.textBoxOriginal);
      this.Name = "FormPreview";
      this.Text = "Preview";
      this.Load += new System.EventHandler(this.FormPreview_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxOriginal;
    private System.Windows.Forms.TextBox textBoxResult;
    private System.Windows.Forms.Label labelBefore;
    private System.Windows.Forms.Label labelAfter;
    private System.Windows.Forms.Button buttonPreviewOK;
  }
}