using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.DatosVenta;

public class FormaPago : BaseEntity
{
    public string Descipcion { get; set; }
    public ICollection<Venta> Ventas { get; set; }
}
