using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.DatosVenta;

namespace Core.Interfaces.Ropa;

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

}
