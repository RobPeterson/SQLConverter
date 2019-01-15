using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLConverter
{
  public static class DataAccess
  {
    public static string server { get; set; }
    public static string authentication { get; set; }
    public static string userName { get; set; }
    public static string password { get; set; }
    public static string database { get; set; }

    public static List<string> GetDatabases()
    {
      List<string> result = new List<string>();
      string queryString = "SELECT name FROM sys.databases;";
      string connectionString = authentication == "Windows Authentication" ? $"Server={server}; Database=master; Integrated Security=True" : $"Server={server}; Database=master; User ID={userName}; Password={password}";

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(queryString, connection);
        //command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();
        try
        {
          while (reader.Read())
          {
            result.Add(reader["name"].ToString());
          }
        }
        finally
        {
          // Always call Close when done reading.
          reader.Close();
        }
      }

      return result;
    }

    public static List<DatabaseObject> GetStoredProcedures()
    {
      List<DatabaseObject> result = new List<DatabaseObject>();
      string queryString =
        "SELECT o.name ,m.definition FROM sys.sql_modules AS m INNER JOIN sys.objects AS o ON m.[object_id] = o.[OBJECT_ID] WHERE type = 'p' ORDER BY o.name";
      string connectionString = GetConnectionString();

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(queryString, connection);
        //command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();
        try
        {
          while (reader.Read())
          {
            result.Add(new DatabaseObject(){Definition = reader["definition"].ToString(), Name  = reader["name"].ToString()});
          }
        }
        finally
        {
          // Always call Close when done reading.
          reader.Close();
        }
      }
      return result;
    }

    public static List<DatabaseObject> GetViews()
    {
      List<DatabaseObject> result = new List<DatabaseObject>();
      string queryString = "SELECT o.name ,m.definition FROM sys.sql_modules AS m INNER JOIN sys.objects AS o ON m.[object_id] = o.[OBJECT_ID] WHERE type = 'v' ORDER BY o.name";
      string connectionString = GetConnectionString();

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(queryString, connection);
        //command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();
        try
        {
          while (reader.Read())
          {
            result.Add(new DatabaseObject() { Definition = reader["definition"].ToString(), Name = reader["name"].ToString() });
          }
        }
        finally
        {
          // Always call Close when done reading.
          reader.Close();
        }
      }

      return result;
    }

    public static List<DatabaseObject> GetFunctions()
    {
      List<DatabaseObject> result = new List<DatabaseObject>();
      string queryString = "SELECT o.name, m.definition FROM sys.sql_modules AS m INNER JOIN sys.objects AS o ON m.[object_id] = o.[OBJECT_ID] WHERE type IN ('IF', 'FS', 'FN', 'FT', 'TF') ORDER BY o.Name;";
      string connectionString = GetConnectionString();

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(queryString, connection);
        //command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();
        try
        {
          while (reader.Read())
          {
            result.Add(new DatabaseObject() { Definition = reader["definition"].ToString(), Name = reader["name"].ToString() });
          }
        }
        finally
        {
          // Always call Close when done reading.
          reader.Close();
        }
      }

      return result;
    }


    private static string GetConnectionString()
    {
      var result = authentication == "Windows Authentication" ? $"Server={server}; Database={database}; Integrated Security=True" : $"Server={server}; Database={database}; User ID={userName}; Password={password}";
      return result;
    }
  }
}
