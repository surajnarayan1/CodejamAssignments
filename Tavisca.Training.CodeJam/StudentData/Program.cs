using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    class Program
    {
        static void Main(string[] args)
        {

            var StudentInformation = new InformationProcessing();


            do
            {
                Console.WriteLine("Enter your choice \n(1) Insert Data\n(2)Display Data");
                int result;
                var choice = Int32.TryParse(Console.ReadLine(), out result);
                if (choice)
                {
                    switch (result)
                    {
                        case 1:
                            var studentinfo = new Student();
                            Console.WriteLine("Enter Name");
                            studentinfo.Name = Console.ReadLine();
                            Console.WriteLine("Enter Age");
                            studentinfo.Age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Roll No");
                            studentinfo.RollNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Class");
                            studentinfo.Class = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter University Name");
                            studentinfo.UniversityName = Console.ReadLine();

                            StudentInformation.InsertStudentdata(studentinfo);
                            break;

                        case 2:
                            var DataDisplay = StudentInformation.DisplayData();
                            Console.WriteLine("The detail information of Student is ");

                            foreach (var item in DataDisplay)
                            {
                                Console.WriteLine("The Name is   " + item.Name);
                                Console.WriteLine("The city name is   " + item.Age);
                                Console.WriteLine("The Street name is   " + item.RollNo);
                                Console.WriteLine("The pincode   " + item.Class);
                                Console.WriteLine("The house no " + item.UniversityName);
                                Console.WriteLine("\n");

                            }
                            break;
                        default:
                            Environment.Exit(0);
                            break;

                    }


                }
            }
            while (true);


        }
    }
    }

