using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractica
{
    /*
    #5.- Realice un programa que guarde los nombres y los apellidos de 
    una persona en dos colecciones distintas y  lo imprima junto. 
     */
    public class EjercicioV
    {
        public static List<string> listaNombres = new List<string>();
        public static List<string> listaApellidos = new List<string>();


        public static void Run()
        {
            string opcion = "";
            Console.WriteLine("Iniciar Ejercicio V: \n Digite S para continuar o N para Salir");
            opcion = Console.ReadLine();
            while (opcion == "S")
            {
                Console.WriteLine("Ingrese un nombre: \n");
                string? nombre = Console.ReadLine();
                listaNombres.Add(nombre);
                Console.WriteLine("Ingrese el apellido: \n");
                string? apellido = Console.ReadLine();
                listaApellidos.Add(apellido);

                var tuple = listaNombres.Zip(listaApellidos);
                foreach ( var item in tuple )
                {
                    Console.WriteLine("El nombre de la persona ingresada es: " + item.First + " "+ item.Second);
                }

                Console.WriteLine("¿Desea continuar?: \n Digite S para continuar o N para Salir");
                opcion = Console.ReadLine();

            }

        }
    }


}
