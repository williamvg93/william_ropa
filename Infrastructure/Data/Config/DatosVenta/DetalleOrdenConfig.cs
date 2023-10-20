using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosVenta;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.DatosVenta;

public class DetalleOrdenConfig : IEntityTypeConfiguration<DetalleOrden>
{
    public void Configure(EntityTypeBuilder<DetalleOrden> builder)
    {
        builder.ToTable("detalleorden");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(n => n.CantidadProducir)
        .IsRequired();

        builder.Property(n => n.CantidadProducida)
        .IsRequired();

        builder.HasOne(fk => fk.Orden)
        .WithMany(fk => fk.DetalleOrdenes)
        .HasForeignKey(fk => fk.IdOrdenFk);

        builder.HasOne(fk => fk.Prenda)
        .WithMany(fk => fk.DetalleOrdenes)
        .HasForeignKey(fk => fk.IdPrendaFk);

        builder.HasOne(fk => fk.Colores)
        .WithMany(fk => fk.DetalleOrdenes)
        .HasForeignKey(fk => fk.IdColorFk);

        builder.HasOne(fk => fk.Estado)
        .WithMany(fk => fk.DetalleOrdenes)
        .HasForeignKey(fk => fk.IdEstadoFk);
    }
}
