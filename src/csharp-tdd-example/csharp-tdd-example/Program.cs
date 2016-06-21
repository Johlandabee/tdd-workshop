using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment
{
    class Program
    {
        private static string filePath;

        static void Main(string[] args)
        {
            var writer = new FileWriter();
            writer.CreateOutFile("./Output.txt");
            writer.WriteToOutFile("Hallo Welt");

            Console.WriteLine("Feddich Meister!");
            Console.ReadKey();
        }

        
    }
}
