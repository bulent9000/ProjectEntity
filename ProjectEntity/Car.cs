//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        public int carNum { get; set; }
        public Nullable<decimal> carPrice { get; set; }
        public string plate { get; set; }
        public string brand { get; set; }
        public Nullable<int> model { get; set; }
        public Nullable<int> year { get; set; }
        public string engine { get; set; }
        public string package { get; set; }
        public string color { get; set; }
        public string gear { get; set; }
        public int branchNum { get; set; }
        public int customerId { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Customer Customer { get; set; }
    }
}