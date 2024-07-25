using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace std20.ModelsNorthWind;

public partial class Territory
{
    [Key]
    [Column("TerritoryID")]
    public string TerritoryId { get; set; }

    [Required]
    public string TerritoryDescription { get; set; }

    [Column("RegionID")]
    public int RegionId { get; set; }

    [ForeignKey("RegionId")]
    [InverseProperty("Territories")]
    public virtual Region Region { get; set; }

    [ForeignKey("TerritoryId")]
    [InverseProperty("Territories")]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
