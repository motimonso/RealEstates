using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstates
{
    public class Client
    {
        private string id;
        private string fName;
        private string lName;
        private string p1, p2, p3;

        public Client(string id,string fName,string lName,string p1,string p2,string p3)
        {
            this.id = id;
            this.fName = fName;
            this.lName = lName;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;

        }
        public string Id
        {
            get
            {
                return id;
            }
        }
        public string FName
        {
            get
            {
                return fName;
            }
        }
        public string LName
        {
            get
            {
                return lName;
            }
        }
        public string P1
        {
            get
            {
                return p1;
            }
        }
        public string P2
        {
            get
            {
                return p2;
            }
        }
        public string P3
        {
            get
            {
                return p3;
            }
        }
    }
}