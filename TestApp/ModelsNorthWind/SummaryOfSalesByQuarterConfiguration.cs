#if SummaryOfSalesByQuarterCONFIG
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Database8.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace Database8.ModelsNorthWind;

public partial class SummaryOfSalesByQuarterConfiguration : IEntityTypeConfiguration<SummaryOfSalesByQuarter>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<SummaryOfSalesByQuarter> builder);

    public void Configure(EntityTypeBuilder<SummaryOfSalesByQuarter> builder)
    {

        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
        });

        MoreBuilderCalls (builder) ;


    }
}



public partial class SummaryOfSalesByQuarter
{
#if MVVM
    [ObservableProperty]
    private SummaryOfSalesByQuarterExtProp _ExtProp;
#else
    public SummaryOfSalesByQuarterExtProp ExtProp { get; set; }
#endif

 
    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }


}



public partial class SummaryOfSalesByQuarterExtProp
{
    // Add your class definition in another file so that it won't be overwritten when regenerated 
    /*KeepChanges09*/

    /*KeepChanges09*/

}
#endif
