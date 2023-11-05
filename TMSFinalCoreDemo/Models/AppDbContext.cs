using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TMSFinalCoreDemo.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }

        public virtual DbSet<SignUpModel> SignUpModel { get; set; }


        public virtual DbSet<TaskModel> TaskModels { get; set; }

    }
}
