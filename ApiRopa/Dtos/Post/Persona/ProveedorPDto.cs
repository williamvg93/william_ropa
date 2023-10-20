using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Post.Persona;

public class ProveedorPDto
{
    public int Id { get; set; }
    public int NitProveedor { get; set; }
    public string Nombre { get; set; }
    public int IdTipoPersFk { get; set; }
    public int IdMuniciFk { get; set; }
}
