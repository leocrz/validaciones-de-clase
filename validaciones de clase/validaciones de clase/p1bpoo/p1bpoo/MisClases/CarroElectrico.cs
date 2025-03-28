using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class CarroElectrico : Vehiculo
    {
        private int cargaBateria;
        public CarroElectrico(int anio, string elColor, string elModelo) : base (anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "C", "c" };
            cargaBateria = 50;
            velocidadMaxima = 130;//km/h
            CapacidadTanque = 0; //  No tiene tanque de combustible
            ConsumoCombustible = 0; //  No aplica para autos eléctricos


        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            cargaBateria = -2;
        }


        public int NivelBateria() { return cargaBateria; }
        public void cargarBateria()
        {
            cargaBateria++;
        }

        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);
            cargaBateria = cuanto;

        }

    }
}
