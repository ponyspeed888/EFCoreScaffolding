#if SummaryOfSalesByYearCONFIG
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Database8.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace Database8.ModelsNorthWind;

public partial class SummaryOfSalesByYearConfiguration : IEntityTypeConfiguration<SummaryOfSalesByYear>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<SummaryOfSalesByYear> builder);

    public void Configure(EntityTypeBuilder<SummaryOfSalesByYear> builder)
    {

        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
        });

        MoreBuilderCalls (builder) ;


    }
}



public partial class SummaryOfSalesByYear
{
#if MVVM
    [ObservableProperty]
    private SummaryOfSalesByYearExtProp _ExtProp;
#else
    public SummaryOfSalesByYearExtProp ExtProp { get; set; }
#endif

 
    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }


}



public partial class SummaryOfSalesByYearExtProp
{
    // Add your class definition in another file so that it won't be overwritten when regenerated 
    /*KeepChanges09*/

    /*KeepChanges09*/

}
#endif
