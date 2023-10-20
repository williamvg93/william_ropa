using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosEmpresa;
using Core.Interfaces.DatosEmpresa;
using Infrastructure.Data;

namespace Infrastructure.Repositories.DatosEmpresa;

public class EmpresaRepo : GenericRepository<Empresa>, IEmpresa
{
    private readonly RopaContext _context;

    public EmpresaRepo(RopaContext context) : base(context)
    {
        _context = context;
    }
}