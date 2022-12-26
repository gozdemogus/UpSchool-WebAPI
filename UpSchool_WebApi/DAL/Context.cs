using Microsoft.EntityFrameworkCore;
using UpSchool_WebApi.DAL.Entities;

namespace UpSchool_WebApi.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:127.0.0.1,1433;Database=ApiProject;MultipleActiveResultSets=true;User=SA;Password=MyPass@word;");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
