using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class RopaContext : DbContext
{
    public RopaContext(DbContextOptions options) : base(options)
    {
    }
    /* public DbSet<> */
}
