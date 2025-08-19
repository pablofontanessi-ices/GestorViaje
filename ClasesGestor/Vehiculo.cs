using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGestor
{
    public abstract class Vehiculo
    {
        // placa, kilometraje, viajes y métodos para agregar viajes y calcular distancia total.
        public string placa { get; set; }
        public int kilometraje { get; set; }
        
        public List<Viaje> listaViajes { get; set; }

        public void AgregarViaje(Viaje viajeAAgregar) {

            listaViajes.Add(viajeAAgregar);
        } 
    }
}
