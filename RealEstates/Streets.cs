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
    
    public partial class Streets
    {
        public int StreetID { get; set; }
        public Nullable<int> HoodID { get; set; }
        public string StreetName { get; set; }
    
        public virtual Neighborhood Neighborhood { get; set; }
    }
}