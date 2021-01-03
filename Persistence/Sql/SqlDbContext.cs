using Microsoft.EntityFrameworkCore;
using Core.Entities.Blogs;

namespace Persistence.Sql
{
    public class SqlDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public SqlDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}