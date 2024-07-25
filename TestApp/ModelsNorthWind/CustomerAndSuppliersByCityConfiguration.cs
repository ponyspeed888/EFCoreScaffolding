#if CustomerAndSuppliersByCityCONFIG
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Database8.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace Database8.ModelsNorthWind;

public partial class CustomerAndSuppliersByCityConfiguration : IEntityTypeConfiguration<CustomerAndSuppliersByCity>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<CustomerAndSuppliersByCity> builder);

    public void Configure(EntityTypeBuilder<CustomerAndSuppliersByCity> builder)
    {

        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
        });

        MoreBuilderCalls (builder) ;


    }
}



public partial class CustomerAndSuppliersByCity
{
#if MVVM
    [ObservableProperty]
    private CustomerAndSuppliersByCityExtProp _ExtProp;
#else
    public CustomerAndSuppliersByCityExtProp ExtProp { get; set; }
#endif

 
    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }


}



public partial class CustomerAndSuppliersByCityExtProp
{
    // Add your class definition in another file so that it won't be overwritten when regenerated 
    /*KeepChanges09*/

    /*KeepChanges09*/

}
#endif
