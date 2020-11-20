using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Config
{
    public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.Property(m => m.Name)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(m => m.Supplier)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(m => m.Unit)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(m => m.Type)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}