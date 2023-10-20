using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosCompra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.DatosCompra;

public class InsumoConfig : IEntityTypeConfiguration<Insumo>
{
    public void Configure(EntityTypeBuilder<Insumo> builder)
    {
        builder.ToTable("insumo");

        builder.HasKey(k => k.Id);

        builder.Property(id => id.Id);

        builder.Property(n => n.Name)
        .IsRequired()
        .HasMaxLength(50);
        builder.HasIndex(n => n.Name)
        .IsUnique();

        builder.Property(vu => vu.ValorUnit)
        .HasColumnType("double");

        builder.Property(smi => smi.StockMin);
        builder.Property(sma => sma.StockMax);

    }
}
