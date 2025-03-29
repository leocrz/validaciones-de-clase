using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class AutodeCombustion : Vehiculo
    {
   
        private int cantidadCombustible;
       

        public AutodeCombustion(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "B", "b" };
          
            cantidadCombustible = 9;
            
            velocidadMaxima = 210; 
            ConsumoCombustible = 2; // kilometros por galon 
            CapacidadTanque = 15; //galones


        }

        public override void frenar(int cuanto)
        {
            base.frenar(cuanto); // Reutilizamos la lógica de la clase base
        }
        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto); //reutilizr la logica de la calse base 
        }

        

    }
}
