namespace Clases
{
    public class Musica
    {
        public string Nombre;
        public string Artista;
        public string genero;
        public string Ruta;
        public Musica()
        {
        }
        public override string ToString()
        {
            return $"{Nombre} - {Artista}";
        }
    }
}