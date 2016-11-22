using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NETTWO_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //File class
            //Directory Class

            string[] dir = Directory.GetDirectories(@"C:\");
            foreach(string name in dir)
            {
                Console.WriteLine(name);
            }
            string[] files = Directory.GetFiles(@"C:\Users\ryang\Downloads");
            foreach (string name in files)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
