using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Post.DatosCompra;

public class InsumoPrendaPDto
{
    public int Id { get; set; }
    public int Cantidad { get; set; }
    public int IdInsumoFk { get; set; }
    public int IdPrendaFk { get; set; }
}
