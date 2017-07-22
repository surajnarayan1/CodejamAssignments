using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            DetailStud student = new DetailStud();
            student.input();
            student.display();
            Console.ReadKey();


        }
    }
}
