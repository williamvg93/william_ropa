using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Persona;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.Persona;

public class EmpleadoConfig : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
        builder.ToTable("empleado");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(n => n.IdEmpleado)
        .IsRequired();
        builder.HasIndex(n => n.IdEmpleado)
        .IsUnique();

        builder.Property(d => d.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(n => n.FechaIngreso)
        .HasColumnType("datetime");

        builder.HasOne(fk => fk.Cargo)
        .WithMany(fk => fk.Empleados)
        .HasForeignKey(fk => fk.IdCargoFk);

        builder.HasOne(fk => fk.Municipio)
        .WithMany(fk => fk.Empleados)
        .HasForeignKey(fk => fk.IdMuniciFk);
    }
}
