using GerenciadorDespesas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDespesas.Mapeamento
{
    public class TipoDespesasMap : IEntityTypeConfiguration<TipoDespesas>
    {
        public void Configure(EntityTypeBuilder<TipoDespesas> builder)
        {
            builder.HasKey(x => x.TipoDespesasId);
            builder.Property(x => x.Nome).HasMaxLength(50).IsRequired();
            builder.HasMany(x => x.Despesas).WithOne(x => x.TipoDespesas).HasForeignKey(x => x.TipoDespesaId);
            builder.ToTable("TipoDespesas");
        }
    }
}
