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
    
    public partial class Fact_imp_reng
    {
        public int fact_num { get; set; }
        public int reng_num { get; set; }
        public int doc_orig { get; set; }
        public decimal prec_orig { get; set; }
        public string co_art { get; set; }
        public string art_des { get; set; }
        public decimal precio { get; set; }
        public decimal total_art { get; set; }
        public Nullable<decimal> reng_neto { get; set; }
        public System.Guid rowguid { get; set; }
        public byte[] validador { get; set; }
    
        public virtual Fact_imp Fact_imp { get; set; }
    }
}
