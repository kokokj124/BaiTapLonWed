using BaiTapLon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models.DAOO
{
    public class LoginDAO
    {
        public DataBase db;
        public LoginDAO()
        {
            db = new DataBase();
        }

        public string createUser(Login user)
        {
            try
            {
                db.Logins.Add(user);
                db.SaveChanges();
                return "Success";
            }
            catch
            {
                return "Error";
            }
        }
        public string checkUser(string email, string password)
        {
            var user = db.Logins.Find(email);
            if(user != null && user.Password == password) return "Success";
            return "Error";
        }
    }
}