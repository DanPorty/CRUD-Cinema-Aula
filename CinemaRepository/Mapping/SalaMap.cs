using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaRepository.Mapping
{
    public class SalaMap : IEntityTypeConfiguration<Sala>
    {
        public void Configure(EntityTypeBuilder<Sala> builder)
        {
            builder.ToTable("Sala");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Assentos).IsRequired().HasColumnName("Assentos");
            builder.Property(x => x.Capacidade).IsRequired().HasColumnName("Capacidade").HasMaxLength(200);
            builder.Property(x => x.Fileiras).IsRequired().HasColumnName("Fileiras").HasMaxLength(20);
            builder.Property(x => x.Numero).IsRequired().HasColumnName("Numero");
        }
    }
}
