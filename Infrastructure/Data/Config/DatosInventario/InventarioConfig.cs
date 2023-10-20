using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosInventario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.DatosInventario;

public class InventarioConfig : IEntityTypeConfiguration<Inventario>
{
    public void Configure(EntityTypeBuilder<Inventario> builder)
    {
        builder.ToTable("inventario");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(n => n.CodInv)
        .IsRequired();
        builder.HasIndex(n => n.CodInv)
        .IsUnique();

        builder.Property(n => n.ValorVtaCop)
        .HasColumnType("double");

        builder.Property(n => n.ValorVtaUsd)
        .HasColumnType("double");

        builder.HasOne(fk => fk.Prenda)
        .WithMany(fk => fk.Inventarios)
        .HasForeignKey(fk => fk.IdPrendaFk);
    }
}
