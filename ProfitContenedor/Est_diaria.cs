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
    
    public partial class Est_diaria
    {
        public System.DateTime fecha { get; set; }
        public int id_meta { get; set; }
        public string grupo { get; set; }
        public Nullable<decimal> porc { get; set; }
        public System.Guid rowguid { get; set; }
        public int id_num { get; set; }
        public decimal tasa_aju { get; set; }
        public decimal diaria_aju { get; set; }
    
        public virtual Metas_Vtas Metas_Vtas { get; set; }
    }
}
