using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruxlab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileContent = FileReader.ReadFile();

            var validPasswordsAmount = PasswordValidator.GetValidPasswordAmount(fileContent);

            Console.WriteLine($"Amount of valid passwords from the file: {validPasswordsAmount}");

            Console.ReadLine();
        }
    }
}
