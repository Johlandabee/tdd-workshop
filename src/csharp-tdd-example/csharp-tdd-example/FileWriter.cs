using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment
{
    public class FileWriter
    {
        private string _filePath;

        public FileWriter()
        {
            _filePath = string.Empty;
        }

        public void CreateOutFile(string filePath)
        {
            _filePath = filePath;
            var stream = File.Create(_filePath);
            stream.Close();
        }

        public void WriteToOutFile(string text)
        {
            File.WriteAllText(_filePath, text);
        }
    }
}
