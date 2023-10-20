using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Get.Persona;

public class EmpleadoDto
{
    public int Id { get; set; }
    public int IdEmpleado { get; set; }
    public string Nombre { get; set; }
    public DateTime FechaIngreso { get; set; }
}
