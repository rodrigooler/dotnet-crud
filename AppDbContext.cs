using Microsoft.EntityFrameworkCore;
using ApiBasic.Models;

namespace ApiBasic.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }
}