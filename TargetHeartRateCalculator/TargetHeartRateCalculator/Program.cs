using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetHeartRateCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Please Enter Birth Year: ");
            int birthYear = int.Parse(Console.ReadLine());
            Console.Write("Please Enter Current Year: ");
            int currentYear = int.Parse(Console.ReadLine());

            HeartRates patient = new HeartRates(firstName, lastName, birthYear, currentYear);
            patient.DisplayPatientRecord();
        }
    }
}
