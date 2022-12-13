namespace artigosAntigos.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }

        public string NomeCliente { get; set; }

        public string CpfCliente { get; set; }

        public ICollection<Vendas> Vendas { get; set; }

    }
}
