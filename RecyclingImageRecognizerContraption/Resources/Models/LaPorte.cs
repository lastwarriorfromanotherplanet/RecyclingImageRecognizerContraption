using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingImageRecognizerContraption.Resources.Models;

[Table("LaPorte")]

public class LaPorte
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [Unique]
    public string? Name { get; set; }

    public string? Category { get; set; } 
    
    public string? DescriptionText { get; set; }

    public bool IsRecyclable { get; set; }

}
