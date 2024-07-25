using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace std20.ModelsNorthWind;

[Keyless]
public partial class OrderSubtotal
{
    [Column("OrderID")]
    public int? OrderId { get; set; }

    public double? Subtotal { get; set; }
}
