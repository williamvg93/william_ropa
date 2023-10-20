using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosVenta;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.DatosVenta;

public class OrdenConfig : IEntityTypeConfiguration<Orden>
{
    public void Configure(EntityTypeBuilder<Orden> builder)
    {
        builder.ToTable("orden");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(n => n.Fecha)
        .IsRequired()
        .HasColumnType("datetime");

        builder.HasOne(fk => fk.Empleado)
        .WithMany(fk => fk.Ordenes)
        .HasForeignKey(fk => fk.IdEmpleadoFk);

        builder.HasOne(fk => fk.Cliente)
        .WithMany(fk => fk.Ordenes)
        .HasForeignKey(fk => fk.IdClienteFk);

        builder.HasOne(fk => fk.Estado)
        .WithMany(fk => fk.Ordenes)
        .HasForeignKey(fk => fk.IdEstadoFk);
    }
}
