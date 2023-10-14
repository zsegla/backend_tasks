using Microsoft.EntityFrameworkCore;
using BlogAPP.Models;

namespace BlogAPP.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
