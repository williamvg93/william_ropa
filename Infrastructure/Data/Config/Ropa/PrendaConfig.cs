using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Ropa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.Ropa;

public class PrendaConfig : IEntityTypeConfiguration<Prenda>
{
    public void Configure(EntityTypeBuilder<Prenda> builder)
    {
        builder.ToTable("prenda");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(n => n.IdPrenda)
        .IsRequired();
        builder.HasIndex(n => n.IdPrenda)
        .IsUnique();

        builder.Property(d => d.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(n => n.ValorUnitCop)
        .HasColumnType("double");

        builder.Property(n => n.ValorUnitUsd)
        .HasColumnType("double");

        builder.HasOne(fk => fk.Estado)
        .WithMany(fk => fk.Prendas)
        .HasForeignKey(fk => fk.IdEstadoFk);

        builder.HasOne(fk => fk.TipoProteccion)
        .WithMany(fk => fk.Prendas)
        .HasForeignKey(fk => fk.IdTipoProFk);

        builder.HasOne(fk => fk.Genero)
        .WithMany(fk => fk.Prendas)
        .HasForeignKey(fk => fk.IdGeneroFk);
    }
}