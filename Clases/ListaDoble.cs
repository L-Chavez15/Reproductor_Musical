using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ListaDoble
    {
        public Nodo primero = null;
        public Nodo ultimo = null;

        public void Ingresar(Musica m)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = m;

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.sig = nuevo;
                nuevo.ant = ultimo;
                ultimo = nuevo;
            }
        }
        public void MostrarPU()
        {
            Nodo temporal = primero;
            while (temporal != null)
            {
                Console.WriteLine(temporal.dato);
                temporal = temporal.sig;
            }
        }
        public void MostrarUP()
        {
            Nodo temporal = ultimo;
            while (temporal != null)
            {
                Console.WriteLine(temporal.dato);
                temporal = temporal.ant;
            }
        }
        public void Buscar(string bus)
        {
            Nodo temp = primero;
            while (temp != null)
            {
                if (temp.dato.Nombre == bus)
                {
                    Console.WriteLine(temp.dato);
                    return;
                }
                temp = temp.sig;
            }
            Console.WriteLine("Persona no encontrada");
        }
        public void Eliminar(string bus)
        {
            Nodo temp = primero;
            while (temp != null)
            {
                if (temp.dato.Nombre == bus)
                {
                    if (temp == primero)
                    {
                        primero = temp.sig;
                        primero.ant = null;
                    }
                    else if (temp == ultimo)
                    {
                        ultimo = ultimo.ant;
                        ultimo.sig = null;
                    }
                    else
                    {
                        temp.ant.sig = temp.sig;
                        temp.sig.ant = temp.ant;
                    }
                    return;
                }
                temp = temp.sig;
            }
            Console.WriteLine("Persona no encontrada");
        }
    }
}
