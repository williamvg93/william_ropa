using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Persona;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.Persona;

public class TipoPersonaConfig : IEntityTypeConfiguration<TipoPersona>
{
    public void Configure(EntityTypeBuilder<TipoPersona> builder)
    {
        builder.ToTable("tipopersona");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(n => n.Nombre)
        .IsRequired()
        .HasMaxLength(50);
    }
}
