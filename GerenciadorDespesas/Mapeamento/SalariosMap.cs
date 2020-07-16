using GerenciadorDespesas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDespesas.Mapeamento
{
    public class SalariosMap : IEntityTypeConfiguration<Salarios>
    {
        public void Configure(EntityTypeBuilder<Salarios> builder)
        {
            builder.HasKey(x => x.SalariosId);
            builder.Property(x => x.Valor).IsRequired();
            builder.HasOne(x => x.Meses).WithOne(x => x.Salarios).HasForeignKey<Salarios>(x => x.MesId);
            builder.ToTable("Salarios");
        }
    }
}
