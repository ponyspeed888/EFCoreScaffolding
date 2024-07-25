using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace Database8.ModelsNorthWind;



public partial class SalesTotalsByAmount
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
    [ObservableProperty]
    private byte[]? _SaleAmount ; 
#else
    public byte[]? SaleAmount { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private int? _OrderId ; 
#else
    public int? OrderId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _CompanyName ; 
#else
    public string? CompanyName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private DateTime? _ShippedDate ; 
#else
    public DateTime? ShippedDate { get; set; }
#endif
}



