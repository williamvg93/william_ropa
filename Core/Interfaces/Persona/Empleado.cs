using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.DatosVenta;
using Core.Interfaces.Location;

namespace Core.Interfaces.Persona;

public class Empleado : BaseEntity
{
    public int IdEmpleado { get; set; }
    public string Nombre { get; set; }
    public DateTime FechaIngreso { get; set; }
    public int IdCargoFk { get; set; }
    public Cargo Cargo { get; set; }
    public int IdMuniciFk { get; set; }
    public Municipio Municipio { get; set; }
    public ICollection<Orden> Ordenes { get; set; }
    public ICollection<Venta> Ventas { get; set; }
}
