using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public  class Vehiculo 
    {
        public string Color { get; set; }
        public string Modelo { get;  }
        public int Year { get;  }

        private int velocidad = 0;

        //ATributos nuevos 

        protected List<string> tiposLicenciaAceptados = new List<string> { "A", "B", "C" };

        private Chofer piloto = null;
        private int estadoVehiculo = 0; // 0 = apagado, 1 = encendido, 2 = en movimiento
        protected int velocidadMaxima = 100;
        protected int CapacidadTanque;
        protected int ConsumoCombustible;
    
        public string AsignarPiloto(Chofer elPiloto)
        {
            if (elPiloto == null)
            {
                return "No se puede asignar un piloto nulo";
            }
            if (!tiposLicenciaAceptados.Contains(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene la licencia adecuada para este Vehiculo";
            }
            if (piloto != null)
            {
                return "Ya tiene un Piloto Asignado";
            }
            piloto = elPiloto;
            return "Piloto asignado correctamente";
        }
        public string Encender()
        {
            if (piloto == null)
                return "No puedes encender el vehiculo sin un piloto";
            if (estadoVehiculo == 1)
            {
                return "El vehiculo ya esta encendido";
            }
            else
            {
                return "El vehiculo esta encendido";
            }
        }
        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Año: " + Year);
            Console.WriteLine("Velocidad Actual: " + velocidad + " KMS / Hora");
            Console.WriteLine("Velocidad Máxima: " + velocidadMaxima + " KMS / Hora");
            if (estadoVehiculo == 0)
                Console.WriteLine("Estado del Vehículo: Apagado");
            else if (velocidad > 0)
                Console.WriteLine("Estado del Vehículo: En Movimiento");
            else
                Console.WriteLine("Estado del Vehículo: Encendido");
            if (piloto != null)
                Console.WriteLine("Piloto Asignado: " + piloto.Nombre);
            else
                Console.WriteLine("Piloto Asignado: No hay piloto asignado");
        }
        public virtual void acelerar(int cuanto)
        {if (estadoVehiculo == 0)
            {
                Console.WriteLine("El vehiculo esta apagado");
                return;
            }
            velocidad += cuanto;
            Console.WriteLine("vas a {0} KMS / Hora",velocidad);
            if (velocidad > velocidadMaxima )
            {
                Console.WriteLine("No se puede superar la velocidad máxima de {0} KMS / Hora", velocidadMaxima);

            }
        }
        public virtual void frenar(int cuanto) 
        {
            velocidad -= cuanto;
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);

            if (velocidad == 0)
            {
                Console.WriteLine("Vehiculo encendido");
                estadoVehiculo = 1;
            }
        }

        public virtual void apagar()
        {
            if (velocidad == 0)
            {
                Console.WriteLine("El vehículo ya está apagado.");
                return;
            }
            Console.WriteLine("El vehículo no se puede apagar en movimiento.");
        }


    }
}

