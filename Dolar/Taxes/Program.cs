using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxes
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarRate = 3.89, tax = 0;

            Console.WriteLine("Please enter your gross salary in shekels");
            double salary = double.Parse(Console.ReadLine());

            if (salary > 0 && salary <= 2000)
            {
                tax = 0;
            }

            if (salary > 2000 && salary <= 4770)
            {
                tax += 0.1 * (salary);
            }

            if (salary > 4770 && salary <= 10000)
            {
                tax += 0.3 * (salary);
            }

            if (salary > 10000)
            {
                tax += 0.5 * (salary);
            }

            Console.WriteLine("Gross Salary: {0}", salary);
            Console.WriteLine("Tax to pay: {0}", tax);
            Console.WriteLine("Net Salary: {0}", salary - tax);
            Console.WriteLine("Net Salary in dolars: ${0}", Math.Round(salary / dolarRate, 2));
            Console.ReadLine();
        }


    }
}


