using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Ropa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.Ropa;

public class ColoresConfig : IEntityTypeConfiguration<Colores>
{
    public void Configure(EntityTypeBuilder<Colores> builder)
    {
        builder.ToTable("color");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(d => d.Descripcion)
        .IsRequired()
        .HasMaxLength(100);
    }
}
