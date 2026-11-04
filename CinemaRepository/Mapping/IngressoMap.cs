using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaRepository.Mapping
{
    public class IngressoMap : IEntityTypeConfiguration<Ingresso>
    {
        public void Configure(EntityTypeBuilder<Ingresso> builder)
        {
            builder.ToTable("Ingresso");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DataCompra);
            builder.Property(x => x.Documento).HasMaxLength(14).IsRequired();
            builder.Property(x => x.ValorTotal).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(x => x.FormaPagamento).HasMaxLength(20).IsRequired();

            builder.HasOne(x => x.Sessao);

            builder.HasMany(x => x.IngressoItens)
                   .WithOne(x => x.Ingresso)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class IngressoItemMap : IEntityTypeConfiguration<IngressoItem>
    {
        public void Configure(EntityTypeBuilder<IngressoItem> builder)
        {
            builder.ToTable("IngressoItem");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Assento).IsRequired();
            builder.Property(x => x.Fileira).IsRequired();
            builder.Property(x => x.MeiaEntrada).IsRequired();

            builder.HasOne(x => x.Ingresso)
                   .WithMany(x => x.IngressoItens)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
