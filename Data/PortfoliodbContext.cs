using Portfolio.Models;
using Microsoft.EntityFrameworkCore;

public class PortfoliodbContext : DbContext{
    // Deklarasi Model
    public DbSet<Profile>? Profile { get; set; }
    public DbSet<Education>? Education { get; set; }
    public DbSet<Project>? Project { get; set; }

    public PortfoliodbContext(DbContextOptions<PortfoliodbContext> options) : base(options){

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {   
        modelBuilder.Entity<Profile>()      //Relasi Entitas Profile
        .HasMany(p => p.Educations)         //Lebih Dari 1 Education(p => p.Education)
        .WithOne(e => e.Profile)            //Education Hanya Memiliki 1 Relasi(e => e.Profile) dengan Profile 
        .HasForeignKey(e => e.Profile_Id);  //Memiliki FK di Education(e=>E.Profile_Id) dengan nama Kolom FK

        modelBuilder.Entity<Profile>()
        .HasMany(p => p.Projects)
        .WithOne(pr => pr.Profile)
        .HasForeignKey(pr => pr.Profile_Id);

        base.OnModelCreating(modelBuilder);
    }

}