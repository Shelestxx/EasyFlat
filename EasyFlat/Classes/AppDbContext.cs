using EasyFlat.Classes;
using Microsoft.EntityFrameworkCore;

namespace EasyFlat.Classes
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Listing> Listings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Отримаємо шлях до каталогу проєкту (папка EasyFlat)
            var projectDir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));

            // Вказуємо базу саме у цій папці
            var dbPath = Path.Combine(projectDir, "EasyFlatDB.db");

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
            Console.WriteLine($"[EF] Використовується база даних: {dbPath}");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Зв'язок Listing → User
            modelBuilder.Entity<Listing>()
                .HasOne(l => l.Owner)
                .WithMany(u => u.Listings)
                .HasForeignKey(l => l.OwnerID)
                .OnDelete(DeleteBehavior.Cascade);

            // Обмеження довжин для User
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(u => u.Name).HasMaxLength(100);
                entity.Property(u => u.Email).HasMaxLength(150);
               
                entity.Property(u => u.PhoneNumber).HasMaxLength(20);
                entity.Property(u => u.PasswordHash).HasMaxLength(255);
            });

            // Обмеження довжин для Listing
            modelBuilder.Entity<Listing>(entity =>
            {
                entity.Property(l => l.Title).HasMaxLength(150);
                entity.Property(l => l.Description).HasMaxLength(1000);
                entity.Property(l => l.Location).HasMaxLength(255);
                entity.Property(l => l.PhoneNumber).HasMaxLength(20);
            });
        }

    }
}

