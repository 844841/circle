using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcparameter
{
    class Program
    {
        static void Main(string[] args)
        {
            circle circle = new circle();
            Console.WriteLine("enter radius:");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(circle.Calculate(x => 2 * (p+p*p)));
            Console.WriteLine(circle.Calculate(r => 2 * Math.PI * p));
            Console.WriteLine();
            Console.WriteLine(circle.Calculate(r =>  Math.PI * p));
            Console.WriteLine(circle.Calculate(a =>  p * p * p));
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            Console.WriteLine(circle.Changecase(a => s.ToUpper()));
            //Console.Writeline("Enter upper case letters");
            string t = "IN UPPER CASE";
            Console.WriteLine(circle.Changecase(x => t.ToLower()));






        }
    }
}
