using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

//using NsExcel = Microsoft.Office.Interop.Excel;

namespace BatchPass.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var list = new PasswordDictionary(500);
            ToExcel(list.passwords);

        }


        public void ToExcel(List<string> l)
        {
            using (StreamWriter sw = File.CreateText(@"C:\Users\rpaulson\Desktop\list.csv"))
            {
                for (int i = 0; i < l.Count; i++)
                {
                    sw.WriteLine(l[i]);
                }
            }

        }
    }
}
