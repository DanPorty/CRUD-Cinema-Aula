using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaRepository.Mapping
{
    public class FilmeMap : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("Filme");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired(true).HasMaxLength(50).HasColumnName("NomeDoFilme");
            builder.Property(x => x.Classificacao).IsRequired(true).HasMaxLength(50).HasColumnName("ClassificacaoDoFilme");
            builder.Property(x => x.Duracao).IsRequired(true).HasColumnName("DuracaoDoFilme").HasDefaultValue(120);
            builder.HasOne(x => x.Genero).WithMany().HasForeignKey("GeneroId").IsRequired(true); //Relacionamento com genero
        }
    }
}
