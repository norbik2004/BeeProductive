using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DatabaseEntities
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();

            // Tutaj wpisz connection string do Twojej bazy Postgres
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=BeeProductiveDB;Username=postgres;Password=root");

            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}
