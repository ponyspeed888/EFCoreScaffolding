using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace std20.ModelsNorthWind;

public partial class Region
{
    [Key]
    [Column("RegionID")]
    public int RegionId { get; set; }

    [Required]
    public string RegionDescription { get; set; }

    [InverseProperty("Region")]
    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
}
