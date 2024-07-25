#if CustomerDemographicCONFIG
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Database8.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace Database8.ModelsNorthWind;

public partial class CustomerDemographicConfiguration : IEntityTypeConfiguration<CustomerDemographic>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<CustomerDemographic> builder);

    public void Configure(EntityTypeBuilder<CustomerDemographic> builder)
    {

        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
        });

        MoreBuilderCalls (builder) ;


    }
}



public partial class CustomerDemographic
{
#if MVVM
    [ObservableProperty]
    private CustomerDemographicExtProp _ExtProp;
#else
    public CustomerDemographicExtProp ExtProp { get; set; }
#endif

 
    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }


}



public partial class CustomerDemographicExtProp
{
    // Add your class definition in another file so that it won't be overwritten when regenerated 
    /*KeepChanges09*/

    /*KeepChanges09*/

}
#endif
