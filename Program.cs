using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace touch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Error Checking"
            if (args[0].Length > 15)
            {
                Console.WriteLine("Error. File name too long");
                return;
            }
            if (args.Length > 1)
            {
                Console.WriteLine("Syntax error. Usage: touch {filename}");
                return;
            }
            //Check for path traversal
            string filename = args[0];
            if (filename.StartsWith("..") || filename.StartsWith("/"))
            {
                Console.WriteLine("Path traversal error!");
                return;
            }

            if (File.Exists(filename))
            {
                Console.WriteLine("Error. File already exists");
                return;
            }
            
            #endregion
            File.Create(filename);
        }
    }
}
