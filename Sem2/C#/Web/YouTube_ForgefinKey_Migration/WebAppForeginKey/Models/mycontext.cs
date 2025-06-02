using Microsoft.EntityFrameworkCore;

namespace WebAppForeginKey.Models
{
    public class mycontext :DbContext
    {
        public mycontext(DbContextOptions options) : base(options)
        {
            
        }

        public virtual DbSet<skill> Skills { get; set; }

        public virtual DbSet<student> Students { get; set; }
    }
}
