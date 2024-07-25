//#if NET8_0_OR_GREATER
#if true
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Database8.ModelsNorthWind;



public partial class CustomerExtProp
{
    /*KeepChanges00*/

    public string NickName { get; set; }
    public int NumberOfVisit { get; set; }
    public int AddedInt { get; set; }

    /*KeepChanges00*/

}

public partial class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    partial void MoreBuilderCalls(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(x => x.CustomerId).HasDefaultValue("A1 change me");  // Why a guid instead of my hard coded string ????

        var options = new JsonSerializerOptions(JsonSerializerDefaults.General);


        //builder.Property(x => x.CustomerId).HasDefaultValue("A1 change me");  // Why a guid instead of my hard coded string ????
        builder.Property(x => x.ExtPropDynamic)
         .HasConversion<ObjectToJsonConverter>(new MyCustomComparer(true))


         ;



    }


}





#endif
