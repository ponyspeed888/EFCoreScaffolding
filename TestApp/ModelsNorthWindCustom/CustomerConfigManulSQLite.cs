using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace TestApp.ModelsNorthWind;

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

    }


}

