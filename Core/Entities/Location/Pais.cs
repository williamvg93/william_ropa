using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Location;

public class Pais : BaseEntity
{
    public string Nombre { get; set; }
    public ICollection<Departamento> Departamentos { get; set; }
}
