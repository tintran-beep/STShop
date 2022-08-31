using Microsoft.EntityFrameworkCore;

namespace STShop.Database.Context
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
