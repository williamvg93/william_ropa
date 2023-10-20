using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Location;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.Location;

public class DepartamentoConfig : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        builder.ToTable("departamento");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(n => n.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(fk => fk.Pais)
        .WithMany(fk => fk.Departamentos)
        .HasForeignKey(fk => fk.IdPaisFk);
    }
}
