using System;
using System.IO;


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
            string filePath = args[0];

            if (File.Exists(filePath))
            {
                Console.WriteLine("Error. File already exists");
                return;
            }
            
            #endregion
            File.Create(filePath);
        }
    }
}
