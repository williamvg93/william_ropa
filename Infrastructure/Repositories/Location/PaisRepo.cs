using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Location;
using Core.Interfaces.Location;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Location;

public class PaisRepo : GenericRepository<Pais>, IPais
{
    private readonly RopaContext _context;

    public PaisRepo(RopaContext context) : base(context)
    {
        _context = context;
    }
}