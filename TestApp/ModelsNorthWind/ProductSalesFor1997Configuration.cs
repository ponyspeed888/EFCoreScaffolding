#if ProductSalesFor1997CONFIG
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Database8.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace Database8.ModelsNorthWind;

public partial class ProductSalesFor1997Configuration : IEntityTypeConfiguration<ProductSalesFor1997>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<ProductSalesFor1997> builder);

    public void Configure(EntityTypeBuilder<ProductSalesFor1997> builder)
    {

        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
        });

        MoreBuilderCalls (builder) ;


    }
}



public partial class ProductSalesFor1997
{
#if MVVM
    [ObservableProperty]
    private ProductSalesFor1997ExtProp _ExtProp;
#else
    public ProductSalesFor1997ExtProp ExtProp { get; set; }
#endif

 
    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }


}



public partial class ProductSalesFor1997ExtProp
{
    // Add your class definition in another file so that it won't be overwritten when regenerated 
    /*KeepChanges09*/

    /*KeepChanges09*/

}
#endif
