using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Post.DatosInventario;

public class InventarioTallaPDto
{
    public int Id { get; set; }
    public int Cantidad { get; set; }
    public int IdInventaFk { get; set; }
    public int IdTallaFk { get; set; }
}
