using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cola
    {
        Nodo frente = null;
        Nodo final = null;
        public void Encolar(Musica p)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = p;

            if (frente == null)
            {
                frente = nuevo;
            }
            else
            {
                final.sig = nuevo;
            }
            final = nuevo;
        }
        public Musica Desencolar()
        {
            Musica aux = null;
            if (frente != null)
            {
                aux = frente.dato;
                frente = frente.sig;
            }
            return aux;
        }

        public void Destruir()
        {
            frente = null;
            final = null;
        }
        public void Mostrar()
        {
            Nodo temp = frente;
            while (temp != null)
            {
                Console.WriteLine(temp.dato);
                temp = temp.sig;
            }
        }
    }
}
