using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitContenedor
{
    class Entrega
    {
        public int Fact_num
        {
            get;
            set;
        }
        public DateTime Fec_emis
        {
            get;
            set;
        }
        public int Reng_num
        {
            get;
            set;
        }
        public string Co_art
        {
            get;
            set;
        }
        public string Art_des
        {
            get;
            set;
        }
        public decimal Total_art
        {
            get;
            set;
        }
        public string Ubicacion
        {
            get;
            set;
        }
        public string Cli_des
        {
            get;
            set;
        }
        public string Zon_des
        {
            get;
            set;
        }

        public decimal Entregado
        {
            get;
            set;
        }
        public decimal Recibido
        {
            get;
            set;
        }
        public DateTime Fecha
        {
            get;
            set;
        }
    }
}
