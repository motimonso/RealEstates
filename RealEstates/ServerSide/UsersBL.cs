using RealEstates.ServerSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstates.ServerSide
{
   
    public class UsersBL
    {
        private UsersDAL ud;
        public UsersBL()
        {
            ud = new UsersDAL();

        }

        public string GetUser(string uName, string uPassword)
        {
            string toReturn = ud.GetUser(uName, uPassword);
            if (toReturn == null)
                return null;
            return toReturn;
        }

        public bool isAdmin(string userName)
        {
            return ud.isAdmin(userName);
        }


    }
}