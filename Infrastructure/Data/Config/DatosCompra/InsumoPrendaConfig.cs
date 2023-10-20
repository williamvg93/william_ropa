using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosCompra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.DatosCompra;

public class InsumoPrendaConfig : IEntityTypeConfiguration<InsumoPrenda>
{
    public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
    {
        builder.ToTable("insumoprenda");

        builder.HasKey(k => k.Id);
        builder.HasKey(k => k.IdInsumoFk);
        builder.HasKey(k => k.IdPrendaFk);
        builder.Property(id => id.Id);

        builder.Property(c => c.Cantidad)
        .IsRequired();

        builder.HasOne(fk => fk.Insumos)
        .WithMany(fk => fk.InsumoPrendas)
        .HasForeignKey(fk => fk.IdInsumoFk);

        builder.HasOne(fk => fk.Prendas)
        .WithMany(fk => fk.InsumoPrendas)
        .HasForeignKey(fk => fk.IdPrendaFk);
    }
}
