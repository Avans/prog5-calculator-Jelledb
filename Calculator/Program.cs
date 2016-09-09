using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vul je geboortedatum in met het formaat dd-MM-yyyy...");
            String datum = Console.ReadLine();
            MijnEpischeCalculator calculator = new MijnEpischeCalculator();
            DateTime dt = DateTime.Today;

            if (calculator.ParseInput(datum, out dt)) {
                Console.WriteLine("Je bent " + calculator.CalculateAge(dt) + " jaar oud.");
            }

            Console.ReadKey();
            
        }
    }
}
