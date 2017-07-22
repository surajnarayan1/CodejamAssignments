using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the  Income");
            int inc = Convert.ToInt32(Console.ReadLine());
            CalculateTax taxevaluate = new CalculateTax();
            taxevaluate.EvaluateTax(inc);


            Console.ReadKey();

        }
    }
}
