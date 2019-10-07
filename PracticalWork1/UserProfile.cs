using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork1
{
    class UserProfile
    {
        //public const char MALE = 'M';
        //public const char FEMALE = 'F'; konstantes

        public enum Genders //enumerators = tips, kas ierobežo konkrētas vērtības; enumi sākas ar 0 numerācija
        { 
            Male,
            Female
        
        }
        public string FullName;
        public Genders Gender;
        public DateTime BirthDate;
        public UserProfile(string fullname, Genders gender, DateTime birthdate)
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
