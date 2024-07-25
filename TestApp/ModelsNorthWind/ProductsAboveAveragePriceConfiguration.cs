#if ProductsAboveAveragePriceCONFIG
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Database8.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace Database8.ModelsNorthWind;

public partial class ProductsAboveAveragePriceConfiguration : IEntityTypeConfiguration<ProductsAboveAveragePrice>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<ProductsAboveAveragePrice> builder);

    public void Configure(EntityTypeBuilder<ProductsAboveAveragePrice> builder)
    {

        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
        });

        MoreBuilderCalls (builder) ;


    }
}



public partial class ProductsAboveAveragePrice
{
#if MVVM
    [ObservableProperty]
    private ProductsAboveAveragePriceExtProp _ExtProp;
#else
    public ProductsAboveAveragePriceExtProp ExtProp { get; set; }
#endif

 
    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }


}



public partial class ProductsAboveAveragePriceExtProp
{
    // Add your class definition in another file so that it won't be overwritten when regenerated 
    /*KeepChanges09*/

    /*KeepChanges09*/

}
#endif
