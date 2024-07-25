using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace std20.ModelsNorthWind;

public partial class Shipper
{
    [Key]
    [Column("ShipperID")]
    public int ShipperId { get; set; }

    [Required]
    public string CompanyName { get; set; }

    public string Phone { get; set; }

    [InverseProperty("ShipViaNavigation")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
