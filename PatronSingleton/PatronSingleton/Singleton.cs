using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
     class Singleton
    {
        //Guardamos la unica instancia que va  a existir

        private static Singleton instancia;


        //Datos de la clase.

        private string Nombre;
        private int Edad;

        //Creamos el constructor privado
        private Singleton()
        {

            Nombre = "Sin asignar";
            Edad = 99;


        }

        public static Singleton ObtenerInstancia()

        {
            //Verificamos si no existe la instancia

            if (instancia == null)
            {
                // Si no existe instanciamos

                instancia = new Singleton();

                Console.WriteLine("------Instancia  creada por primera vez------");
            }

            //Regresamos la instancia
            return instancia;
        }


        //Metodos de la clase

        public override string ToString()
        {
            return string.Format("El estudiante {0}, tiene edad de {1} años" ,Nombre, Edad);
        }

        public void IngresarDatos(string pNombre, int pEdad)
        {

            Nombre = pNombre;
            Edad = pEdad;
        }

        // Esta parte representa cualquier otro objeto

        public void OtroProceso()
        {
            Console.WriteLine("{0} esta trabajando en un proyecto de Poo", Nombre);
        }



    }
}
