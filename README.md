This project is a drop in replacement of Microsoft.EntityFrameworkCore.Templates.

It contains multiple branches.

How to use :

For all branches except xxx :

* Copy The folder CodeTemplates into you project
* If you want Better template error detection at compile time, follow the instruction in install.txt
* Run reverse engineering as usual to get your model




The main branch :

This branch is basic the same as Microsoft's version, with the following changes

* Add debug support, so that you can debug using Debugger.Launch
* All t4 include another file file called T4Helper.t4
* Better template error detection at compile time






BETTER TEMPLATE ERROR DETECTION AT COMPILE TIME

The standard reverse engineering only use the t4 template as unstructured text.  It often return an error message that is meaningless. For example, this code block

    <#

        string StaticExtPropName = "ExtProp" ;
        string DynamicExtPropName = "ExtPropDynamic" ;
        string [] UseConfigure = new stringx [] { "Order", "OrderDetail"} ;

    #>

it return the following message


    Object reference not set to an instance of an object

If change the t4 template custom tool to "TextTemplatingFilePreProcessor", then the error message becomes :

Severity	Code	Description	Project	File	Line	Suppression State
Error (active)	CS0246	The type or namespace name 'stringx' could not be found (are you missing a using directive or an assembly reference?)	TemplateTestConsoleApp	U:\EFTemplate\TemplateTestConsoleApp\CodeTemplates\EFCore\EntityTypeConfiguration.cs	44	

But this create 2 problems :

1. The generated code reference global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData, which only exist in .net framework.  To solve the problem, I created a dummy class int JYDummyT4Helper.cs that provide the definition
2. EntityType.t4 itself use a parameter that use the name also called EntityType.  This will create a compile time error.  My solution is rename EntityType.t4 to entityType.t4



















It has the following changes :

* Add debug support, so that you can debug using Debugger.Launch
* Allow you to specify which entity want to use EntityTypeConfiguration file
* MVVM toolkit support
* Provide the plumbing to better compile time error check
* Generate dynamic properties per entity, using EF Core 8 Json column or dictionary (To be added)
* 

When you install this template with 

   dotnet new ponyspeed888-eftemplates

It will be mostly the same as Microsoft.EntityFrameworkCore.Templates

To Generate mvvm tool style property use

   dotnet new ponyspeed888-eftemplates --TemplateType mvvm --force




To specify which entity to generate config file look for this line

    string [] UseConfigure = new string [] { "Order", "OrderDetail"} ;

and fill with the entity names you want to generate config file.  The generate config file is like :


public partial class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<Order> builder);


    public void Configure(EntityTypeBuilder<Order> builder)
    {

        MoreBuilderCalls (builder) ;


    }
}

So just implement the partial method MoreBuilderCalls in another manually created class, so that it won't be overwritten when regenerating





