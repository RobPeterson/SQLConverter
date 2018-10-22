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
  public partial class FormPreview : Form
  {

    public void SetBefore(string before)
    {
      this.textBoxOriginal.Text = before;
    }

    public void SetAfter(string after)
    {
      this.textBoxResult.Text = after;
    }

    public FormPreview()
    {
      InitializeComponent();
    }

    private void FormPreview_Load(object sender, EventArgs e)
    {

    }

    private void textBoxOriginal_TextChanged(object sender, EventArgs e)
    {

    }

    private void buttonPreviewOK_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
