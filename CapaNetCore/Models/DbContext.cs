using Microsoft.EntityFrameworkCore;
using CapaNetCore.Models.Entities;

namespace CapaNetCore.Models
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Persona> Personas { get; set; }
  }
}