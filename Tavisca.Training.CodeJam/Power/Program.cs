using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power");
            int power = Convert.ToInt32(Console.ReadLine());
            NumberofPower powerobj = new NumberofPower(number,power);
            powerobj.CalculatePower(number,power);
            Console.ReadKey();

        }
    }
}
