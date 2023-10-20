using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.DatosVenta;

namespace Core.Interfaces.Ropa;

public class Colores : BaseEntity
{
    public string Descripcion { get; set; }
    public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
}
