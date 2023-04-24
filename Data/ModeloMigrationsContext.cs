using Microsoft.EntityFrameworkCore;

namespace ModeloMigrationsMVC.Models
{
    public class ModeloMigrationsMVCContext : DbContext
    {
        public ModeloMigrationsMVCContext (DbContextOptions<ModeloMigrationsMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
    }
}
