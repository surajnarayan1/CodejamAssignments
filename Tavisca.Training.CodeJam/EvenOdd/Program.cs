using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = 0;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32((Console.ReadLine()));

            ValidatingEvenOdd find = new ValidatingEvenOdd(num);
            Console.ReadLine();




        }
    }
}
