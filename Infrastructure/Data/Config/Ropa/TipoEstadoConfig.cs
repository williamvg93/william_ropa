using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Ropa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.Ropa;

public class TipoEstadoConfig : IEntityTypeConfiguration<TipoEstado>
{
    public void Configure(EntityTypeBuilder<TipoEstado> builder)
    {
        builder.ToTable("tipoestado");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(d => d.Descripcion)
        .IsRequired()
        .HasMaxLength(100);

    }
}