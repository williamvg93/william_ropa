using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Ropa;

namespace Core.Entities.DatosInventario;

public class Inventario : BaseEntity
{
    public int CodInv { get; set; }
    public double ValorVtaCop { get; set; }
    public double ValorVtaUsd { get; set; }
    public int IdPrendaFk { get; set; }
    public Prenda Prenda { get; set; }
    public ICollection<DetalleVenta> DetalleVentas { get; set; }
    public ICollection<InventarioTalla> InventarioTallas { get; set; }
}
