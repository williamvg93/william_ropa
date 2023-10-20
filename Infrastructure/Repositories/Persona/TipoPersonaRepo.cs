using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Persona;
using Core.Interfaces.Persona;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Persona;

public class TipoPersonaRepo : GenericRepository<TipoPersona>, ITipoPersona
{
    private readonly RopaContext _context;

    public TipoPersonaRepo(RopaContext context) : base(context)
    {
        _context = context;
    }
}