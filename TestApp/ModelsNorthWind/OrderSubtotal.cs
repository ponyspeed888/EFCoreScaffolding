using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestApp.ModelsNorthWind;

[Keyless]



public partial class OrderSubtotal : object
{
    [Column("OrderID")]
    public int? OrderId { get; set; }

    public double? Subtotal { get; set; }
}
