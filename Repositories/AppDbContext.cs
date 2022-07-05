using Microsoft.EntityFrameworkCore;
using mvc1.Models;

namespace mvc1.Repositories;

public class AppDbContext : DbContext
{
    public DbSet<Produto>? Produtos { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}