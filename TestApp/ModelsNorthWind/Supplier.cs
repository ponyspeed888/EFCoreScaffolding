using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace Database8.ModelsNorthWind;



public partial class Supplier
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
    [ObservableProperty]
    private int _SupplierId ; 
#else
    public int SupplierId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string _CompanyName  = null!; 
#else
    public string CompanyName { get; set; } = null!;
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
    private string? _HomePage ; 
#else
    public string? HomePage { get; set; }
#endif

#if MVVM
    public virtual ICollection<Product> Products { get; set; } = new ObservableCollection<Product>();
#else
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
#endif

}



