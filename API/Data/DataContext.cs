using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
// Added OnModelCreating because of the error "can't trck keyless entities"
//          protected override void OnModelCreating(ModelBuilder modelBuilder)
// {
//    modelBuilder
//         .Entity<AppUser>(
//             eb =>
//             {
//                 eb.HasKey("PasswordHash");
//                 // eb.ToView("View_BlogPostCounts");
//                 // eb.Property(v => v.BlogName).HasColumnName("Name");
//             });
// }
        public DbSet<AppUser> Users { get; set; }
       
    }

    
}