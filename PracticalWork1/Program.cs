using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserList list = new UserList();
           
            while (true)
            {
                string fullname = GetName();
                UserProfile.Genders gender = GetGender();//genders datu tips
                DateTime birthdate = GetDate();
                list.Add(fullname, gender, birthdate);               
                Console.Read();
            }
            
            //1.ievada vārdu
            //1.2.ievada dzimumu(DateTime.TryParse)
            //1.3.ievada dzimumu (Enum.TryParse)
            //2.Izsauc lietotāja pievienošana list.Add();
            //3. Ja neizdevās pievienot, attēlo kļūdas paziņojum
           // Console.Read();

        }
        public static DateTime GetDate()
        {

            Console.WriteLine("Enter your birth date(yyyy/mm/dd): ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime birthdate))
            {              
                return birthdate;                
            }
            else
            {
                Console.WriteLine("Error");
                return GetDate();
            }          
        }
        public static string GetName()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            name = name.Trim();

            if(!String.IsNullOrEmpty(name))
            {
                return name;
            }
            else
            {
                Console.WriteLine("Empty text!");
                return GetName();
            }
        }
        public static UserProfile.Genders GetGender()
        {
            Console.WriteLine("Enter your gender(male of female): ");
            string value = Console.ReadLine();

            if(Enum.TryParse(value, true, out UserProfile.Genders gender))//parametrs IgnoreCase ->true, false neignore vertibas
            {
                return gender;
            }
            else
            {
                Console.WriteLine("Incorrect value!");
                return GetGender();
            }
        }

    }
}


