using EmployeePayment.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EmployeePayment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number od employees:");
            int number = int.Parse(Console.ReadLine());

            for(int index = 1; index <= number; index++)
            {
                Console.WriteLine($"Employee #{index} data:");

                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            for(int i = 0; i < number; i++)
            {
                Console.WriteLine(employees[i].ToString());
            }


        }
    }
}
