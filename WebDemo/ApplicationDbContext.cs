using Microsoft.EntityFrameworkCore;

namespace WebDemo;

public class ApplicationDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
}