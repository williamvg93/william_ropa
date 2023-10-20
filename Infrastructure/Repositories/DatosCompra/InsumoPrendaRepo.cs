using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosCompra;
using Core.Interfaces.DatosCompra;
using Infrastructure.Data;

namespace Infrastructure.Repositories.DatosCompra;

public class InsumoPrendaRepo : GenericRepository<InsumoPrenda>, IInsumoPrenda
{
    private readonly RopaContext _context;

    public InsumoPrendaRepo(RopaContext context) : base(context)
    {
        _context = context;
    }
}
