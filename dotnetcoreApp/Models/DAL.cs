using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreApp.Models
{
    public class DAL
    {

        public static Users getUser(string username, string password)
        {

            try
            {
                leadDemoContext user = new leadDemoContext();
                var users = user.Users.Where(x => x.Username == username && x.Password == password).SingleOrDefault();
                if (users != null)
                {
                    return users;
                }
                return null;
            }
            catch (Exception ex)
            {
                
                return null;

            }

        }
    }
}
