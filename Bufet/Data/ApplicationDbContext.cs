using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bufet.Models;

namespace Bufet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Bufet.Models.Zamowienia>? Zamowienia { get; set; }
        public DbSet<Bufet.Models.Kanapki>? Kanapki { get; set; }
        public DbSet<Bufet.Models.Kategoria>? Kategoria { get; set; }
        public DbSet<Bufet.Models.Uzytkownik>? Uzytkownik { get; set; }
    }
}