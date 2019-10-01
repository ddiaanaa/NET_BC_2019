using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork1
{
    class UserProfile
    {
        public string FullName;
        public char Gender;
        public DateTime BirthDate;
        public UserProfile(string fullname, char gender, DateTime birthdate)
        {
            Gender = gender;
            FullName = fullname;
            BirthDate = birthdate;
        }

        public int UserAge()
        {
            return DateTime.Today.Year - BirthDate.Year;

        }
    }
}
