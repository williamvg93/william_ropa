using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Get.DatosCompra;

public class InsumoPrendaDto
{
    public int Id { get; set; }
    public int Cantidad { get; set; }
    public int IdInsumoFk { get; set; }
    public int IdPrendaFk { get; set; }
}
