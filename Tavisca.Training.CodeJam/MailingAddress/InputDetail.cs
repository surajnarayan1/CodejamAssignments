using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingAddress
{
    public class Detail
    {
        string UserName="";
        string city = " ";
        string Street = " ";
        int pin = 0;
       public  void InputInformation()
        {
            Console.WriteLine("Enter User Name \n City \n Street \n Pin \n");
            UserName = Console.ReadLine();
             city = Console.ReadLine();
             Street = Console.ReadLine();
            pin = Int32.Parse(Console.ReadLine());



        }
        public void  OutputInformation()
        {
            Console.WriteLine("The Username is " + UserName);
            Console.WriteLine("The city is" + city);
            Console.WriteLine("Street is" + Street);
            Console.WriteLine("pin is"+pin);
          


        }


    }
}
