using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosCompra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.DatosCompra
{
    public class InsumoProveedorConfig : IEntityTypeConfiguration<InsumoProveedor>
    {
        public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
        {
            builder.ToTable("insumoproveedor");

            builder.HasKey(k => k.Id);
            builder.HasKey(k => k.IdInsumoFk);
            builder.HasKey(k => k.IdProveedorFk);
            builder.Property(id => id.Id);

            builder.HasOne(fk => fk.Insumos)
            .WithMany(fk => fk.InsumoProveedores)
            .HasForeignKey(fk => fk.IdInsumoFk);

            builder.HasOne(fk => fk.Proveedores)
            .WithMany(fk => fk.InsumoProveedores)
            .HasForeignKey(fk => fk.IdProveedorFk);
        }
    }
}