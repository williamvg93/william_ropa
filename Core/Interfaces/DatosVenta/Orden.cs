using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.Persona;
using Core.Interfaces.Ropa;

namespace Core.Interfaces.DatosVenta;

public class Orden : BaseEntity
{
    public int IdOrden { get; set; }
    public DateTime Fecha { get; set; }
    public int IdEmpleadoFk { get; set; }
    public Empleado Empleado { get; set; }
    public int IdClienteFk { get; set; }
    public Cliente Cliente { get; set; }
    public int IdEstadoFk { get; set; }
    public Estado Estado { get; set; }
}

