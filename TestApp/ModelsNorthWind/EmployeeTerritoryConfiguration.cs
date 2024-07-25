#if EmployeeTerritoryCONFIG
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Database8.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace Database8.ModelsNorthWind;

public partial class EmployeeTerritoryConfiguration : IEntityTypeConfiguration<EmployeeTerritory>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<EmployeeTerritory> builder);

    public void Configure(EntityTypeBuilder<EmployeeTerritory> builder)
    {

        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
        });

        MoreBuilderCalls (builder) ;


    }
}



public partial class EmployeeTerritory
{
#if MVVM
    [ObservableProperty]
    private EmployeeTerritoryExtProp _ExtProp;
#else
    public EmployeeTerritoryExtProp ExtProp { get; set; }
#endif

 
    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }


}



public partial class EmployeeTerritoryExtProp
{
    // Add your class definition in another file so that it won't be overwritten when regenerated 
    /*KeepChanges09*/

    /*KeepChanges09*/

}
#endif
