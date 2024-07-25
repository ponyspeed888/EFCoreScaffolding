using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace Database8.ModelsNorthWind;



public partial class Category
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
    [ObservableProperty]
    private int _CategoryId ; 
#else
    public int CategoryId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _CategoryName ; 
#else
    public string? CategoryName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _Description ; 
#else
    public string? Description { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private byte[]? _Picture ; 
#else
    public byte[]? Picture { get; set; }
#endif

#if MVVM
    public virtual ICollection<Product> Products { get; set; } = new ObservableCollection<Product>();
#else
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
#endif

}



