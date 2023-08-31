using CoastalVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CoastalVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }
    }
}
