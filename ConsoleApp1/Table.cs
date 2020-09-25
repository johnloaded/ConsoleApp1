using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Table
    {
        protected int width, height;

        public Table(int tableWidth, int tableHeight)
        {
            width = tableWidth;
            height = tableHeight;
        }

        public void ShowData()
        {
            Console.WriteLine("Width: {0}, Height: {1}", width, height);
        }

        public void Save(string name)
        {
            BinaryWriter outputFile = new BinaryWriter(
            File.Open(name, FileMode.Create));
            outputFile.Write(height);
            outputFile.Write(width);
            outputFile.Close();
        }

        public void Load(string name)
        {
            BinaryReader inputFile = new BinaryReader(
            File.Open(name, FileMode.Open));
            height = inputFile.ReadInt32();
            width = inputFile.ReadInt32();
            inputFile.Close();
        }
    }
}
