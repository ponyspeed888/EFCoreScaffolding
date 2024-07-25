#if QuarterlyOrderCONFIG
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Database8.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace Database8.ModelsNorthWind;

public partial class QuarterlyOrderConfiguration : IEntityTypeConfiguration<QuarterlyOrder>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<QuarterlyOrder> builder);

    public void Configure(EntityTypeBuilder<QuarterlyOrder> builder)
    {

        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
        });

        MoreBuilderCalls (builder) ;


    }
}



public partial class QuarterlyOrder
{
#if MVVM
    [ObservableProperty]
    private QuarterlyOrderExtProp _ExtProp;
#else
    public QuarterlyOrderExtProp ExtProp { get; set; }
#endif

 
    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }


}



public partial class QuarterlyOrderExtProp
{
    // Add your class definition in another file so that it won't be overwritten when regenerated 
    /*KeepChanges09*/

    /*KeepChanges09*/

}
#endif
