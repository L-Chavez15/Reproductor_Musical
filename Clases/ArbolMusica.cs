using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public class ArbolMusica
    {
        public Nodo raizPrincipal = null;
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
                else if (string.Compare(m.Nombre, raiz.dato.Nombre) > 0)
                {
                    Insertar(ref raiz.derecha, m);
                }
                else
                {
                    MessageBox.Show("Música ya registrada");
                }
            }
        }
        public Musica Buscar(Nodo raiz, string nombre)
        {
            if (raiz == null)
            {
                return null;
            }
            else
            {
                if (string.Compare(nombre, raiz.dato.Nombre) < 0)
                {
                    return Buscar(raiz.izquierda, nombre);
                }
                else if (string.Compare(nombre, raiz.dato.Nombre) > 0)
                {
                    return Buscar(raiz.derecha, nombre);
                }
                else
                {
                    return raiz.dato;
                }
            }
        }
    }
}
