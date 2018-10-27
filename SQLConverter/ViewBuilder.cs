using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SQLConverter
{
  public class ViewBuilder : SqlBuilder, ISqlBuilder
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


      public string Get(string sql)
      {
        this.Build(sql);
        return this.sqlBuilder.ToString();
      }
    

    protected override string GetBody(string sql)
    {
      Regex rx = new Regex(@"AS(.*|\n*)*.", RegexOptions.IgnoreCase);
      if (!rx.IsMatch(sql))
        throw new Exception("VIEW not matched exception");

      var body = rx.Match(sql).ToString().Trim();

      return body;
    }

    protected override string GetHeader(string name)
    {
      var header = new StringBuilder();
      header.AppendLine($"IF OBJECT_ID('dbo.{name}') IS NULL");
      header.AppendLine($"EXEC('CREATE VIEW dbo.{name} AS SELECT 0 AS A;')");
      header.AppendLine("GO");
      header.AppendLine("");
      header.Append($"ALTER VIEW [dbo].[{name}] AS");

      return header.ToString();
    }

    protected override string GetName(string sql)
    {
      Regex rx = new Regex(@"(?<=VIEW\s).*", RegexOptions.IgnoreCase);
      if (!rx.IsMatch(sql))
        throw new Exception("Can't find Function Name Exception");

      var name = rx.Match(sql).ToString().Trim();

      return name;
    }

    protected override bool HasHeader(string sql)
    {
      Regex rx = new Regex(@"(IF OBJECT_ID).*\s*EXEC\([""']\s*CREATE\s*VIEW", RegexOptions.IgnoreCase);
      return rx.IsMatch(sql);
    }


    public bool IsType(string sql)
    {
      Regex rx = new Regex(@"[(ALTER)(CREATE)]\s+VIEW", RegexOptions.IgnoreCase);
      return rx.IsMatch(sql); ;
    }
  }
}
