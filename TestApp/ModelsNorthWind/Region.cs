using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace Database8.ModelsNorthWind;



public partial class Region
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
    [ObservableProperty]
    private int _RegionId ; 
#else
    public int RegionId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string _RegionDescription  = null!; 
#else
    public string RegionDescription { get; set; } = null!;
#endif

#if MVVM
    public virtual ICollection<Territory> Territories { get; set; } = new ObservableCollection<Territory>();
#else
    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
#endif

}



