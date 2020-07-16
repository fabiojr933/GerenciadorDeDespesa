using GerenciadorDespesas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDespesas.Mapeamento
{
    public class MesesMap : IEntityTypeConfiguration<Meses>
    {
        public void Configure(EntityTypeBuilder<Meses> builder)
        {
            builder.HasKey(x => x.MesId);
            builder.Property(x => x.MesId).ValueGeneratedNever();
            builder.Property(x => x.Nome).HasMaxLength(50).IsRequired();
            builder.HasMany(x => x.Despesas).WithOne(x => x.Meses).HasForeignKey(x => x.MesId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Salarios).WithOne(x => x.Meses).OnDelete(DeleteBehavior.Cascade); ;
            builder.ToTable("Meses");
        }
    }
}
