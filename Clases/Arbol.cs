using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public class Arbol
    {
        public Nodo raizPrinciola = null;

        public void Insertar(ref Nodo raiz, Musica m)
        {
            if (raiz == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.dato = m;
                raiz = nuevo;
            }
            else
            {
                if (string.Compare(m.Nombre, raiz.dato.Nombre) < 0)
                {
                    Insertar(ref raiz.izquierda, m);
                }
                else
                {
                    Insertar(ref raiz.derecha, m);
                }
            }
        }
        public void Buscar(Nodo raiz, Musica m)
        {
            if (raiz == null)
            {
                Console.WriteLine("DATO NO ENCONTRADO");
            }
            else
            {
                if (string.Compare(m.Nombre, raiz.dato.Nombre) < 0)
                {
                    Buscar(raiz.izquierda, m);
                }
                else if (string.Compare(m.Nombre, raiz.dato.Nombre) > 0)
                {
                    Buscar(raiz.derecha, m);
                }
                else
                {
                    MessageBox.Show("DATO ENCONTRADO");
                    MessageBox.Show("Nombre: " + raiz.dato.Nombre);
                    MessageBox.Show("Artista: " + raiz.dato.Artista);
                    MessageBox.Show("Género: " + raiz.dato.genero);
                }
            }
        }
        public void Eliminar(ref Nodo raiz, string nombre)
        {
            if (raiz == null)
            {
                Console.WriteLine("DATO NO ENCONTRADO");
                return;
            }

            if (nombre.CompareTo(raiz.dato.Nombre) < 0)
            {
                Eliminar(ref raiz.izquierda, nombre);
            }
            else if (nombre.CompareTo(raiz.dato.Nombre) > 0)
            {
                Eliminar(ref raiz.derecha, nombre);
            }
            else
            {
                // Caso 1: Nodo hoja
                if (raiz.izquierda == null && raiz.derecha == null)
                {
                    raiz = null;
                }

                // Caso 2: Solo hijo derecho
                else if (raiz.izquierda == null)
                {
                    raiz = raiz.derecha ;
                }

                // Caso 3: Solo hijo izquierdo
                else if (raiz.derecha == null)
                {
                    raiz = raiz.izquierda;
                }

                // Caso 4: Dos hijos
                else
                {
                    Nodo aux = raiz.izquierda;

                    while (aux.derecha != null)
                    {
                        aux = aux.derecha;
                    }

                    raiz.dato = aux.dato;

                    Eliminar(ref raiz.izquierda, aux.dato.Nombre);
                }

                Console.WriteLine("Nombre eliminado");
            }
        }
    }
}
