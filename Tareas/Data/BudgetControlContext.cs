using Microsoft.EntityFrameworkCore;
using BudgetControlApp.Data.Entities;

namespace BudgetControlApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }

    }
}
