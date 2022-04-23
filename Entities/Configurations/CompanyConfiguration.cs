using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    Id = new Guid("1611b6e2-de3d-459f-8828-dfaf2123f71d"),
                    Address = "Cairo",
                    Country = "Cairo",
                    Name = "Google"
                },
                new Company
                {
                    Id = new Guid("9eb5874f-2315-4afb-9bc9-200e348f94c8"),
                    Address = "London",
                    Country = "London",
                    Name = "Facebook"
                }
                );
            ;
        }
    }

}
