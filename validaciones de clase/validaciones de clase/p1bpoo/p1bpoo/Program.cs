
using p1bpoo.MisClases;

//Vehiculo miCarrito = new Vehiculo(2026,"Azul","Alfa Romeo");

//Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

//CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

//miBYD.InformacionVehiculo();
//miBYD.cargarBateria();
//Console.WriteLine("El nivel de bateria es: {0}",miBYD.NivelBateria());
Chofer piloto1 = new Chofer("patricia", 28, "A");
Chofer piloto2 = new Chofer("Karen", 24, "M");

piloto1.mostrarInformacion();
piloto2.mostrarInformacion();

Vehiculo sedan = new Vehiculo(2025, "Rojo", "Honda");

string respuesta;
respuesta = sedan.AsignarPiloto(piloto1);
Console.WriteLine(respuesta);
respuesta = sedan.Encender();
Console.WriteLine(respuesta);

Console.WriteLine("\n");
Chofer chofer = new Chofer("Portillo", 25, "B");
chofer.mostrarInformacion();
chofer.CambiarLicencia("A");
chofer.mostrarInformacion();




sedan.acelerar(25);
Moto honda = new Moto(2025, "negro", "Kawasaki");


