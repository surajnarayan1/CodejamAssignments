using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArthematicOperation
{
    class Calculation
    {
       public void Operation(double first,double second,double third,double fourth)
        {
            double add = (first + second + third + fourth);
            double mul = (first * second * third * fourth);
            Console.WriteLine("The addition is " + add);
            Console.WriteLine("The Multiplication  is" + mul);
        }


    }
}
