using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Portfolio.Models;

// Membuat kelas portfoliodbcontext
public class PortfoliodbContext : DbContext {
    // Constructor untuk menginisialisasi DbContext
    public PortfoliodbContext(DbContextOptions<PortfoliodbContext>options) : base(options) 
    {
    }
    // Mendefinisikan tabel kedalam database
    public DbSet<Profile>? Profile { get; set; }
}