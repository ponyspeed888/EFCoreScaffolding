using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace Database8.ModelsNorthWind;



public partial class Invoice
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
    [ObservableProperty]
    private string? _ShipName ; 
#else
    public string? ShipName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ShipAddress ; 
#else
    public string? ShipAddress { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ShipCity ; 
#else
    public string? ShipCity { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ShipRegion ; 
#else
    public string? ShipRegion { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ShipPostalCode ; 
#else
    public string? ShipPostalCode { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ShipCountry ; 
#else
    public string? ShipCountry { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _CustomerId ; 
#else
    public string? CustomerId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _CustomerName ; 
#else
    public string? CustomerName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _Address ; 
#else
    public string? Address { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _City ; 
#else
    public string? City { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _Region ; 
#else
    public string? Region { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _PostalCode ; 
#else
    public string? PostalCode { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _Country ; 
#else
    public string? Country { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private int? _Salesperson ; 
#else
    public int? Salesperson { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private int? _OrderId ; 
#else
    public int? OrderId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private DateTime? _OrderDate ; 
#else
    public DateTime? OrderDate { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private DateTime? _RequiredDate ; 
#else
    public DateTime? RequiredDate { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private DateTime? _ShippedDate ; 
#else
    public DateTime? ShippedDate { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ShipperName ; 
#else
    public string? ShipperName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private int? _ProductId ; 
#else
    public int? ProductId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ProductName ; 
#else
    public string? ProductName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private double? _UnitPrice ; 
#else
    public double? UnitPrice { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private int? _Quantity ; 
#else
    public int? Quantity { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private double? _Discount ; 
#else
    public double? Discount { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private double? _ExtendedPrice ; 
#else
    public double? ExtendedPrice { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private double? _Freight ; 
#else
    public double? Freight { get; set; }
#endif
}



