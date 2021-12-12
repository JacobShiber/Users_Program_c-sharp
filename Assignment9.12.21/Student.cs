using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9._12._21
{
    class Student : User
    {
        string grade;

        public Student(string _firstName, string _lastName, int _birthYear, string _email, string _grade) : base(_firstName, _lastName, _birthYear, _email)
        {
            this.grade = _grade;
        }

        public override string PrintDetails()
        {
            return $"{base.PrintDetails()}\nGrade - {this.grade}";
        }
    }
}
