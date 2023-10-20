using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Post.DatosCompra;

public class InsumoProveedorPDto
{
    public int Id { get; set; }
    public int IdInsumoFk { get; set; }
    public int IdProveedorFk { get; set; }
}
