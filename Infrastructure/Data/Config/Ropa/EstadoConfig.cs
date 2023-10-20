using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Ropa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.Ropa;

public class EstadoConfig : IEntityTypeConfiguration<Estado>
{
    public void Configure(EntityTypeBuilder<Estado> builder)
    {
        builder.ToTable("estado");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(d => d.Descripcion)
        .IsRequired()
        .HasMaxLength(100);

        builder.HasOne(fk => fk.TipoEstado)
        .WithMany(fk => fk.Estados)
        .HasForeignKey(fk => fk.IdTipoEstaFk);
    }
}
