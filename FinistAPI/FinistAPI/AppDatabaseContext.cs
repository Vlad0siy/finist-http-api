using Microsoft.EntityFrameworkCore;
using FinistAPI.Models;
    
namespace FinistAPI
{
    public partial class AppDatabaseContext : DbContext
    {
        public AppDatabaseContext()
        {
        }

        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer($"Data Source=DESKTOP-PM78I88\\SQLEXPRESS;Initial Catalog=FinistTestDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<Card> Cards { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<OperationHistory> OperationsHistories { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<OperationType> OperationTypes { get; set; }
    }
}
