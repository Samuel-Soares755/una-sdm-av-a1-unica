using Microsoft.EntityFrameworkCore;
using ValeAtivos324147097.Models;

namespace ValeAtivos324147097.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Equipamento> Equipamentos { get; set; }
    }
}