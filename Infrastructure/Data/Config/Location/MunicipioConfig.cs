using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Location;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.Location;

public class MunicipioConfig : IEntityTypeConfiguration<Municipio>
{
    public void Configure(EntityTypeBuilder<Municipio> builder)
    {
        builder.ToTable("municipio");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(n => n.Nombre)
        .IsRequired()
        .HasMaxLength(100);

        builder.HasOne(fk => fk.Departamento)
        .WithMany(fk => fk.Municipios)
        .HasForeignKey(fk => fk.IdDeparFk);
    }
}
