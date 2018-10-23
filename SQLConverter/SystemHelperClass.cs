using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLConverter
{
  public static class SystemHelperClass
  {
    public static void GetInstalledApps()
    {
      string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
      List<string> lstInstalled = new List<string>();
       using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
      {
        foreach (string skName in rk.GetSubKeyNames())
        {
          using (RegistryKey sk = rk.OpenSubKey(skName))
          {
            try
            {
              lstInstalled.Add(sk.GetValue("DisplayName").ToString());
            }
            catch (Exception ex)
            { }
          }
        }
      }
    }
  }
}
