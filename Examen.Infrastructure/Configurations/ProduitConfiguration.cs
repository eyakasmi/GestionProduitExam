using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    public class ProduitConfiguration : IEntityTypeConfiguration<Produit>
    {
        public void Configure(EntityTypeBuilder<Produit> builder)
        {
            builder.HasMany(p => p.Fournisseurs)
                .WithMany(f => f.Produits)
                .UsingEntity(p => p.ToTable("Facture"));

            builder.HasDiscriminator<char>("TypeProduit")
            .HasValue<Produit>('P')
            .HasValue<Chimique>('C')
            .HasValue<Biologique>('B');
        }
    }
}
