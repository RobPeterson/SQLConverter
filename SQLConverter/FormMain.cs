using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLConverter
{
  public partial class FormMain : System.Windows.Forms.Form
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
      this.listBoxSourceFiles.DataSource = Directory.GetFiles(textBoxSource.Text);
      foreach (var i in this.listBoxSourceFiles.Items)
      {
        this.ConvertFile(i.ToString());
      }
      this.listBoxDestinationFiles.DataSource = Directory.GetFiles(textBoxDestination.Text);
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
      ConvertFile(currentFile);
      this.listBoxDestinationFiles.DataSource = Directory.GetFiles(textBoxDestination.Text);
    }

    private void ConvertFile(string currentFile)
    {
      var bytes = File.ReadAllBytes(currentFile);

      var encoding = new System.Text.UTF8Encoding(false); // NO BOM
      var utf = encoding.GetString(bytes);
      var SqlFactory = new SqlFactory();
      var previewText = SqlFactory.GetWithHeaders(utf);

      var destinationPath = Path.Combine(textBoxDestination.Text,
        Path.GetFileName(currentFile).Replace("[", String.Empty).Replace("]", String.Empty));
      if (File.Exists(destinationPath) && this.checkBoxOverwriteExistingFiles.Checked == true)
        File.WriteAllText(destinationPath, previewText, encoding);

      if (!File.Exists(destinationPath))
        File.WriteAllText(destinationPath, previewText, encoding);
    }



    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
      var currentFile = this.listBoxSourceFiles.SelectedItem.ToString();
      var bytes = File.ReadAllBytes(currentFile);
      var encoding = new System.Text.UTF8Encoding(false); // NO BOM
      var utf = encoding.GetString(bytes);
      FormViewer viewer = new FormViewer();
      viewer.SetContent(utf);
      viewer.Show();
    }

    private void contextMenuDestination_Opening(object sender, CancelEventArgs e)
    {

    }

    private void toolStripMenuDelete_Click(object sender, EventArgs e)
    {
      if (this.listBoxDestinationFiles.SelectedItem == null)
      {
        MessageBox.Show("You must select a file to delete it.");
        return;
      }
      else
      {
        if (MessageBox.Show($"Are you sure you want to delete {this.listBoxDestinationFiles.SelectedItem.ToString()}?",
              "File Delete Check", MessageBoxButtons.YesNo) == DialogResult.No)
          return;
      }

      var currentFile = this.listBoxDestinationFiles.SelectedItem.ToString();
      File.Delete(currentFile);
      this.listBoxDestinationFiles.DataSource = Directory.GetFiles(textBoxDestination.Text);
    }

    private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
    {
      if (this.listBoxDestinationFiles.SelectedItem == null)
      {
        MessageBox.Show("You must select a file to open it.");
        return;
      }
      var f = this.listBoxDestinationFiles.SelectedItem.ToString();
      System.Diagnostics.Process.Start("ssms.exe", $"-E {f}");
    }

    private void toolStripMenuItemVSCODE_Click(object sender, EventArgs e)
    {
      if (this.listBoxDestinationFiles.SelectedItem == null)
      {
        MessageBox.Show("You must select a file to open it.");
        return;
      }
      var f = this.listBoxDestinationFiles.SelectedItem.ToString();
      System.Diagnostics.Process.Start("code", $"-g {f}");
    }

    private void openInNotePadToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.listBoxDestinationFiles.SelectedItem == null)
      {
        MessageBox.Show("You must select a file to open it.");
        return;
      }
      var f = this.listBoxDestinationFiles.SelectedItem.ToString();
      System.Diagnostics.Process.Start("Notepad++.exe", $"{f}");
    }

    private void openInSSMSToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.listBoxSourceFiles.SelectedItem == null)
      {
        MessageBox.Show("You must select a file to open it.");
        return;
      }
      var f = this.listBoxSourceFiles.SelectedItem.ToString();
      System.Diagnostics.Process.Start("ssms.exe", $"-E {f}");
    }

    private void openInVSCodeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.listBoxSourceFiles.SelectedItem == null)
      {
        MessageBox.Show("You must select a file to open it.");
        return;
      }
      var f = this.listBoxSourceFiles.SelectedItem.ToString();
      System.Diagnostics.Process.Start("code", $"-g {f}");
    }

    private void openInNotePadToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.listBoxSourceFiles.SelectedItem == null)
      {
        MessageBox.Show("You must select a file to open it.");
        return;
      }
      var f = this.listBoxSourceFiles.SelectedItem.ToString();
      System.Diagnostics.Process.Start("Notepad++.exe", $"{f}");
    }

    private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      try
      {
        this.listBoxDestinationFiles.DataSource = Directory.GetFiles(textBoxDestination.Text);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Error Cannot Refresh: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.listBoxSourceFiles.DataSource = Directory.GetFiles(textBoxSource.Text);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Error Cannot Refresh: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      listBoxDestinationFiles.Items.Clear();
      listBoxSourceFiles.Items.Clear();
      textBoxDestination.Text = "";
      textBoxSource.Text = "";
    }
  }
  
}

