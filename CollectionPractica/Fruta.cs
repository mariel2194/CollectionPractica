using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractica
{
    public class Fruta
    {
        private string nombre;
        public Fruta(string nombre) {
        this.nombre = nombre;
        }

        public string getNombre() { return nombre; }
    }
}
