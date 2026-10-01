using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaRepository.Mapping
{
    public class GeneroMap : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("Sonic");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired(true).HasMaxLength(50).HasColumnName("NomeDoGenero");
        }
    }
}
