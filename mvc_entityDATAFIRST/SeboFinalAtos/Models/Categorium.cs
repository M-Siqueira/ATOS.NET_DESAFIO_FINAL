using System;
using System.Collections.Generic;

namespace SeboFinalAtos.Models;

public partial class Categorium
{
    public int IdCategoria { get; set; }

    public string NomeCategoria { get; set; } = null!;

    public virtual ICollection<Item> Items { get; } = new List<Item>();
}
