#if true
//#if NET8_0_OR_GREATER

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Database8.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace Database8.ModelsNorthWind;

public partial class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<Customer> builder);

    public void Configure(EntityTypeBuilder<Customer> builder)
    {

#if NET8_0_OR_GREATER

        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
        });
#endif



        //builder.Property(x => x.ExtPropDynamic)
        //  .HasConversion<ObjectToJsonConverter>(new MyCustomComparer(true))


        //  ;



        MoreBuilderCalls(builder) ;


    }
}



public partial class Customer
{


#if NET8_0_OR_GREATER


#if MVVM
    [ObservableProperty]
    private CustomerExtProp? _ExtProp;
#else
        public CustomerExtProp? ExtProp { get; set; }
#endif


    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize(ExtProp); else return null; } }

#endif


}



public partial class CustomerExtProp
{
    // Add your class definition in another file so that it won't be overwritten when regenerated 
    /*KeepChanges09*/

    /*KeepChanges09*/

}

#endif
