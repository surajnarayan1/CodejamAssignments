using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;



namespace FileHandling
{
    class Program
    {
        
        static void Main(string[] args)
        {

           StudentInfo studobj = new StudentInfo();
           DirectoryInfo directory = new DirectoryInfo(@"D:\like");
           directory.Create();
           Console.Write("Enter 1 for input 2. for view saved record\n");
            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Input inputObj = new Input();
                    inputObj.InputName();
                    inputObj.InputMObile();
                    inputObj.InputDateofBirth();
                    inputObj.InputEmail();
                    inputObj.InputEmergencyContact();
                    inputObj.Inputmentorcourse();
                    if(!File.Exists(@"D:\like\" + inputObj.studobj.FirstName + ".txt"))
                    {
                        using (File.Create(@"D:\like\" + inputObj.studobj.FirstName + ".txt")) ;
                    }
                    File.WriteAllText(@"D:\like\" + inputObj.studobj.FirstName + ".txt", inputObj.studobj.ToString());
                    Console.ReadKey(true);
                    break;
                case 2:
                    string name;
                    Console.WriteLine("Enter first name");
                    name=Console.ReadLine();
                    StudentInfo RetrievedObject=JsonConvert.DeserializeObject<StudentInfo>(File.ReadAllText(@"D:\like\" + name +".txt"));
                    //Console.WriteLine(RetrievedObject);
                    printdetails(RetrievedObject);

                    Console.ReadKey(true);
                    break;
                
            }
            
        }

        public  static void printdetails(StudentInfo student)
        {
            Console.WriteLine(student.Email);

            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.MobileNumber);
            Console.WriteLine(student.EmergencyContact);
        }
    }
}