using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitContenedor
{
    class RenglonesDG
    {
        public Int32 codigo { get; set; } = 0;
        public string empleado { get; set; } = "";
        public string empresa { get; set; } = "";
        public string activo { get; set; } = "";
        public DateTime desde { get; set; } = new DateTime(DateTime.Now.Ticks);
        public DateTime hasta { get; set; } = new DateTime(DateTime.Now.Ticks);
        public string consultor { get; set; } = "";
        public string Rowguid { get; set; } = "";
    }
}
