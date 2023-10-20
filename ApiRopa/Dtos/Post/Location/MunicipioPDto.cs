using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Post.Location;

public class MunicipioPDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int IdDeparFk { get; set; }
}
