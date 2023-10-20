using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Post.DatosEmpresa;

public class EmpresaPDto
{
    public string Id { get; set; }
    public string Nit { get; set; }
    public string RazonSocial { get; set; }
    public string RepresentanteLegal { get; set; }
    public DateTime FechaCreacion { get; set; }
    public int IdMuniciFk { get; set; }
}
