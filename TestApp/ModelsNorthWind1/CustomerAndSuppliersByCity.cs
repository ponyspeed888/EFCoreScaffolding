using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestApp.ModelsNorthWind;

[Keyless]



public partial class CustomerAndSuppliersByCity : object
{
    public string? City { get; set; }

    public string? CompanyName { get; set; }

    public string? ContactName { get; set; }

    public string? Relationship { get; set; }
}
