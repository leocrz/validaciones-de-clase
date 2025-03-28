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
        private int nivelAceite;

        public AutodeCombustion(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "B", "b" };
          
            cantidadCombustible = 9;//esta es la cantidad que tiene el auto de combustion 
            nivelAceite = 100; 
            velocidadMaxima = 100; // km/h
            ConsumoCombustible = 2; // En kilometros por galon 
            CapacidadTanque = 18; //galones 


        }

        public override void frenar(int cuanto)
        {
            base.frenar(cuanto); // Reutilizamos la lógica de la clase base
        }
        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto); //reutilizr la logica de la calse base 
        }

        public int CalcularAutonomia()
        {
            int autonomia = cantidadCombustible * ConsumoCombustible; // Kilómetros
            Console.WriteLine("Autonomía actual es: {0} km", autonomia);
            return autonomia;
        }
        public void RevisarAceite()
        {
            Console.WriteLine("El nivel de aceite actual es: {0}" , nivelAceite);
        }

    }
}
