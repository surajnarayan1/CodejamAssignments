using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    class InformationProcessing
    {
        List<Student> StudentData = new List<Student>();
        public void InsertStudentdata(Student data)
        {
            StudentData.Add(data);
        }
        public List<Student> DisplayData()
        {
            return StudentData;
        }
    }
}
