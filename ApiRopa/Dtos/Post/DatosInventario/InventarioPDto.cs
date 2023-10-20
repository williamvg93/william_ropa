using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Post.DatosInventario;

public class InventarioPDto
{
    public int Id { get; set; }
    public int CodInv { get; set; }
    public double ValorVtaCop { get; set; }
    public double ValorVtaUsd { get; set; }
    public int IdPrendaFk { get; set; }
}
