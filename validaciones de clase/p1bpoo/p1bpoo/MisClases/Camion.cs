using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Camion : Vehiculo
    {
            private int horasUsoMotor;
            private int cargaActual;
            private int desgastesdefrenos;
            


        public Camion(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
            {
            tiposLicenciaAceptados = new List<string> { "A" , "a" };
            horasUsoMotor = 0;
            cargaActual = 0;
            desgastesdefrenos = 0;
            velocidadMaxima = 190; 
            CapacidadTanque = 280; 
            ConsumoCombustible = 15; 


        }
        public void registrarHorasMotor(int horas)
            {
                if (horas > 0)
                {
                    horasUsoMotor += horas;
                    Console.WriteLine("La cantidad de horas de uso del motor es {0}", horas);
                }
                else
                {
                    Console.WriteLine("No se puede registrar una cantidad negativa de horas ");
                }
            }

            public void cargar(int cuanto)
            {
                if (cuanto > 0)
                {

                    cargaActual += cuanto;
                    Console.WriteLine("la cantidad de la carga es {0}", cargaActual);
                }
                else
                {
                    Console.WriteLine("No se puede cargar una cantidad negativa ");
                }
            }

        
    }
}
