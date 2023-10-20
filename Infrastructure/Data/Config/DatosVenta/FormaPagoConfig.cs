using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosVenta;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.DatosVenta;

public class FormaPagoConfig : IEntityTypeConfiguration<FormaPago>
{
    public void Configure(EntityTypeBuilder<FormaPago> builder)
    {
        builder.ToTable("formapago");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(n => n.Descipcion)
        .IsRequired()
        .HasMaxLength(100);
    }
}
