namespace artigosAntigos.Models
{
    public class Categoria
    {
        public Categoria(int idCategoria, string nomeCategoria)
        {
            IdCategoria = idCategoria;
            NomeCategoria = nomeCategoria;
        }

        public int IdCategoria { get; set; }

        public string NomeCategoria { get; set; }

        public ICollection<Item> Items { get; set; }


    }
}
