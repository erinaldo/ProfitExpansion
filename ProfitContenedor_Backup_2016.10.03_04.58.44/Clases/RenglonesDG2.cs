using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitContenedor
{
    class RenglonesDG2
    {
        public Int32 codigoM { get; set; } = 0;
        public string idactivo { get; set; } = "";
        public DateTime fec_emis { get; set; } = new DateTime(DateTime.Now.Ticks);
        public string observacion  { get; set; } = "";
        public string valor { get; set; } = "";
        public string asesor { get; set; } = "";
        public string consultor { get; set; } = "";
        public string problema { get; set; } = "";
        public string solucion { get; set; } = "";
        public string Rowguid { get; set; } = "";


    }
}
