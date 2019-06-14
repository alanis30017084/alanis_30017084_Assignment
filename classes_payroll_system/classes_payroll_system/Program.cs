/*Name: Alanis Correa Kriener
 Assignment*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_payroll_system
{
    class Program
    {
        static void Main(string[] args)
        {
            // New employee object.
            Employee e1 = new Employee();

            // Welcome message.
            Console.WriteLine("Welcome to the Rotorua Thermal Holiday park Payroll System.\n");

            // Prompts to obtain name, annual gross salary and tax rate. Assigned to appropriate properties.
            Console.Write("Please enter the employee's name: ");
            e1.Name = Console.ReadLine();
            Console.Write("Please enter their annual gross salary: ");
            e1.Salary = double.Parse(Console.ReadLine());
            Console.Write("Please enter their tax rate as a percentage: ");
            e1.Tax = double.Parse(Console.ReadLine());

            // Displaying name, gross salary, tax rate and net salary back to the user.
            Console.WriteLine($"\nEmployee name: {e1.Name}\nAnnual gross salary: ${e1.Salary}\nTax rate: {e1.Tax}%\nNet salary: ${e1.CalcNet(e1.Salary, e1.Tax)}");
            Console.ReadLine();
        }
    }
    class Employee
    {
        // Private instance variables.
        private string name;
        private double salary;
        private double tax;

        // Getters and setters.
        public string Name { get { return name; } set { name = value; } }
        public double Salary { get { return salary; } set { salary = value; } }
        public double Tax { get { return tax; } set { tax = value; } }

        // Method to calculate employee's net salary.
        public double CalcNet(double _salary, double _tax)
        {
            Salary = _salary;
            Tax = _tax;
            double netSalary = Math.Round(salary - salary * (tax/100), 2);
            return netSalary;
        }

        // Constructor displaying message.
        public Employee()
        {
            Console.WriteLine("Employee record created.");
        }
    }
}
