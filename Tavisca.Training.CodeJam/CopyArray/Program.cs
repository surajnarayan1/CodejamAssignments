using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit of array");
            int limit = Convert.ToInt32(Console.ReadLine());
            TCopyArray arraycopy = new TCopyArray();
            arraycopy.Tranfer(limit);



        }
    }
}
