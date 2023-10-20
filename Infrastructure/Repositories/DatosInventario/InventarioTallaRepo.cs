using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosInventario;
using Core.Interfaces.DatosInventario;
using Infrastructure.Data;

namespace Infrastructure.Repositories.DatosInventario;

public class InventarioTallaRepo : GenericRepository<InventarioTalla>, IInventarioTalla
{
    private readonly RopaContext _context;

    public InventarioTallaRepo(RopaContext context) : base(context)
    {
        _context = context;
    }
}