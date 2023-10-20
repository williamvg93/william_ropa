using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.DatosVenta;
using Core.Interfaces.Location;

namespace Core.Interfaces.Persona;

public class Cliente : BaseEntity
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public DateTime FechaRegistro { get; set; }
    public int IdTipoPersFk { get; set; }
    public TipoPersona TipoPersona { get; set; }
    public int IdMuniciFk { get; set; }
    public Municipio Municipio { get; set; }
    public ICollection<Orden> Ordenes { get; set; }
    public ICollection<Venta> Ventas { get; set; }
}
