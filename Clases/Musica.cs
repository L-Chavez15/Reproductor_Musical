namespace Clases
{
    public class Musica
    {
        public string Nombre;
        public string Artista;
        public int Apublicacion;
        public float duracion;
        public override string ToString()
        {
            return $"{Nombre} - {Artista}";
        }
    }
}