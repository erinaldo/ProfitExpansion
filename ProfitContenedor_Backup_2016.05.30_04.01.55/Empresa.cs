//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProfitContenedor
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empresa
    {
        public Empresa()
        {
            this.Embarques = new HashSet<Embarque>();
            this.Pantalla_Stock = new HashSet<Pantalla_Stock>();
            this.Usu_Emp = new HashSet<Usu_Emp>();
        }
    
        public string co_empresa { get; set; }
        public string des_emp { get; set; }
        public byte[] validador { get; set; }
        public string email { get; set; }
        public byte[] clave { get; set; }
        public string servidor { get; set; }
        public int puerto { get; set; }
        public int ssl { get; set; }
        public decimal mont_segu { get; set; }
        public string almacen { get; set; }
        public System.Guid rowguid { get; set; }
        public string co_tran { get; set; }
        public string forma_pag { get; set; }
        public string moneda { get; set; }
        public string co_sucu { get; set; }
        public string nomina { get; set; }
        public string contab { get; set; }
        public string proceden { get; set; }
    
        public virtual ICollection<Embarque> Embarques { get; set; }
        public virtual ICollection<Pantalla_Stock> Pantalla_Stock { get; set; }
        public virtual ICollection<Usu_Emp> Usu_Emp { get; set; }
    }
}
