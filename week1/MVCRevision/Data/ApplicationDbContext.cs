using Microsoft.EntityFrameworkCore;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext (DbContextOptions<ApplicationDbContext>options) : base(options)
    {

    }
    public DbSet<Post> Posts { get; set; }
}