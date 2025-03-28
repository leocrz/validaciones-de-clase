using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Moto : Vehiculo
    {

        public Moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "M", "m" };
            velocidadMaxima = 120; // km/h
            CapacidadTanque = 5;
            ConsumoCombustible = 3;
           
        }
        public void Hacercaballito(int velocidad)
        {
            if (velocidad == 28)
            {
                Console.WriteLine("Haciendo Caballito");
            }
            else
            {
                Console.WriteLine("No se puede hacer caballito");
            }
        }



        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
        }
        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);
        }
        
    }
}
