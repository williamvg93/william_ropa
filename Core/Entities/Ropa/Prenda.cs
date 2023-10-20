using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosCompra;
using Core.Entities.DatosInventario;
using Core.Entities.DatosVenta;

namespace Core.Entities.Ropa;

public class Prenda : BaseEntity
{
    public int IdPrenda { get; set; }
    public string Nombre { get; set; }
    public double ValorUnitCop { get; set; }
    public double ValorUnitUsd { get; set; }
    public int IdEstadoFk { get; set; }
    public Estado Estado { get; set; }
    public int IdTipoProFk { get; set; }
    public TipoProteccion TipoProteccion { get; set; }
    public int IdGeneroFk { get; set; }
    public Genero Genero { get; set; }
    public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
    public ICollection<Inventario> Inventarios { get; set; }
    public ICollection<InsumoPrenda> InsumoPrendas { get; set; }


}
