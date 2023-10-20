using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Get.Ropa;

public class PrendaDto
{
    public int Id { get; set; }
    public int IdPrenda { get; set; }
    public string Nombre { get; set; }
    public double ValorUnitCop { get; set; }
    public double ValorUnitUsd { get; set; }
}
