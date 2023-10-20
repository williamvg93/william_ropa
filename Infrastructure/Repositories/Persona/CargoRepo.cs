using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Persona;
using Core.Interfaces.Persona;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Persona;

public class CargoRepo : GenericRepository<Cargo>, ICargo
{
    private readonly RopaContext _context;

    public CargoRepo(RopaContext context) : base(context)
    {
        _context = context;
    }
}