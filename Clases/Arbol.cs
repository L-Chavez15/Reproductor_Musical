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
        
        
        
        /*public void Eliminar(ref Nodo raiz, string nombre)
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
        }*/
    }
}
