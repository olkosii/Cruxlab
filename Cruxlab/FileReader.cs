using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Text;

namespace Cruxlab
{
    public static class FileReader
    {
        private static List<string> content = new List<string>();

        public static List<string> ReadFile()
        {
            Console.Write("Provide the path to the file with passwords: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                        content.Add(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n Something was wrong, try again\n");
                ReadFile();
            }
            
            return content;
        }
    }
}
