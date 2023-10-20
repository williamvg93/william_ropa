using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosCompra;
using Core.Entities.Location;

namespace Core.Entities.Persona;

public class Proveedor : BaseEntity
{
    public int NitProveedor { get; set; }
    public string Nombre { get; set; }
    public int IdTipoPersFk { get; set; }
    public TipoPersona TipoPersona { get; set; }
    public int IdMuniciFk { get; set; }
    public Municipio Municipio { get; set; }
    public ICollection<InsumoProveedor> InsumoProveedores { get; set; }
}
