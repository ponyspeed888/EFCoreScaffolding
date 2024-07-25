using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace Database8.ModelsNorthWind;



public partial class CustomerDemographic
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
    [ObservableProperty]
    private string _CustomerTypeId  = null!; 
#else
    public string CustomerTypeId { get; set; } = null!;
#endif

#if MVVM
    [ObservableProperty]
    private string? _CustomerDesc ; 
#else
    public string? CustomerDesc { get; set; }
#endif

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}



