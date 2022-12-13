namespace artigosAntigos.Models
{
    public class Vendas
    {
        public int IdVenda { get; set; }

        public DateTime DataVenda { get; set; }

        public ICollection<Item> Items { get; set; }
        public Cliente cliente { get; set; }
    }
}
