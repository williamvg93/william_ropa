using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Location;

namespace Core.Entities.DatosEmpresa;

public class Empresa : BaseEntity
{
    public string Nit { get; set; }
    public string RazonSocial { get; set; }
    public string RepresentanteLegal { get; set; }
    public DateTime FechaCreacion { get; set; }
    public int IdMuniciFk { get; set; }
    public Municipio Municipio { get; set; }
}
