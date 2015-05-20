using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstates
{
    public class GeneralMethods
    {
        public static string generateID()
        {
            DateTime d = DateTime.Now;
            return d.Year.ToString() + d.Month.ToString() + d.Day.ToString() + d.Hour.ToString()
                + d.Minute.ToString() + d.Second.ToString() + d.Millisecond.ToString();
        }
        
        public static string getMySqlString()
        {
            MySqlConnectionStringBuilder csb = new MySqlConnectionStringBuilder();
            csb.Server = "e853c44f-0777-4bbf-b145-a47a011c7bba.mysql.sequelizer.com";
            csb.UserID = "dnmvszthwcynrvus";
            csb.Password = "StPjQNyQy2VejHVHsjsuXBC4kqw7LjK2YNRXgrUAhWzYgRgttxmEFA3qYU8zrzdo";
            csb.Database = "dbe853c44f07774bbfb145a47a011c7bba";
            csb.PersistSecurityInfo = true;
            return csb.ToString();
        }
        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
        public static bool IsDigitsOnlyAddress(string str)
        {
            foreach (char c in str)
            {
                if ((c < '0' || c > '9') && !c.Equals('/'))
                    return false;
            }

            return true;
        }
    }
}