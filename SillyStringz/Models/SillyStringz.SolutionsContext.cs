using Microsoft.EntityFrameworkCore;

namespace SillyStringz.Models 
{
  public class SillyStringzContext : DbContext 
  {
    public DbSet<Engineer> Engineers { get; set; } 
    public DbSet<Machine> Machines { get; set; } 
    public DbSet<EngineerMachine> EngineerMachines { get; set; } 

    public SillyStringzContext(DbContextOptions options) : base(options) { } 
  }
}