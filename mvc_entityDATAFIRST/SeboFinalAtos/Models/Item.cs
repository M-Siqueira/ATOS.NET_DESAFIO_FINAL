using System;
using System.Collections.Generic;

namespace SeboFinalAtos.Models;

public partial class Item
{
    public int IdItem { get; set; }

    public string NomeItem { get; set; } = null!;

    public int? CategoriaId { get; set; }

    public DateTime DataItem { get; set; }

    public decimal? CustoItem { get; set; }

    public decimal? PrecoItem { get; set; }

    public string? Foto { get; set; }

    public virtual Categorium? Categoria { get; set; }
}
