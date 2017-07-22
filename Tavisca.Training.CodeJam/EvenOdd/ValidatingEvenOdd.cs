using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
  public class ValidatingEvenOdd
    {
        private int num;

        public ValidatingEvenOdd(int num)
        {
            this.num = num;
        }

       public  void check(int num)
        {
            if((num % 2)==1)
            
                Console.WriteLine("Odd number");
                else
                Console.WriteLine("Even number");
            
        }
    }
}
