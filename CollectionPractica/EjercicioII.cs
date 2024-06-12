using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

/*Realice un programa que almacene en forma de pila un conjunto de frutas e imprima 
 * la fruta diferente a la primera en entrar y la ultima al ingresar.*/

namespace CollectionPractica
{

    public static class EjercicioII
    {
        static Stack<Fruta> frutasPila = new Stack<Fruta>();
        public static void Run()
        {
            Console.WriteLine("A continuacion agregue frutas \n");
            frutasPila = AgregarFruta();
            Console.WriteLine("¿Desea ver la lista de frutas \n (Digite S para ver o N para salir)");
            string? respuesta = Console.ReadLine();
            if (respuesta == "S")
            {
                ImprimirTodasFrutas(frutasPila);
            }
            Console.WriteLine("¿Desea ver la pila de frutas diferente a la primera en entrar y la ultima al ingresar \n (Digite S para ver o N para salir)");
            respuesta = Console.ReadLine();
            if (respuesta == "S")
            {
                ImprimirPilaFrutas(frutasPila);
            }
        }

        public static Stack<Fruta> AgregarFruta()
        {
            Console.WriteLine("\nIngrese la cantidad de frutas a agregar");
            int? nFrutas = int.Parse(Console.ReadLine());
            for (int i = 0; i < nFrutas; i++)
            {
                Console.WriteLine("\nIngrese el nombre de la fruta");
                Fruta fruta = new Fruta(Console.ReadLine());
                frutasPila.Push(fruta);
                Console.WriteLine("\n Fruta Agregada\n");
            }
            return frutasPila;
        }
        public static void ImprimirTodasFrutas(Stack<Fruta> frutas)
        {
            int n = 0;
            foreach (var fruta in frutas)
            {
                Console.WriteLine((n += 1) + "." + fruta.getNombre() + "\n");
            }
        }
        public static void ImprimirPilaFrutas(Stack<Fruta> frutas)
        {
            string primeraFruta = frutasPila.Peek().getNombre();
            string frutaDiferentePrimera = null;
            foreach (Fruta fruta in frutasPila)
            {
                if (fruta.getNombre() != primeraFruta)
                {
                    frutaDiferentePrimera = fruta.getNombre();
                    break;
                }
            }

            Console.WriteLine("\nFruta diferente a la primera en entrar: " + frutaDiferentePrimera);

            // Mostrar la última fruta ingresada
            string ultimaFrutaIngresada = frutasPila.Peek().getNombre();
            Console.WriteLine("\nÚltima fruta ingresada: " + ultimaFrutaIngresada);
        }


    } 
}
