using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DatabaseEntities
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();

            // Ustaw swój connection string tutaj
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=BeeProductiveDatabase;Integrated Security=True;TrustServerCertificate=True");

            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}