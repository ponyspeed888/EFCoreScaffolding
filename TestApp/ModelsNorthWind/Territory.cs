using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace Database8.ModelsNorthWind;



public partial class Territory
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
    [ObservableProperty]
    private string _TerritoryId  = null!; 
#else
    public string TerritoryId { get; set; } = null!;
#endif

#if MVVM
    [ObservableProperty]
    private string _TerritoryDescription  = null!; 
#else
    public string TerritoryDescription { get; set; } = null!;
#endif

#if MVVM
    [ObservableProperty]
    private int _RegionId ; 
#else
    public int RegionId { get; set; }
#endif

    public virtual Region Region { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}



