using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    class Exchange
    {
        private int num1;
        private int num2;

        public Exchange(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        void Swap(int num1,int num2)
        {
             num1 = num1 + num2;
             num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("The value after swapping are as folow:");
            Console.WriteLine("The first number"+num1);
            Console.WriteLine("The second number is"+num2);
        }
    }
}
