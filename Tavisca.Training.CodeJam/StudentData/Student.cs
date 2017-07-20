using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    class Student
    {










        private string _name;
        private int _age;
        private int _rollNo;
        private int _class;
        private string _universityName;

        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public int RollNo { get { return _rollNo; } set { _rollNo = value; } }
        public int Class { get { return _class; } set { _class = value; } }
        public string UniversityName { get { return _universityName; } set { _universityName = value; } }
    }
}
