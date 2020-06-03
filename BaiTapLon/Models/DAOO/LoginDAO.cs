using BaiTapLon.Models.Entities;
using BaiTapLon.Models.Entity;
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

        public string createUser(creatUser user)
        {
            try
            {
                Login login = new Login();
                login.FirstName = user.FirstName;
                login.LastName = user.LastName;
                login.Sex = user.Sex;
                login.Email = user.Email;
                login.Password = user.Password;
                db.Logins.Add(login);
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