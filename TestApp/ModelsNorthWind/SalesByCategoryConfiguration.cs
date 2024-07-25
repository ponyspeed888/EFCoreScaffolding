#if SalesByCategoryCONFIG
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Database8.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace Database8.ModelsNorthWind;

public partial class SalesByCategoryConfiguration : IEntityTypeConfiguration<SalesByCategory>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<SalesByCategory> builder);

    public void Configure(EntityTypeBuilder<SalesByCategory> builder)
    {

        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
        });

        MoreBuilderCalls (builder) ;


    }
}



public partial class SalesByCategory
{
#if MVVM
    [ObservableProperty]
    private SalesByCategoryExtProp _ExtProp;
#else
    public SalesByCategoryExtProp ExtProp { get; set; }
#endif

 
    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }


}



public partial class SalesByCategoryExtProp
{
    // Add your class definition in another file so that it won't be overwritten when regenerated 
    /*KeepChanges09*/

    /*KeepChanges09*/

}
#endif
