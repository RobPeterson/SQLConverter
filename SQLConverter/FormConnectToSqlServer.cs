using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SQLConverter
{
  public partial class FormConnectToSqlServer : System.Windows.Forms.Form
  {
    public FormConnectToSqlServer()
    {
      InitializeComponent();
    }

    private void listBoxAuthentication_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.listBoxAuthentication.SelectedItem.ToString() == "Windows Authentication")
      {
        this.labelPassword.Enabled = false;
        this.labelUserName.Enabled = false;
        this.textBoxUserName.Enabled = false;
        this.textBoxPassword.Enabled = false;

      }
      else
      {
        this.labelPassword.Enabled = true;
        this.labelUserName.Enabled = true;
        this.textBoxUserName.Enabled = true;
        this.textBoxPassword.Enabled = true;
      }
    }
  }
}
