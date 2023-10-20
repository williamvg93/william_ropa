using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosEmpresa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.DatosEmpresa;

public class EmpresaConfig : IEntityTypeConfiguration<Empresa>
{
    public void Configure(EntityTypeBuilder<Empresa> builder)
    {
        builder.ToTable("empresa");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(n => n.Nit)
        .IsRequired();
        builder.HasIndex(n => n.Nit)
        .IsUnique();

        builder.Property(d => d.RazonSocial)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(d => d.RepresentanteLegal)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(n => n.FechaCreacion)
        .HasColumnType("datetime");

        builder.HasOne(fk => fk.Municipio)
        .WithMany(fk => fk.Empresas)
        .HasForeignKey(fk => fk.IdMuniciFk);
    }
}
