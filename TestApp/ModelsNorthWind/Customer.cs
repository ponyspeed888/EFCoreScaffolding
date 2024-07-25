using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace Database8.ModelsNorthWind;


#if true
//#if NET8_0_OR_GREATER
[EntityTypeConfiguration(typeof(CustomerConfiguration))]
#endif

public partial class Customer
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
    [ObservableProperty]
    private string _CustomerId  = null!; 
#else
    public string CustomerId { get; set; } = null!;
#endif

#if MVVM
    [ObservableProperty]
    private string? _CompanyName ; 
#else
    public string? CompanyName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ContactName ; 
#else
    public string? ContactName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ContactTitle ; 
#else
    public string? ContactTitle { get; set; }
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
    private string? _Phone ; 
#else
    public string? Phone { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _Fax ; 
#else
    public string? Fax { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _CustomerDict ; 
#else
    public string? CustomerDict { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _DictOnly ; 
#else
    public string? DictOnly { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _DictJson ; 
#else
    public string? DictJson { get; set; }
#endif

#if MVVM
    public virtual ICollection<Order> Orders { get; set; } = new ObservableCollection<Order>();
#else
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
#endif


    public virtual ICollection<CustomerDemographic> CustomerTypes { get; set; } = new List<CustomerDemographic>();
}



