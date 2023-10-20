using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Post.DatosVenta;

public class OrdenPDto
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public int IdEmpleadoFk { get; set; }
    public int IdClienteFk { get; set; }
    public int IdEstadoFk { get; set; }
}
