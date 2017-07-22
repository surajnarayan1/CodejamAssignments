using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArthematicOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            double _FirstNumber;
            double _SecondNumber;
            double _ThirdNumber;
            double _FourthNumber;
            Console.WriteLine("Enter  the four number");
            bool CheckFirst = Double.TryParse(Console.ReadLine(), out _FirstNumber);
            bool CheckSecond = Double.TryParse(Console.ReadLine(), out _SecondNumber);
            bool CheckThird = Double.TryParse(Console.ReadLine(), out _ThirdNumber);
            bool CheckFourth= Double.TryParse(Console.ReadLine(), out _FourthNumber);
            if((CheckFirst==true)&&(CheckSecond==true)&&(CheckThird==true)&&(CheckFourth==true))
            {
                Calculation calobj = new Calculation();
                calobj.Operation(_FirstNumber, _SecondNumber, _ThirdNumber, _FourthNumber);

    
                }
            else
            {
                Console.WriteLine("Enter the valid input");
            }



            Console.ReadKey();


        }
    }
}
