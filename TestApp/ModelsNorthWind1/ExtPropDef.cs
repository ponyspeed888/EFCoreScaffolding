using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestApp.ModelsNorthWind;

[Table("ExtPropDef")]
[Index("TableName", "KeyName", Name = "UniqueTableNameKeyName", IsUnique = true)]



public partial class ExtPropDef : object
{
    [Key]
    [Column("ExtPropDictID")]
    public int ExtPropDictId { get; set; }

    [Column(TypeName = "NVARCHAR(128)")]
    public string TableName { get; set; } = null!;

    [Column(TypeName = "NVARCHAR(128)")]
    public string KeyName { get; set; } = null!;

    [Column(TypeName = "NVARCHAR(128)")]
    public string? Category { get; set; }

    [Column(TypeName = "NVARCHAR(128)")]
    public string? DataType { get; set; }
}
