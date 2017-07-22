using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class DetailStud
    {
        string Sname = " ";
        int rollnum = 0;
        int age = 0;
        String classes = " ";
        string UniversityName=" ";

        public void input()
        {
            Console.WriteLine("Enter the Student Name \n Roll number \n age \nclass \n UniversityName");
         Sname = Console.ReadLine();
            rollnum = Convert.ToInt32(Console.ReadLine());
            age = Convert.ToInt32((Console.ReadLine()));
           classes = Console.ReadLine();
            //String class = Console.ReadLine();
          UniversityName = Console.ReadLine();




        }

        public void display()
        {
            Console.WriteLine("The Student name is " + Sname);
            Console.WriteLine("Roll Number" + rollnum);
            Console.WriteLine("Age" + age);
            Console.WriteLine("classes" + classes);
            Console.WriteLine("UniversityName" + UniversityName);

        }


    }
}
