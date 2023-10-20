using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosInventario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.DatosInventario;

public class DetalleVentaConfig : IEntityTypeConfiguration<DetalleVenta>
{
    public void Configure(EntityTypeBuilder<DetalleVenta> builder)
    {
        builder.ToTable("detalleventa");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(n => n.Cantidad)
        .IsRequired();

        builder.Property(n => n.ValorUnit)
        .IsRequired()
        .HasColumnType("double");

        builder.HasOne(fk => fk.Venta)
        .WithMany(fk => fk.DetalleVentas)
        .HasForeignKey(fk => fk.IdVentaFk);

        builder.HasOne(fk => fk.Inventario)
        .WithMany(fk => fk.DetalleVentas)
        .HasForeignKey(fk => fk.IdProducInveFk);

        builder.HasOne(fk => fk.Talla)
        .WithMany(fk => fk.DetalleVentas)
        .HasForeignKey(fk => fk.IdTallaFk);
    }
}
