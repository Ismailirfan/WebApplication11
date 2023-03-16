using WebApplication11.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication11.Areas.Identity.Data;

public class mydbcontext : IdentityDbContext<IdentityUser>
{
    public mydbcontext(DbContextOptions<mydbcontext> options)
        : base(options)
    {
    }
    public DbSet<category> categories { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
