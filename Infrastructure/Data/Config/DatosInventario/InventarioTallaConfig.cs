using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosInventario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.DatosInventario;

public class InventarioTallaConfig : IEntityTypeConfiguration<InventarioTalla>
{
    public void Configure(EntityTypeBuilder<InventarioTalla> builder)
    {
        builder.ToTable("inventariotalla");

        builder.HasKey(k => k.Id);
        builder.HasKey(k => k.IdInventaFk);
        builder.HasKey(k => k.IdTallaFk);

        builder.Property(id => id.Id);

        builder.Property(n => n.Cantidad);

        builder.HasOne(fk => fk.Inventarios)
        .WithMany(fk => fk.InventarioTallas)
        .HasForeignKey(fk => fk.IdInventaFk);

        builder.HasOne(fk => fk.Tallas)
        .WithMany(fk => fk.InventarioTallas)
        .HasForeignKey(fk => fk.IdTallaFk);
    }
}
