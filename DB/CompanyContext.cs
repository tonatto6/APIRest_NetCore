using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {

        }

        public DbSet<JobsPositions> JobsPositions { get; set; }

        public DbSet<Employees> Employees{ get; set; }

    }
}