using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MijnEpischeCalculator : IAgeCalculator
    {
        public int CalculateAge(DateTime dateOfBirth)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - dateOfBirth.Year;
            if (dateOfBirth > now.AddYears(-age)) age--;
            return age;
        }

        public bool ParseInput(string input, out DateTime result)
        {
            try
            {
                result = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Het formaat van de datum is incorrect.");
                result = DateTime.Today;
                return false;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Je hebt niets ingevuld.");
                result = DateTime.Today;
                return false;
            }

        }
    }
}
