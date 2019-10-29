using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop
{
    public static class SessionExtensions
    {
        private const string MAIL = "userEmail";//konstantem pieskir seit vertibu un citur vairs nevar mainit.
        private const string ID = "userId";
        private const string BASKET = "userBasket";
        public static void SetUserEmail(this ISession session, string email)//pirmais mainigais klasi ko velamies paplasinat, talak visi mainigie, lai to izdaritu
        {
            session.SetString(MAIL, email);//atselga user email
        }
        public static string GetUserEmail(this ISession session)
        {
            return session.GetString(MAIL);
        }
        public static void SetUserId(this ISession session, int id)
        {
            session.SetInt32(ID, id);
        }
        public static int? GetUserId(this ISession session)
        {
            return session.GetInt32(ID);
        }
        public static void SetUserBasket(this ISession session, List<int> items)//sesijas var saglabat tikai int un string, ja vajag ko citu, tad izmanto JSON
        {
            var json = JsonConvert.SerializeObject(items);//parvertam sarakstu uz string - serialize
            session.SetString(BASKET, json);
        }
        public static List<int> GetUserBasket(this ISession session)
        {
            var json = session.GetString(BASKET);
            return json == null ? null : JsonConvert.DeserializeObject<List<int>>(json);//desiraliaze
            
        }
    }
}
