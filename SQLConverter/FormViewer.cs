using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLConverter
{
  public partial class FormViewer : System.Windows.Forms.Form
  {
    public FormViewer()
    {
      InitializeComponent();
    }

    public void SetContent(string content)
    {
      this.textBoxContent.Text = content;
    }
  }
}
