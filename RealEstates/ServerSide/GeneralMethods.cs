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
            return @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Dev\Visual_Projects\RealEstates\RealEstates\App_Data\DB.mdf;Integrated Security=True;Connect Timeout=30";
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