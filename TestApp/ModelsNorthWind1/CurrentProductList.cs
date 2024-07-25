﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestApp.ModelsNorthWind;

[Keyless]



public partial class CurrentProductList : object
{
    [Column("ProductID")]
    public int? ProductId { get; set; }

    public string? ProductName { get; set; }
}
