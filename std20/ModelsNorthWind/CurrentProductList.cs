﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace std20.ModelsNorthWind;

[Keyless]
public partial class CurrentProductList
{
    [Column("ProductID")]
    public int? ProductId { get; set; }

    public string ProductName { get; set; }
}
