using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosVenta;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.DatosVenta;

public class VentaConfig : IEntityTypeConfiguration<Venta>
{
    public void Configure(EntityTypeBuilder<Venta> builder)
    {
        builder.ToTable("venta");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(n => n.Fecha)
        .HasColumnType("datetime");

        builder.HasOne(fk => fk.Empleado)
        .WithMany(fk => fk.Ventas)
        .HasForeignKey(fk => fk.IdEmpleadoFk);

        builder.HasOne(fk => fk.Cliente)
        .WithMany(fk => fk.Ventas)
        .HasForeignKey(fk => fk.IdClienteFk);

        builder.HasOne(fk => fk.FormaPago)
        .WithMany(fk => fk.Ventas)
        .HasForeignKey(fk => fk.IdFormaPagoFk);
    }
}
