using GerenciadorDespesas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDespesas.Mapeamento
{
    public class DespesasMap : IEntityTypeConfiguration<Despesas>
    {
        public void Configure(EntityTypeBuilder<Despesas> builder)
        {
            builder.HasKey(x => x.DespesasId);
            builder.Property(x => x.Valor).IsRequired();
            builder.HasOne(x => x.Meses).WithMany(x => x.Despesas).HasForeignKey(x => x.MesId);
            builder.HasOne(x => x.TipoDespesas).WithMany(x => x.Despesas).HasForeignKey(x => x.TipoDespesaId);
            builder.ToTable("Despesas");
        }
    }
}
