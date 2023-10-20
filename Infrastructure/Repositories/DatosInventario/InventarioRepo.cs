using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosInventario;
using Core.Interfaces.DatosInventario;
using Infrastructure.Data;

namespace Infrastructure.Repositories.DatosInventario;

public class InventarioRepo : GenericRepository<Inventario>, IInventario
{
    private readonly RopaContext _context;

    public InventarioRepo(RopaContext context) : base(context)
    {
        _context = context;
    }
}