using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SQLConverter
{
  public class SqlFactory
  {
    private  StringBuilder sqlBuilder;
    private string sprocHeaderTemplate;
    private string functHeaderTemplate;
    private string viewHeaderTemplate;

    public string GetWithHeaders(string sql)
    {


      if (IsSproc(sql))
        BuildSproc(sql);
        
      return sqlBuilder.ToString();
    }

    private void BuildSproc(string sql)
    {
      this.sqlBuilder = new StringBuilder();
      if (HasUse(sql))
        this.sqlBuilder.Append(GetUse(sql));

      var name = GetSprocName(sql);
      name = GetNameOnly(name);

      this.sqlBuilder.Append(GetSprocHeader(name));
      this.sqlBuilder.Append("(");
      this.sqlBuilder.Append(GetSprocBody(sql));


    }

    private string GetUse(string sql)
    {
      Regex rx = new Regex(@"^.* USE.*\nGO$", RegexOptions.IgnoreCase);
      return rx.Match(sql).Value;

    }

    private string GetSprocName(string sql)
    {
      Regex rx = new Regex(@"(?<=PROCEDURE\s).*(?=\()", RegexOptions.IgnoreCase);
      if (!rx.IsMatch(sql))
        throw new Exception("Can't find Sproc Name Excpetion");
      var name = rx.Match(sql).ToString().Trim();
      return name;

    }

    private string GetFunctionName(string sql)
    {
      Regex rx = new Regex(@"(?<=FUNCTION).*\([@|\s*]", RegexOptions.IgnoreCase);
      if (!rx.IsMatch(sql))
        throw new Exception("Can't find Function Name Exception");

      var name = rx.Match(sql).ToString().Trim();

      // Trim off the extra stuff.
      while (name.Length > 2 && (!char.IsLetterOrDigit(name[name.Length - 1]) || name[name.Length - 1] != ']'))
      {
        name = name.Substring(0, name.Length - 2);
      }

      return name;

    }

    private string GetNameOnly(string name)
    {
      while(name.Contains("."))
        name = name.Substring(1,name.Length-1);

      name = name.Replace("[", string.Empty);
      name = name.Replace("]", string.Empty);
      return name;

    }

    private string GetSprocBody(string sql)
    {
      Regex rx = new Regex(@"(?<=PROCEDURE)(.*|\n*)\(", RegexOptions.IgnoreCase);
      if (!rx.IsMatch(sql))
        throw new Exception("sproc not matched exception");

      var s = rx.Split(sql);

      return s[s.Length - 1];

    }


    private bool IsSproc(string sql)
    {
      Regex rx = new Regex(@"[(CREATE)(ALTER)]\s+PROCEDURE", RegexOptions.IgnoreCase);

      return rx.IsMatch(sql);
    }

    private bool IsFunction(string sql)
    {
      Regex rx = new Regex(@"[(ALTER)(CREATE)]\s+FUNCTION", RegexOptions.IgnoreCase);
      return rx.IsMatch(sql);

    }

    private bool IsView(string sql)
    {
      Regex rx = new Regex(@"[(ALTER)(CREATE)]\s+VIEW", RegexOptions.IgnoreCase);
      return rx.IsMatch(sql); ;
    }

    private bool HasFunctionHeader(string sql)
    {
      Regex rx = new Regex(@"(IF OBJECT_ID).*\s*EXEC\([""']\s*DROP\s*FUNCTION", RegexOptions.IgnoreCase);
      return rx.IsMatch(sql);
    }

    private bool HasSprocHeader(string sql)
    {
      Regex rx  = new Regex(@"(IF OBJECT_ID).*\s*EXEC\([""']\s*CREATE\s*PROCEDURE", RegexOptions.IgnoreCase);
      return rx.IsMatch(sql);
    }

    private bool HasViewHeader(string sql)
    {
      Regex rx = new Regex(@"(IF OBJECT_ID).*\s*EXEC\([""']\s*CREATE\s*VIEW", RegexOptions.IgnoreCase);
      return rx.IsMatch(sql);
    }

    private bool HasUse(string sql)
    {
      Regex rx = new Regex(@"^.* USE.*\nGO$", RegexOptions.IgnoreCase);
      return rx.IsMatch(sql);
    }

    private string GetSprocHeader(string name)
    {
      var header = new StringBuilder();
        header.AppendLine($"IF OBJECT_ID('dbo.{name}') IS NULL");
      header.AppendLine($"EXEC('CREATE PROCEDURE dbo.{name} as SET NOCOUNT ON;')");
      header.AppendLine("GO");
      header.AppendLine("");
      header.AppendLine("SET ANSI_NULLS ON");
      header.AppendLine("GO");
      header.AppendLine("");
      header.AppendLine("SET QUOTED_IDENTIFIER OFF");
      header.AppendLine("GO");
      header.AppendLine("");
      header.AppendLine($"ALTER PROCEDURE [dbo].[{name}]");

      return header.ToString();
    }

    private string GetFuncHeader(string name)
    {
      var header = new StringBuilder();

      header.AppendLine($"IF OBJECT_ID('dbo.{name}') IS NOT NULL");
      header.AppendLine($"EXEC('DROP FUNCTION dbo.{name}')");
      header.AppendLine("GO");
      header.AppendLine("");
      header.AppendLine($"CREATE FUNCTION [dbo].[{name}]()");

      return header.ToString();
    }

    private string GetViewHeader(string name)
    {
      var header = new StringBuilder();
      header.AppendLine($"IF OBJECT_ID('dbo.{name}') IS NULL");
      header.AppendLine($"EXEC('CREATE VIEW dbo.{name} AS SELECT 0 AS A;')");
      header.AppendLine("GO");
      header.AppendLine("");
      header.Append($"ALTER VIEW [dbo].[{name}] AS");

      return header.ToString();
    }

  }


}
