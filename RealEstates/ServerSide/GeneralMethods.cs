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
            return @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Dev\Visual_Projects\Moti\Moti\App_Data\DB.mdf;Integrated Security=True;Connect Timeout=30";
        }
    }
}