using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SQLConverter
{
  public class FunctionBuilder : SqlBuilder, ISqlBuilder
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
      Regex rx = new Regex(@"RETURNS(.*|\n*)*.", RegexOptions.IgnoreCase);
      if (!rx.IsMatch(sql))
        throw new Exception("Can't find Function Body Exception");

      var body = rx.Match(sql).ToString().Trim();


      return body;
    }

    protected override string GetHeader(string name)
    {
      var header = new StringBuilder();

      header.AppendLine($"IF OBJECT_ID('dbo.{name}') IS NOT NULL");
      header.AppendLine($"EXEC('DROP FUNCTION dbo.{name}')");
      header.AppendLine("GO");
      header.AppendLine("");
      header.AppendLine($"CREATE FUNCTION [dbo].[{name}]()");

      return header.ToString();
    }

    protected override string GetName(string sql)
    {
      Regex rx = new Regex(@"(?<=FUNCTION).*\([@|\s*]", RegexOptions.IgnoreCase); // function with parameters
      Regex rx2 = new Regex(@"(?<=FUNCTION).*\(", RegexOptions.IgnoreCase); // without parameters
      if (!rx.IsMatch(sql))
      {
        
        if (!rx2.IsMatch(sql))
        {
          throw new Exception("Can't find function name.");
        }
      }

      var name = rx.Match(sql).ToString().Trim();
      if (name == String.Empty)
        name = rx2.Match(sql).ToString().Trim();

      // Trim off the extra stuff.
      while (name.Length > 2 && (!char.IsLetterOrDigit(name[name.Length - 1]) && name[name.Length - 1] != ']'))
      {
        name = name.Substring(0, name.Length - 1);
      }

      return name;
    }

    protected override bool HasHeader(string sql)
    {
      Regex rx = new Regex(@"(IF OBJECT_ID).*\s*EXEC\([""']\s*DROP\s*FUNCTION", RegexOptions.IgnoreCase);
      return rx.IsMatch(sql);
    }


    public bool IsType(string sql)
    {
      Regex rx = new Regex(@"[(ALTER)(CREATE)]\s+FUNCTION", RegexOptions.IgnoreCase);
      return rx.IsMatch(sql);
    }

    public string Get(string sql)
    {
      this.Build(sql);
      return this.sqlBuilder.ToString();
    }
  }
}
