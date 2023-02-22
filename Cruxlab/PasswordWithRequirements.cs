using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruxlab
{
    public class PasswordWithRequirements
    {
        public char RequiredSymbol { get; set; }
        public char[] Password { get; set; }
        public int MinAmountOfRequiredSymbol { get; set; }
        public int MaxAmountOfRequiredSymbol { get; set; }

        public PasswordWithRequirements(string passwordWithRequirements)
        {
            var splitString = passwordWithRequirements
                .Split(new char[] { ' ', '-', ':' }, StringSplitOptions.RemoveEmptyEntries);

            RequiredSymbol = splitString[0][0];
            MinAmountOfRequiredSymbol= int.Parse(splitString[1]);
            MaxAmountOfRequiredSymbol= int.Parse(splitString[2]);
            Password = splitString[3].ToCharArray();
        }
    }
}
