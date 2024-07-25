using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestApp.ModelsNorthWind;

[Keyless]



public partial class QuarterlyOrder : object
{
    [Column("CustomerID")]
    public string? CustomerId { get; set; }

    public string? CompanyName { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }
}
