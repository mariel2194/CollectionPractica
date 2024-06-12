using System;
using System.Collections;
using System.Linq;
using static System.Collections.Specialized.BitVector32;

namespace CollectionPractica
{
    public class EjercicioI
    {
        static Queue<Estudiante> seccionI = new Queue<Estudiante>();
        static void RunEjercicioI(string[] args)
        {
            Console.WriteLine("A continuacion cree una seccion de estudiantes \n");
            seccionI = CrearSeccion();

            Console.WriteLine("¿Desea ver la lista de estudiantes \n (Digite S para ver o N para salir)");
            string? respuesta = Console.ReadLine();
            if (respuesta == "S")
            {
                ImprimirGrupo(seccionI);
                Console.WriteLine("¿Desea busca algun estudiante (\n Digite S para buscar o N para salir)");
                respuesta = Console.ReadLine();
                if (respuesta == "S")
                {
                    Console.WriteLine("Ingrese la matricula para buscar el estudiante");
                    string? matriculaFilter = Console.ReadLine();
                    BuscarPorMatricula(seccionI, matriculaFilter);
                }
            }                  

        }
        public static Queue<Estudiante> CrearSeccion()
        {
            Console.WriteLine("Ingrese la cantidad de estudiantes a enlistar\n");
            int? nEstudiantes = int.Parse(Console.ReadLine());
            for (int i = 0; i < nEstudiantes; i++)
            {
                Console.WriteLine("\nIngrese el Nombre del estudiante");
                string? nombre = Console.ReadLine();
                Console.WriteLine("\n Ingrese la Matricula");
                string? matricula = Console.ReadLine();

                Estudiante estudiante = new Estudiante(nombre, matricula);
                seccionI.Enqueue(estudiante);
                Console.WriteLine("\nEstudiante Agregado\n");
            }
            return seccionI;
        }

        public static void ImprimirGrupo(Queue<Estudiante> seccion)
        {
            int n = 0;
            foreach (var estudiante in seccion)
            {
                Console.WriteLine( (n+=1) + "." + estudiante.getNombre() + " " + estudiante.getMatricula()+ "\n");
            }
        }

        public static void BuscarPorMatricula(Queue<Estudiante> seccion, string matricula)
        {
            foreach (var estudiante in seccion)
            {
                if (matricula == estudiante.getMatricula())
                {
                    Console.WriteLine("Esta matricula pertence a:" + estudiante.getNombre() + "\n");
                }                
              
            }

        }
    }
}