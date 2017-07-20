using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            String str = Console.ReadLine();
            ReverseString reverseObj = new ReverseString();
           reverseObj.Reverse(str);
            Console.ReadKey();


        }
    }
}
