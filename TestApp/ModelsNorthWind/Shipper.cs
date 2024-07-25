using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace Database8.ModelsNorthWind;



public partial class Shipper
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
    [ObservableProperty]
    private int _ShipperId ; 
#else
    public int ShipperId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string _CompanyName  = null!; 
#else
    public string CompanyName { get; set; } = null!;
#endif

#if MVVM
    [ObservableProperty]
    private string? _Phone ; 
#else
    public string? Phone { get; set; }
#endif

#if MVVM
    public virtual ICollection<Order> Orders { get; set; } = new ObservableCollection<Order>();
#else
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
#endif

}



