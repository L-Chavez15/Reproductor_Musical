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
        public Nodo raizPrincipal2 = null;

        public void InsertarUsuario(ref Nodo raiz, Usuario u)
        {
            if (raiz == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.datoUsuario = u;
                raiz = nuevo;
            }
            else
            {
                if (string.Compare(u.NombreUsuario, raiz.datoUsuario.NombreUsuario) < 0)
                {
                    InsertarUsuario(ref raiz.izquierda, u);
                }
                else if (string.Compare(u.NombreUsuario, raiz.datoUsuario.NombreUsuario) > 0)
                {
                    InsertarUsuario(ref raiz.derecha, u);
                }
                else
                {
                    MessageBox.Show("Usuario ya registrado");
                }
            }
        }
        public Usuario BuscarUsuario(Nodo raiz, string nombreUsuario)
        {
            if (raiz == null)
            {
                return null;
            }
            else
            {
                if (string.Compare(nombreUsuario, raiz.datoUsuario.NombreUsuario) < 0)
                {
                    return BuscarUsuario(raiz.izquierda, nombreUsuario);
                }
                else if (string.Compare(nombreUsuario, raiz.datoUsuario.NombreUsuario) > 0)
                {
                    return BuscarUsuario(raiz.derecha, nombreUsuario);
                }
                else
                {
                    return raiz.datoUsuario;
                }
            }
        }


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
