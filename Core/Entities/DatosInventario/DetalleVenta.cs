using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosVenta;

namespace Core.Entities.DatosInventario;

public class DetalleVenta : BaseEntity
{
    public int Cantidad { get; set; }
    public double ValorUnit { get; set; }


    public int IdVentaFk { get; set; }
    public Venta Venta { get; set; }
    public int IdProducInveFk { get; set; }
    public Inventario Inventario { get; set; }
    public int IdTallaFk { get; set; }
    public Talla Talla { get; set; }
}
