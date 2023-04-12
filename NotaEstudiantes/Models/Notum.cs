using System;
using System.Collections.Generic;

namespace NotaEstudiantes.Models;

public partial class Notum
{
    public int IdNotas { get; set; }

    public string? NombreEstudiante { get; set; }

    public decimal? Lab1 { get; set; }

    public decimal? Par1 { get; set; }

    public decimal? Lab2 { get; set; }

    public decimal? Par2 { get; set; }

    public decimal? Lab3 { get; set; }

    public decimal? Par3 { get; set; }

    public decimal? Resultado { get; set; }
}
