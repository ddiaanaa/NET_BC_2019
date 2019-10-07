using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork1
{
    class UserList
    {
        public List<UserProfile> users = new List<UserProfile>();

        public void Add(string fullname, UserProfile.Genders gender, DateTime birthdate)
        {
            if(birthdate > DateTime.Now)
            {
                throw new InputExceptions("Date is incorrect! You date is in the future!");
            }            
            if(birthdate < new DateTime(1800, 1, 1))
            {
                throw new InputExceptions("Date is incorrect! It was many years ago...");
            }
             
            if(fullname.Length> 20)
            {
                throw new InputExceptions("Your name is too long. Try shorter one.");
            }
           
            //if...thro new exceptions 
                //visas tris kludas seit norada
            //pārbaudes:
            //1.datums nedrīkst būt nākotne
            //2.datums nedrīkst būt mazāks par 01.01.1800.
            //3.vārds nedrīkst pārsniegt 20 simbolus

            UserProfile user = new UserProfile(fullname, gender, birthdate); //visas funkcijas kas ir UserProfile klase caur mainigo user mes varam izsaukt
            Console.WriteLine(user.UserAge());
            users.Add(user);
        }
    }
}
