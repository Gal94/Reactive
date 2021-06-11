using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    // * Table name will be called activities
    public DbSet<Activity> Activities { get; set; }
  }
}