using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruxlab
{
    public static class PasswordValidator
    {
        public static int GetValidPasswordAmount(List<string> passwords)
        {
            int validPasswordsAmount = 0;

            foreach (var line in passwords)
            {
                var passwordWithRequirements = new PasswordWithRequirements(line);

                var amountOfRequiredSymbol = passwordWithRequirements.Password
                    .Count(e => e == passwordWithRequirements.RequiredSymbol);

                if (passwordWithRequirements.MinAmountOfRequiredSymbol <= amountOfRequiredSymbol &&
                    amountOfRequiredSymbol <= passwordWithRequirements.MaxAmountOfRequiredSymbol)
                {
                    validPasswordsAmount++;
                }
            }

            return validPasswordsAmount;
        }
    }
}
