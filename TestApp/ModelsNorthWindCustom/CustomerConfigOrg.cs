


using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Options;
using System.Text.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

namespace Database8.ModelsNorthWind;


public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {


        var options = new JsonSerializerOptions(JsonSerializerDefaults.General);


        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
            //cb.Property(x => x.)
        });

   

        //builder.Property(x => x.DictOnly)
        //    //.HasColumnName("Values")
        //    .HasColumnType("TEXT") // sqlite BLOB type
        //    .HasConversion(
        //        v => JsonSerializer.Serialize(v, options),
        //        s => JsonSerializer.Deserialize<Dictionary<string, string>>(s, options)!,
        //        ValueComparer.CreateDefault(typeof(Dictionary<string, string>), true)
        //    )


        //    ;




        //builder.OwnsOne(x => x.CustomerDict, cb =>
        //{


        //    //                 cb.HasConversion(
        //    //            v => JsonSerializer.Serialize(v, options),
        //    //            s => JsonSerializer.Deserialize<Dictionary<string, string>>(s, options)!,
        //    //            ValueComparer.CreateDefault(typeof(Dictionary<string, string>), true)
        //    //        );

        //    //});


        //    cb.ToJson();
        //    cb.Property(x => x.ContentText);
        //    cb.Property(x => x.dict);

        //});


    }

}



public partial class Customer
{
    //public Customer() { ExtendedProperties = new CustomerExtendedProperties(); }

    //static Customer()
    //{
    //    ExtendedProperties = new CustomerExtendedProperties();
    //    //Details = "{}"; // Empty JSON object
    //}


    //public Customer() { CustomerDict = new Dictionary<string, string>(); }
    //public Customer() { CustomerDict = new CustomerDictType(); }
    //public Customer() { DictJson = new Dictionary<string, string>(); DictJson.Add("a", "b"); }
    //public override string ToString()
    //{
    //    return base.ToString();
    //}


    //public string ExtStr ()
    //{
    //    return base.ToString();
    //}

    //[property:Column("ExtendedProperties")]

    //[CommunityToolkit.Mvvm.ComponentModel.ObservableProperty] private string? _ExtStr;


    [CommunityToolkit.Mvvm.ComponentModel.ObservableProperty] private ExtProp _ExtProp;


    //[Column(TypeName = "json")]
    ////[CommunityToolkit.Mvvm.ComponentModel.ObservableProperty] private Dictionary<string, string>? _CustomerDict ;
    ////[CommunityToolkit.Mvvm.ComponentModel.ObservableProperty] private List<string>? _CustomerDict ;
    //[CommunityToolkit.Mvvm.ComponentModel.ObservableProperty] private CustomerDictType? _CustomerDict ;


    //[CommunityToolkit.Mvvm.ComponentModel.ObservableProperty] private Dictionary<string, string>? _DictOnly;
    ////[CommunityToolkit.Mvvm.ComponentModel.ObservableProperty] private Dictionary<string, string>? _DictJson;

    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }


}


public partial class ExtProp
{
 
    public string NickName { get; set; }
    //public int NumberOfVisit { get; set; }
    public int AddedInt { get; set; }


}




public partial class CustomerDictType //: CommunityToolkit.Mvvm.ComponentModel.ObservableObject
{
    //public string dict { get; set; } 
    public Dictionary<string, string> dict { get; set; } = new();

    //[CommunityToolkit.Mvvm.ComponentModel.ObservableProperty]
    //private string? contentText;


    public string? ContentText { get; set; }

    //public override string ToString()
    //{
    //    return ContentText;
    //}

}


