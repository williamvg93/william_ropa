using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Location;
using Core.Interfaces.Location;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Location;

public class DepartamentoRepo : GenericRepository<Departamento>, IDepartamento
{
    private readonly RopaContext _context;

    public DepartamentoRepo(RopaContext context) : base(context)
    {
        _context = context;
    }
}