#if CustomerCustomerDemoCONFIG
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Database8.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace Database8.ModelsNorthWind;

public partial class CustomerCustomerDemoConfiguration : IEntityTypeConfiguration<CustomerCustomerDemo>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<CustomerCustomerDemo> builder);

    public void Configure(EntityTypeBuilder<CustomerCustomerDemo> builder)
    {

        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
        });

        MoreBuilderCalls (builder) ;


    }
}



public partial class CustomerCustomerDemo
{
#if MVVM
    [ObservableProperty]
    private CustomerCustomerDemoExtProp _ExtProp;
#else
    public CustomerCustomerDemoExtProp ExtProp { get; set; }
#endif

 
    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }


}



public partial class CustomerCustomerDemoExtProp
{
    // Add your class definition in another file so that it won't be overwritten when regenerated 
    /*KeepChanges09*/

    /*KeepChanges09*/

}
#endif
