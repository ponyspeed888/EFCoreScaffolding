using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace Database8.ModelsNorthWind;



public partial class Employee
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
    [ObservableProperty]
    private int _EmployeeId ; 
#else
    public int EmployeeId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _LastName ; 
#else
    public string? LastName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _FirstName ; 
#else
    public string? FirstName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _Title ; 
#else
    public string? Title { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _TitleOfCourtesy ; 
#else
    public string? TitleOfCourtesy { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private DateOnly? _BirthDate ; 
#else
    public DateOnly? BirthDate { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private DateOnly? _HireDate ; 
#else
    public DateOnly? HireDate { get; set; }
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
    private string? _HomePhone ; 
#else
    public string? HomePhone { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _Extension ; 
#else
    public string? Extension { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private byte[]? _Photo ; 
#else
    public byte[]? Photo { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _Notes ; 
#else
    public string? Notes { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private int? _ReportsTo ; 
#else
    public int? ReportsTo { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _PhotoPath ; 
#else
    public string? PhotoPath { get; set; }
#endif

#if MVVM
    public virtual ICollection<Employee> InverseReportsToNavigation { get; set; } = new ObservableCollection<Employee>();
#else
    public virtual ICollection<Employee> InverseReportsToNavigation { get; set; } = new List<Employee>();
#endif


#if MVVM
    public virtual ICollection<Order> Orders { get; set; } = new ObservableCollection<Order>();
#else
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
#endif


    public virtual Employee? ReportsToNavigation { get; set; }

    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
}



