using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.Interfaces;

namespace p1bpoo.MisClases
{
    public class Chofer : IPiloto
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string TipoLicencia { get; set; }

        public Chofer(string name, int LaEdad, string Licencia)
        {
            if (!EsEdadAdecuada(LaEdad, Licencia)) // Verificación en el constructor
            {
                throw new Exception("La edad no es adecuada para la Licencia seleccionada");
            }
            Nombre = name;
            Edad = LaEdad;
            TipoLicencia = Licencia;
        }

        private bool EsEdadAdecuada(int edad, string Licencia)
        {
            if ((Licencia == "A" || Licencia == "a") && edad >= 23)
            {
                return true;
            }
            if ((Licencia == "B" || Licencia == "b") && edad >= 21)
            {
                return true;
            }
            if ((Licencia == "C" || Licencia == "c") && edad >= 18)
            {
                return true;
            }
            if ((Licencia == "M" || Licencia == "m") && edad >= 18)
            {
                return true;
            }
            return false; // En caso de que no se cumpla ninguna condición
        }

        public void mostrarInformacion()
        {
            Console.WriteLine($"El piloto es: {Nombre}");
            Console.WriteLine($"La edad es: {Edad}");
            Console.WriteLine($"La licencia es: {TipoLicencia}");
        }

        // Método para cambiar la licencia con validación
        public void CambiarLicencia(string nuevaLicencia)
        {
            if (!EsEdadAdecuada(Edad, nuevaLicencia))
            {
                throw new Exception("La edad no es adecuada para la Licencia seleccionada");
            }
            TipoLicencia = nuevaLicencia;
        }
    }
}


