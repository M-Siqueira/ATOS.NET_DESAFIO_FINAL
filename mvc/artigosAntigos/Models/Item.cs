using System.Reflection;

namespace artigosAntigos.Models
{
    public class Item
    {

        public Item()
        {
            DataItem = DateOnly.FromDateTime(new DateTime());
        }
        public Item(int idItem, string nomeItem, int categoriaId, DateOnly dataItem, decimal custoItem, decimal precoItem, string foto)
        {
            IdItem = idItem;
            NomeItem = nomeItem;
            CategoriaId = categoriaId;
            DataItem = dataItem;
            CustoItem = custoItem;
            PrecoItem = precoItem;
            Foto = foto;
        }

        public int IdItem { get; set; }

        public string NomeItem { get; set; }

        public int CategoriaId { get; set; }

        public DateOnly DataItem { get; set; }

        public decimal CustoItem { get; set; }

        public decimal PrecoItem { get; set; }

        public Categoria categoria { get; set; }


        public  string Foto {get; set;}
    }
}
