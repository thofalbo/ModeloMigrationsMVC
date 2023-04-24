using Microsoft.EntityFrameworkCore;

namespace ModeloMigrations.Models
{
    public class ModeloMigrationsContext : DbContext
    {
        public ModeloMigrationsContext (DbContextOptions<ModeloMigrationsContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
    }
}
