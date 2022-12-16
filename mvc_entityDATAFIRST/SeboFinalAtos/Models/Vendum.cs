using System;
using System.Collections.Generic;

namespace SeboFinalAtos.Models;

public partial class Vendum
{
    public int IdVenda { get; set; }

    public DateTime DataVenda { get; set; }

    public int? IdCliente { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }
}
