using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Detail detail = new Detail();
            detail.InputInformation();
            detail.OutputInformation();
            Console.ReadKey();
           



        }
    }
}
