using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces.Persona;

public class TipoPersona : BaseEntity
{
    public string Nombre { get; set; }
    public ICollection<Cliente> Clientes { get; set; }
    public ICollection<Proveedor> Proveedores { get; set; }
}
