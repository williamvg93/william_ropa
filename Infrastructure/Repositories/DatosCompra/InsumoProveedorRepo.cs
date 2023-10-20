using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosCompra;
using Core.Interfaces.DatosCompra;
using Infrastructure.Data;

namespace Infrastructure.Repositories.DatosCompra;

public class InsumoProveedorRepo : GenericRepository<InsumoProveedor>, IInsumoProveedor
{
    private readonly RopaContext _context;

    public InsumoProveedorRepo(RopaContext context) : base(context)
    {
        _context = context;
    }
}