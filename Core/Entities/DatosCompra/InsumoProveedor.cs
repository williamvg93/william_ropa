using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Persona;

namespace Core.Entities.DatosCompra;

public class InsumoProveedor : BaseEntity
{
    public int IdInsumoFk { get; set; }
    public Insumo Insumos { get; set; }
    public int IdProveedorFk { get; set; }
    public Proveedor Proveedores { get; set; }
}
