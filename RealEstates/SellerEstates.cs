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
    
    public partial class SellerEstates
    {
        public SellerEstates()
        {
            this.Matches = new HashSet<Matches>();
        }
    
        public string estateId { get; set; }
        public string sellerId { get; set; }
        public string estateType { get; set; }
        public string price { get; set; }
        public string city { get; set; }
        public string neighborhood { get; set; }
        public string street { get; set; }
        public string number { get; set; }
        public string rooms { get; set; }
        public string area { get; set; }
        public string floor { get; set; }
        public string stairs { get; set; }
        public string elevator { get; set; }
        public string balcony { get; set; }
        public string toilets { get; set; }
        public string bath { get; set; }
        public string storage { get; set; }
        public string park { get; set; }
        public string garden { get; set; }
        public string renovation { get; set; }
        public string boiler { get; set; }
        public string bars { get; set; }
        public string pladelet { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual ICollection<Matches> Matches { get; set; }
    }
}
