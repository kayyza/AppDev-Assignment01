using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetHeartRateCalculator
{
    internal class HeartRates
    {
        // instance variables
        private string firstName;
        private string lastName;
        private int birthYear;
        private int currentYear;

        // constructor
        public HeartRates(string firstName, string lastName, int birthYear, int currentYear)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.currentYear = currentYear;
        }

        // properties for each attribute
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public int BirthYear
        {
            get
            {
                return birthYear;
            }
            set
            {
                birthYear = value;
            }
        }

        public int CurrentYear
        {
            get
            {
                return currentYear;
            }
            set
            {
                currentYear = value;
            }
        }

        // property to calculate age
        public int Age
        {
            get
            {
                int age = currentYear - birthYear;
                return age;
            }
        }

        // property to calculate max heart rate
        public int MaxHeartRate
        {
            get
            {
                int maxHeartRate = 220 - Age;
                return maxHeartRate;
            }
        }

        // property to calculate a person's minimum target heart rate
        public int MinTargetHeartRate
        {
            get
            {
                int minTargetHeartRate = (int)(MaxHeartRate * 0.50);
                return minTargetHeartRate;
            }
        }

        // property to calculate a person's maximum target heart rate
        public int MaxTargetHeartRate
        {
            get
            {
                int maxTargetHeartRate = (int)(MaxHeartRate * 0.85);
                return maxTargetHeartRate;
            }
        }

        // displays person’s data in tabular form 
        public void DisplayPatientRecord()
        {
            string fullName = lastName + "," + firstName;
            string range = MinTargetHeartRate + "-" + MaxTargetHeartRate;

            drawLine();
            Console.WriteLine($"| {"PATIENT HEART RATE RECORD",53}  {"|",25}");
            drawLine();

            Console.WriteLine($"| {"Patient Name",-50} | {fullName,-25} |");
            Console.WriteLine($"| {"Patient Birth Year",-50} | {birthYear,25} |");
            Console.WriteLine($"| {"Patient Age",-50} | {Age,25} |");
            Console.WriteLine($"| {"Maximum Heart Rate",-50} | {MaxHeartRate,25} |");
            Console.WriteLine($"| {"Target Heart Rate Range",-50} | {range,25} |");
            drawLine();

        }

        public static void drawLine()
        {
            Console.Write("|");
            for (int i = 0; i < 80; i++)
            {
                Console.Write("-");

            }
            Console.WriteLine("|");
        }
    }
}
