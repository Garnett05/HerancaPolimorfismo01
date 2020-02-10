using System;
using ExercicioHerancaPolimorfismoOO.Entities;
using System.Collections.Generic; //necessário p/ usar List
using System.Globalization;

namespace ExercicioHerancaPolimorfismoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int aux = int.Parse(Console.ReadLine());
            List<Employee> emp = new List<Employee>();

            for (int i = 1; i <= aux; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double additional = 0.00;
                if (c == 'y')
                {
                    Console.Write("Additional charge: ");
                    additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.Add(new OutsourcedEmployee(name, hours, valuePerHour, additional));
                }
                else
                {
                    emp.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach(Employee x in emp)
            {
                Console.WriteLine(x.Name + " - $ " + x.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
