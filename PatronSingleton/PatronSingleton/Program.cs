using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
    class Program
    {
        static void Main (string []args)
        {
            //No se puede obtener la instancia directamente

           

            //Obtenemos la instancia, se crea por primera vez

            Singleton uno = Singleton.ObtenerInstancia();

            //Realizamos algo con la instancia

            uno.IngresarDatos("Luis", 25);
            uno.OtroProceso();
            Console.WriteLine(uno);
            Console.WriteLine("--------------------------------------------");

            //Obtenemos la instancia
            Singleton dos=Singleton.ObtenerInstancia();


            //Comprobamos que es la misma instancia
            //Si lo es tendrá el mismo estado

            Console.WriteLine(dos);
        }
    }
}