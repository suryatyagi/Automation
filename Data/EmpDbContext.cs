using Microsoft.EntityFrameworkCore;

namespace Aspcore.Data
#pragma warning restore format
{
    public class EmpDbContext:DbContext
 {
    public EmpDbContext(DbContextOptions<EmpDbContext> options): base(options)
    {

    }
    public Dbset<Employee>employees{ get; set;}
    }
}
