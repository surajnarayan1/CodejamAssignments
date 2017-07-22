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


            int _num = 0;
            Console.WriteLine("Enter the number");
           // num = Convert.ToInt32((Console.ReadLine()));
           bool b = Int32.TryParse(Console.ReadLine(), out _num);
            if (b == true)
            {


                ValidatingEvenOdd find = new ValidatingEvenOdd(_num);
                find.check(_num);

                Console.ReadLine();



            }
            else
            {
                Console.WriteLine("Enter valid Number format");
            }
        }
    }
}
