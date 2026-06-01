using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ListaCircular
    {
        public Nodo primero = null;
        public Nodo ultimo = null;
        public void IngresarFinal(Musica m)
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
            ultimo.sig = primero;
            primero.ant = ultimo;
        }
        public void IngresarInicio(Musica m)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = m;

            if (primero == null)
            {
                primero = nuevo;
                nuevo.sig = primero;
                nuevo.ant = primero;
            }
            else
            {
                Nodo ultimo = primero.ant;
                ultimo.sig = nuevo;
                nuevo.ant = ultimo;
                nuevo.sig = primero;
                primero.ant = nuevo;
                primero = nuevo;
            }
        }
        public void Mostrar()
        {
            if (primero == null) return;
            Nodo temp = primero;
            do
            {
                Console.WriteLine(temp.dato);
                temp = temp.sig;
            }
            while (temp != primero);
        }
        public void BuscarArtista(string artista)
        {
            if (primero == null) return;
            Nodo temp = primero;
            do
            {
                if (temp.dato.Artista.ToLower() == artista.ToLower())
                { 
                    Console.WriteLine("Encontrado: " + temp.dato); 
                }
                temp = temp.sig;
            }
            while (temp != primero);
        }

    }
}
