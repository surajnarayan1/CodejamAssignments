using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Firt Number and Second Number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number before swapping are {0} {1}", num1, num2);
            Exchange Swapobj = new Exchange(num1, num2);





        }
    }
}
