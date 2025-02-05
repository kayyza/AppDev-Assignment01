using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecords
{
    internal class HealthProfile
    {
        // instance variables
        private string firstName;
        private string lastName;
        private int birthYear;
        private double height;
        private double weight;
        private int currentYear;

        // constructor
        public HealthProfile(string firstName, string lastName, int birthYear, double height, double weight, int currentYear)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.height = height;
            this.weight = weight;
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

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
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

        // property to calculate a person's maximum heart rate
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

        // calculate a person's BMI
        public double CalculateBMI()
        {
            double BMI = Math.Round((Weight * 703) / (Height * Height), 2);

            return BMI;
        }

        // converts a person's BMI result to text
        public string BMIText()
        {
            double bmi = CalculateBMI();
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Normal Weight";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }

        }

        // displays a person's health record in tabular form
        public void DisplayHealthRecord()
        {
            string fullName = lastName + "," + firstName;
            string range = MinTargetHeartRate + "-" + MaxTargetHeartRate;
            double BMI = CalculateBMI();
            string textBMI = BMIText();

            drawLine();
            Console.WriteLine($"│ {"PATIENT HEALTH RECORD",53}  {"│",25}");
            drawLine();

            Console.WriteLine($"│ {"Patient Name",-50} │ {fullName,-25} │");
            Console.WriteLine($"│ {"Patient Birth Year",-50} │ {birthYear,25} │");
            Console.WriteLine($"│ {"Patient Age",-50} │ {Age,25} │");
            Console.WriteLine($"│ {"Patient Height",-50} │ {Height,25} │");
            Console.WriteLine($"│ {"Patient Weight",-50} │ {Weight,25} │");
            Console.WriteLine($"│ {"Maximum Heart Rate",-50} │ {MaxHeartRate,25} │");
            Console.WriteLine($"│ {"Target Heart Rate Range",-50} │ {range,25} │");
            Console.WriteLine($"│ {"BMI Numeric Value",-50} │ {BMI,25} │");
            Console.WriteLine($"│ {"BMI Text Value",-50} │ {textBMI,-25} │");
            drawLine();

        }

        public static void drawLine()
        {
            Console.Write("│");
            for (int i = 0; i < 80; i++)
            {
                Console.Write("─");

            }
            Console.WriteLine("│");
        }
    }
}
