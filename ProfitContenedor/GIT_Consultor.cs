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
    
    public partial class GIT_Consultor
    {
        public GIT_Consultor()
        {
            this.GIT_Mantenimiento = new HashSet<GIT_Mantenimiento>();
            this.GIT_Asign_Equipo = new HashSet<GIT_Asign_Equipo>();
        }
    
        public string co_consultor { get; set; }
        public string nombre { get; set; }
        public System.Guid Rowguid { get; set; }
    
        public virtual ICollection<GIT_Mantenimiento> GIT_Mantenimiento { get; set; }
        public virtual ICollection<GIT_Asign_Equipo> GIT_Asign_Equipo { get; set; }
    }
}
