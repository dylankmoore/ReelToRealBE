using Microsoft.EntityFrameworkCore;
using ReelToReal.Models;
using System.Runtime.CompilerServices;

public class ReelToRealDbContext : DbContext
{

    public DbSet<Movie> Movies { get; set; }

    public ReelToRealDbContext(DbContextOptions<ReelToRealDbContext> context) : base(context)
    {


    }
}