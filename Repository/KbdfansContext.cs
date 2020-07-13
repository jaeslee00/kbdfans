using Kbdfans.Models;
using Microsoft.EntityFrameworkCore;

namespace Kbdfans.Repository
{
    public class KbdfansContext : DbContext
    {
        public KbdfansContext(DbContextOptions<KbdfansContext> options) : base(options)
        {
            
        }
        public DbSet<Keyboard> Keyboards { get; set; }
    }
}