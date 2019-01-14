namespace SQLConverter
{
  partial class FormConnectToSqlServer
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
      this.labelServerName = new System.Windows.Forms.Label();
      this.labelAuthentication = new System.Windows.Forms.Label();
      this.labelUserName = new System.Windows.Forms.Label();
      this.labelPassword = new System.Windows.Forms.Label();
      this.textBoxServerName = new System.Windows.Forms.TextBox();
      this.listBoxAuthentication = new System.Windows.Forms.ListBox();
      this.textBoxUserName = new System.Windows.Forms.TextBox();
      this.textBoxPassword = new System.Windows.Forms.TextBox();
      this.buttonConnect = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // labelServerName
      // 
      this.labelServerName.AutoSize = true;
      this.labelServerName.Location = new System.Drawing.Point(14, 29);
      this.labelServerName.Name = "labelServerName";
      this.labelServerName.Size = new System.Drawing.Size(93, 17);
      this.labelServerName.TabIndex = 0;
      this.labelServerName.Text = "Server name:";
      // 
      // labelAuthentication
      // 
      this.labelAuthentication.AutoSize = true;
      this.labelAuthentication.Location = new System.Drawing.Point(19, 66);
      this.labelAuthentication.Name = "labelAuthentication";
      this.labelAuthentication.Size = new System.Drawing.Size(102, 17);
      this.labelAuthentication.TabIndex = 1;
      this.labelAuthentication.Text = "Authentication:";
      // 
      // labelUserName
      // 
      this.labelUserName.AutoSize = true;
      this.labelUserName.Enabled = false;
      this.labelUserName.Location = new System.Drawing.Point(40, 99);
      this.labelUserName.Name = "labelUserName";
      this.labelUserName.Size = new System.Drawing.Size(81, 17);
      this.labelUserName.TabIndex = 2;
      this.labelUserName.Text = "User name:";
      // 
      // labelPassword
      // 
      this.labelPassword.AutoSize = true;
      this.labelPassword.Enabled = false;
      this.labelPassword.Location = new System.Drawing.Point(44, 133);
      this.labelPassword.Name = "labelPassword";
      this.labelPassword.Size = new System.Drawing.Size(73, 17);
      this.labelPassword.TabIndex = 3;
      this.labelPassword.Text = "Password:";
      // 
      // textBoxServerName
      // 
      this.textBoxServerName.Location = new System.Drawing.Point(126, 31);
      this.textBoxServerName.Name = "textBoxServerName";
      this.textBoxServerName.Size = new System.Drawing.Size(204, 22);
      this.textBoxServerName.TabIndex = 4;
      // 
      // listBoxAuthentication
      // 
      this.listBoxAuthentication.FormattingEnabled = true;
      this.listBoxAuthentication.ItemHeight = 16;
      this.listBoxAuthentication.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
      this.listBoxAuthentication.Location = new System.Drawing.Point(127, 66);
      this.listBoxAuthentication.Name = "listBoxAuthentication";
      this.listBoxAuthentication.Size = new System.Drawing.Size(201, 20);
      this.listBoxAuthentication.TabIndex = 5;
      this.listBoxAuthentication.SelectedIndexChanged += new System.EventHandler(this.listBoxAuthentication_SelectedIndexChanged);
      // 
      // textBoxUserName
      // 
      this.textBoxUserName.Enabled = false;
      this.textBoxUserName.Location = new System.Drawing.Point(126, 99);
      this.textBoxUserName.Name = "textBoxUserName";
      this.textBoxUserName.Size = new System.Drawing.Size(204, 22);
      this.textBoxUserName.TabIndex = 6;
      // 
      // textBoxPassword
      // 
      this.textBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
      this.textBoxPassword.Enabled = false;
      this.textBoxPassword.Location = new System.Drawing.Point(128, 135);
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.PasswordChar = '*';
      this.textBoxPassword.Size = new System.Drawing.Size(202, 22);
      this.textBoxPassword.TabIndex = 7;
      // 
      // buttonConnect
      // 
      this.buttonConnect.Location = new System.Drawing.Point(149, 163);
      this.buttonConnect.Name = "buttonConnect";
      this.buttonConnect.Size = new System.Drawing.Size(87, 38);
      this.buttonConnect.TabIndex = 8;
      this.buttonConnect.Text = "Connect";
      this.buttonConnect.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(242, 163);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(88, 38);
      this.button1.TabIndex = 9;
      this.button1.Text = "Cancel";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // FormConnectToSqlServer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(354, 215);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.buttonConnect);
      this.Controls.Add(this.textBoxPassword);
      this.Controls.Add(this.textBoxUserName);
      this.Controls.Add(this.listBoxAuthentication);
      this.Controls.Add(this.textBoxServerName);
      this.Controls.Add(this.labelPassword);
      this.Controls.Add(this.labelUserName);
      this.Controls.Add(this.labelAuthentication);
      this.Controls.Add(this.labelServerName);
      this.Name = "FormConnectToSqlServer";
      this.Text = "Connect to SQL Server";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelServerName;
    private System.Windows.Forms.Label labelAuthentication;
    private System.Windows.Forms.Label labelUserName;
    private System.Windows.Forms.Label labelPassword;
    private System.Windows.Forms.TextBox textBoxServerName;
    private System.Windows.Forms.ListBox listBoxAuthentication;
    private System.Windows.Forms.TextBox textBoxUserName;
    private System.Windows.Forms.TextBox textBoxPassword;
    private System.Windows.Forms.Button buttonConnect;
    private System.Windows.Forms.Button button1;
  }
}