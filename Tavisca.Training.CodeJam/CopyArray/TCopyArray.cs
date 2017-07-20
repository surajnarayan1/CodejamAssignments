using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyArray
{
    class TCopyArray
    {


        public void Tranfer(int limit)
        {


            int[] arrayold = new int[limit];
            int[] arraynew = new int[limit];
            int index;

            for( index=0;index<limit;index++)
            {
                arrayold[index] = Convert.ToInt32(Console.ReadLine());
                arraynew[index] = arrayold[index];


            }
            Console.WriteLine("The second Array is as follow"
            for(index=0;index<limit;index++)
            {
                Console.WriteLine(arraynew[index]);

            }
        }
    }
}
