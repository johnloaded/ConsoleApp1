using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Logger
    {
        public static void Write(string nameFile, string text)
        {
            StreamWriter myFile;
            myFile = File.AppendText(nameFile);
            myFile.WriteLine(DateTime.Now + " - " + text);
            myFile.Close();
        }
    }
}
