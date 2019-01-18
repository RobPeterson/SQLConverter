using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLConverter
{
  public class ExtractionService
  {
    private Encoding encoding;

    public ExtractionService()
    {
      this.encoding = new System.Text.UTF8Encoding(false);
    }

    public void ExtractAll(string filePath, bool overwriteExisting = false)
    {
      List<DatabaseObject> list = DataAccess.GetStoredProcedures();
      list.AddRange(DataAccess.GetFunctions());
      list.AddRange(DataAccess.GetViews());
      foreach(var obj in list)
        WriteDatabaseObject(filePath, obj, overwriteExisting);
    }

    public void ExtractStoredProcedures(string filePath, bool overwriteExisting = false)
    {
      ExtractObject(filePath, DataAccess.GetStoredProcedures, overwriteExisting);
    }

    public void ExtractFunctions(string filePath, bool overwriteExisting = false)
    {
      ExtractObject(filePath, DataAccess.GetFunctions, overwriteExisting);
    }

    public void ExtractViews(string filePath, bool overwriteExisting = false)
    {
      ExtractObject(filePath, DataAccess.GetViews, overwriteExisting);
    }

    public void ExtractObject(string filePath, Func<List<DatabaseObject>> extract, bool overwriteExisting = false)
    {
      var objList = extract();
      foreach (var obj in objList)
      {
        WriteDatabaseObject(filePath, obj, overwriteExisting);
      }

    }


    private void WriteDatabaseObject(string destinationPath, DatabaseObject obj, bool overwriteExisting = false)
    {
      destinationPath = Path.Combine(destinationPath, obj.Name + ".sql", String.Empty);
      if (File.Exists(destinationPath) && overwriteExisting == true)
        File.WriteAllText(destinationPath, obj.Definition, encoding);

      if (!File.Exists(destinationPath))
      {
        File.WriteAllText(destinationPath, obj.Definition, encoding);
      }
    }
  }
}
