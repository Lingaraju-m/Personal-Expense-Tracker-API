using Microsoft.EntityFrameworkCore;
using Personal_Expense_Tracker_API.Entities;

namespace Personal_Expense_Tracker_API.Data
{
    public class ExpenseDbContext : DbContext
    {
        public ExpenseDbContext(DbContextOptions<ExpenseDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<Transcation>()
                .Property(t => t.Amount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Transcation>()
                .HasOne<User>(t => t.User)                 
                .WithMany(u => u.Transactions)                     
                .HasForeignKey(t => t.UserId)        
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Transcation> Transcations { get; set; }
    }
}
