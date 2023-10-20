using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Persona;
using Core.Interfaces.Persona;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Persona;

public class ClienteRepo : GenericRepository<Cliente>, ICliente
{
    private readonly RopaContext _context;

    public ClienteRepo(RopaContext context) : base(context)
    {
        _context = context;
    }
}