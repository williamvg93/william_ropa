using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Post.Ropa;

public class PrendaPDto
{
    public int Id { get; set; }
    public int IdPrenda { get; set; }
    public string Nombre { get; set; }
    public double ValorUnitCop { get; set; }
    public double ValorUnitUsd { get; set; }
    public int IdEstadoFk { get; set; }
    public int IdTipoProFk { get; set; }
    public int IdGeneroFk { get; set; }
}