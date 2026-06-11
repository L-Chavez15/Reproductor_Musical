using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pila
    {
        public Nodo cima = null;

        public void Apilar(Musica m)
        {
            Nodo nuevo = new Nodo();
            nuevo.fecha = DateTime.Now;
            nuevo.dato = m;
            nuevo.sig = cima;
            cima = nuevo;
        }
        public Musica Desapilar()
        {
            Musica dato = null;
            if (cima != null)
            {
                dato = cima.dato;
                cima = cima.sig;
            }
            return dato;
        }
        public void mostrar()
        {
            Nodo temp = cima;
            while (temp != null)
            {
                Console.WriteLine(temp.dato);
                temp = temp.sig;
            }
        }
    }
}
