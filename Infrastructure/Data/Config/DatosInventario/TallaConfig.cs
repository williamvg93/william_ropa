using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.DatosInventario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.DatosInventario
{
    public class TallaConfig : IEntityTypeConfiguration<Talla>
    {
        public void Configure(EntityTypeBuilder<Talla> builder)
        {
            builder.ToTable("talla");

            builder.HasKey(k => k.Id);
            builder.Property(id => id.Id);

            builder.Property(n => n.Descripcion)
            .IsRequired();
            builder.HasIndex(n => n.Descripcion)
            .IsUnique();
        }
    }
}