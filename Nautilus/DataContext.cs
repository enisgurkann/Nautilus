using Microsoft.EntityFrameworkCore;
using Nautilus.Core.Domain;

namespace Nautilus
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }

        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<JobSteps> JobSteps { get; set; }



    }
}
