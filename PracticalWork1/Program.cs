using ConsoleHelpers;
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
            
            try
            {
                UserList list = new UserList();     
                while (true)
                {
                    try
                    {
                        string fullname = ConsoleInput.GetName("Enter name");
                        UserProfile.Genders gender = GetGender();//genders datu tips
                        DateTime birthdate = ConsoleInput.GetDate("Enter birthdate");
                        list.Add(fullname, gender, birthdate);

                        Console.WriteLine("Add another? (y/n)");
                        string input = Console.ReadLine().ToLower();
                        if(input=="n")
                        {
                            break;
                        }
                    }
                    catch (InputExceptions ex)//inputExceptions musu kluda
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unexpected error! {0}", ex.Message);
            }         
               
                Console.Read();
            
            
            //1.ievada vārdu
            //1.2.ievada dzimumu(DateTime.TryParse)
            //1.3.ievada dzimumu (Enum.TryParse)
            //2.Izsauc lietotāja pievienošana list.Add();
            //3. Ja neizdevās pievienot, attēlo kļūdas paziņojum
           // Console.Read();

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


