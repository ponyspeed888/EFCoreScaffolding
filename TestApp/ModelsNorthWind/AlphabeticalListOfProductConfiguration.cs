#if AlphabeticalListOfProductCONFIG
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Database8.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace Database8.ModelsNorthWind;

public partial class AlphabeticalListOfProductConfiguration : IEntityTypeConfiguration<AlphabeticalListOfProduct>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<AlphabeticalListOfProduct> builder);

    public void Configure(EntityTypeBuilder<AlphabeticalListOfProduct> builder)
    {

        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
        });

        MoreBuilderCalls (builder) ;


    }
}



public partial class AlphabeticalListOfProduct
{
#if MVVM
    [ObservableProperty]
    private AlphabeticalListOfProductExtProp _ExtProp;
#else
    public AlphabeticalListOfProductExtProp ExtProp { get; set; }
#endif

 
    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }


}



public partial class AlphabeticalListOfProductExtProp
{
    // Add your class definition in another file so that it won't be overwritten when regenerated 
    /*KeepChanges09*/

    /*KeepChanges09*/

}
#endif
