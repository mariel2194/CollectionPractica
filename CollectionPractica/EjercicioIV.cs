using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractica
{
    /*
     * #4.- Realice un programa que reciba varios nombres y se 
     * detenga cuando el usuario introduzca Domingo en minúscula 
     * (como usuario no valido) 
     * y tambien se detenga cuando  el usuario introduzca un nombre que inicie con (J)
     
     */
    public class EjercicioIV
    {
        public static List<string> listaNombres = new List<string>();

        public static void Run()
        {
            string opcion = "";
            Console.WriteLine("¿Desea agregar un nombre a la lsita?: \n Digite S para continuar o N para Salir");
            opcion = Console.ReadLine();
            while (opcion == "S")
            {
                Console.WriteLine("A continuacion ingrese un nombre: \n");
                string nombre = Console.ReadLine();
                listaNombres.Add(nombre);
                foreach (var item in listaNombres)
                {
                    if (item.Equals("domingo") || item.StartsWith("J"))
                    {
                        Console.WriteLine(item);
                        opcion = "N";
                        break;
                    }
                }

            }

        }
    }


}
