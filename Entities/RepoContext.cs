using Entities.Configurations;
using Entities.Models;
using Microsoft.EntityFrameworkCore;


namespace Entities
{
    public class RepoContext : DbContext
    {
        public RepoContext(DbContextOptions options) : base(options)
        {

        }
        /// <summary>
        /// Using OnModelCreating : to add seeds as Configurations to Tables that will be Built
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Company> companies { get; set; }
    }
}
