namespace SQLConverter
{
  partial class FormSelectDatabase
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
      this.listBoxDatabases = new System.Windows.Forms.ListBox();
      this.buttonOk = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // listBoxDatabases
      // 
      this.listBoxDatabases.FormattingEnabled = true;
      this.listBoxDatabases.ItemHeight = 16;
      this.listBoxDatabases.Location = new System.Drawing.Point(11, 32);
      this.listBoxDatabases.Name = "listBoxDatabases";
      this.listBoxDatabases.Size = new System.Drawing.Size(295, 196);
      this.listBoxDatabases.TabIndex = 0;
      // 
      // buttonOk
      // 
      this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonOk.Location = new System.Drawing.Point(12, 238);
      this.buttonOk.Name = "buttonOk";
      this.buttonOk.Size = new System.Drawing.Size(83, 45);
      this.buttonOk.TabIndex = 1;
      this.buttonOk.Text = "OK";
      this.buttonOk.UseVisualStyleBackColor = true;
      this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(216, 238);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(91, 45);
      this.buttonCancel.TabIndex = 2;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(8, 12);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(126, 17);
      this.label3.TabIndex = 5;
      this.label3.Text = "Select a database:";
      // 
      // FormSelectDatabase
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(316, 289);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonOk);
      this.Controls.Add(this.listBoxDatabases);
      this.Name = "FormSelectDatabase";
      this.Text = "Select Database";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBoxDatabases;
    private System.Windows.Forms.Button buttonOk;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Label label3;
  }
}