using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractica
{
    /*#3 Realice un programa que imprima de forma descendente los números del 100 - 1 en el siguiente formato:
        100 - 99
        98 - 97*/
    public class EjercicioIII
    {
        public static List<int> listaNumeros = new List<int>();

        public static void Run() {

            Console.WriteLine("A continuacion mostrando los numeros del 1 al 100 en forma descentente: \n");
            listaNumeros = CrearListaNumeros();
            for (int i = 0; i < 50; i++)
            {
                listaNumeros.Sort();
                listaNumeros.Reverse();
                Console.WriteLine(listaNumeros[i] + "-" + listaNumeros[i +1]);
                listaNumeros.RemoveAt(i+1);

         }
        }
        public static List<int> CrearListaNumeros() {
            int n = 0;
            while (n <= 99)
            {
                n++;
                listaNumeros.Add(n);
            }   
            return listaNumeros;        
        }

    }
}
