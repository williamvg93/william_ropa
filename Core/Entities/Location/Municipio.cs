using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosEmpresa;
using Core.Entities.Persona;

namespace Core.Entities.Location;

public class Municipio : BaseEntity
{
    public string Nombre { get; set; }
    public int IdDeparFk { get; set; }
    public Departamento Departamento { get; set; }
    public ICollection<Empresa> Empresas { get; set; }
    public ICollection<Empleado> Empleados { get; set; }
    public ICollection<Cliente> Clientes { get; set; }
    public ICollection<Proveedor> Proveedores { get; set; }
}
