using Keikobar.Models;
using Microsoft.EntityFrameworkCore;

namespace Keikobar.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<ApplicationType> ApplicationTypes { get; set; }
}