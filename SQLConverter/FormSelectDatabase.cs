using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SQLConverter
{
  public partial class FormSelectDatabase : Form
  {
    public FormSelectDatabase()
    {
      InitializeComponent();
      this.databases = new List<string>();
      PopulateDatabase();
    }

    private List<string> databases;

    private void PopulateDatabase()
    {
      this.databases = DataAccess.GetDatabases();
      this.listBoxDatabases.DataSource = this.databases;
    }

    private void buttonOk_Click(object sender, EventArgs e)
    {
      if (this.listBoxDatabases.SelectedItem == null) return;
      DataAccess.database = this.listBoxDatabases.SelectedItem.ToString();
      this.Close();


    }
  }
}
