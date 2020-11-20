using DotNetCoreWebApi.Services.Common.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCoreWebApi.Services.Common.Data.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(t => t.Address1).HasMaxLength(256).IsRequired();
            builder.Property(t => t.Address2).HasMaxLength(256).IsRequired();
            builder.Property(t => t.City).HasMaxLength(256).IsRequired();

            builder.HasData
            (
                new Address 
                {
                    Id = 1,
                    Address1 = "5774 E Wallings Rd",
                    Address2 = "test address 2",
                    City = "Broadview Heights",
                    StateId = 1,
                    PostalCode = 44147
                }
                
            );
        }
    }
}
