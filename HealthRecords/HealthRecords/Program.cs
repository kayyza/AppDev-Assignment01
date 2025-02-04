using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Birth Year: ");
            int birthYear = int.Parse(Console.ReadLine());
            Console.Write("Enter Height (in inches): ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Enter Weight (in pounds): ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Enter Current Year: ");
            int currentYear = int.Parse(Console.ReadLine());

            HealthProfile healthProfile = new HealthProfile(firstName, lastName, birthYear, height, weight, currentYear);
            healthProfile.DisplayHealthRecord();
        }
    }
}
