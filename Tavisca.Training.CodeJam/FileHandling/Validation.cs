using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FileHandling
{
    class Validation
    {


        #region validation methods
        public bool validateMobile(StudentInfo studobj)
        {
            //int length = studobj.MobileNumber.Length;
            if (!Regex.IsMatch(studobj.MobileNumber, "^[0-9]{10}$"))
            {
                Console.WriteLine("Enter valid mobile number");
                return false;
            }
            else
            {

                return true;
            }

        }
       
        public bool validateEmail(StudentInfo studobj)
        {
            if (!Regex.IsMatch(studobj.Email, @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-z]{2,3}$"))
            {
               
                return  false;
            }
            else
                return true;
        }
            public void Address(StudentInfo studobj)
           {
            if (!Regex.IsMatch(studobj.Address, @"^[0-3][0-9][01][0-9][12][0-9]{3}$"))
            {
                Console.WriteLine("Enter valid Address");
            }
            #endregion


          


        }
            


    }


}

