using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.DatosVenta;

namespace Core.Interfaces.Ropa;

public class Color : BaseEntity
{
    public string Descipcion { get; set; }
    public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
}
