using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces.Persona;

public class Proveedor : BaseEntity
{
    public int NitProveedor { get; set; }
    public string Nombre { get; set; }
    public int IdTipoPersFk { get; set; }
    public TipoPersona TipoPersona { get; set; }
}
