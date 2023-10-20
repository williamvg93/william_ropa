using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos.Post.Ropa;

public class EstadoPDto
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public int IdTipoEstaFk { get; set; }
}
