using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestApp.ModelsNorthWind;




public partial class CustomerDemographic : object
{
    [Key]
    [Column("CustomerTypeID")]
    public string CustomerTypeId { get; set; } = null!;

    public string? CustomerDesc { get; set; }

    [ForeignKey("CustomerTypeId")]
    [InverseProperty("CustomerTypes")]
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
