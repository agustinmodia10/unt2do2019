using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;
namespace PracticaDeVehiculos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("auto", 4, EMarca.Fiat,5);
            Moto moto = new Moto("moto", 2, EMarca.Zanella, 500);
            Camion camion = new Camion("camion", 10, EMarca.Scania, 123);
            Auto auto1 = new Auto("auto1", 4, EMarca.Ford, 5);
            Moto moto1 = new Moto("moto1", 2, EMarca.Honda, 500);
            Camion camion1 = new Camion("camion1", 10, EMarca.Renault, 123);

            #region TEST PTOPIEDADES Y METODOS ABSTRACTOS

            Console.WriteLine(" \n\r PROPIEDAD ABSTRACTA DE PRECIO \n\r");

            Console.WriteLine(moto.precio.ToString());
            Console.WriteLine(auto.precio.ToString());
            Console.WriteLine(camion.precio.ToString());

            Console.WriteLine(" \n\r METODO ABSTRACTO PRECIO CON IVA \n\r");

            double auxpimoto = moto.CalcularPrcioConIVA();
            double auxpiauto = auto.CalcularPrcioConIVA();
            double auxpicamion = camion.CalcularPrcioConIVA();

            Console.WriteLine( auxpimoto + "\n" + auxpiauto + "\n" + auxpicamion);


            Console.WriteLine(" \n\r FIN TEST ABSTRACTO \n\r");
            Console.ReadKey();

            #endregion

            #region USO LA CLASE LAVADERO

            Lavadero lava = new Lavadero(200, 300, 100);

            lava += auto;
            lava += moto;
            lava += camion;
            lava += auto1;
            lava += moto1;
            lava += camion1;
            

            Console.WriteLine(lava);

            Console.WriteLine(" \n \r ELIMINO CAMION \n\r");
            lava -= camion;
            Console.WriteLine(lava);

            Console.WriteLine(" \n\r FIN DE LISTA LAVADERO \n\r");
            Console.ReadKey();


            //prueba de sobrecarga ToString()
            string auxauto = auto.ToString();
            Console.WriteLine(" \n\r AUTO \n\r" + auxauto);
            Console.ReadKey();

            List<Vehiculo> lv = new List<Vehiculo>();
            lv.Add(auto);
            lv.Add(moto);
            lv.Add(camion);

            foreach (Vehiculo item in lv)
            {

                Console.WriteLine("PATENTE - MARCA - CANT.RUEDAS  - INFO");
                Console.WriteLine(item);
            }

            Console.WriteLine(" \n\r FIN DE LISTA \n\r");
            Console.ReadKey();

            #endregion

            #region MUESTRO OBJECTOS DE CLASE NORMAL

            Console.WriteLine("PATENTE - MARCA - CANT.RUEDAS - ASIENTOS");
            Console.WriteLine(auto);
            Console.WriteLine("PATENTE - MARCA - CANT.RUEDAS - TARA");
            Console.WriteLine(camion);
            Console.WriteLine("PATENTE - MARCA - CANT.RUEDAS - CILINDROS");
            Console.WriteLine(moto);
            Console.ReadKey();

            #endregion
        }
    }
}
