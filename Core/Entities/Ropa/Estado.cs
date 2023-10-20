using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.DatosVenta;

namespace Core.Interfaces.Ropa;

public class Estado : BaseEntity
{
    public string Descripcion { get; set; }
    public int IdTipoEstaFk { get; set; }
    public TipoEstado TipoEstado { get; set; }
    public ICollection<Orden> Ordenes { get; set; }
    public ICollection<Prenda> Prendas { get; set; }
    public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
}
