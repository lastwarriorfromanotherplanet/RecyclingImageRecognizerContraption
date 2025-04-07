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

    public bool? HasCollectionRequirements { get; set; }

    public bool? HasDropOffEvents { get; set; }

    public bool? HasAcceptedMaterials { get; set; }

    public bool? HasNotAcceptedMaterials { get; set; }

    public bool? HasHaulerInfo { get; set; }

    public bool? HasOtherRecyclables { get; set; }

    public bool? HasWhatHappensNext { get; set; }

    public bool? HasReuseOptions { get; set; }

    public string? RecycleCoachLink { get; set; }

    public bool? HasAboutComposting { get; set; }

    public bool? HasDropOffLocations { get; set; }

    public bool? HasUsedOilRecycling { get; set; }

    public bool? HasAboutHazardousWaste { get; set; }

    public string? VideoLink { get; set; }

    public string? HasExternalLink { get; set; }

    

}
