using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class LigaBetDbContext : DbContext
    {
        public LigaBetDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}