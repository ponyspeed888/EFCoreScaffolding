#if OrderDetailCONFIG
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Database8.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace Database8.ModelsNorthWind;

public partial class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<OrderDetail> builder);

    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {

        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
        });

        MoreBuilderCalls (builder) ;


    }
}



public partial class OrderDetail
{
#if MVVM
    [ObservableProperty]
    private OrderDetailExtProp _ExtProp;
#else
    public OrderDetailExtProp ExtProp { get; set; }
#endif

 
    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }


}



public partial class OrderDetailExtProp
{
    // Add your class definition in another file so that it won't be overwritten when regenerated 
    /*KeepChanges09*/

    /*KeepChanges09*/

}
#endif
