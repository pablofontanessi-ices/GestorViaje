using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGestor
{
    public class Camion : Vehiculo
    {
        public int capacidadAdicional { get; set; }
        public int cargaMaxima() 
        {
            int max = 0;
            //Devuelve la cantidad maxima de carga que tuvo en sus viajes.
            foreach (var viaje in listaViajes)
            {
                if (viaje.cargaTransportada > max)
                {
                    max = viaje.cargaTransportada;
                    
                }
            }
            
            return max; 
        
        }

        public Camion(int capacidadAdicional, string patente, int kilometraje)
        {
            this.capacidadAdicional = capacidadAdicional;
            this.kilometraje = kilometraje;
            this.placa = patente;
            listaViajes = new List<Viaje>();
        }

    }
}
