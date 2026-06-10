using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Nodo
    {
        public Musica dato;
        public Usuario datoUsuario;
        public Nodo sig = null;
        public Nodo ant = null;

        public Nodo derecha=null;
        public Nodo izquierda = null;
    }
}
