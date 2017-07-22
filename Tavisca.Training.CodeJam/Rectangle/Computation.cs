using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Computation
    {
        public void calculation(int length,int breadth)
        {
            var area = length * breadth;
            var perimeter = 2*(length + breadth);

            Console.WriteLine("The area is " + area);
            Console.WriteLine("The perimeter is" + perimeter);

        }
    }
}
