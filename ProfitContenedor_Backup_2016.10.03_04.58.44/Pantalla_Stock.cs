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
    
    public partial class Pantalla_Stock
    {
        public string co_usuario { get; set; }
        public string Emp_Art { get; set; }
        public string Almacen { get; set; }
        public byte[] validador { get; set; }
        public System.Guid rowguid { get; set; }
    
        public virtual Empresa Empresa { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}