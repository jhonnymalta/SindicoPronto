using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SindicoPronto.Models;

namespace SindicoPronto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Sindico> Sindico {  get; set; }
        public DbSet<Condominio> Condominio { get; set; }
    }
}
