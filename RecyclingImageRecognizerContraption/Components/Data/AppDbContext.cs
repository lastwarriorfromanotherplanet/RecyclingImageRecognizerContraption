//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//namespace RecyclingImageRecognizerContraption.Components.Data;

//public class AppDbContext : DbContext
//{
//    private readonly string _dbPath;
//    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
//    {
//        _dbPath = Path.Combine(FileSystem.AppDataDirectory, "mydatabase.db");
//        Database.EnsureCreated();

//    }
//    public DbSet<Homewood> HomewoodRecyclable { get; set; }
    
//    public DbSet<Borden> BordenRecyclable { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder options)
//    {
//        options.UseSqlite($"Data Source={_dbPath}");
//    }

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        //modelBuilder.Entity<Borden>().HasData(
//        //    new Borden { Id = 1, Name = "Water Bottle", Category = "1 - PET", Instructions = "Recycle in normal plastic bins." },
//        //    new Borden { Id = 2, Name = "Milk Jug", Category = "2 - HDPE", Instructions = "Rinse and recycle curbside." },
//        //    new Borden { Id = 3, Name = "PVC Pipe", Category = "3 - PVC", Instructions = "Cannot be recycled curbside; take to special collection." },
//        //    new Borden { Id = 4, Name = "Plastic Bag", Category = "4 - LDPE", Instructions = "Take to store drop-off locations." },
//        //    new Borden { Id = 5, Name = "Yogurt Cup", Category = "5 - PP", Instructions = "Rinse and recycle curbside." },
//        //    new Borden { Id = 6, Name = "Styrofoam Cup", Category = "6 - PS", Instructions = "Not recyclable curbside; take to special facilities." },
//        //    new Borden { Id = 7, Name = "Baby Bottle", Category = "7 - Other", Instructions = "Not recyclable curbside; check local recycling centers." }
//        //);
//    }

//    public async Task InitializeDatabase()
//    {
//        await Database.EnsureCreatedAsync();
//    }
//}





