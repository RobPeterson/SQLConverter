using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLConverter
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void buttonSource_Click(object sender, EventArgs e)
    {
      this.folderBrowserDialogSource.ShowDialog();
      this.textBoxSource.Text = this.folderBrowserDialogSource.SelectedPath;
      this.listBoxSourceFiles.DataSource = Directory.GetFiles(textBoxSource.Text);
    }

    private void buttonDestination_Click(object sender, EventArgs e)
    {
      this.folderBrowserDialogDestination.ShowDialog();
      this.textBoxDestination.Text = this.folderBrowserDialogDestination.SelectedPath;
      this.listBoxDestinationFiles.DataSource = Directory.GetFiles(textBoxDestination.Text);
    }

    private void buttonConvert_Click(object sender, EventArgs e)
    {
      var currentFile = this.listBoxSourceFiles.Items[0].ToString();
      var bytes = File.ReadAllBytes(currentFile);
      
      var encoding = new System.Text.UTF8Encoding(false); // NO BOM
      var utf = encoding.GetString(bytes);
      //MessageBox.Show(new SqlFactory().IsSproc(utf).ToString());
      MessageBox.Show(new SqlFactory().GetWithHeaders(utf));
      //var destinationPath = Path.Combine(textBoxDestination.Text,Path.GetFileName(currentFile));
      //File.WriteAllText(destinationPath,utf, encoding);
      //this.listBoxDestinationFiles.DataSource = Directory.GetFiles(textBoxDestination.Text);
    }

    private void previewToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var currentFile = this.listBoxSourceFiles.SelectedItem.ToString();
      var bytes = File.ReadAllBytes(currentFile);

      var encoding = new System.Text.UTF8Encoding(false); // NO BOM
      var utf = encoding.GetString(bytes);

      var SqlFactory = new SqlFactory();
      var previewText = SqlFactory.GetWithHeaders(utf);
      FormPreview preview = new FormPreview();
      preview.SetBefore(utf);
      preview.SetAfter(previewText);
      preview.Show();
    }

    private void contextMenuSource_Opening(object sender, CancelEventArgs e)
    {

    }

    private void convertToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var currentFile = this.listBoxSourceFiles.SelectedItem.ToString();
      var bytes = File.ReadAllBytes(currentFile);

      var encoding = new System.Text.UTF8Encoding(false); // NO BOM
      var utf = encoding.GetString(bytes);
      var SqlFactory = new SqlFactory();
      var previewText = SqlFactory.GetWithHeaders(utf);
   
      var destinationPath = Path.Combine(textBoxDestination.Text, Path.GetFileName(currentFile).Replace("[",String.Empty).Replace("]",String.Empty));
      File.WriteAllText(destinationPath, previewText, encoding);
      this.listBoxDestinationFiles.DataSource = Directory.GetFiles(textBoxDestination.Text);
    }
  }
}
