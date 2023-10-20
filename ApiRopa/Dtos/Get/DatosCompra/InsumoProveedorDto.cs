using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Get.DatosCompra;

public class InsumoProveedorDto
{
    public int Id { get; set; }
    public int IdInsumoFk { get; set; }
    public int IdProveedorFk { get; set; }
}
