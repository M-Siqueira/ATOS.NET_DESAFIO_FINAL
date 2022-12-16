using System;
using System.Collections.Generic;

namespace SeboFinalAtos.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string NomeCliente { get; set; } = null!;

    public string CpfCliente { get; set; } = null!;

    public virtual ICollection<Vendum> Venda { get; } = new List<Vendum>();
}
