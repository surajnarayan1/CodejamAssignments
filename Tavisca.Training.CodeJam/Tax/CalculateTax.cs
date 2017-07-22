using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax
{
    class CalculateTax
    {

        double tax;
        public void  EvaluateTax(int income)
        {
            if (income < 10000)
            {
                tax = 0.05 * income;
            }
             else if((income>=10000)&&(income<100000))
            {
                tax = 0.08 * income;
            }
            else if((income>100000))
            {
                tax = 0.85 * income;
            }

            Console.WriteLine(tax);
        }
    }
}
