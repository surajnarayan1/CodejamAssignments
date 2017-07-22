using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FileHandling
{
    class StudentInfo
    {
        private string _Fname;
        private string _Lname;
        public string _Mnumber;
        private string _Email;
        private string _address;
        private DateTime _Dob;
        private string _CurrentMentor;
        private string _CurrentCourse;
        private string _EmergencyContact;

        public string FirstName { get { return _Fname; } set { _Fname = value; } }
        public string LastName { get { return _Lname; } set { _Lname = value; } }
        public string MobileNumber { get { return _Mnumber; } set { _Mnumber = value; } }
        public string Email { get { return _Email; } set { _Email = value; ; } }
        public string Address { get { return _address; } set { _address = value; } }
        public DateTime DateOfBirth { get { return _Dob; } set { _Dob = value; } }
        public string CurrentMentor { get { return _CurrentMentor; } set { _CurrentMentor = value; } }
        public string currentCourse { get { return _CurrentCourse; } set { _CurrentCourse = value; } }
        public string EmergencyContact { get { return _EmergencyContact; } set { _EmergencyContact = value; } }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }











    }
}
