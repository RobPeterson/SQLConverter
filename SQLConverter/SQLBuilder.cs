using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SQLConverter
{
  public abstract class SqlBuilder
  {
    protected StringBuilder sqlBuilder;
    public string GetUse(string sql)
    {
      Regex rx = new Regex(@"^.*USE.*\nGO$", RegexOptions.IgnoreCase);
      return rx.Match(sql).Value;
    }

    protected string GetNameOnly(string name)
    {
      while (name.Contains("."))
        name = name.Substring(1, name.Length - 1);

      name = name.Replace("[", string.Empty);
      name = name.Replace("]", string.Empty);
      return name;

    }
    protected bool HasUse(string sql)
    {
      Regex rx = new Regex(@"^.*USE.*\nGO$", RegexOptions.IgnoreCase);
      return rx.IsMatch(sql);
    }

    protected abstract void Build(string sql);
    protected abstract string GetBody(string sql);
    protected abstract string GetHeader(string name);
    protected abstract bool HasHeader(string sql);
    protected abstract string GetName(string sql);




  }
}
