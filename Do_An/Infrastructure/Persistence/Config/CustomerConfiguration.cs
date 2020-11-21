using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Config
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(m => m.CustomerName)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(m => m.PhoneNumber)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(m => m.Address)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(m => m.Email)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(m => m.CustomerType)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}