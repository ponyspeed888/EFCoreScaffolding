using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace std20.ModelsNorthWind;

[Table("ExtPropDef")]
[Index("TableName", "KeyName", Name = "UniqueTableNameKeyName", IsUnique = true)]
public partial class ExtPropDef
{
    [Key]
    [Column("ExtPropDictID")]
    public int ExtPropDictId { get; set; }

    [Required]
    [Column(TypeName = "NVARCHAR(128)")]
    public string TableName { get; set; }

    [Required]
    [Column(TypeName = "NVARCHAR(128)")]
    public string KeyName { get; set; }

    [Column(TypeName = "NVARCHAR(128)")]
    public string Category { get; set; }

    [Column(TypeName = "NVARCHAR(128)")]
    public string DataType { get; set; }
}
