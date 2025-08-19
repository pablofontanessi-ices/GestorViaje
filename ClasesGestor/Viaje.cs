using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGestor
{
    public class Viaje
    {
        //clase para registrar cada viaje, con propiedades distancia, cargaTransportada, y fecha.
        public int distancia { get; set; }
        public int cargaTransportada { get; set; }
        public DateTime fecha { get; set; }
    }
}
