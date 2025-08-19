using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGestor
{
    public class Furgoneta : Vehiculo
    {
        public int capacidadAdicional { get; set; }
        public Furgoneta(int capacidadAdicional, string patente, int kilometraje)
        {
            this.capacidadAdicional = capacidadAdicional;
            this.kilometraje = kilometraje;
            this.placa = patente;
            listaViajes = new List<Viaje>();
        }
        
    }
}
