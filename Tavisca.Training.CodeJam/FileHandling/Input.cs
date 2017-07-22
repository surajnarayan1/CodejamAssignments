using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FileHandling
{
    class Input
    {
        public StudentInfo studobj = new StudentInfo();
        Validation validateobj = new Validation();
       

        public void InputName()
        {


            Console.WriteLine("Enter First name");
            studobj.FirstName = Console.ReadLine();
            Console.WriteLine("enter Last name");
            studobj.LastName = Console.ReadLine();
        }
        //in main : studobj.MobileNumber=inputobj.InputMobile()
        public void InputMObile()
        {
            while (true)
            {

                Console.WriteLine("enter mobile number");
                String mobile = Console.ReadLine();
                studobj.MobileNumber = mobile;
            
                if (validateobj.validateMobile(studobj))
                {
                    studobj.MobileNumber = mobile;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter validate  Email_id");
                }
            }
        }
        public void InputEmail()
        {
            while (true)
            {
                Console.WriteLine("Enter Email");
                string email = Console.ReadLine();
                studobj.Email = email;
           
                if (validateobj.validateEmail(studobj))
                {
                    studobj.Email = email;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter validate  Email_id");
                }



            }
        }

        public void InputDateofBirth()
        {
            Console.WriteLine("Enter Date Of Birth");
            studobj.DateOfBirth = DateTime.Parse(Console.ReadLine());
        }
        public void Inputmentorcourse()
        {
            Console.WriteLine("eNTER  CURRENT mENTOR AND CURRENT COURSE AND Emergency contact");
            studobj.CurrentMentor = (Console.ReadLine());
            studobj.currentCourse = (Console.ReadLine());
        }
        public void InputEmergencyContact()
        {  
                string Econtact = (Console.ReadLine());
                studobj.EmergencyContact = Econtact;
        }











    }
}
