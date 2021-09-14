using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QFramework;

namespace QFramework.Net_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            QFramework.QCls_QApplication QApp = new QCls_QApplication();

            QApp.QApp_Version_Major = 1;
            QApp.QApp_Version_Minor = 2;
            QApp.QApp_Version_Sub = 1;
            QApp.QApp_Version_Update = 1;

            Console.WriteLine(QApp.QApp_Version);
            Console.ReadKey();
        }
    }
}
