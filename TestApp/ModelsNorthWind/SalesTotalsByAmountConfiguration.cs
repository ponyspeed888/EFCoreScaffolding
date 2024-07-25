﻿#if SalesTotalsByAmountCONFIG
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Database8.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace Database8.ModelsNorthWind;

public partial class SalesTotalsByAmountConfiguration : IEntityTypeConfiguration<SalesTotalsByAmount>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<SalesTotalsByAmount> builder);

    public void Configure(EntityTypeBuilder<SalesTotalsByAmount> builder)
    {

        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
        });

        MoreBuilderCalls (builder) ;


    }
}



public partial class SalesTotalsByAmount
{
#if MVVM
    [ObservableProperty]
    private SalesTotalsByAmountExtProp _ExtProp;
#else
    public SalesTotalsByAmountExtProp ExtProp { get; set; }
#endif

 
    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }


}



public partial class SalesTotalsByAmountExtProp
{
    // Add your class definition in another file so that it won't be overwritten when regenerated 
    /*KeepChanges09*/

    /*KeepChanges09*/

}
#endif
