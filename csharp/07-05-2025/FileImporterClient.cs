using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileImporter;

namespace FileImporterClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileManager fm = new FileManager();
            string Result = fm.ReadFileContent(@"c:\swetha");
            Console.WriteLine(Result);
        }
        //C:\Users\akkarapaku.swetha\.net(05-05-2025)\FileImporter\FileImporter\bin\Debug
    }
}
