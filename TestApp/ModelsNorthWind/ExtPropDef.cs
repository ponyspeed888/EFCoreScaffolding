using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace Database8.ModelsNorthWind;



public partial class ExtPropDef
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
    [ObservableProperty]
    private int _ExtPropDictId ; 
#else
    public int ExtPropDictId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string _TableName  = null!; 
#else
    public string TableName { get; set; } = null!;
#endif

#if MVVM
    [ObservableProperty]
    private string _KeyName  = null!; 
#else
    public string KeyName { get; set; } = null!;
#endif

#if MVVM
    [ObservableProperty]
    private string? _Category ; 
#else
    public string? Category { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _DataType ; 
#else
    public string? DataType { get; set; }
#endif
}



