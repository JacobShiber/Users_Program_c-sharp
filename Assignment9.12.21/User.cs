using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9._12._21
{
    class User : IComparable
    {
        public string firstName;
        public string lastName;
        public int birthYear;
        public string email;

        public User(string _firstName, string _lastName, int _birthYear, string _email)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.birthYear = _birthYear;
            this.email = _email;
        }

        public virtual string PrintDetails()
        {
            return $"Username - {this.firstName} {this.lastName}\nBirth Year - {this.birthYear}\nEmail - {this.email}";
        }

        public int CompareTo(object obj)
        {
            User u = (User)obj;
            if (this.birthYear > u.birthYear) return -1;
            if (this.birthYear < u.birthYear) return 1;
            return 0;
        }
    }
}
