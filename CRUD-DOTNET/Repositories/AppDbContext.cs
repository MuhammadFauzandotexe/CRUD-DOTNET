using CRUD_DOTNET.Entities;
using Microsoft.EntityFrameworkCore;
namespace CRUD_DOTNET.Repository;

public class AppDbContext : DbContext
{
 public   DbSet<Customer?> Customers { set; get; }
 
 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
  optionsBuilder.UseNpgsql("Server=localhost,5432;Username=postgres;Password=1;Database=postgres;TrustServerCertificate=True;");
 }
}