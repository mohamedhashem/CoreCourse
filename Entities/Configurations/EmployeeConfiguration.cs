using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee { 
                    Id=new Guid("641c895d-683f-40af-b831-e7a4a8dea895"),
                    Age = 30,
                    CompanyId = new Guid ("1611b6e2-de3d-459f-8828-dfaf2123f71d"),
                    Name= "Mohamed",
                    Position = "Junior"
                }, 
                new Employee {
                    Id = new Guid("49746903-1394-42bf-86fc-18c345cdc7e5"),
                    Age = 35,
                    CompanyId = new Guid("1611b6e2-de3d-459f-8828-dfaf2123f71d"),
                    Name = "Ahmed",
                    Position = "Senior"
                }, 
                new Employee {
                    Id = new Guid("c7bdbb9c-1b26-4deb-83a7-d411bcbe20e2"),
                    Age = 40,
                    CompanyId = new Guid("9eb5874f-2315-4afb-9bc9-200e348f94c8"),
                    Name = "Ali",
                    Position = "Team Leader"
                });
            
        }
    }

}
