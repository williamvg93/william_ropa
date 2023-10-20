using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Location;
using Core.Entities.Ropa;
using Core.Interfaces.Ropa;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Location;

public class MunicipioRepo : GenericRepository<Municipio>, IMunicipio
{
    private readonly RopaContext _context;

    public MunicipioRepo(RopaContext context) : base(context)
    {
        _context = context;
    }
}