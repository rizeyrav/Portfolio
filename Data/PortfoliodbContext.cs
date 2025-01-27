// Membuat kelas portfoliodbcontext
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

public class PortfoliodbContext : DbContext {
    // Constructor untuk menginisialisasi DbContext
    public PortfoliodbContext(DbContextOptions<PortfoliodbContext>options) : base(options) 
    {
    }
    // Mendefinisikan tabel kedalam database
    public DbSet<Profile>? Profile { get; set; }
}