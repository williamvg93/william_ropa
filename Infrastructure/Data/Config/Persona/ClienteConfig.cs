using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Persona;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.Persona;

public class ClienteConfig : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("cliente");

        builder.HasKey(k => k.Id);
        builder.Property(id => id.Id);

        builder.Property(n => n.IdCliente)
        .IsRequired();
        builder.HasIndex(n => n.IdCliente)
        .IsUnique();

        builder.Property(d => d.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(n => n.FechaRegistro)
        .HasColumnType("datetime");

        builder.HasOne(fk => fk.TipoPersona)
        .WithMany(fk => fk.Clientes)
        .HasForeignKey(fk => fk.IdTipoPersFk);

        builder.HasOne(fk => fk.Municipio)
        .WithMany(fk => fk.Clientes)
        .HasForeignKey(fk => fk.IdMuniciFk);

    }
}
