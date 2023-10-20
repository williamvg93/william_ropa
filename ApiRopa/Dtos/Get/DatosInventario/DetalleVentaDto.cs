using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Get.DatosInventario;

public class DetalleVentaDto
{
    public int Id { get; set; }
    public int Cantidad { get; set; }
    public double ValorUnit { get; set; }
}
