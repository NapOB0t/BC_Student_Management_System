using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRGProject
{
    internal class Student
    {
        public Student(int studentNumber, string name, string surName, DateTime dOB, string phoneNumber, string address, int modCode, string Gender)
        {
            StudentNumber = studentNumber;
            Name = name;
            SurName = surName;
            DOB = dOB;
            PhoneNumber = phoneNumber;
            Address = address;
            ModCode = modCode;
            gender = Gender;
        }

        public int StudentNumber { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public string Picture { get; set; }
        public DateTime DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public int ModCode { get; set; }

        public string gender { get; set; }
    }
}

