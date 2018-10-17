using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
      return sql;
    }

    public bool IsSproc(string sql)
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

    private string GetViewHeader()
    {
      var header = new StringBuilder();
      header.AppendLine("IF OBJECT_ID('dbo.viewname') IS NULL");
      header.AppendLine("EXEC('CREATE VIEW dbo.viewname AS SELECT 0 AS A;')");
      header.AppendLine("GO");
      header.AppendLine("");
      header.Append("ALTER VIEW[dbo].[viewname] AS");

      return header.ToString();
    }

  }


}
