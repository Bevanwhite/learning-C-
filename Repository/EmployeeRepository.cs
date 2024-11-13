using Contracts;
using Entities.Models;

namespace Repository;

internal class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
{
    public EmployeeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
        
    }
}