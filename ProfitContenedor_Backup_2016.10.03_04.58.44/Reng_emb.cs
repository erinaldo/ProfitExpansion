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
    
    public partial class Reng_emb
    {
        public int nro_viaje { get; set; }
        public string empresa { get; set; }
        public int fact_num { get; set; }
        public string co_art { get; set; }
        public string art_des { get; set; }
        public decimal total_art { get; set; }
        public System.Guid rowguid { get; set; }
        public decimal prec_vta { get; set; }
        public decimal tasa { get; set; }
    
        public virtual Embarque Embarque { get; set; }
    }
}
