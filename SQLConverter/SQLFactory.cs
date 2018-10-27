using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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
      var sprocBuilder = new SprocBuilder();
      var functionBuilder = new FunctionBuilder();
      var viewBuilder = new ViewBuilder();
      var result = "";
      if (sprocBuilder.IsType(sql))
        result = sprocBuilder.Get(sql);
      if (functionBuilder.IsType(sql))
        result = functionBuilder.Get(sql);
      if (viewBuilder.IsType(sql))
        result = viewBuilder.Get(sql);

      return result;
    }




    

  }


}
