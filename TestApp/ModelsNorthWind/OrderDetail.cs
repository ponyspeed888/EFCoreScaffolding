using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace Database8.ModelsNorthWind;



public partial class OrderDetail
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
    private int _ProductId ; 
#else
    public int ProductId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private double _UnitPrice ; 
#else
    public double UnitPrice { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private int _Quantity ; 
#else
    public int Quantity { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private double _Discount ; 
#else
    public double Discount { get; set; }
#endif

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}



