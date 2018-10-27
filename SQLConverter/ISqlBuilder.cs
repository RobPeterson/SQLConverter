using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLConverter
{
  public interface ISqlBuilder
  {

    bool IsType(string sql);
    string Get(string sql);


  }
}
