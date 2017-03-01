using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitContenedor
{
    class RenglonesDG3
    {
        public int id_movimiento { get; set; } = 0;
        public string autoriza { get; set; } = "";

        public string date { get; set; } = "";      //=new DateTime(DateTime.Now.Ticks);
        public string activo { get; set; } = "";

        public string  desde { get; set; } = ""; //= new DateTime(DateTime.Now.Ticks);

        public string  hasta { get; set; } = ""; //= new DateTime(DateTime.Now.Ticks);

        public string  confirmar_salida { get; set; } = ""; //= new DateTime(DateTime.Now.Ticks);

        public string confirmar_entrada { get; set; } = ""; //= new DateTime (DateTime.Now.Ticks);

        public SByte  status { get; set; } = 0;

    }
}
