using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace std20.ModelsNorthWind;

public partial class Customer
{
    [Key]
    [Column("CustomerID")]
    public string CustomerId { get; set; }

    public string CompanyName { get; set; }

    public string ContactName { get; set; }

    public string ContactTitle { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string Region { get; set; }

    public string PostalCode { get; set; }

    public string Country { get; set; }

    public string Phone { get; set; }

    public string Fax { get; set; }

    [Column(TypeName = "json")]
    public string CustomerDict { get; set; }

    public string DictOnly { get; set; }

    public string DictJson { get; set; }

    [Required]
    [Column(TypeName = "NVARCHAR(64000)")]
    public string ExtProp { get; set; }

    [Column(TypeName = "nvarchar(64000)")]
    public string ExtPropDynamic { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [ForeignKey("CustomerId")]
    [InverseProperty("Customers")]
    public virtual ICollection<CustomerDemographic> CustomerTypes { get; set; } = new List<CustomerDemographic>();
}
