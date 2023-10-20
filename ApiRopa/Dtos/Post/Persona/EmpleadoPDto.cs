using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Post.Persona;

public class EmpleadoPDto
{
    public int Id { get; set; }
    public int IdEmpleado { get; set; }
    public string Nombre { get; set; }
    public DateTime FechaIngreso { get; set; }
    public int IdCargoFk { get; set; }
    public int IdMuniciFk { get; set; }
}
