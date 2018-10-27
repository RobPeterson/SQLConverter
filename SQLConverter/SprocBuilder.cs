using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SQLConverter
{
  public class SprocBuilder : SqlBuilder, ISqlBuilder
  {
    protected override void Build(string sql)
    {
      this.sqlBuilder = new StringBuilder();
      if (HasUse(sql))
        this.sqlBuilder.Append(GetUse(sql));

      var name = GetName(sql);
      name = GetNameOnly(name);

      this.sqlBuilder.Append(GetHeader(name));
      this.sqlBuilder.Append("(");
      this.sqlBuilder.Append(GetBody(sql));
    }

    protected override string GetBody(string sql)
    {
      Regex rx = new Regex(@"(?<=PROCEDURE)(.*|\n*)\(", RegexOptions.IgnoreCase);
      if (!rx.IsMatch(sql))
        throw new Exception("sproc not matched exception");

      var s = rx.Split(sql);

      return s[s.Length - 1];
    }

    protected override string GetHeader(string name)
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

    protected override string GetName(string sql)
    {
      Regex rx = new Regex(@"(?<=PROCEDURE\s).*(?=\()", RegexOptions.IgnoreCase);
      if (!rx.IsMatch(sql))
        throw new Exception("Can't find Sproc Name Excpetion");
      var name = rx.Match(sql).ToString().Trim();
      return name;
    }

    protected override bool HasHeader(string sql)
    {
      Regex rx = new Regex(@"(IF OBJECT_ID).*\s*EXEC\([""']\s*CREATE\s*PROCEDURE", RegexOptions.IgnoreCase);
      return rx.IsMatch(sql);
    }

    public bool IsType(string sql)
    {
      Regex rx = new Regex(@"[(CREATE)(ALTER)]\s+PROCEDURE", RegexOptions.IgnoreCase);

      return rx.IsMatch(sql);
    }

    public string Get(string sql)
    {
      this.Build(sql);
      return this.sqlBuilder.ToString();
    }

    
  }
}
