//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealEstates
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuyerEstates
    {
        public BuyerEstates()
        {
            this.Matches = new HashSet<Matches>();
        }
    
        public string EstateID { get; set; }
        public string clientId { get; set; }
        public string estateType { get; set; }
        public string city { get; set; }
        public string neighborhood { get; set; }
        public string roomsFrom { get; set; }
        public string roomsTo { get; set; }
        public string areaFrom { get; set; }
        public string areaTo { get; set; }
        public string floorFrom { get; set; }
        public string floorTo { get; set; }
        public string garden { get; set; }
        public string priceFrom { get; set; }
        public string priceTo { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual ICollection<Matches> Matches { get; set; }
    }
}
