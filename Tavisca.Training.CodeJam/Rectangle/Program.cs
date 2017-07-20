using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int length;int breadth;
            bool testforLength = int.TryParse(args[0], out length);
           // int length = Convert.ToInt32(args[0]);
            bool  testforbreadth = int.TryParse(args[1], out breadth);
            if ((testforLength == true) && (testforbreadth == true))
            {
                Computation rectangle = new Computation();
                rectangle.calculation(length, breadth);


            }
            else
            {
                Console.WriteLine("Enter in valid format");
            }

        }
    }
}
