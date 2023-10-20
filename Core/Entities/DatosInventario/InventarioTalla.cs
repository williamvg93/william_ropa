using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces.DatosInventario;

public class InventarioTalla : BaseEntity
{
    public int Cantidad { get; set; }
    public int IdInventaFk { get; set; }
    public Inventario Inventarios { get; set; }
    public int IdTallaFk { get; set; }
    public Talla Tallas { get; set; }
}
