using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstates.ServerSide
{
    public class GeneralMethods
    {
        public static string generateID()
        {
            DateTime d = DateTime.Now;
            return d.Year.ToString() + d.Month.ToString() + d.Day.ToString() + d.Hour.ToString()
                + d.Minute.ToString() + d.Second.ToString() + d.Millisecond.ToString();
        }
        public static string getSqlString()
        {
            return "server=e853c44f-0777-4bbf-b145-a47a011c7bba.mysql.sequelizer.com;database=dbe853c44f07774bbfb145a47a011c7bba;uid=dnmvszthwcynrvus;pwd=StPjQNyQy2VejHVHsjsuXBC4kqw7LjK2YNRXgrUAhWzYgRgttxmEFA3qYU8zrzdo";
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