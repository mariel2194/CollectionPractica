using System.Runtime.CompilerServices;

namespace CollectionPractica
{
    public class Estudiante
    {
        private string nombre;
        private string matricula;

        public Estudiante(string nombre, string matricula)
        {
            this.nombre = nombre;
            this.matricula = matricula;

        }

        public string getMatricula() { return matricula; }
        public string getNombre() { return nombre; }
        public void setNombre(string newName) 
        {
            nombre = newName;
        }
        public void setMatricula(string newMatricula)
        {
            matricula = newMatricula;
        }
       


    }
}
