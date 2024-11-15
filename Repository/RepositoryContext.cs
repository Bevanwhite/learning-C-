using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository;

public class RepositoryContext: DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration()); 
        modelBuilder.ApplyConfiguration(new CompanyConfiguration()); 
    }
    
    public DbSet<Company>? Companies => Set<Company>();
    public DbSet<Employee>? Employees => Set<Employee>();
}
