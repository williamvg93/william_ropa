using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosVenta;
using Core.Interfaces.DatosVenta;
using Infrastructure.Data;

namespace Infrastructure.Repositories.DatosVenta;

public class VentaRepo : GenericRepository<Venta>, IVenta
{
    private readonly RopaContext _context;

    public VentaRepo(RopaContext context) : base(context)
    {
        _context = context;
    }
}