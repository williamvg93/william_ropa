using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Persona;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.Persona;

public class ProveedorConfig : IEntityTypeConfiguration<Proveedor>
{
    public void Configure(EntityTypeBuilder<Proveedor> builder)
    {
        builder.ToTable("proveedor");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(n => n.NitProveedor)
        .IsRequired();
        builder.HasIndex(n => n.NitProveedor)
        .IsUnique();

        builder.Property(d => d.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(fk => fk.TipoPersona)
        .WithMany(fk => fk.Proveedores)
        .HasForeignKey(fk => fk.IdTipoPersFk);

        builder.HasOne(fk => fk.Municipio)
        .WithMany(fk => fk.Proveedores)
        .HasForeignKey(fk => fk.IdMuniciFk);
    }
}
