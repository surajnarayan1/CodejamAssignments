using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class NumberofPower
    {
        private int power;
        private int power1;
        private int number;

        public NumberofPower(int number, int power)
        {
            this.number = number;
            this.power = power;
        }

        public void CalculatePower(int number ,int power )
        {
            int value =(int) Math.Pow(number, power);
            Console.WriteLine(value);
        }
    }
}
