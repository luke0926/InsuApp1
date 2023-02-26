using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InsuApp1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<InsuApp1.Models.User> User { get; set; } = default!;
        public DbSet<InsuApp1.Models.UserInsurance> UserInsurance { get; set; } = default!;
        public DbSet<InsuApp1.Models.MainInsurance> MainInsurance { get; set; } = default!;
        public DbSet<InsuApp1.Models.UserDetailViewModel> UserDetailViewModel { get; set; } = default!;
        public DbSet<InsuApp1.Models.MainInsuredEvent> MainInsuredEvent { get; set; } = default!;
        public DbSet<InsuApp1.Models.UserInsuredEvent> UserInsuredEvent { get; set; } = default!;
        public DbSet<InsuApp1.Models.UserDetailViewModelEvent> UserDetailViewModelEvent { get; set; } = default!;



        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            {
				modelBuilder.Entity<UserInsurance>()
                .Property(p => p.InsuranceValue).IsRequired(required: false);
			}
        }*/
    }
}