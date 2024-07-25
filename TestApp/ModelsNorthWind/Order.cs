using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace Database8.ModelsNorthWind;



public partial class Order
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
    [ObservableProperty]
    private int _OrderId ; 
#else
    public int OrderId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _CustomerId ; 
#else
    public string? CustomerId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private int? _EmployeeId ; 
#else
    public int? EmployeeId { get; set; }
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
    private int? _ShipVia ; 
#else
    public int? ShipVia { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private int? _Freight ; 
#else
    public int? Freight { get; set; }
#endif

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

    public virtual Customer? Customer { get; set; }

    public virtual Employee? Employee { get; set; }

#if MVVM
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new ObservableCollection<OrderDetail>();
#else
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
#endif


    public virtual Shipper? ShipViaNavigation { get; set; }
}



