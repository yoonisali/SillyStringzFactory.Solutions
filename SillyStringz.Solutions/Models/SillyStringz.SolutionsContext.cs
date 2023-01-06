// Needed for accessing database

using Microsoft.EntityFrameworkCore;


namespace SillyStringz.Solutions.Models 
{
  public class SillyStringz.SolutionsContext : DbContext 
  {
    public DbSet<ClassName> ClassNames { get; set; }  // CHANGE CLASS NAME!!!

    public SillyStringz.SolutionsContext(DbContextOptions options) : base(options) { } 
  }
}