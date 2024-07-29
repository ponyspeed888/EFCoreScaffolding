using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace JsonMvvmTest.ModelsNorthWind;

#if true
public partial class CustomerExtProp : ObservableValidator
{
    /*KeepChanges00*/

    public string NickName { get; set; }
    public int NumberOfVisit { get; set; }
    public int AddedInt { get; set; }


    /*KeepChanges00*/

}

#else

   //** mvvm

    [ObservableProperty]
    private string _NickName;
    [ObservableProperty]
    private int _NumberOfVisit;
    [ObservableProperty]
    private int _AddedInt;


#endif



public partial class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    partial void MoreBuilderCalls(EntityTypeBuilder<Customer> builder)
    {

    }


}

