//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProfitContenedor
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ordene
    {
        public Ordene()
        {
            this.Ord_reng = new HashSet<Ord_reng>();
        }
    
        public int fact_num { get; set; }
        public string empresa { get; set; }
        public string co_prov { get; set; }
        public string prov_des { get; set; }
        public System.DateTime fecha { get; set; }
        public string observ { get; set; }
        public int status { get; set; }
        public bool anulado { get; set; }
        public decimal total_net { get; set; }
        public System.Guid rowguid { get; set; }
        public byte[] validador { get; set; }
    
        public virtual ICollection<Ord_reng> Ord_reng { get; set; }
    }
}