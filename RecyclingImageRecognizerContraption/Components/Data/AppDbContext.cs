using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingImageRecognizerContraption.Components.Data;

using Microsoft.EntityFrameworkCore;


public class AppDbContext : DbContext
{
    public DbSet<Homewood> HomewoodRecyclable { get; set; }
    public DbSet<Borden> BordenRecyclable { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=mydatabase.db");
}

public class Homewood
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; }
    public string? Instructions { get; set; }
}

public class Borden
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; }
    public string? Instructions { get; set; }
}

