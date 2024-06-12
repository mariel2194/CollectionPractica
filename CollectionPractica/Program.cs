using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione el # del Ejercicio (1-5) que quiere ver \n  ");
            int? opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n Ejercicio 1");
                    EjercicioI.Run();
                    break;
                case 2:
                    Console.WriteLine("\n Ejercicio 2");
                    EjercicioII.Run();
                    break;
                case 3: Console.WriteLine("\n Ejercicio 3");
                    EjercicioIII.Run();
                    break;
                case 4:
                    Console.WriteLine("\n Ejercicio 4");
                    EjercicioIV.Run();
                    break;
                case 5:
                    Console.WriteLine("\n Ejercicio 5");
                    EjercicioV.Run();
                    break;
            }


        }
    }
}
